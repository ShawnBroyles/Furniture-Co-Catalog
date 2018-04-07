Option Strict On

Imports System.Data.SQLite

Module SQL

    Enum DatabaseTables
        ACCOUNT
        PAYMENT
        PRODUCT
    End Enum

    Enum SQLValidate
        USERNAME
        PASSWORD
        EMAIL
        OTHER_EMPTY
        ACCOUNT_ID
    End Enum

    Const _cstrDatabaseName As String = "Database.db"
    Const _cstrConnection As String = "Data Source=" & _cstrDatabaseName

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
        PAY_PRICE           REAL DEFAULT 0.00,
        FOREIGN KEY (ACC_ID) REFERENCES ACCOUNT (ACC_ID)
        );
        CREATE TABLE IF NOT EXISTS PRODUCT (
        PROD_ID             INTEGER PRIMARY KEY,
        PROD_NAME           TEXT DEFAULT '',
        PROD_PRICE          REAL DEFAULT 0.00,
        PROD_STOCK          INTEGER DEFAULT 0,
        PROD_FEE            REAL DEFAULT 0.00,
        PROD_CATEGORY       TEXT DEFAULT '',
        PROD_DESCRIPTION    TEXT DEFAULT ''
        );"

        ' Creating the connection
        Dim connection As String = "Data Source=" & _cstrDatabaseName
        Dim SQLConn As New SQLiteConnection(connection)
        Dim SQLcmd As New SQLiteCommand(SQLConn)
        SQLConn.Open()

        SQLcmd.Connection = SQLConn

        ' Executing the SQL statements to create the database
        SQLcmd.CommandText = strSQLCreateDatabase
        SQLcmd.ExecuteNonQuery()

        ' Close the connection
        SQLConn.Close()

        ' Creating a new record in the ACCOUNT table for Guest if it doesn't already exist
        Try
            Dim intErrorID As Integer = -1
            Dim strField As String = "ACC_USERNAME"
            Dim strFieldValue As String = "Guest"
            Dim intGuestRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, strField, strFieldValue)
            If (intGuestRecordID.Equals(intErrorID)) Then
                SQLCreateAccount("Guest", "", "Guest_FName", "Guest_LName", "Guest@example.com", "+1 (234) 567-8901", "123 North Main St.")
                Console.WriteLine("Guest account created.")
            Else
                Console.WriteLine("Guest account already exists.")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Unknown error occurred when trying to create the Guest account.")
        End Try

    End Sub

    Public Sub SQLCreateAccount(ByVal strUsername As String,
                                ByVal strPassword As String,
                                ByVal strFName As String,
                                ByVal strLName As String,
                                ByVal strEmail As String,
                                ByVal strPhone As String,
                                ByVal strAddress As String)

        Dim strSQLCreateAccountRecord As String = "INSERT INTO ACCOUNT (ACC_USERNAME, ACC_PASSWORD, ACC_FNAME, ACC_LNAME, ACC_EMAIL, ACC_PHONE, ACC_ADDRESS)
        VALUES('" & strUsername & "', '" & strPassword & "', '" & strFName & "', '" & strLName & "', '" & strEmail & "', '" & strPhone & "', '" & strAddress & "');"

        ' Creating the connection
        Dim connection As String = "Data Source=" & _cstrDatabaseName
        Dim SQLConn As New SQLiteConnection(connection)
        Dim SQLcmd As New SQLiteCommand(SQLConn)
        SQLConn.Open()

        SQLcmd.Connection = SQLConn

        ' Executing the SQL statement to create a new record in the ACCOUNT table
        SQLcmd.CommandText = strSQLCreateAccountRecord
        SQLcmd.ExecuteNonQuery()

        ' Close the connection
        SQLConn.Close()
    End Sub

    Function SQLValidateUserData(ByVal strData As String, ByVal intDataType As Integer) As Boolean
        Dim blnReturn As Boolean
        Dim strAllowedCharactersRegex As String
        Select Case intDataType
            Case SQLValidate.USERNAME
                strAllowedCharactersRegex = "^[A-Za-z][A-Za-z0-9]{3,}$"
            Case SQLValidate.PASSWORD
                strAllowedCharactersRegex = "^[A-Za-z0-9@.\-_\s]{6,}$"
            Case SQLValidate.EMAIL
                strAllowedCharactersRegex = "^[A-Za-z0-9.\-_]+@[A-Za-z0-9.\-_]+.[A-Za-z0-9.\-_]+$"
            Case SQLValidate.OTHER_EMPTY
                strAllowedCharactersRegex = "^[A-Za-z0-9@.\-_\s\(\)]*$"
            Case SQLValidate.ACCOUNT_ID
                strAllowedCharactersRegex = "^[0-9]+$"
            Case Else
                strAllowedCharactersRegex = "^[A-Za-z0-9@.\-_\s\(\)]+$"
        End Select
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

    Function SQLGetRecordID(ByVal intTable As Integer, ByVal strField As String, ByVal strFieldValue As String) As Integer

        Dim intErrorID As Integer = -1
        Dim intRecordID As Integer = intErrorID

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

        If (String.IsNullOrWhiteSpace(strTable)) Then
            Console.WriteLine("Error: Table not found from intTable")
        Else

            Dim SQLstr As String = "SELECT * FROM " & strTable & " WHERE " & strField & "='" & strFieldValue & "';"

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
                    intRecordID = Convert.ToInt32(SQLdr.GetValue(SQLdr.GetOrdinal(strPrimaryKey)))
                Catch ex As IndexOutOfRangeException
                    Console.WriteLine(ex.Message)
                    Console.WriteLine("Invalid column name (" & strField & ") in " & strTable & ". [2]")
                Catch ex As InvalidCastException
                    Console.WriteLine(ex.Message)
                    Console.WriteLine("Invalid cast when executing a SQLiteDataReader method. [2]")
                End Try
            End While

            ' Close the connection
            SQLdr.Close()
            SQLConn.Close()

        End If

        Return intRecordID

    End Function

End Module
