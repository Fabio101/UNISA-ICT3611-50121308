﻿Imports System.Data.SqlClient

Public Class dataSQL

    Dim con As New SqlConnection

    'Student RDMS entry
    Public Function addNew(stuNum1 As String, title1 As String, initial1 As String, surname1 As String, address1 As String, dob1 As String, gender1 As String) As Boolean

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabz\Desktop\Assignment1\ICT3611-50121308\ICT3611-50121308\lib\Model\DB\DB\orangeDB.mdf;Integrated Security=True;Connect Timeout=30"

        con.Open()

        Dim cmd As New SqlCommand(("INSERT INTO students VALUES('" & stuNum1 & "','" & title1 & "','" & initial1 & "','" & surname1 & "','" & address1 & "','" & dob1 & "','" & gender1 & "')"), con)

        cmd.ExecuteNonQuery()

        con.Close()

        Return True

    End Function

    'Module registration RDMS entry
    Public Function addNewMod(modcode1 As String, title2 As String, semester1 As String, activated1 As String, year1 As String) As Boolean

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabz\Desktop\Assignment1\ICT3611-50121308\ICT3611-50121308\lib\Model\DB\DB\orangeDB.mdf;Integrated Security=True;Connect Timeout=30"

        con.Open()

        Dim cmd As New SqlCommand(("INSERT INTO modules VALUES('" & modcode1 & "','" & title2 & "','" & semester1 & "','" & activated1 & "','" & year1 & "')"), con)

        cmd.ExecuteNonQuery()

        con.Close()

        Return True

    End Function

End Class
