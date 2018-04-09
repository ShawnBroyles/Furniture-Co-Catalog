' Developed by Shawn Broyles
' The SQL module contains all of the methods that directly
' access and manipulate data in the database.

Option Strict On

Imports System.Data.SQLite

Module SQL

    Enum DatabaseTables
        ACCOUNT
        PAYMENT
        PRODUCT
    End Enum

    Enum RegexValidate
        USERNAME
        PASSWORD
        EMAIL
        OTHER_EMPTY
        ID
    End Enum

    Const _cstrDatabaseName As String = "Database.db"
    Const _cstrConnection As String = "Data Source=" & _cstrDatabaseName
    Const _cstrCaseInsensitive As String = " COLLATE NOCASE"

    Public Sub SQLInitializeDatabase()
        SQLCreateDatabaseIfNotExists()
        SQLCreateGuestIfNotExists()
        SQLCreateSampleProductsIfNotExists()
        SQLGetProducts()
        CreateShoppingCart()
    End Sub

    Public Sub SQLCreateDatabaseIfNotExists()
        Dim strSQLCreateDatabase As String = "CREATE TABLE IF NOT EXISTS ACCOUNT (
        ACC_ID              INTEGER PRIMARY KEY,
        ACC_USERNAME        TEXT UNIQUE NOT NULL,
        ACC_PASSWORD        TEXT NOT NULL,
        ACC_FNAME           TEXT DEFAULT '',
        ACC_LNAME           TEXT DEFAULT '',
        ACC_EMAIL           TEXT UNIQUE DEFAULT '',
        ACC_PHONE           TEXT DEFAULT '',
        ACC_ADDRESS         TEXT DEFAULT '',
        ACC_MONEY           TEXT DEFAULT '0.00',
        ACC_CREATION_DATE   DATE DEFAULT (datetime('now','localtime')),
        ACC_STATUS          TEXT DEFAULT 'Good'
        );
        CREATE TABLE IF NOT EXISTS PAYMENT (
        PAY_ID              INTEGER PRIMARY KEY,
        ACC_ID              INTEGER,
        PAY_DATE            DATE DEFAULT CURRENT_TIMESTAMP,
        PAY_PRICE           TEXT DEFAULT '0.00',
        FOREIGN KEY (ACC_ID) REFERENCES ACCOUNT (ACC_ID)
        );
        CREATE TABLE IF NOT EXISTS PRODUCT (
        PROD_ID             INTEGER PRIMARY KEY,
        PROD_NAME           TEXT DEFAULT '' UNIQUE,
        PROD_PRICE          TEXT DEFAULT '0.00',
        PROD_STOCK          INTEGER DEFAULT 0,
        PROD_FEE            TEXT DEFAULT '0.00',
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

    End Sub

    Function Exists(ByVal intRecordID As Integer) As Boolean
        Dim blnExists As Boolean
        Dim intErrorID As Integer = -1

        If (intRecordID.Equals(intErrorID)) Then
            blnExists = False
        Else
            blnExists = True
        End If

        Return blnExists

    End Function

    Public Sub SQLCreateSampleProductsIfNotExists()
        ' Creating new records in the PRODUCT table for sample products if they don't already exist
        Try
            Dim intCounter As Integer = _cintZero

            ' Hard-coded sample products
            CreateSampleProduct(intCounter, "Pine Chair", 72D, 1, 4.5D, "Chair", "Our pine chairs are created from the finest pine wood.")
            CreateSampleProduct(intCounter, "Maple Chair", 80D, 7, 5D, "Chair", "The maple chair is a household favorite!")
            CreateSampleProduct(intCounter, "Oak Chair", 83.33D, 22, 4.55D, "Chair", "Oak never goes out of style!")
            CreateSampleProduct(intCounter, "Pine Table", 141.5D, 3, 11.2D, "Table", "This pine table is extremely sturdy.")
            CreateSampleProduct(intCounter, "Maple Table", 148.73D, 0, 13.1D, "Table", "Tables made out of maple look good.")
            CreateSampleProduct(intCounter, "Oak Table", 162D, 4, 17.05D, "Table", "Our oak tables are always well-built!")
            CreateSampleProduct(intCounter, "Pine Desk", 138.6D, 2, 11.1D, "Desk", "The pine desk.")
            CreateSampleProduct(intCounter, "Maple Desk", 145D, 5, 12.7D, "Desk", "Maple desks are reliable.")
            CreateSampleProduct(intCounter, "Oak Desk", 160.9D, 11, 13D, "Desk", "This oak desk is smooth.")
            CreateSampleProduct(intCounter, "Leather Couch", 341.5D, 1, 51.28D, "Couch", "This leather couch is water-resistant!")
            CreateSampleProduct(intCounter, "Silk Couch", 343.73D, 1, 53.62D, "Couch", "The silk couch is easy to clean.")
            CreateSampleProduct(intCounter, "Wool Couch", 362.99D, 9, 77.2D, "Couch", "Our wool couches are comfortable.")
            CreateSampleProduct(intCounter, "Linen Carpet", 421.22D, 2, 54D, "Carpet", "Linen carpets are very popular.")
            CreateSampleProduct(intCounter, "Silk Carpet", 440D, 5, 55.99D, "Carpet", "This silk carpet can withstand some wear and tear.")
            CreateSampleProduct(intCounter, "Wool Carpet", 442.99D, 8, 78.37D, "Carpet", "Our wool carpets are stain-resistant.")

            If (intCounter.Equals(_cintZero)) Then
                Console.WriteLine("Sample products already exist in the database.")
            Else
                Console.WriteLine("Created " & intCounter.ToString() & " sample products in the database.")
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Unknown error occurred when trying to create sample products.")
        End Try
    End Sub

    Private Sub CreateSampleProduct(ByRef intCounter As Integer,
                                    ByVal strName As String,
                                    ByVal decPrice As Decimal,
                                    ByVal intStock As Integer,
                                    ByVal decFee As Decimal,
                                    ByVal strCategory As String,
                                    ByVal strDescription As String)
        Dim strField As String = "PROD_NAME"
        Dim strFieldValue As String = strName
        If (Not Exists(SQLGetRecordID(DatabaseTables.PRODUCT, strField, strFieldValue))) Then
            SQLCreateProduct(strName, decPrice, intStock, decFee, strCategory, strDescription)
            intCounter += 1
        End If

    End Sub

    Public Sub SQLCreateProduct(ByVal intName As String,
                                ByVal decPrice As Decimal,
                                ByVal intStock As Integer,
                                ByVal decFee As Decimal,
                                ByVal strCategory As String,
                                ByVal strDescription As String)

        Dim strSQLCreateProductRecord As String = "INSERT INTO PRODUCT (PROD_NAME, PROD_PRICE, PROD_STOCK, PROD_FEE, PROD_CATEGORY, PROD_DESCRIPTION)
        VALUES('" & intName & "', '" & decPrice & "', " & intStock & ", '" & decFee & "', '" & strCategory & "', '" & strDescription & "');"

        ' Creating the connection
        Dim connection As String = "Data Source=" & _cstrDatabaseName
        Dim SQLConn As New SQLiteConnection(connection)
        Dim SQLcmd As New SQLiteCommand(SQLConn)
        SQLConn.Open()

        SQLcmd.Connection = SQLConn

        ' Executing the SQL statement to create a new record in the ACCOUNT table
        SQLcmd.CommandText = strSQLCreateProductRecord
        SQLcmd.ExecuteNonQuery()

        ' Close the connection
        SQLConn.Close()
    End Sub

    Public Sub SQLCreateGuestIfNotExists()
        ' Creating a new record in the ACCOUNT table for Guest if it doesn't already exist
        Try
            Dim strField As String = "ACC_USERNAME"
            Dim strFieldValue As String = "Guest"
            Dim intGuestRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, strField, strFieldValue)
            If (Not Exists(intGuestRecordID)) Then
                SQLCreateAccount("Guest", "password", "Guest_FName", "Guest_LName", "Guest@example.com", "+1 (234) 567-8901", "123 North Main St.")
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

    Function RegexValidateUserData(ByVal strData As String, ByVal intDataType As Integer) As Boolean
        Dim blnReturn As Boolean
        Dim strAllowedCharactersRegex As String
        Select Case intDataType
            Case RegexValidate.USERNAME
                strAllowedCharactersRegex = "^[A-Za-z][A-Za-z0-9]{3,}$"
            Case RegexValidate.PASSWORD
                strAllowedCharactersRegex = "^[A-Za-z0-9@.\-_\s]{6,}$"
            Case RegexValidate.EMAIL
                strAllowedCharactersRegex = "^[A-Za-z0-9.\-_]+@[A-Za-z0-9.\-_]+.[A-Za-z0-9.\-_]+$"
            Case RegexValidate.OTHER_EMPTY
                strAllowedCharactersRegex = "^[A-Za-z0-9@.\-_\s\(\)]*$"
            Case RegexValidate.ID
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

    Function SQLGetFieldInfo(ByVal intTable As Integer, ByVal intPrimaryKeyID As Integer, ByVal strField As String, Optional ByVal blnCaseSensitive As Boolean = False) As String

        Const cstrError As String = "Error - Unable to get field info from the database."

        Dim strReturn As String = _cstrEmpty

        Dim strTable As String = _cstrEmpty
        Dim strPrimaryKey As String = _cstrEmpty
        Dim strCaseSensitivity As String = _cstrEmpty

        If (blnCaseSensitive) Then
            ' SQL queries are case sensitive by default
        Else
            strCaseSensitivity = _cstrCaseInsensitive
        End If

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

            Dim strFieldInfo As String = _cstrEmpty

            Dim SQLstr As String = "SELECT * FROM " & strTable & " WHERE " & strPrimaryKey & "=" & intPrimaryKeyID.ToString() & strCaseSensitivity & ";"

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

    Function SQLGetRecordID(ByVal intTable As Integer, ByVal strField As String, ByVal strFieldValue As String, Optional ByVal blnCaseSensitive As Boolean = False) As Integer

        Dim intErrorID As Integer = -1
        Dim intRecordID As Integer = intErrorID

        Dim strTable As String = _cstrEmpty
        Dim strPrimaryKey As String = _cstrEmpty
        Dim strCaseSensitivity As String = _cstrEmpty

        If (blnCaseSensitive) Then
            ' SQL queries are case sensitive by default
        Else
            strCaseSensitivity = _cstrCaseInsensitive
        End If

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

            Dim SQLstr As String = "SELECT * FROM " & strTable & " WHERE " & strField & "='" & strFieldValue & "'" & strCaseSensitivity & ";"

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

    Public Sub SQLSetFieldInfo(ByVal intTable As Integer, ByVal intPrimaryKeyID As Integer, ByVal strField As String, ByVal strFieldNewValue As String, Optional ByVal blnCaseSensitive As Boolean = False)
        Dim intErrorID As Integer = -1
        Dim intRecordID As Integer = intErrorID

        Dim strTable As String = _cstrEmpty
        Dim strPrimaryKey As String = _cstrEmpty
        Dim strCaseSensitivity As String = _cstrEmpty

        If (blnCaseSensitive) Then
            ' SQL queries are case sensitive by default
        Else
            strCaseSensitivity = _cstrCaseInsensitive
        End If

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
            Dim SQLstr As String = "UPDATE " & strTable & "
            SET " & strField & " = '" & strFieldNewValue & "'
            WHERE " & strPrimaryKey & " = " & intPrimaryKeyID & strCaseSensitivity & ";"

            Dim SQLConn As New SQLiteConnection(_cstrConnection)
            Dim SQLcmd As New SQLiteCommand(SQLConn)
            Dim SQLdr As SQLiteDataReader
            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = SQLstr
            SQLdr = SQLcmd.ExecuteReader()

            ' Close the connection
            SQLdr.Close()
            SQLConn.Close()

        End If

    End Sub

    Public Sub SQLGetProducts()
        ' Reading products from the database, creating Items, and adding the Items
        ' to the _Products list
        Dim SQLstr As String = "SELECT * FROM PRODUCT;"

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
                Dim itmNewItem As Item = New Item() With {
                    .ID = Convert.ToInt32(SQLdr.GetValue(SQLdr.GetOrdinal("PROD_ID")).ToString()),
                    .Name = SQLdr.GetValue(SQLdr.GetOrdinal("PROD_NAME")).ToString(),
                    .Price = Convert.ToDecimal(SQLdr.GetValue(SQLdr.GetOrdinal("PROD_PRICE")).ToString()),
                    .Stock = Convert.ToInt32(SQLdr.GetValue(SQLdr.GetOrdinal("PROD_STOCK")).ToString()),
                    .Fee = Convert.ToDecimal(SQLdr.GetValue(SQLdr.GetOrdinal("PROD_FEE")).ToString()),
                    .Category = SQLdr.GetValue(SQLdr.GetOrdinal("PROD_CATEGORY")).ToString(),
                    .Description = SQLdr.GetValue(SQLdr.GetOrdinal("PROD_DESCRIPTION")).ToString()
                }
                AddToProducts(itmNewItem)
            Catch ex As IndexOutOfRangeException
                Console.WriteLine(ex.Message)
                Console.WriteLine("Invalid column name.")
            Catch ex As InvalidCastException
                Console.WriteLine(ex.Message)
                Console.WriteLine("Invalid cast when executing a SQLiteDataReader method.")
            End Try
        End While

        ' Close the connection
        SQLdr.Close()
        SQLConn.Close()

    End Sub

End Module
