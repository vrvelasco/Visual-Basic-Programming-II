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
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnMagazine = New System.Windows.Forms.Button()
        Me.lblRead = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMagRead = New System.Windows.Forms.CheckBox()
        Me.chkBookRead = New System.Windows.Forms.CheckBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(293, 49)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(97, 19)
        Me.btnBook.TabIndex = 31
        Me.btnBook.Text = "Show Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Location = New System.Drawing.Point(66, 29)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(143, 19)
        Me.lblTitle.TabIndex = 13
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(32, 30)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(30, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Title:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 48)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Published:"
        '
        'lblYear
        '
        Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYear.Location = New System.Drawing.Point(66, 48)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(75, 19)
        Me.lblYear.TabIndex = 15
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(8, 95)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(53, 13)
        Me.label10.TabIndex = 20
        Me.label10.Text = "Summary:"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(66, 94)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(148, 126)
        Me.lblOutput.TabIndex = 21
        '
        'btnMagazine
        '
        Me.btnMagazine.Location = New System.Drawing.Point(293, 71)
        Me.btnMagazine.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMagazine.Name = "btnMagazine"
        Me.btnMagazine.Size = New System.Drawing.Size(97, 19)
        Me.btnMagazine.TabIndex = 32
        Me.btnMagazine.Text = "Show Magazine"
        Me.btnMagazine.UseVisualStyleBackColor = True
        '
        'lblRead
        '
        Me.lblRead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRead.Location = New System.Drawing.Point(66, 67)
        Me.lblRead.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRead.Name = "lblRead"
        Me.lblRead.Size = New System.Drawing.Size(75, 19)
        Me.lblRead.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(27, 67)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Read:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblTitle)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.lblRead)
        Me.groupBox1.Controls.Add(Me.lblYear)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.lblOutput)
        Me.groupBox1.Location = New System.Drawing.Point(37, 40)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(227, 235)
        Me.groupBox1.TabIndex = 35
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Publication"
        '
        'chkMagRead
        '
        Me.chkMagRead.AutoSize = True
        Me.chkMagRead.Location = New System.Drawing.Point(411, 71)
        Me.chkMagRead.Margin = New System.Windows.Forms.Padding(2)
        Me.chkMagRead.Name = "chkMagRead"
        Me.chkMagRead.Size = New System.Drawing.Size(58, 17)
        Me.chkMagRead.TabIndex = 34
        Me.chkMagRead.Text = "Read?"
        Me.chkMagRead.UseVisualStyleBackColor = True
        '
        'chkBookRead
        '
        Me.chkBookRead.AutoSize = True
        Me.chkBookRead.Location = New System.Drawing.Point(411, 49)
        Me.chkBookRead.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBookRead.Name = "chkBookRead"
        Me.chkBookRead.Size = New System.Drawing.Size(58, 17)
        Me.chkBookRead.TabIndex = 33
        Me.chkBookRead.Text = "Read?"
        Me.chkBookRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 289)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnMagazine)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.chkMagRead)
        Me.Controls.Add(Me.chkBookRead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Publications"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnBook As Button
    Private WithEvents lblTitle As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents lblYear As Label
    Private WithEvents label10 As Label
    Private WithEvents lblOutput As Label
    Private WithEvents btnMagazine As Button
    Private WithEvents lblRead As Label
    Private WithEvents label3 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents chkMagRead As CheckBox
    Private WithEvents chkBookRead As CheckBox
End Class
