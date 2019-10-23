<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblEarnings = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lblEmpAttrib2 = New System.Windows.Forms.Label()
        Me.lblEmpAttrib1 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.grpEmp = New System.Windows.Forms.GroupBox()
        Me.lblBaseSalary = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.radBasePlusEmployee = New System.Windows.Forms.RadioButton()
        Me.radCommission = New System.Windows.Forms.RadioButton()
        Me.grpEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Location = New System.Drawing.Point(155, 37)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(205, 24)
        Me.lblFirstName.TabIndex = 2
        '
        'lblEarnings
        '
        Me.lblEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEarnings.Location = New System.Drawing.Point(155, 340)
        Me.lblEarnings.Name = "lblEarnings"
        Me.lblEarnings.Size = New System.Drawing.Size(205, 24)
        Me.lblEarnings.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(69, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "First Name:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(27, 340)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(68, 17)
        Me.label11.TabIndex = 11
        Me.label11.Text = "Earnings:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(69, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 17)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Last Name:"
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Location = New System.Drawing.Point(155, 74)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(205, 24)
        Me.lblLastName.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(60, 110)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 17)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Gross Sales:"
        '
        'lblEmpAttrib2
        '
        Me.lblEmpAttrib2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpAttrib2.Location = New System.Drawing.Point(155, 145)
        Me.lblEmpAttrib2.Name = "lblEmpAttrib2"
        Me.lblEmpAttrib2.Size = New System.Drawing.Size(205, 24)
        Me.lblEmpAttrib2.TabIndex = 8
        '
        'lblEmpAttrib1
        '
        Me.lblEmpAttrib1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpAttrib1.Location = New System.Drawing.Point(155, 110)
        Me.lblEmpAttrib1.Name = "lblEmpAttrib1"
        Me.lblEmpAttrib1.Size = New System.Drawing.Size(205, 24)
        Me.lblEmpAttrib1.TabIndex = 6
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(28, 145)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(121, 17)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Commission Rate:"
        '
        'grpEmp
        '
        Me.grpEmp.Controls.Add(Me.lblBaseSalary)
        Me.grpEmp.Controls.Add(Me.label4)
        Me.grpEmp.Controls.Add(Me.lblOutput)
        Me.grpEmp.Controls.Add(Me.lblFirstName)
        Me.grpEmp.Controls.Add(Me.lblEarnings)
        Me.grpEmp.Controls.Add(Me.label1)
        Me.grpEmp.Controls.Add(Me.label11)
        Me.grpEmp.Controls.Add(Me.label3)
        Me.grpEmp.Controls.Add(Me.lblLastName)
        Me.grpEmp.Controls.Add(Me.label5)
        Me.grpEmp.Controls.Add(Me.lblEmpAttrib2)
        Me.grpEmp.Controls.Add(Me.lblEmpAttrib1)
        Me.grpEmp.Controls.Add(Me.label7)
        Me.grpEmp.Location = New System.Drawing.Point(59, 73)
        Me.grpEmp.Name = "grpEmp"
        Me.grpEmp.Size = New System.Drawing.Size(392, 380)
        Me.grpEmp.TabIndex = 26
        Me.grpEmp.TabStop = False
        Me.grpEmp.Text = "Employee"
        '
        'lblBaseSalary
        '
        Me.lblBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBaseSalary.Location = New System.Drawing.Point(155, 186)
        Me.lblBaseSalary.Name = "lblBaseSalary"
        Me.lblBaseSalary.Size = New System.Drawing.Size(205, 24)
        Me.lblBaseSalary.TabIndex = 15
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(61, 186)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 17)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Base Salary:"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(23, 223)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(337, 99)
        Me.lblOutput.TabIndex = 13
        '
        'radBasePlusEmployee
        '
        Me.radBasePlusEmployee.AutoSize = True
        Me.radBasePlusEmployee.Location = New System.Drawing.Point(214, 23)
        Me.radBasePlusEmployee.Name = "radBasePlusEmployee"
        Me.radBasePlusEmployee.Size = New System.Drawing.Size(237, 21)
        Me.radBasePlusEmployee.TabIndex = 28
        Me.radBasePlusEmployee.TabStop = True
        Me.radBasePlusEmployee.Text = "Base Plus Commission Employee"
        Me.radBasePlusEmployee.UseVisualStyleBackColor = True
        '
        'radCommission
        '
        Me.radCommission.AutoSize = True
        Me.radCommission.Checked = True
        Me.radCommission.Location = New System.Drawing.Point(38, 23)
        Me.radCommission.Name = "radCommission"
        Me.radCommission.Size = New System.Drawing.Size(170, 21)
        Me.radCommission.TabIndex = 27
        Me.radCommission.TabStop = True
        Me.radCommission.Text = "Commission Employee"
        Me.radCommission.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 488)
        Me.Controls.Add(Me.grpEmp)
        Me.Controls.Add(Me.radBasePlusEmployee)
        Me.Controls.Add(Me.radCommission)
        Me.Name = "Form1"
        Me.Text = "Employee Payroll App"
        Me.grpEmp.ResumeLayout(False)
        Me.grpEmp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblFirstName As Label
    Private WithEvents lblEarnings As Label
    Private WithEvents label1 As Label
    Private WithEvents label11 As Label
    Private WithEvents label3 As Label
    Private WithEvents lblLastName As Label
    Private WithEvents label5 As Label
    Private WithEvents lblEmpAttrib2 As Label
    Private WithEvents lblEmpAttrib1 As Label
    Private WithEvents label7 As Label
    Private WithEvents grpEmp As GroupBox
    Private WithEvents lblBaseSalary As Label
    Private WithEvents label4 As Label
    Private WithEvents lblOutput As Label
    Private WithEvents radBasePlusEmployee As RadioButton
    Private WithEvents radCommission As RadioButton
End Class
