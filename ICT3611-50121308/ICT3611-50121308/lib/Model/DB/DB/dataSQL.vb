Imports System.Data.SqlClient

Public Class dataSQL

    Dim con As New SqlConnection

    Public Sub New()

    End Sub

    Public Sub New(stuNum As String, title As String, initial As String, surname As String, address As String, dob As String, gender As String)

        con.ConnectionString = "C:\USERS\FABZ\DESKTOP\ASSIGNMENT1\ICT3611-50121308\ICT3611-50121308\LIB\MODEL\DB\DB\DATABASE1.MDF"

        con.Open()

        Dim cmd As New SqlCommand(("INSERT INTO students VALUES('" & stuNum & "','" & title & "','" & initial & "','" & surname & "','" & address & "','" & dob & "','" & gender & "')"), con)

        cmd.ExecuteNonQuery()

        con.Close()

    End Sub


End Class
