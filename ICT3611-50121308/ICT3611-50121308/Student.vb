Imports System.IO

Public Class Student

    'Student text file + line count for student number generation
    Private Const StudentFile As String = "files\students.txt"
    Public Property StudentCount As Integer = File.ReadAllLines(StudentFile).Length

    'VB Complains without the below private properties...
    Private Property m_Title As String
    Private Property m_Initial As String
    Private Property m_Surname As String
    Private Property m_Address As String
    Private Property m_DoB As Date
    Private Property m_Gender As String
    Private Property m_StudentNumber As Decimal

    'Constructors
    Public Sub New()
    End Sub

    Public Sub New(title As String, initial As String, surname As String, address As String, dob As Date, gender As String, studentnumber As String)
        Me.Title = title
        Me.Initial = initial
        Me.Surname = surname
        Me.Address = address
        Me.DoB = dob
        Me.Gender = gender

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

    Public Property DoB As Date
        Get
            Return m_DoB
        End Get
        Set(value As Date)
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
            'This gives us the last two digits of the year 
            Dim dateYear = DoB.ToString("yy")

            'Add 1 to number of students
            Dim num As Integer = StudentCount + 1

            Dim paddedNum As Integer

            'Padding ensuring a max of 4 digits
            If num > 999 Then
                paddedNum = num
            ElseIf num > 99 Then
                paddedNum = num.ToString().PadLeft(1, "0")
            ElseIf num > 9 Then
                paddedNum = num.ToString().PadLeft(2, "0")
            Else
                paddedNum = num.ToString().PadLeft(3, "0")
            End If

            'Loop to add the sum of the digits of paddedNum
            Dim paddedNumSum As Integer = paddedNum
            Dim Sum As Integer
            Dim digit As Integer

            While (paddedNumSum <> 0)
                digit = paddedNumSum Mod 10
                Sum = Sum + digit
                paddedNumSum = paddedNumSum / 10
            End While

            'Get remainer of Sum divided by 10
            Dim Remainder As Integer = Sum Mod 10

            'Subtract remiander from 10 to get check digit
            Dim checkDigit As Integer = 10 - Remainder

            'Concatenate paddedNum with check digit
            value = paddedNum & checkDigit

        End Set
    End Property

    Public Sub validateStudentNumber(studentnumber As String)
        'Validate Student number
        Dim Sum As Integer
        Dim digit As Integer

        Dim studentNumSum As Integer = studentnumber

        While (studentNumSum <> 0)
            digit = studentNumSum Mod 10
            Sum = Sum + digit
            studentNumSum = studentNumSum / 10
        End While

        If Not Sum Mod 10 = 0 Then
            MessageBox.Show(Me.StudentNumber & " is not a valid student number.", "Entry Error")
        End If
    End Sub

End Class
