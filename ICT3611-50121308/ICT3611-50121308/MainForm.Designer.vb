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
        Me.pnlStudentReg = New System.Windows.Forms.Panel()
        Me.lblStudentRegMain = New System.Windows.Forms.Label()
        Me.lblStudentTitle = New System.Windows.Forms.Label()
        Me.lblStudentInit = New System.Windows.Forms.Label()
        Me.lblStudentSur = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtInit = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.Functions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlStudentReg.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.pnlStudentReg)
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
        Me.lblInfo.Location = New System.Drawing.Point(206, 132)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(116, 13)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "SELECT A FUNCTION"
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
        Me.btnSave.Visible = False
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
        'pnlStudentReg
        '
        Me.pnlStudentReg.Controls.Add(Me.radioFemale)
        Me.pnlStudentReg.Controls.Add(Me.radioMale)
        Me.pnlStudentReg.Controls.Add(Me.datePicker)
        Me.pnlStudentReg.Controls.Add(Me.txtAddress)
        Me.pnlStudentReg.Controls.Add(Me.txtSurname)
        Me.pnlStudentReg.Controls.Add(Me.txtInit)
        Me.pnlStudentReg.Controls.Add(Me.txtTitle)
        Me.pnlStudentReg.Controls.Add(Me.lblGender)
        Me.pnlStudentReg.Controls.Add(Me.lblDob)
        Me.pnlStudentReg.Controls.Add(Me.lblAddress)
        Me.pnlStudentReg.Controls.Add(Me.lblStudentSur)
        Me.pnlStudentReg.Controls.Add(Me.lblStudentInit)
        Me.pnlStudentReg.Controls.Add(Me.lblStudentTitle)
        Me.pnlStudentReg.Controls.Add(Me.lblStudentRegMain)
        Me.pnlStudentReg.Location = New System.Drawing.Point(6, 19)
        Me.pnlStudentReg.Name = "pnlStudentReg"
        Me.pnlStudentReg.Size = New System.Drawing.Size(514, 264)
        Me.pnlStudentReg.TabIndex = 1
        Me.pnlStudentReg.Visible = False
        '
        'lblStudentRegMain
        '
        Me.lblStudentRegMain.AutoSize = True
        Me.lblStudentRegMain.Location = New System.Drawing.Point(4, 10)
        Me.lblStudentRegMain.Name = "lblStudentRegMain"
        Me.lblStudentRegMain.Size = New System.Drawing.Size(85, 13)
        Me.lblStudentRegMain.TabIndex = 0
        Me.lblStudentRegMain.Text = "Student Details :"
        '
        'lblStudentTitle
        '
        Me.lblStudentTitle.AutoSize = True
        Me.lblStudentTitle.Location = New System.Drawing.Point(4, 38)
        Me.lblStudentTitle.Name = "lblStudentTitle"
        Me.lblStudentTitle.Size = New System.Drawing.Size(33, 13)
        Me.lblStudentTitle.TabIndex = 1
        Me.lblStudentTitle.Text = "Title :"
        '
        'lblStudentInit
        '
        Me.lblStudentInit.AutoSize = True
        Me.lblStudentInit.Location = New System.Drawing.Point(110, 38)
        Me.lblStudentInit.Name = "lblStudentInit"
        Me.lblStudentInit.Size = New System.Drawing.Size(42, 13)
        Me.lblStudentInit.TabIndex = 2
        Me.lblStudentInit.Text = "Initials :"
        '
        'lblStudentSur
        '
        Me.lblStudentSur.AutoSize = True
        Me.lblStudentSur.Location = New System.Drawing.Point(261, 38)
        Me.lblStudentSur.Name = "lblStudentSur"
        Me.lblStudentSur.Size = New System.Drawing.Size(55, 13)
        Me.lblStudentSur.TabIndex = 3
        Me.lblStudentSur.Text = "Surname :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(7, 71)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(51, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address :"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(7, 177)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(75, 13)
        Me.lblDob.TabIndex = 5
        Me.lblDob.Text = "Date of Birth : "
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(7, 214)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(48, 13)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(43, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(61, 20)
        Me.txtTitle.TabIndex = 7
        '
        'txtInit
        '
        Me.txtInit.Location = New System.Drawing.Point(159, 35)
        Me.txtInit.Name = "txtInit"
        Me.txtInit.Size = New System.Drawing.Size(96, 20)
        Me.txtInit.TabIndex = 8
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(323, 35)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(156, 20)
        Me.txtSurname.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(65, 71)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(414, 91)
        Me.txtAddress.TabIndex = 10
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(88, 177)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(200, 20)
        Me.datePicker.TabIndex = 11
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Location = New System.Drawing.Point(65, 214)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(48, 17)
        Me.radioMale.TabIndex = 12
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Location = New System.Drawing.Point(119, 214)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(59, 17)
        Me.radioFemale.TabIndex = 13
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
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
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orange University - Student System"
        Me.Functions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlStudentReg.ResumeLayout(False)
        Me.pnlStudentReg.PerformLayout()
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
    Friend WithEvents pnlStudentReg As System.Windows.Forms.Panel
    Friend WithEvents lblStudentRegMain As System.Windows.Forms.Label
    Friend WithEvents lblStudentTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudentInit As System.Windows.Forms.Label
    Friend WithEvents lblStudentSur As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtInit As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents datePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents radioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radioMale As System.Windows.Forms.RadioButton

End Class
