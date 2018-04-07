Option Strict On

Imports System.Data.SQLite

Module SQL

    Enum DatabaseTables
        ACCOUNT
        PAYMENT
        PRODUCT
    End Enum

    Const _cstrDatabaseName As String = "Database.db"
    Const _cstrConnection As String = "Data Source=" & _cstrDatabaseName

    Public Sub SQLCreateAccount(ByVal strUsername As String,
                                ByVal strPassword As String,
                                ByVal strFName As String,
                                ByVal strLName As String,
                                ByVal strEmail As String,
                                ByVal strPhone As String,
                                ByVal strAddress As String)

    End Sub

    Public Sub SQLInitializeDatabase()
        Dim strSQLCreateDatabase As String = "CREATE TABLE IF NOT EXISTS ACCOUNT (
        ACC_ID              INTEGER PRIMARY KEY,
        ACC_USERNAME        TEXT UNIQUE NOT NULL,
        ACC_PASSWORD        TEXT NOT NULL,
        ACC_FNAME           TEXT DEFAULT '',
        ACC_LNAME           TEXT DEFAULT '',
        ACC_EMAIL           TEXT UNIQUE DEFAULT '',
        ACC_PHONE           TEXT DEFAULT '',
        ACC_ADDRESS         TEXT DEFAULT '',
        ACC_MONEY           REAL DEFAULT 0.00,
        ACC_CREATION_DATE   DATE DEFAULT CURRENT_TIMESTAMP,
        ACC_STATUS          TEXT DEFAULT 'Good'
        );
        CREATE TABLE IF NOT EXISTS PAYMENT (
        PAY_ID              INTEGER PRIMARY KEY,
        ACC_ID              INTEGER,
        PAY_DATE            DATE DEFAULT CURRENT_TIMESTAMP,
        PAY_PRICE           INTEGER,
        FOREIGN KEY (ACC_ID) REFERENCES ACCOUNT (ACC_ID)
        );
        CREATE TABLE IF NOT EXISTS PRODUCT (
        PROD_ID             INTEGER PRIMARY KEY,
        PROD_NAME           TEXT,
        PROD_PRICE          REAL,
        PROD_STOCK          INTEGER,
        PROD_FEE            REAL,
        PROD_CATEGORY       TEXT,
        PROD_DESCRIPTION    TEXT
        );"

        Dim strSQLCreateGuestRecord As String = "INSERT INTO ACCOUNT (ACC_USERNAME, ACC_PASSWORD, ACC_FNAME, ACC_LNAME, ACC_EMAIL, ACC_PHONE, ACC_ADDRESS)
        VALUES('Guest', 'pass', 'Guest_FName', 'Guest_LName', 'Guest@example.com', '+1 (234) 567-8901', '123 North Main St.');"

        ' Creating the connection
        Dim connection As String = "Data Source=" & _cstrDatabaseName
        Dim SQLConn As New SQLiteConnection(connection)
        Dim SQLcmd As New SQLiteCommand(SQLConn)
        SQLConn.Open()

        SQLcmd.Connection = SQLConn

        ' Executing the SQL statements to create the database
        SQLcmd.CommandText = strSQLCreateDatabase
        SQLcmd.ExecuteNonQuery()

        ' Executing the SQL statements to create a record in the ACCOUNT
        ' table for the guest account
        SQLcmd.CommandText = strSQLCreateGuestRecord
        SQLcmd.ExecuteNonQuery()

        ' Close the connection
        SQLConn.Close()
    End Sub

    Function SQLValidateUserData(ByVal strData As String) As Boolean
        Dim blnReturn As Boolean
        Dim strAllowedCharactersRegex = "^[A-Za-z0-9@.-_]+$"
        If (System.Text.RegularExpressions.Regex.IsMatch(strData, strAllowedCharactersRegex)) Then
            blnReturn = True
        Else
            blnReturn = False
        End If
        Return blnReturn
    End Function

    Function SQLGetFieldInfo(ByVal intTable As Integer, ByVal intPrimaryKeyID As Integer, ByVal strField As String) As String

        Const cstrError As String = "Error - Unable to get field info from the database."

        Dim strReturn As String = ""

        Dim strTable As String = ""
        Dim strPrimaryKey As String = ""

        Select Case intTable
            Case DatabaseTables.ACCOUNT
                strTable = "ACCOUNT"
                strPrimaryKey = "ACC_ID"
            Case DatabaseTables.PAYMENT
                strTable = "PAYMENT"
                strPrimaryKey = "PAY_ID"
            Case DatabaseTables.PRODUCT
                strTable = "PRODUCT"
                strPrimaryKey = "PROD_ID"
        End Select

        If (String.IsNullOrWhiteSpace(strTable) Or String.IsNullOrWhiteSpace(strPrimaryKey)) Then
            Console.WriteLine(cstrError)
            strReturn = cstrError
        Else

            Dim strFieldInfo As String = ""

            Dim SQLstr As String = "SELECT * FROM " & strTable & " WHERE " & strPrimaryKey & "=" & intPrimaryKeyID.ToString() & ";"

            Dim SQLConn As New SQLiteConnection(_cstrConnection)
            Dim SQLcmd As New SQLiteCommand(SQLConn)
            Dim SQLdr As SQLiteDataReader
            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = SQLstr
            SQLdr = SQLcmd.ExecuteReader()

            ' Loop through all records returned
            While SQLdr.Read()
                Try
                    strFieldInfo = (SQLdr.GetValue(SQLdr.GetOrdinal(strField))).ToString()
                Catch ex As IndexOutOfRangeException
                    strFieldInfo = "Not found"
                    Console.WriteLine(ex.Message)
                    Console.WriteLine("Invalid column name (" & strField & ") in " & strTable & ".")
                Catch ex As InvalidCastException
                    strFieldInfo = "Unknown"
                    Console.WriteLine(ex.Message)
                    Console.WriteLine("Invalid cast when executing a SQLiteDataReader method.")
                End Try
            End While

            ' Close the connection
            SQLdr.Close()
            SQLConn.Close()

            strReturn = strFieldInfo

        End If

        Return strReturn

    End Function

End Module
