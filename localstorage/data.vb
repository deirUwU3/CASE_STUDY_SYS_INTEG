Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Data
    Public Function GetConnection() As MySqlConnection
        Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=studentdb")
        Return connection

    End Function
    ' Define connection


End Module
