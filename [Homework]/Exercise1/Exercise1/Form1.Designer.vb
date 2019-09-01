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
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnNegative = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCSize = New System.Windows.Forms.Label()
        Me.lblSSize = New System.Windows.Forms.Label()
        Me.lblTSize = New System.Windows.Forms.Label()
        Me.lblTVolume = New System.Windows.Forms.Label()
        Me.lblSVolume = New System.Windows.Forms.Label()
        Me.lblCVolume = New System.Windows.Forms.Label()
        Me.lblTArea = New System.Windows.Forms.Label()
        Me.lblSArea = New System.Windows.Forms.Label()
        Me.lblCArea = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Location = New System.Drawing.Point(384, 38)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(75, 23)
        Me.btnEnlarge.TabIndex = 0
        Me.btnEnlarge.Text = "Enlarge 10%"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnNegative
        '
        Me.btnNegative.Location = New System.Drawing.Point(384, 67)
        Me.btnNegative.Name = "btnNegative"
        Me.btnNegative.Size = New System.Drawing.Size(75, 50)
        Me.btnNegative.TabIndex = 1
        Me.btnNegative.Text = "Try a negative size"
        Me.btnNegative.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cube:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sphere:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tetra:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCSize
        '
        Me.lblCSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCSize.Location = New System.Drawing.Point(66, 38)
        Me.lblCSize.Name = "lblCSize"
        Me.lblCSize.Size = New System.Drawing.Size(100, 23)
        Me.lblCSize.TabIndex = 5
        Me.lblCSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSSize
        '
        Me.lblSSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSSize.Location = New System.Drawing.Point(66, 66)
        Me.lblSSize.Name = "lblSSize"
        Me.lblSSize.Size = New System.Drawing.Size(100, 23)
        Me.lblSSize.TabIndex = 6
        Me.lblSSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTSize
        '
        Me.lblTSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTSize.Location = New System.Drawing.Point(66, 94)
        Me.lblTSize.Name = "lblTSize"
        Me.lblTSize.Size = New System.Drawing.Size(100, 23)
        Me.lblTSize.TabIndex = 7
        Me.lblTSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTVolume
        '
        Me.lblTVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTVolume.Location = New System.Drawing.Point(172, 94)
        Me.lblTVolume.Name = "lblTVolume"
        Me.lblTVolume.Size = New System.Drawing.Size(100, 23)
        Me.lblTVolume.TabIndex = 10
        Me.lblTVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSVolume
        '
        Me.lblSVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSVolume.Location = New System.Drawing.Point(172, 66)
        Me.lblSVolume.Name = "lblSVolume"
        Me.lblSVolume.Size = New System.Drawing.Size(100, 23)
        Me.lblSVolume.TabIndex = 9
        Me.lblSVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCVolume
        '
        Me.lblCVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCVolume.Location = New System.Drawing.Point(172, 38)
        Me.lblCVolume.Name = "lblCVolume"
        Me.lblCVolume.Size = New System.Drawing.Size(100, 23)
        Me.lblCVolume.TabIndex = 8
        Me.lblCVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTArea
        '
        Me.lblTArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTArea.Location = New System.Drawing.Point(278, 94)
        Me.lblTArea.Name = "lblTArea"
        Me.lblTArea.Size = New System.Drawing.Size(100, 23)
        Me.lblTArea.TabIndex = 13
        Me.lblTArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSArea
        '
        Me.lblSArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSArea.Location = New System.Drawing.Point(278, 66)
        Me.lblSArea.Name = "lblSArea"
        Me.lblSArea.Size = New System.Drawing.Size(100, 23)
        Me.lblSArea.TabIndex = 12
        Me.lblSArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCArea
        '
        Me.lblCArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCArea.Location = New System.Drawing.Point(278, 38)
        Me.lblCArea.Name = "lblCArea"
        Me.lblCArea.Size = New System.Drawing.Size(100, 23)
        Me.lblCArea.TabIndex = 11
        Me.lblCArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(66, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(172, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Volume"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(278, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Surface Area"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 131)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTArea)
        Me.Controls.Add(Me.lblSArea)
        Me.Controls.Add(Me.lblCArea)
        Me.Controls.Add(Me.lblTVolume)
        Me.Controls.Add(Me.lblSVolume)
        Me.Controls.Add(Me.lblCVolume)
        Me.Controls.Add(Me.lblTSize)
        Me.Controls.Add(Me.lblSSize)
        Me.Controls.Add(Me.lblCSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNegative)
        Me.Controls.Add(Me.btnEnlarge)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Exercise 1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnlarge As Button
    Friend WithEvents btnNegative As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCSize As Label
    Friend WithEvents lblSSize As Label
    Friend WithEvents lblTSize As Label
    Friend WithEvents lblTVolume As Label
    Friend WithEvents lblSVolume As Label
    Friend WithEvents lblCVolume As Label
    Friend WithEvents lblTArea As Label
    Friend WithEvents lblSArea As Label
    Friend WithEvents lblCArea As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
