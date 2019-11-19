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
        Me.dgvTitles = New System.Windows.Forms.DataGridView()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstYears = New System.Windows.Forms.ListBox()
        CType(Me.dgvTitles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTitles
        '
        Me.dgvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTitles.Location = New System.Drawing.Point(12, 12)
        Me.dgvTitles.Name = "dgvTitles"
        Me.dgvTitles.Size = New System.Drawing.Size(543, 265)
        Me.dgvTitles.TabIndex = 0
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(6, 202)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(147, 23)
        Me.btnCopy.TabIndex = 1
        Me.btnCopy.Text = "Filter by Copyright Year"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(561, 254)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(159, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstYears)
        Me.GroupBox1.Controls.Add(Me.btnCopy)
        Me.GroupBox1.Location = New System.Drawing.Point(561, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 236)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'lstYears
        '
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.Location = New System.Drawing.Point(6, 19)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(147, 173)
        Me.lstYears.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dgvTitles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Books Database"
        CType(Me.dgvTitles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTitles As DataGridView
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstYears As ListBox
End Class
