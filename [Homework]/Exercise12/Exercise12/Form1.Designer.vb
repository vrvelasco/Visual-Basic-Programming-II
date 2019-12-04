<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DeptcodeLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeptcodeTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DeptcodeLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeptcodeLabel
        '
        DeptcodeLabel.AutoSize = True
        DeptcodeLabel.Location = New System.Drawing.Point(6, 131)
        DeptcodeLabel.Name = "DeptcodeLabel"
        DeptcodeLabel.Size = New System.Drawing.Size(65, 13)
        DeptcodeLabel.TabIndex = 12
        DeptcodeLabel.Text = "Department:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(6, 79)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(60, 13)
        FirstnameLabel.TabIndex = 14
        FirstnameLabel.Text = "First Name:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Location = New System.Drawing.Point(6, 105)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(61, 13)
        LastnameLabel.TabIndex = 22
        LastnameLabel.Text = "Last Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(6, 157)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 24
        PhoneLabel.Text = "Phone:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(6, 53)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 18
        IdLabel.Text = "ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(DeptcodeLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.EmployeeBindingNavigator)
        Me.GroupBox1.Controls.Add(Me.DeptcodeTextBox)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(LastnameLabel)
        Me.GroupBox1.Controls.Add(FirstnameLabel)
        Me.GroupBox1.Controls.Add(Me.LastnameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(72, 154)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PhoneTextBox.TabIndex = 25
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(227, 25)
        Me.EmployeeBindingNavigator.TabIndex = 2
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Enabled = False
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeptcodeTextBox
        '
        Me.DeptcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "deptcode", True))
        Me.DeptcodeTextBox.Location = New System.Drawing.Point(72, 128)
        Me.DeptcodeTextBox.Name = "DeptcodeTextBox"
        Me.DeptcodeTextBox.Size = New System.Drawing.Size(155, 20)
        Me.DeptcodeTextBox.TabIndex = 13
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "lastname", True))
        Me.LastnameTextBox.Location = New System.Drawing.Point(72, 102)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.LastnameTextBox.TabIndex = 23
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(72, 76)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.FirstnameTextBox.TabIndex = 15
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(72, 50)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(155, 20)
        Me.IdTextBox.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblResults)
        Me.GroupBox2.Controls.Add(Me.lstResults)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboDepart)
        Me.GroupBox2.Location = New System.Drawing.Point(251, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 186)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'lblResults
        '
        Me.lblResults.Location = New System.Drawing.Point(6, 160)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(156, 14)
        Me.lblResults.TabIndex = 3
        Me.lblResults.Text = "15 employees"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(6, 43)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(156, 108)
        Me.lstResults.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Depart Code:"
        '
        'cboDepart
        '
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(82, 13)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(80, 21)
        Me.cboDepart.TabIndex = 0
        Me.cboDepart.Text = "AC"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnView)
        Me.GroupBox3.Controls.Add(Me.txtEnd)
        Me.GroupBox3.Controls.Add(Me.txtStart)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dgvResults)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 198)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(326, 11)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(255, 13)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(65, 20)
        Me.txtEnd.TabIndex = 4
        Me.txtEnd.Text = "1/1/2000"
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(153, 13)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(65, 20)
        Me.txtStart.TabIndex = 3
        Me.txtStart.Text = "1/1/1990"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "and"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee hire date between"
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(6, 40)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(395, 151)
        Me.dgvResults.TabIndex = 0
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataSource = GetType(Exercise12.Employee)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmployeeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DeptcodeTextBox As TextBox
    Friend WithEvents LastnameTextBox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblResults As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents txtStart As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvResults As DataGridView
End Class
