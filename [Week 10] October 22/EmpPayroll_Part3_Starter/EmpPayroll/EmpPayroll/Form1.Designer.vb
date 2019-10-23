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
        Me.lstEmps = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstEmps
        '
        Me.lstEmps.FormattingEnabled = True
        Me.lstEmps.ItemHeight = 16
        Me.lstEmps.Location = New System.Drawing.Point(29, 45)
        Me.lstEmps.Name = "lstEmps"
        Me.lstEmps.Size = New System.Drawing.Size(1120, 404)
        Me.lstEmps.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 488)
        Me.Controls.Add(Me.lstEmps)
        Me.Name = "Form1"
        Me.Text = "Employee Payroll App"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lstEmps As ListBox
End Class
