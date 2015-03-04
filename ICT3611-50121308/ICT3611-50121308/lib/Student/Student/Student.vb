Imports System
Imports System.IO

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

        'Add 1 to number of students
        Dim num As Integer = studentcount + 1

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

        textOut.Write(Me.StudentNumber & "|")
        textOut.Write(Me.Title & "|")
        textOut.Write(Me.Surname & "|")
        textOut.Write(Me.Address & "|")
        textOut.Write(Me.DoB & "|")
        textOut.Write(Me.Gender & vbCrLf)

        textOut.Close()

    End Sub


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

    Public Sub enrollStudent()

    End Sub

End Class
