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
        Me.SuspendLayout()
        '
        'btnStudentReg
        '
        Me.btnStudentReg.Location = New System.Drawing.Point(35, 40)
        Me.btnStudentReg.Name = "btnStudentReg"
        Me.btnStudentReg.Size = New System.Drawing.Size(119, 55)
        Me.btnStudentReg.TabIndex = 0
        Me.btnStudentReg.Text = "Student Registrations"
        Me.btnStudentReg.UseVisualStyleBackColor = True
        '
        'btnModuleReg
        '
        Me.btnModuleReg.Location = New System.Drawing.Point(35, 101)
        Me.btnModuleReg.Name = "btnModuleReg"
        Me.btnModuleReg.Size = New System.Drawing.Size(119, 55)
        Me.btnModuleReg.TabIndex = 1
        Me.btnModuleReg.Text = "Module Registrations"
        Me.btnModuleReg.UseVisualStyleBackColor = True
        '
        'btnModuleAct
        '
        Me.btnModuleAct.Location = New System.Drawing.Point(35, 162)
        Me.btnModuleAct.Name = "btnModuleAct"
        Me.btnModuleAct.Size = New System.Drawing.Size(119, 55)
        Me.btnModuleAct.TabIndex = 2
        Me.btnModuleAct.Text = "Module Activations"
        Me.btnModuleAct.UseVisualStyleBackColor = True
        '
        'btnStudentEnroll
        '
        Me.btnStudentEnroll.Location = New System.Drawing.Point(35, 223)
        Me.btnStudentEnroll.Name = "btnStudentEnroll"
        Me.btnStudentEnroll.Size = New System.Drawing.Size(119, 55)
        Me.btnStudentEnroll.TabIndex = 3
        Me.btnStudentEnroll.Text = "Student Enrolments"
        Me.btnStudentEnroll.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 356)
        Me.Controls.Add(Me.btnStudentEnroll)
        Me.Controls.Add(Me.btnModuleAct)
        Me.Controls.Add(Me.btnModuleReg)
        Me.Controls.Add(Me.btnStudentReg)
        Me.Name = "MainForm"
        Me.Text = "Orange University - Student System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudentReg As System.Windows.Forms.Button
    Friend WithEvents btnModuleReg As System.Windows.Forms.Button
    Friend WithEvents btnModuleAct As System.Windows.Forms.Button
    Friend WithEvents btnStudentEnroll As System.Windows.Forms.Button

End Class
