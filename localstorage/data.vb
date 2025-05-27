Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Data
    Public Function GetConnection() As MySqlConnection
        Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=studentdb")
        'Dim connection As New MySqlConnection("server=198.168.10.85;userid=vbnetuser;password=password;database=studentdb;port=3306;")
        Return connection

    End Function
    ' Define connection


End Module
