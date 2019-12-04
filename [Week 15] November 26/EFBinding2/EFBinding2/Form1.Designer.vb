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
        Dim AuthorIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AuthorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AuthorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AuthorDataGridView = New System.Windows.Forms.DataGridView()
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AuthorIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuthorBindingNavigator.SuspendLayout()
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(138, 240)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 2
        AuthorIDLabel.Text = "Author ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(138, 266)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(138, 292)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 6
        LastNameLabel.Text = "Last Name:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(142, 318)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 8
        FullNameLabel.Text = "Full Name:"
        '
        'AuthorBindingNavigator
        '
        Me.AuthorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AuthorBindingNavigator.BindingSource = Me.AuthorBindingSource
        Me.AuthorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AuthorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AuthorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuthorBindingNavigatorSaveItem})
        Me.AuthorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AuthorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AuthorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AuthorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AuthorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AuthorBindingNavigator.Name = "AuthorBindingNavigator"
        Me.AuthorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AuthorBindingNavigator.Size = New System.Drawing.Size(443, 25)
        Me.AuthorBindingNavigator.TabIndex = 0
        Me.AuthorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'AuthorBindingNavigatorSaveItem
        '
        Me.AuthorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuthorBindingNavigatorSaveItem.Enabled = False
        Me.AuthorBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuthorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AuthorBindingNavigatorSaveItem.Name = "AuthorBindingNavigatorSaveItem"
        Me.AuthorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AuthorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AuthorDataGridView
        '
        Me.AuthorDataGridView.AutoGenerateColumns = False
        Me.AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AuthorIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn})
        Me.AuthorDataGridView.DataSource = Me.AuthorBindingSource
        Me.AuthorDataGridView.Location = New System.Drawing.Point(0, 45)
        Me.AuthorDataGridView.Name = "AuthorDataGridView"
        Me.AuthorDataGridView.Size = New System.Drawing.Size(443, 155)
        Me.AuthorDataGridView.TabIndex = 1
        '
        'AuthorIDTextBox
        '
        Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox.Location = New System.Drawing.Point(205, 237)
        Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
        Me.AuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorIDTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(205, 263)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(205, 289)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 7
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(205, 315)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FullNameTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AuthorBindingSource
        '
        Me.AuthorBindingSource.DataSource = GetType(EFBinding2.Author)
        '
        'AuthorIDDataGridViewTextBoxColumn
        '
        Me.AuthorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID"
        Me.AuthorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID"
        Me.AuthorIDDataGridViewTextBoxColumn.Name = "AuthorIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(AuthorIDLabel)
        Me.Controls.Add(Me.AuthorIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.AuthorDataGridView)
        Me.Controls.Add(Me.AuthorBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AuthorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuthorBindingNavigator.ResumeLayout(False)
        Me.AuthorBindingNavigator.PerformLayout()
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuthorBindingSource As BindingSource
    Friend WithEvents AuthorBindingNavigator As BindingNavigator
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
    Friend WithEvents AuthorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AuthorDataGridView As DataGridView
    Friend WithEvents AuthorIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents AuthorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
