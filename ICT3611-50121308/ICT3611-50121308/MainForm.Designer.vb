<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStudentReg = New System.Windows.Forms.Button()
        Me.btnModuleReg = New System.Windows.Forms.Button()
        Me.btnModuleAct = New System.Windows.Forms.Button()
        Me.btnStudentEnroll = New System.Windows.Forms.Button()
        Me.Functions = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Functions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStudentReg
        '
        Me.btnStudentReg.Location = New System.Drawing.Point(6, 29)
        Me.btnStudentReg.Name = "btnStudentReg"
        Me.btnStudentReg.Size = New System.Drawing.Size(119, 55)
        Me.btnStudentReg.TabIndex = 0
        Me.btnStudentReg.Text = "Student Registrations"
        Me.btnStudentReg.UseVisualStyleBackColor = True
        '
        'btnModuleReg
        '
        Me.btnModuleReg.Location = New System.Drawing.Point(6, 90)
        Me.btnModuleReg.Name = "btnModuleReg"
        Me.btnModuleReg.Size = New System.Drawing.Size(119, 55)
        Me.btnModuleReg.TabIndex = 1
        Me.btnModuleReg.Text = "Module Registrations"
        Me.btnModuleReg.UseVisualStyleBackColor = True
        '
        'btnModuleAct
        '
        Me.btnModuleAct.Location = New System.Drawing.Point(6, 151)
        Me.btnModuleAct.Name = "btnModuleAct"
        Me.btnModuleAct.Size = New System.Drawing.Size(119, 55)
        Me.btnModuleAct.TabIndex = 2
        Me.btnModuleAct.Text = "Module Activations"
        Me.btnModuleAct.UseVisualStyleBackColor = True
        '
        'btnStudentEnroll
        '
        Me.btnStudentEnroll.Location = New System.Drawing.Point(6, 212)
        Me.btnStudentEnroll.Name = "btnStudentEnroll"
        Me.btnStudentEnroll.Size = New System.Drawing.Size(119, 55)
        Me.btnStudentEnroll.TabIndex = 3
        Me.btnStudentEnroll.Text = "Student Enrolments"
        Me.btnStudentEnroll.UseVisualStyleBackColor = True
        '
        'Functions
        '
        Me.Functions.Controls.Add(Me.btnModuleReg)
        Me.Functions.Controls.Add(Me.btnStudentEnroll)
        Me.Functions.Controls.Add(Me.btnStudentReg)
        Me.Functions.Controls.Add(Me.btnModuleAct)
        Me.Functions.Location = New System.Drawing.Point(12, 12)
        Me.Functions.Name = "Functions"
        Me.Functions.Size = New System.Drawing.Size(130, 289)
        Me.Functions.TabIndex = 4
        Me.Functions.TabStop = False
        Me.Functions.Text = "Functions"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 289)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(129, 118)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(231, 39)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Orange Univeristy System System:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select a function from the left menu to proce" & _
    "ed."
        Me.lblInfo.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(468, 307)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 37)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(574, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 37)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 356)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Functions)
        Me.Name = "MainForm"
        Me.Text = "Orange University - Student System"
        Me.Functions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudentReg As System.Windows.Forms.Button
    Friend WithEvents btnModuleReg As System.Windows.Forms.Button
    Friend WithEvents btnModuleAct As System.Windows.Forms.Button
    Friend WithEvents btnStudentEnroll As System.Windows.Forms.Button
    Friend WithEvents Functions As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
