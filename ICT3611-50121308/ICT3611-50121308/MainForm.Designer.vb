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
        Me.pnlModAct = New System.Windows.Forms.Panel()
        Me.pnlActivate = New System.Windows.Forms.Panel()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dateActivate = New System.Windows.Forms.DateTimePicker()
        Me.chkActivated = New System.Windows.Forms.CheckBox()
        Me.chkModSem2 = New System.Windows.Forms.CheckBox()
        Me.chkModSem1 = New System.Windows.Forms.CheckBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lstModules = New System.Windows.Forms.ListBox()
        Me.lblModAct = New System.Windows.Forms.Label()
        Me.pnlModuleReg = New System.Windows.Forms.Panel()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lblActivationSem = New System.Windows.Forms.Label()
        Me.txtModTitle = New System.Windows.Forms.TextBox()
        Me.lblModTitle = New System.Windows.Forms.Label()
        Me.txtModCode = New System.Windows.Forms.TextBox()
        Me.lblModCode = New System.Windows.Forms.Label()
        Me.lblModuleRegMain = New System.Windows.Forms.Label()
        Me.pnlStudentReg = New System.Windows.Forms.Panel()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.dateDob = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtInit = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblStudentSur = New System.Windows.Forms.Label()
        Me.lblStudentInit = New System.Windows.Forms.Label()
        Me.lblStudentTitle = New System.Windows.Forms.Label()
        Me.lblStudentRegMain = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblActYear = New System.Windows.Forms.Label()
        Me.Functions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlModAct.SuspendLayout()
        Me.pnlActivate.SuspendLayout()
        Me.pnlModuleReg.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.pnlModAct)
        Me.GroupBox1.Controls.Add(Me.pnlModuleReg)
        Me.GroupBox1.Controls.Add(Me.pnlStudentReg)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 289)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'pnlModAct
        '
        Me.pnlModAct.Controls.Add(Me.pnlActivate)
        Me.pnlModAct.Controls.Add(Me.lstModules)
        Me.pnlModAct.Controls.Add(Me.lblModAct)
        Me.pnlModAct.Location = New System.Drawing.Point(6, 19)
        Me.pnlModAct.Name = "pnlModAct"
        Me.pnlModAct.Size = New System.Drawing.Size(514, 264)
        Me.pnlModAct.TabIndex = 15
        Me.pnlModAct.Visible = False
        '
        'pnlActivate
        '
        Me.pnlActivate.Controls.Add(Me.lblActYear)
        Me.pnlActivate.Controls.Add(Me.lblSelected)
        Me.pnlActivate.Controls.Add(Me.lblDate)
        Me.pnlActivate.Controls.Add(Me.dateActivate)
        Me.pnlActivate.Controls.Add(Me.chkActivated)
        Me.pnlActivate.Controls.Add(Me.chkModSem2)
        Me.pnlActivate.Controls.Add(Me.chkModSem1)
        Me.pnlActivate.Controls.Add(Me.lblSemester)
        Me.pnlActivate.Location = New System.Drawing.Point(110, 35)
        Me.pnlActivate.Name = "pnlActivate"
        Me.pnlActivate.Size = New System.Drawing.Size(401, 213)
        Me.pnlActivate.TabIndex = 11
        Me.pnlActivate.Visible = False
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(293, 3)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(0, 13)
        Me.lblSelected.TabIndex = 14
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(0, 36)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(88, 13)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Activation Year : "
        '
        'dateActivate
        '
        Me.dateActivate.CustomFormat = "yyyy"
        Me.dateActivate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateActivate.Location = New System.Drawing.Point(93, 33)
        Me.dateActivate.Name = "dateActivate"
        Me.dateActivate.Size = New System.Drawing.Size(90, 20)
        Me.dateActivate.TabIndex = 12
        Me.dateActivate.Visible = False
        '
        'chkActivated
        '
        Me.chkActivated.AutoSize = True
        Me.chkActivated.Location = New System.Drawing.Point(3, 5)
        Me.chkActivated.Name = "chkActivated"
        Me.chkActivated.Size = New System.Drawing.Size(71, 17)
        Me.chkActivated.TabIndex = 2
        Me.chkActivated.Text = "Activated"
        Me.chkActivated.UseVisualStyleBackColor = True
        '
        'chkModSem2
        '
        Me.chkModSem2.AutoSize = True
        Me.chkModSem2.Location = New System.Drawing.Point(66, 86)
        Me.chkModSem2.Name = "chkModSem2"
        Me.chkModSem2.Size = New System.Drawing.Size(91, 17)
        Me.chkModSem2.TabIndex = 10
        Me.chkModSem2.Text = "2nd Semester"
        Me.chkModSem2.UseVisualStyleBackColor = True
        '
        'chkModSem1
        '
        Me.chkModSem1.AutoSize = True
        Me.chkModSem1.Location = New System.Drawing.Point(66, 63)
        Me.chkModSem1.Name = "chkModSem1"
        Me.chkModSem1.Size = New System.Drawing.Size(87, 17)
        Me.chkModSem1.TabIndex = 9
        Me.chkModSem1.Text = "1st Semester"
        Me.chkModSem1.UseVisualStyleBackColor = True
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(0, 64)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(60, 13)
        Me.lblSemester.TabIndex = 8
        Me.lblSemester.Text = "Semester : "
        '
        'lstModules
        '
        Me.lstModules.FormattingEnabled = True
        Me.lstModules.Location = New System.Drawing.Point(7, 35)
        Me.lstModules.Name = "lstModules"
        Me.lstModules.Size = New System.Drawing.Size(97, 212)
        Me.lstModules.TabIndex = 1
        '
        'lblModAct
        '
        Me.lblModAct.AutoSize = True
        Me.lblModAct.Location = New System.Drawing.Point(4, 10)
        Me.lblModAct.Name = "lblModAct"
        Me.lblModAct.Size = New System.Drawing.Size(103, 13)
        Me.lblModAct.TabIndex = 0
        Me.lblModAct.Text = "Module Activations :"
        '
        'pnlModuleReg
        '
        Me.pnlModuleReg.Controls.Add(Me.chk2)
        Me.pnlModuleReg.Controls.Add(Me.chk1)
        Me.pnlModuleReg.Controls.Add(Me.lblActivationSem)
        Me.pnlModuleReg.Controls.Add(Me.txtModTitle)
        Me.pnlModuleReg.Controls.Add(Me.lblModTitle)
        Me.pnlModuleReg.Controls.Add(Me.txtModCode)
        Me.pnlModuleReg.Controls.Add(Me.lblModCode)
        Me.pnlModuleReg.Controls.Add(Me.lblModuleRegMain)
        Me.pnlModuleReg.Location = New System.Drawing.Point(6, 19)
        Me.pnlModuleReg.Name = "pnlModuleReg"
        Me.pnlModuleReg.Size = New System.Drawing.Size(514, 264)
        Me.pnlModuleReg.TabIndex = 14
        Me.pnlModuleReg.Visible = False
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(127, 138)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(91, 17)
        Me.chk2.TabIndex = 7
        Me.chk2.Text = "2nd Semester"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(127, 112)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(87, 17)
        Me.chk1.TabIndex = 6
        Me.chk1.Text = "1st Semester"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'lblActivationSem
        '
        Me.lblActivationSem.AutoSize = True
        Me.lblActivationSem.Location = New System.Drawing.Point(10, 112)
        Me.lblActivationSem.Name = "lblActivationSem"
        Me.lblActivationSem.Size = New System.Drawing.Size(110, 13)
        Me.lblActivationSem.TabIndex = 5
        Me.lblActivationSem.Text = "Activation Semester : "
        '
        'txtModTitle
        '
        Me.txtModTitle.Location = New System.Drawing.Point(88, 68)
        Me.txtModTitle.Name = "txtModTitle"
        Me.txtModTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtModTitle.TabIndex = 4
        '
        'lblModTitle
        '
        Me.lblModTitle.AutoSize = True
        Me.lblModTitle.Location = New System.Drawing.Point(7, 71)
        Me.lblModTitle.Name = "lblModTitle"
        Me.lblModTitle.Size = New System.Drawing.Size(74, 13)
        Me.lblModTitle.TabIndex = 3
        Me.lblModTitle.Text = "Module Title : "
        '
        'txtModCode
        '
        Me.txtModCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModCode.Location = New System.Drawing.Point(88, 35)
        Me.txtModCode.Name = "txtModCode"
        Me.txtModCode.Size = New System.Drawing.Size(100, 20)
        Me.txtModCode.TabIndex = 2
        '
        'lblModCode
        '
        Me.lblModCode.AutoSize = True
        Me.lblModCode.Location = New System.Drawing.Point(7, 38)
        Me.lblModCode.Name = "lblModCode"
        Me.lblModCode.Size = New System.Drawing.Size(79, 13)
        Me.lblModCode.TabIndex = 1
        Me.lblModCode.Text = "Module Code : "
        '
        'lblModuleRegMain
        '
        Me.lblModuleRegMain.AutoSize = True
        Me.lblModuleRegMain.Location = New System.Drawing.Point(4, 10)
        Me.lblModuleRegMain.Name = "lblModuleRegMain"
        Me.lblModuleRegMain.Size = New System.Drawing.Size(83, 13)
        Me.lblModuleRegMain.TabIndex = 0
        Me.lblModuleRegMain.Text = "Module Details :"
        '
        'pnlStudentReg
        '
        Me.pnlStudentReg.Controls.Add(Me.radioFemale)
        Me.pnlStudentReg.Controls.Add(Me.radioMale)
        Me.pnlStudentReg.Controls.Add(Me.dateDob)
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
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Location = New System.Drawing.Point(119, 149)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(59, 17)
        Me.radioFemale.TabIndex = 13
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Location = New System.Drawing.Point(65, 149)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(48, 17)
        Me.radioMale.TabIndex = 12
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'dateDob
        '
        Me.dateDob.CustomFormat = "mm/dd/yyyy"
        Me.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDob.Location = New System.Drawing.Point(88, 112)
        Me.dateDob.Name = "dateDob"
        Me.dateDob.Size = New System.Drawing.Size(90, 20)
        Me.dateDob.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(65, 71)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(414, 20)
        Me.txtAddress.TabIndex = 10
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(323, 35)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(156, 20)
        Me.txtSurname.TabIndex = 9
        '
        'txtInit
        '
        Me.txtInit.Location = New System.Drawing.Point(159, 35)
        Me.txtInit.Name = "txtInit"
        Me.txtInit.Size = New System.Drawing.Size(96, 20)
        Me.txtInit.TabIndex = 8
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(43, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(61, 20)
        Me.txtTitle.TabIndex = 7
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(7, 149)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(48, 13)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender :"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(7, 112)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(75, 13)
        Me.lblDob.TabIndex = 5
        Me.lblDob.Text = "Date of Birth : "
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
        'lblStudentSur
        '
        Me.lblStudentSur.AutoSize = True
        Me.lblStudentSur.Location = New System.Drawing.Point(261, 38)
        Me.lblStudentSur.Name = "lblStudentSur"
        Me.lblStudentSur.Size = New System.Drawing.Size(55, 13)
        Me.lblStudentSur.TabIndex = 3
        Me.lblStudentSur.Text = "Surname :"
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
        'lblStudentTitle
        '
        Me.lblStudentTitle.AutoSize = True
        Me.lblStudentTitle.Location = New System.Drawing.Point(4, 38)
        Me.lblStudentTitle.Name = "lblStudentTitle"
        Me.lblStudentTitle.Size = New System.Drawing.Size(33, 13)
        Me.lblStudentTitle.TabIndex = 1
        Me.lblStudentTitle.Text = "Title :"
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
        'lblActYear
        '
        Me.lblActYear.AutoSize = True
        Me.lblActYear.Location = New System.Drawing.Point(95, 36)
        Me.lblActYear.Name = "lblActYear"
        Me.lblActYear.Size = New System.Drawing.Size(0, 13)
        Me.lblActYear.TabIndex = 15
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
        Me.pnlModAct.ResumeLayout(False)
        Me.pnlModAct.PerformLayout()
        Me.pnlActivate.ResumeLayout(False)
        Me.pnlActivate.PerformLayout()
        Me.pnlModuleReg.ResumeLayout(False)
        Me.pnlModuleReg.PerformLayout()
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
    Friend WithEvents dateDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents radioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radioMale As System.Windows.Forms.RadioButton
    Friend WithEvents pnlModuleReg As System.Windows.Forms.Panel
    Friend WithEvents lblModuleRegMain As System.Windows.Forms.Label
    Friend WithEvents lblModCode As System.Windows.Forms.Label
    Friend WithEvents txtModCode As System.Windows.Forms.TextBox
    Friend WithEvents lblModTitle As System.Windows.Forms.Label
    Friend WithEvents txtModTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblActivationSem As System.Windows.Forms.Label
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents pnlModAct As System.Windows.Forms.Panel
    Friend WithEvents lblModAct As System.Windows.Forms.Label
    Friend WithEvents lstModules As System.Windows.Forms.ListBox
    Friend WithEvents chkActivated As System.Windows.Forms.CheckBox
    Friend WithEvents chkModSem2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkModSem1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents pnlActivate As System.Windows.Forms.Panel
    Friend WithEvents dateActivate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblActYear As System.Windows.Forms.Label

End Class
