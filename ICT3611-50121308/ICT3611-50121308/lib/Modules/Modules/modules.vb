Imports System
Imports System.IO

Public Class modules

    Private Property m_Code As String
    Private Property m_Title As String
    Private Property m_Semester As String

    Public Sub New(code As String, title As String, semester As String)

        'Modules text file + Search for module code in textfile
        Dim path As String = "modules.txt"
        Dim text As String = IO.File.ReadAllText(path)

        Dim index As Integer = text.IndexOf(code)
        If index >= 0 Then
            Throw New System.Exception("Module Code already exists.")
        Else
            Me.Code = code
            Me.Title = title
            Me.Semester = semester
        End If

        'Write student object data to modules file
        Dim textOut As New StreamWriter(New FileStream(path, FileMode.Append, FileAccess.Write))

        textOut.Write(Me.Code & "|")
        textOut.Write(Me.Title & "|")
        textOut.Write(Me.Semester & vbCrLf)

        textOut.Close()

    End Sub

    'Modules Class Properies
    Public Property Code As String
        Get
            Return m_Code
        End Get
        Set(value As String)
            m_Code = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
        End Set
    End Property

    Public Property Semester As String
        Get
            Return m_Semester
        End Get
        Set(value As String)
            m_Semester = value
        End Set
    End Property

End Class
