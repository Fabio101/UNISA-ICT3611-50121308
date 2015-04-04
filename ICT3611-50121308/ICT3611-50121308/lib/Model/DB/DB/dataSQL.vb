Imports System.Data.SqlClient

Public Class dataSQL

    Dim con As New SqlConnection
    Dim con2 As New SqlConnection

    'Student RDMS entry
    Public Function addNew(stuNum1 As String, title1 As String, initial1 As String, surname1 As String, address1 As String, dob1 As String, gender1 As String) As Boolean

        con.Open()

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabz\Desktop\Assignment1\ICT3611-50121308\ICT3611-50121308\lib\Model\DB\DB\orangeDB.mdf;Integrated Security=True;Connect Timeout=30"

        Dim cmd As New SqlCommand(("INSERT INTO students VALUES('" & stuNum1 & "','" & title1 & "','" & initial1 & "','" & surname1 & "','" & address1 & "','" & dob1 & "','" & gender1 & "')"), con)

        cmd.ExecuteNonQuery()
        con.Close()
        Return True
    End Function

    'Module registration RDMS entry
    Public Function addNewMod(modcode1 As String, title2 As String, semester1 As String, activated1 As String, year1 As String) As Boolean

        'The two conenctions are really stupid, will fix in time
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabz\Desktop\Assignment1\ICT3611-50121308\ICT3611-50121308\lib\Model\DB\DB\orangeDB.mdf;Integrated Security=True;Connect Timeout=30"
        con2.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabz\Desktop\Assignment1\ICT3611-50121308\ICT3611-50121308\lib\Model\DB\DB\orangeDB.mdf;Integrated Security=True;Connect Timeout=30"

        con.Open()
        con2.Open()

        Dim cmd1 As New SqlCommand(("SELECT Id FROM modules WHERE Id = '" & modcode1 & "'"), con)

        Dim Result = cmd1.ExecuteReader

        Result.Read()

        'Checks is query has any data, if yes then the moduel already exists
        If Result.HasRows = True Then
            Result.Close()
            Throw New System.Exception("Module Code already exists.")
        Else
            Dim cmd2 As New SqlCommand(("INSERT INTO modules VALUES('" & modcode1 & "','" & title2 & "','" & semester1 & "','" & activated1 & "','" & year1 & "')"), con2)

            cmd2.ExecuteNonQuery()

            Return True
        End If
        con.Close()
        con2.Close()
    End Function
End Class
