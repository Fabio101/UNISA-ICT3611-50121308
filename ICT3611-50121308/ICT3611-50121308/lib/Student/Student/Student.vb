Imports System
Imports System.IO
Imports System.Text
Imports DB.dataSQL

Public Class Student

    'VB Complains without the below private properties...
    Private Property m_Title As String
    Private Property m_Initial As String
    Private Property m_Surname As String
    Private Property m_Address As String
    Private Property m_DoB As String
    Private Property m_Gender As String
    Private Property m_StudentNumber As Integer

    Public Sub New()

    End Sub

    Public Sub New(title As String, initial As String, surname As String, address As String, dob As String, gender As String)

        'Student text file + line count for student number generation
        Dim path As String = "students.txt"
        Dim studentcount As Integer = IO.File.ReadAllLines(path).Length

        'This gives us the last two digits of the year
        Dim curDate = DateAndTime.Year(Now).ToString()
        Dim dateYear = curDate.Substring(curDate.Length - 2)
        Dim num As Integer

        If studentcount = 0 Then
            num = studentcount
        Else
            'Add 1 to number of students
            num = studentcount + 1
        End If

        'Padding
        Dim paddedNum As String = num.ToString().PadLeft(4, "0")

        'Final number minus check digit
        Dim StudentNumNoCheck As String = dateYear & paddedNum

        'Loop to add the sum of the digits of paddedNum to get check digit
        Dim paddedNumSum As Integer = StudentNumNoCheck
        Dim Sum As Integer
        Dim digit As Integer

        While (paddedNumSum <> 0)
            digit = paddedNumSum Mod 10
            Sum = Sum + digit
            paddedNumSum = paddedNumSum \ 10
        End While

        'Get remainer of Sum divided by 10
        Dim Remainder As Integer = Sum Mod 10
        Dim checkDigit As Integer

        If Remainder = 0 Then
            checkDigit = 0
        Else
            'Subtract remiander from 10 to get check digit
            checkDigit = 10 - Remainder
        End If

        'Concatenate studentnumber not checked with check digit
        Dim StudentNum As String = StudentNumNoCheck & checkDigit

        Me.Title = title
        Me.Initial = initial
        Me.Surname = surname
        Me.Address = address
        Me.DoB = dob
        Me.Gender = gender
        Me.StudentNumber = StudentNum

        'Write student object data to studentfile
        Dim textOut As New StreamWriter(New FileStream(path, FileMode.Append, FileAccess.Write))

        If studentcount = 0 Then
            textOut.Write(Me.StudentNumber & "|")
        Else
            textOut.Write(vbCrLf & Me.StudentNumber & "|")
        End If

        textOut.Write(Me.Title & "|")
        textOut.Write(Me.Surname & "|")
        textOut.Write(Me.Address & "|")
        textOut.Write(Me.DoB & "|")
        textOut.Write(Me.Gender)

        textOut.Close()
        textOut.Dispose()
    End Sub

    Public Function validateStudentNumber(studentnumber As Integer) As Boolean
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
            Return True
        Else
            Return False
        End If
    End Function

    Public Function enrollStudent(studentnumber As String, modulecode As String) As Boolean
        Dim path As String = "students.txt"
        'Read each line of student file and on match append module code to that line to enroll
        Dim textIn As New StreamReader(New FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))

        Dim students As New List(Of Student)

        Do While textIn.Peek <> 1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))

            'Matching time
            If columns(0) = studentnumber And row.Contains(modulecode) Then
                Return False
            ElseIf columns(0) = studentnumber Then
                Dim replaced As String = row.Insert(row.Length, "|" & modulecode)

                textIn.Close()

                Dim lines() As String
                Dim outputlines As New List(Of String)
                Dim searchString As String = studentnumber

                lines = IO.File.ReadAllLines(path)

                For Each line As String In lines
                    If line.Contains(searchString) = False Then
                        outputlines.Add(line)
                    End If
                Next
                'Restore file data minus modified line
                File.WriteAllLines(path, outputlines.ToArray(), Encoding.UTF8)

                'Write modified student object data to modules file
                Dim textOut As New StreamWriter(New FileStream(path, FileMode.Append, FileAccess.Write))

                textOut.Write(replaced)

                textOut.Close()

                Return True
            End If
        Loop
        textIn.Close()
        textIn.Dispose()
        Return False
    End Function

    'Student Class Properies
    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
        End Set
    End Property

    Public Property Initial As String
        Get
            Return m_Initial
        End Get
        Set(value As String)
            m_Initial = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return m_Surname
        End Get
        Set(value As String)
            m_Surname = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return m_Address
        End Get
        Set(value As String)
            m_Address = value
        End Set
    End Property

    Public Property DoB As String
        Get
            Return m_DoB
        End Get
        Set(value As String)
            m_DoB = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return m_Gender
        End Get
        Set(value As String)
            m_Gender = value
        End Set
    End Property

    Public Property StudentNumber As String
        Get
            Return m_StudentNumber
        End Get
        Set(value As String)
            m_StudentNumber = value
        End Set
    End Property
End Class
