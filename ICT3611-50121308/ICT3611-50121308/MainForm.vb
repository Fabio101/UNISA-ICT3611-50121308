Imports Student
Imports Modules
Imports System.IO

Public Class MainForm

    Dim stuReg As Integer
    Dim modReg As Integer

    'Form validation functions
    'Checks if supplied tectbox contains characters
    Private Function IsPresent(textbox As TextBox, name As String) As Boolean
        If textbox.Text = "" Then
            MessageBox.Show(name & " is a required field.", "Entry Error")
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'Checks if supplied textbox containsonly alphabetic characters
    Private Function IsLetter(textbox As TextBox, name As String) As Boolean
        If Char.IsLetter(textbox.Text.Chars(textbox.Text.Length - 1)) = False Then
            MessageBox.Show(name & " requires only alphabetic characters.", "Entry Error")
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'Checks two radio buttons of Gender and if neither are checked return false
    Private Function IsGenderSelected(radiobutton1 As RadioButton, radiobutton2 As RadioButton) As Boolean
        If radiobutton1.Checked = False And radiobutton2.Checked = False Then
            MessageBox.Show("Please select a Gender.", "Entry Missing")
            Return False
        Else
            Return True
        End If
    End Function

    'Checks the two semester check boxes and if neither are checked return false
    Private Function IsSemesterSelected(checkbox1 As CheckBox, checkbox2 As CheckBox) As Boolean
        If checkbox1.Checked = False And checkbox2.Checked = False Then
            MessageBox.Show("Please select at least one semester.", "Entry Missing")
            Return False
        Else
            Return True
        End If
    End Function

    'Checks if date of birth and present date are greater than or equal to 18 years difference
    Private Function IsEighteen(dateofbirth As Date) As Boolean
        Dim value = DateDiff(DateInterval.Year, DateAndTime.Now, dateofbirth)
        If Not value <= -18 Then
            MessageBox.Show("Student must be at least 18 years old, Confirm date of birth.")
            Return False
        Else
            Return True
        End If
    End Function

    'Validates the imput objects of the module registration panel
    Private Function IsModuleRegValid() As Boolean
        If Not IsPresent(txtModCode, "Module Code") Then
            Return False
        End If

        If Not IsPresent(txtModTitle, "Title") Then
            Return False
        End If

        If Not IsSemesterSelected(chk1, chk2) Then
            Return False
        End If

        Return True
    End Function

    'Validates the input objects in the student registration panel
    Private Function IsStudentRegValid() As Boolean
        If Not IsPresent(txtTitle, "Title") Then
            Return False
        End If

        If Not IsLetter(txtTitle, "Title") Then
            Return False
        End If

        If Not IsPresent(txtInit, "Initials") Then
            Return False
        End If

        If Not IsLetter(txtInit, "Initials") Then
            Return False
        End If

        If Not IsPresent(txtSurname, "Surname") Then
            Return False
        End If

        If Not IsLetter(txtSurname, "Surname") Then
            Return False
        End If

        If Not IsPresent(txtAddress, "Address") Then
            Return False
        End If

        If Not IsGenderSelected(radioFemale, radioMale) Then
            Return False
        End If

        If Not IsEighteen(dateDob.Value) Then
            Return False
        End If

        Return True
    End Function

    'Form Object event handeling
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStudentReg_Click(sender As Object, e As EventArgs) Handles btnStudentReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuReg = 1
        modReg = 0
        pnlModuleReg.Visible = False
        pnlStudentReg.Visible = True
    End Sub

    Private Sub btnModuleReg_Click(sender As Object, e As EventArgs) Handles btnModuleReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuReg = 0
        modReg = 1
        pnlStudentReg.Visible = False
        pnlModuleReg.Visible = True
    End Sub

    Private Sub btnModuleAct_Click(sender As Object, e As EventArgs) Handles btnModuleAct.Click
        lblInfo.Visible = False
        btnSave.Visible = True
    End Sub

    Private Sub btnStudentEnroll_Click(sender As Object, e As EventArgs) Handles btnStudentEnroll.Click
        lblInfo.Visible = False
        btnSave.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Student registration specific commits
        If stuReg = 1 Then

            If IsStudentRegValid() = True Then

                Dim gender As String
                If radioFemale.Checked = True Then
                    gender = radioFemale.Text
                Else
                    gender = radioMale.Text
                End If

                'Create STudent object passing the data collected from the form
                Dim student As Student.Student
                student = New Student.Student(txtTitle.Text, txtInit.Text, txtSurname.Text, txtAddress.Text, dateDob.Text, gender)
                MessageBox.Show("Student Number : " & student.StudentNumber & vbCrLf & "Student : " & student.Initial & student.Title & " " & student.Surname & vbCrLf & "Address : " & student.Address & vbCrLf & "Gender : " & student.Gender & vbCrLf & "Date of Birth : " & student.DoB, "Success")
                'restart application to restore all vars to state of startup, also clears the forms... handy
                Application.Restart()
                Me.Refresh()
            End If
        ElseIf modReg = 1 Then

            If IsModuleRegValid() = True Then

                Dim semester As String
                If chk1.Checked = True And chk2.Checked = True Then
                    semester = "Both Semesters"
                ElseIf chk1.Checked = True Then
                    semester = "First Semester"
                Else
                    semester = "Second Semester"
                End If

                'restart application to restore all vars to state of startup, also clears the forms... handy
                Application.Restart()
                Me.Refresh()
            End If
        End If
    End Sub

End Class
