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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdateEmp2 = New System.Windows.Forms.Button()
        Me.btnUpdateEmp1 = New System.Windows.Forms.Button()
        Me.lblBOutput = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBFirstName = New System.Windows.Forms.Label()
        Me.lblBEarnings = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblBLastName = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.lblBRate = New System.Windows.Forms.Label()
        Me.lblBGrossSales = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.lblCOutput = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCFirstName = New System.Windows.Forms.Label()
        Me.lblCEarnings = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblCLastName = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lblCRate = New System.Windows.Forms.Label()
        Me.lblCGrossSales = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(31, 418)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(444, 30)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdateEmp2
        '
        Me.btnUpdateEmp2.Location = New System.Drawing.Point(270, 367)
        Me.btnUpdateEmp2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdateEmp2.Name = "btnUpdateEmp2"
        Me.btnUpdateEmp2.Size = New System.Drawing.Size(205, 46)
        Me.btnUpdateEmp2.TabIndex = 21
        Me.btnUpdateEmp2.Text = "Change Emp 2 base salary to $1000"
        Me.btnUpdateEmp2.UseVisualStyleBackColor = True
        '
        'btnUpdateEmp1
        '
        Me.btnUpdateEmp1.Location = New System.Drawing.Point(31, 367)
        Me.btnUpdateEmp1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdateEmp1.Name = "btnUpdateEmp1"
        Me.btnUpdateEmp1.Size = New System.Drawing.Size(205, 46)
        Me.btnUpdateEmp1.TabIndex = 20
        Me.btnUpdateEmp1.Text = "Change Emp 1 gross sales to $5000 and commission rate to 10%"
        Me.btnUpdateEmp1.UseVisualStyleBackColor = True
        '
        'lblBOutput
        '
        Me.lblBOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBOutput.Location = New System.Drawing.Point(10, 185)
        Me.lblBOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBOutput.Name = "lblBOutput"
        Me.lblBOutput.Size = New System.Drawing.Size(195, 102)
        Me.lblBOutput.TabIndex = 13
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lblBOutput)
        Me.groupBox2.Controls.Add(Me.lblBFirstName)
        Me.groupBox2.Controls.Add(Me.lblBEarnings)
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.label15)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.lblBase)
        Me.groupBox2.Controls.Add(Me.lblBLastName)
        Me.groupBox2.Controls.Add(Me.label19)
        Me.groupBox2.Controls.Add(Me.label20)
        Me.groupBox2.Controls.Add(Me.lblBRate)
        Me.groupBox2.Controls.Add(Me.lblBGrossSales)
        Me.groupBox2.Controls.Add(Me.label23)
        Me.groupBox2.Location = New System.Drawing.Point(270, 18)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox2.Size = New System.Drawing.Size(209, 331)
        Me.groupBox2.TabIndex = 19
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Employee #2 - Base Plus Commission"
        '
        'lblBFirstName
        '
        Me.lblBFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBFirstName.Location = New System.Drawing.Point(104, 34)
        Me.lblBFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBFirstName.Name = "lblBFirstName"
        Me.lblBFirstName.Size = New System.Drawing.Size(101, 20)
        Me.lblBFirstName.TabIndex = 2
        '
        'lblBEarnings
        '
        Me.lblBEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBEarnings.Location = New System.Drawing.Point(104, 301)
        Me.lblBEarnings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBEarnings.Name = "lblBEarnings"
        Me.lblBEarnings.Size = New System.Drawing.Size(101, 20)
        Me.lblBEarnings.TabIndex = 12
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(8, 34)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(60, 13)
        Me.label14.TabIndex = 1
        Me.label14.Text = "First Name:"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(8, 301)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(51, 13)
        Me.label15.TabIndex = 11
        Me.label15.Text = "Earnings:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(8, 64)
        Me.label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(61, 13)
        Me.label16.TabIndex = 3
        Me.label16.Text = "Last Name:"
        '
        'lblBase
        '
        Me.lblBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBase.Location = New System.Drawing.Point(104, 151)
        Me.lblBase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(101, 20)
        Me.lblBase.TabIndex = 10
        '
        'lblBLastName
        '
        Me.lblBLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBLastName.Location = New System.Drawing.Point(104, 64)
        Me.lblBLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBLastName.Name = "lblBLastName"
        Me.lblBLastName.Size = New System.Drawing.Size(101, 20)
        Me.lblBLastName.TabIndex = 4
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(8, 151)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(66, 13)
        Me.label19.TabIndex = 9
        Me.label19.Text = "Base Salary:"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(8, 93)
        Me.label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(66, 13)
        Me.label20.TabIndex = 5
        Me.label20.Text = "Gross Sales:"
        '
        'lblBRate
        '
        Me.lblBRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRate.Location = New System.Drawing.Point(104, 122)
        Me.lblBRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBRate.Name = "lblBRate"
        Me.lblBRate.Size = New System.Drawing.Size(101, 20)
        Me.lblBRate.TabIndex = 8
        '
        'lblBGrossSales
        '
        Me.lblBGrossSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBGrossSales.Location = New System.Drawing.Point(104, 93)
        Me.lblBGrossSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBGrossSales.Name = "lblBGrossSales"
        Me.lblBGrossSales.Size = New System.Drawing.Size(101, 20)
        Me.lblBGrossSales.TabIndex = 6
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(8, 122)
        Me.label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(91, 13)
        Me.label23.TabIndex = 7
        Me.label23.Text = "Commission Rate:"
        '
        'lblCOutput
        '
        Me.lblCOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCOutput.Location = New System.Drawing.Point(4, 185)
        Me.lblCOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCOutput.Name = "lblCOutput"
        Me.lblCOutput.Size = New System.Drawing.Size(195, 102)
        Me.lblCOutput.TabIndex = 13
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblCOutput)
        Me.groupBox1.Controls.Add(Me.lblCFirstName)
        Me.groupBox1.Controls.Add(Me.lblCEarnings)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.lblCLastName)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.lblCRate)
        Me.groupBox1.Controls.Add(Me.lblCGrossSales)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Location = New System.Drawing.Point(31, 18)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox1.Size = New System.Drawing.Size(209, 331)
        Me.groupBox1.TabIndex = 18
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Employee #1 - Commission Employee"
        '
        'lblCFirstName
        '
        Me.lblCFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCFirstName.Location = New System.Drawing.Point(104, 34)
        Me.lblCFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCFirstName.Name = "lblCFirstName"
        Me.lblCFirstName.Size = New System.Drawing.Size(101, 20)
        Me.lblCFirstName.TabIndex = 2
        '
        'lblCEarnings
        '
        Me.lblCEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCEarnings.Location = New System.Drawing.Point(98, 301)
        Me.lblCEarnings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCEarnings.Name = "lblCEarnings"
        Me.lblCEarnings.Size = New System.Drawing.Size(101, 20)
        Me.lblCEarnings.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 34)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "First Name:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(2, 301)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(51, 13)
        Me.label11.TabIndex = 11
        Me.label11.Text = "Earnings:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 64)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Last Name:"
        '
        'lblCLastName
        '
        Me.lblCLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCLastName.Location = New System.Drawing.Point(104, 64)
        Me.lblCLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCLastName.Name = "lblCLastName"
        Me.lblCLastName.Size = New System.Drawing.Size(101, 20)
        Me.lblCLastName.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(8, 93)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(66, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Gross Sales:"
        '
        'lblCRate
        '
        Me.lblCRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCRate.Location = New System.Drawing.Point(104, 122)
        Me.lblCRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCRate.Name = "lblCRate"
        Me.lblCRate.Size = New System.Drawing.Size(101, 20)
        Me.lblCRate.TabIndex = 8
        '
        'lblCGrossSales
        '
        Me.lblCGrossSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCGrossSales.Location = New System.Drawing.Point(104, 93)
        Me.lblCGrossSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCGrossSales.Name = "lblCGrossSales"
        Me.lblCGrossSales.Size = New System.Drawing.Size(101, 20)
        Me.lblCGrossSales.TabIndex = 6
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(8, 122)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(91, 13)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Commission Rate:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 461)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpdateEmp2)
        Me.Controls.Add(Me.btnUpdateEmp1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Employee Payroll App"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnReset As Button
    Private WithEvents btnUpdateEmp2 As Button
    Private WithEvents btnUpdateEmp1 As Button
    Private WithEvents lblBOutput As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents lblBFirstName As Label
    Private WithEvents lblBEarnings As Label
    Private WithEvents label14 As Label
    Private WithEvents label15 As Label
    Private WithEvents label16 As Label
    Private WithEvents lblBase As Label
    Private WithEvents lblBLastName As Label
    Private WithEvents label19 As Label
    Private WithEvents label20 As Label
    Private WithEvents lblBRate As Label
    Private WithEvents lblBGrossSales As Label
    Private WithEvents label23 As Label
    Private WithEvents lblCOutput As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblCFirstName As Label
    Private WithEvents lblCEarnings As Label
    Private WithEvents label1 As Label
    Private WithEvents label11 As Label
    Private WithEvents label3 As Label
    Private WithEvents lblCLastName As Label
    Private WithEvents label5 As Label
    Private WithEvents lblCRate As Label
    Private WithEvents lblCGrossSales As Label
    Private WithEvents label7 As Label
End Class
