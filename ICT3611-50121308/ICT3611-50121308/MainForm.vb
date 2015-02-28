Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStudentReg_Click(sender As Object, e As EventArgs) Handles btnStudentReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
        pnlModuleReg.Visible = False
        pnlStudentReg.Visible = True
    End Sub

    Private Sub btnModuleReg_Click(sender As Object, e As EventArgs) Handles btnModuleReg.Click
        lblInfo.Visible = False
        btnSave.Visible = True
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
        Application.Restart()
        Me.Refresh()
    End Sub
End Class
