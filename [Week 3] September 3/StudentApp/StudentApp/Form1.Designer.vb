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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstFullTime = New System.Windows.Forms.ListBox()
        Me.lblFTCnt = New System.Windows.Forms.Label()
        Me.lblAvgCurFT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotCur = New System.Windows.Forms.Label()
        Me.btnAdd3All = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.bsStudents = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd3 = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstFullTime)
        Me.GroupBox2.Controls.Add(Me.lblFTCnt)
        Me.GroupBox2.Controls.Add(Me.lblAvgCurFT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 163)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(332, 129)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Full Time Students"
        '
        'lstFullTime
        '
        Me.lstFullTime.FormattingEnabled = True
        Me.lstFullTime.Location = New System.Drawing.Point(176, 21)
        Me.lstFullTime.Margin = New System.Windows.Forms.Padding(2)
        Me.lstFullTime.Name = "lstFullTime"
        Me.lstFullTime.Size = New System.Drawing.Size(144, 95)
        Me.lstFullTime.TabIndex = 13
        '
        'lblFTCnt
        '
        Me.lblFTCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFTCnt.Location = New System.Drawing.Point(120, 29)
        Me.lblFTCnt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFTCnt.Name = "lblFTCnt"
        Me.lblFTCnt.Size = New System.Drawing.Size(34, 20)
        Me.lblFTCnt.TabIndex = 16
        '
        'lblAvgCurFT
        '
        Me.lblAvgCurFT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgCurFT.Location = New System.Drawing.Point(120, 54)
        Me.lblAvgCurFT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAvgCurFT.Name = "lblAvgCurFT"
        Me.lblAvgCurFT.Size = New System.Drawing.Size(34, 20)
        Me.lblAvgCurFT.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Full-time students:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 54)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Average FT credits"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(98, 17)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 19)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(10, 49)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(2)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(145, 82)
        Me.lstResults.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.lstResults)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(166, 135)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search for Student Last Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 17)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(76, 20)
        Me.txtName.TabIndex = 22
        '
        'btnResetAll
        '
        Me.btnResetAll.Location = New System.Drawing.Point(277, 243)
        Me.btnResetAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(71, 23)
        Me.btnResetAll.TabIndex = 45
        Me.btnResetAll.Text = "Reset All"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(188, 275)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 19)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Total current credits"
        '
        'lblTotCur
        '
        Me.lblTotCur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotCur.Location = New System.Drawing.Point(303, 272)
        Me.lblTotCur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotCur.Name = "lblTotCur"
        Me.lblTotCur.Size = New System.Drawing.Size(45, 20)
        Me.lblTotCur.TabIndex = 42
        '
        'btnAdd3All
        '
        Me.btnAdd3All.Location = New System.Drawing.Point(277, 216)
        Me.btnAdd3All.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd3All.Name = "btnAdd3All"
        Me.btnAdd3All.Size = New System.Drawing.Size(71, 23)
        Me.btnAdd3All.TabIndex = 41
        Me.btnAdd3All.Text = "Add 3 All"
        Me.btnAdd3All.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(22, 25)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowTemplate.Height = 28
        Me.dgvStudents.Size = New System.Drawing.Size(502, 135)
        Me.dgvStudents.TabIndex = 40
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(120, 255)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(31, 24)
        Me.btnLast.TabIndex = 39
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(50, 255)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(31, 24)
        Me.btnPrevious.TabIndex = 37
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(15, 255)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(31, 24)
        Me.btnFirst.TabIndex = 36
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(194, 188)
        Me.btnAdd1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(79, 23)
        Me.btnAdd1.TabIndex = 35
        Me.btnAdd1.Text = "Add 1 Credit"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(194, 243)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 23)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "Reset Credits"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAdd3
        '
        Me.btnAdd3.Location = New System.Drawing.Point(194, 215)
        Me.btnAdd3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(79, 23)
        Me.btnAdd3.TabIndex = 33
        Me.btnAdd3.Text = "Add 3 Credits"
        Me.btnAdd3.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(86, 255)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 24)
        Me.btnNext.TabIndex = 38
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(97, 225)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 13)
        Me.lblTotal.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Total Credits"
        '
        'lblCurrent
        '
        Me.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrent.Location = New System.Drawing.Point(97, 202)
        Me.lblCurrent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(92, 13)
        Me.lblCurrent.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Current Credits"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(97, 177)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 13)
        Me.lblName.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Student Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 314)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnResetAll)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotCur)
        Me.Controls.Add(Me.btnAdd3All)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Student App"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstFullTime As ListBox
    Friend WithEvents lblFTCnt As Label
    Friend WithEvents lblAvgCurFT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnResetAll As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotCur As Label
    Friend WithEvents btnAdd3All As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents bsStudents As BindingSource
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAdd3 As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
End Class
