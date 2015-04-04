Imports System
Imports System.Text
Imports System.IO
Imports DB.dataSQL

Public Class modules

    Private Property m_Code As String
    Private Property m_Title As String
    Private Property m_Semester As String
    Private Property m_Active As Boolean
    Private Property m_Year As String

    Public Sub New()

    End Sub

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
            Me.Active = False
            Me.Year = "0000"
        End If

        'Write student object data to modules file
        Dim textOut As New StreamWriter(New FileStream(path, FileMode.Append, FileAccess.Write))

        textOut.Write(Me.Code & "|")
        textOut.Write(Me.Title & "|")
        textOut.Write(Me.Semester & "|")
        textOut.Write(Me.Active & "|")
        textOut.Write(Me.Year & vbCrLf)

        textOut.Close()

        'Add to database
        Dim add = New DB.dataSQL
        add.addNewMod(Me.Code, Me.Title, Me.Semester, Me.Active, Me.Year)

    End Sub

    Public Function modifyModule(code As String, title As String, semester As String, active As Boolean, year As String) As Boolean

        'Didnt manage with the 6 month restriction here... no more time...

        Me.Code = code
        Me.Title = title
        Me.Active = active
        Me.Year = year
        Me.Semester = semester

        'Search all lines of module file for code value then rewrite the file without the found line, essentially deleting the line
        Dim lines() As String
        Dim outputlines As New List(Of String)
        Dim searchString As String = code

        Dim path As String = "modules.txt"
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

        textOut.Write(Me.Code & "|")
        textOut.Write(Me.Title & "|")
        textOut.Write(Me.Semester & "|")
        textOut.Write(Me.Active & "|")
        textOut.Write(Me.Year & vbCrLf)

        textOut.Close()
        Return True
    End Function

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

    Public Property Active As Boolean
        Get
            Return m_Active
        End Get
        Set(value As Boolean)
            m_Active = value
        End Set
    End Property

    Public Property Year As String
        Get
            Return m_Year
        End Get
        Set(value As String)
            m_Year = value
        End Set
    End Property

End Class
