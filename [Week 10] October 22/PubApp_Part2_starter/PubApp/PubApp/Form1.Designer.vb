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
        Me.lstPubs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstPubs
        '
        Me.lstPubs.FormattingEnabled = True
        Me.lstPubs.ItemHeight = 16
        Me.lstPubs.Location = New System.Drawing.Point(25, 33)
        Me.lstPubs.Name = "lstPubs"
        Me.lstPubs.Size = New System.Drawing.Size(589, 324)
        Me.lstPubs.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 396)
        Me.Controls.Add(Me.lstPubs)
        Me.Name = "Form1"
        Me.Text = "Publications"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lstPubs As ListBox
End Class
