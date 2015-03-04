Imports Student
Imports Modules
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class MainForm

    Dim stuReg As Integer
    Dim modReg As Integer
    Dim modAct As Integer
    Dim stuEnr As Integer

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

        'Populate Module Activation listbox from file + Populate enrollment listbox with only active modules
        Using MyReader As New TextFieldParser("modules.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    lstModules.Items.Add(currentRow(0))

                    If currentRow(3) = "True" Then
                        lstActMod.Items.Add(currentRow(0))
                    End If

                Catch ex As Exception
                    MsgBox("Line " & ex.Message & "is not valid line")
                End Try
            End While
        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStudentReg_Click(sender As Object, e As EventArgs) Handles btnStudentReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuReg = 1
        modReg = 0
        modAct = 0
        stuEnr = 0
        pnlStudentReg.Visible = True
        pnlModuleReg.Visible = False
        pnlModAct.Visible = False
        pnlEnrol.Visible = False
        btnSave.Text = "Register Student"
    End Sub

    Private Sub btnModuleReg_Click(sender As Object, e As EventArgs) Handles btnModuleReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuReg = 0
        modReg = 1
        modAct = 0
        stuEnr = 0
        pnlStudentReg.Visible = False
        pnlModuleReg.Visible = True
        pnlModAct.Visible = False
        pnlEnrol.Visible = False
        btnSave.Text = "Register Module"
    End Sub

    Private Sub btnModuleAct_Click(sender As Object, e As EventArgs) Handles btnModuleAct.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuReg = 0
        modReg = 0
        modAct = 1
        stuEnr = 0
        pnlModAct.Visible = True
        pnlStudentReg.Visible = False
        pnlModuleReg.Visible = False
        pnlEnrol.Visible = False
        btnSave.Text = "Activate/Modify"
    End Sub

    Private Sub btnStudentEnroll_Click(sender As Object, e As EventArgs) Handles btnStudentEnroll.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        stuEnr = 1
        stuReg = 0
        modReg = 0
        modAct = 0
        pnlModAct.Visible = False
        pnlStudentReg.Visible = False
        pnlModuleReg.Visible = False
        pnlEnrol.Visible = True
        btnSave.Text = "Enroll Student"
    End Sub

    Private Sub lstActMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActMod.SelectedIndexChanged
        lstEnrolled.Items.Clear()
        'Populate Enrolled Students listbox from students file
        Using MyReader3 As New StreamReader("students.txt")

            Do While MyReader3.Peek() <> -1
                Dim line() As String = MyReader3.ReadLine.Split("|")
                If line.Contains(lstActMod.SelectedItem.ToString()) Then
                    lstEnrolled.Items.Add(line(0) & " " & line(1) & " " & line(2))
                End If
            Loop
        End Using
    End Sub

    Private Sub lstModules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModules.SelectedIndexChanged

        'Check if the module is activated and prepopulate form objects accordingly
        Using MyReader2 As New StreamReader("modules.txt")

            Do While MyReader2.Peek() <> -1
                Dim line() As String = MyReader2.ReadLine.Split("|")
                If line.Contains(lstModules.SelectedItem.ToString()) And line.Contains("True") Then

                    lblActYear.Visible = True
                    dateActivate.Visible = False
                    chkActivated.Checked = True

                    lblTitle.Text = line(1)
                    lblActYear.Text = line(4)

                    If line(2) = "Both Semesters" Then
                        chkModSem1.Checked = True
                        chkModSem2.Checked = True
                    ElseIf line(2) = "First Semester" Then
                        chkModSem1.Checked = True
                        chkModSem2.Checked = False
                    Else
                        chkModSem1.Checked = False
                        chkModSem2.Checked = True
                    End If

                    Exit Do
                ElseIf line.Contains(lstModules.SelectedItem.ToString()) Then
                    lblTitle.Text = line(1)
                    dateActivate.Visible = True
                    lblActYear.Visible = False
                    chkActivated.Checked = False
                    chkModSem1.Checked = False
                    chkModSem2.Checked = False
                End If
            Loop
        End Using

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
            'Module registration specific commits
            If IsModuleRegValid() = True Then

                Dim semester As String
                If chk1.Checked = True And chk2.Checked = True Then
                    semester = "Both Semesters"
                ElseIf chk1.Checked = True Then
                    semester = "First Semester"
                Else
                    semester = "Second Semester"
                End If

                Dim modl As Modules.modules
                Try
                    modl = New Modules.modules(txtModCode.Text, txtModTitle.Text, semester)
                    MessageBox.Show("Module Code : " & modl.Code & vbCrLf & "Module Title : " & modl.Title & vbCrLf & "Semester Period : " & modl.Semester, "Success")
                    'restart application to restore all vars to state of startup, also clears the forms... handy
                    Application.Restart()
                    Me.Refresh()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        ElseIf modAct = 1 Then

            Dim semester As String
            If chkModSem1.Checked = True And chkModSem2.Checked = True Then
                semester = "Both Semesters"
            ElseIf chkModSem1.Checked = True Then
                semester = "First Semester"
            Else
                semester = "Second Semester"
            End If

            Dim year As String
            If dateActivate.Visible = True Then
                year = dateActivate.Value.ToString("yyyy")
            Else
                year = lblActYear.Text
            End If

            'Module Activation specific commits
            Dim modl As Modules.modules
            Try
                modl = New Modules.modules()
                modl.modifyModule(lstModules.SelectedItem.ToString(), lblTitle.Text, semester, chkActivated.CheckState, year)

                'restart application to restore all vars to state of startup, also clears the forms... handy
                Application.Restart()
                Me.Refresh()
            Catch ex As Exception
                MessageBox.Show("You must select a module from the list.", "Entry Error")
            End Try
        ElseIf stuEnr = 1 Then
            Dim stu As Student.Student
            Try
                Dim moduleCode As String = lstActMod.SelectedItem.ToString()
                stu = New Student.Student()

                'stu.StudentNumber = txtStuNum.Text

                Dim valid = validateStudentNumber(txtStuNum.Text)
                MessageBox.Show(valid)

                If Not valid = 0 Then
                    MessageBox.Show("Invalid", "Failiure")
                Else
                    MessageBox.Show("Student Number is Valid", "Success")
                End If

            Catch ex As Exception
                MessageBox.Show("You must select a Module to enroll for.", "Entry Error")
            End Try
        End If
    End Sub

    Public Function validateStudentNumber(studentnumber As Integer) As Integer
        'Validate Student number
        Dim Sum As Integer
        Dim digit As Integer

        Dim studentNumSum As Integer = studentnumber

        While (studentNumSum <> 0)
            digit = studentNumSum Mod 10
            Sum = Sum + digit
            studentNumSum = studentNumSum \ 10
        End While

        Dim remainder As Integer = Sum Mod 10

        If remainder = 0 Then

            Return remainder
        Else
            Return remainder
        End If
    End Function

End Class
