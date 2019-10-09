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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnRaiseMargin = New System.Windows.Forms.Button()
        Me.lblMargin = New System.Windows.Forms.Label()
        Me.btnLowerMargin = New System.Windows.Forms.Button()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.bindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bsBooks = New System.Windows.Forms.BindingSource(Me.components)
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblInventoryValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblGenreInvValue = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.lblGenreCount = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.cboGenres = New System.Windows.Forms.ComboBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.groupBox3.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNavigator1.SuspendLayout()
        CType(Me.bsBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = False
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtGenre)
        Me.groupBox3.Controls.Add(Me.btnAdd)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.txtCost)
        Me.groupBox3.Controls.Add(Me.txtQuantity)
        Me.groupBox3.Controls.Add(Me.label1)
        Me.groupBox3.Controls.Add(Me.txtTitle)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(9, 197)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Size = New System.Drawing.Size(312, 154)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Add New Book"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(53, 67)
        Me.txtGenre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(241, 23)
        Me.txtGenre.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(212, 109)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 28)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(9, 67)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(41, 15)
        Me.label10.TabIndex = 71
        Me.label10.Text = "Genre"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(53, 110)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(57, 23)
        Me.txtCost.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(170, 110)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(38, 23)
        Me.txtQuantity.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(19, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 15)
        Me.label1.TabIndex = 45
        Me.label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(53, 30)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(243, 23)
        Me.txtTitle.TabIndex = 0
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(15, 109)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(34, 15)
        Me.label9.TabIndex = 65
        Me.label9.Text = "Cost:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(115, 112)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(54, 15)
        Me.label11.TabIndex = 67
        Me.label11.Text = "Quantity:"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btnRaiseMargin)
        Me.groupBox5.Controls.Add(Me.lblMargin)
        Me.groupBox5.Controls.Add(Me.btnLowerMargin)
        Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox5.Location = New System.Drawing.Point(326, 88)
        Me.groupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox5.Size = New System.Drawing.Size(236, 85)
        Me.groupBox5.TabIndex = 2
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Profit Margin"
        '
        'btnRaiseMargin
        '
        Me.btnRaiseMargin.Location = New System.Drawing.Point(20, 46)
        Me.btnRaiseMargin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRaiseMargin.Name = "btnRaiseMargin"
        Me.btnRaiseMargin.Size = New System.Drawing.Size(80, 24)
        Me.btnRaiseMargin.TabIndex = 0
        Me.btnRaiseMargin.Text = "Increase"
        Me.btnRaiseMargin.UseVisualStyleBackColor = True
        '
        'lblMargin
        '
        Me.lblMargin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMargin.Location = New System.Drawing.Point(20, 20)
        Me.lblMargin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMargin.Name = "lblMargin"
        Me.lblMargin.Size = New System.Drawing.Size(206, 22)
        Me.lblMargin.TabIndex = 92
        Me.lblMargin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLowerMargin
        '
        Me.btnLowerMargin.Location = New System.Drawing.Point(147, 46)
        Me.btnLowerMargin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLowerMargin.Name = "btnLowerMargin"
        Me.btnLowerMargin.Size = New System.Drawing.Size(80, 24)
        Me.btnLowerMargin.TabIndex = 1
        Me.btnLowerMargin.Text = "Decrease"
        Me.btnLowerMargin.UseVisualStyleBackColor = True
        '
        'lblGenre
        '
        Me.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenre.Location = New System.Drawing.Point(72, 98)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(227, 20)
        Me.lblGenre.TabIndex = 80
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.bindingNavigator1)
        Me.groupBox6.Controls.Add(Me.lblGenre)
        Me.groupBox6.Controls.Add(Me.label15)
        Me.groupBox6.Controls.Add(Me.Label2)
        Me.groupBox6.Controls.Add(Me.Label7)
        Me.groupBox6.Controls.Add(Me.lblPrice)
        Me.groupBox6.Controls.Add(Me.Label8)
        Me.groupBox6.Controls.Add(Me.lblQuantity)
        Me.groupBox6.Controls.Add(Me.lblInventoryValue)
        Me.groupBox6.Controls.Add(Me.Label3)
        Me.groupBox6.Controls.Add(Me.Label4)
        Me.groupBox6.Controls.Add(Me.lblTitle)
        Me.groupBox6.Controls.Add(Me.lblCost)
        Me.groupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox6.Location = New System.Drawing.Point(9, 10)
        Me.groupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox6.Size = New System.Drawing.Size(310, 177)
        Me.groupBox6.TabIndex = 86
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Book Details"
        '
        'bindingNavigator1
        '
        Me.bindingNavigator1.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.bindingNavigator1.BindingSource = Me.bsBooks
        Me.bindingNavigator1.CountItem = Me.bindingNavigatorCountItem
        Me.bindingNavigator1.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.bindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem})
        Me.bindingNavigator1.Location = New System.Drawing.Point(2, 18)
        Me.bindingNavigator1.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.bindingNavigator1.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.bindingNavigator1.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.bindingNavigator1.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.bindingNavigator1.Name = "bindingNavigator1"
        Me.bindingNavigator1.PositionItem = Me.bindingNavigatorPositionItem
        Me.bindingNavigator1.Size = New System.Drawing.Size(306, 27)
        Me.bindingNavigator1.TabIndex = 76
        Me.bindingNavigator1.Text = "bindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bsBooks
        '
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(17, 98)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(44, 15)
        Me.label15.TabIndex = 79
        Me.label15.Text = "Genre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Cost:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(72, 147)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(58, 20)
        Me.lblPrice.TabIndex = 70
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Price:"
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Location = New System.Drawing.Point(237, 124)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(62, 20)
        Me.lblQuantity.TabIndex = 71
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInventoryValue
        '
        Me.lblInventoryValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInventoryValue.Location = New System.Drawing.Point(237, 147)
        Me.lblInventoryValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInventoryValue.Name = "lblInventoryValue"
        Me.lblInventoryValue.Size = New System.Drawing.Size(62, 20)
        Me.lblInventoryValue.TabIndex = 74
        Me.lblInventoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Inventory Value:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Quantity:"
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Location = New System.Drawing.Point(72, 56)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 34)
        Me.lblTitle.TabIndex = 68
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost.Location = New System.Drawing.Point(72, 124)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(58, 20)
        Me.lblCost.TabIndex = 69
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.groupBox4)
        Me.GroupBox1.Controls.Add(Me.cboGenres)
        Me.GroupBox1.Controls.Add(Me.lstBooks)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 178)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(236, 227)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genres"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.lblGenreInvValue)
        Me.groupBox4.Controls.Add(Me.label12)
        Me.groupBox4.Controls.Add(Me.lblGenreCount)
        Me.groupBox4.Controls.Add(Me.label14)
        Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox4.Location = New System.Drawing.Point(13, 153)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox4.Size = New System.Drawing.Size(214, 66)
        Me.groupBox4.TabIndex = 87
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Genre Summary"
        '
        'lblGenreInvValue
        '
        Me.lblGenreInvValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenreInvValue.Location = New System.Drawing.Point(134, 41)
        Me.lblGenreInvValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenreInvValue.Name = "lblGenreInvValue"
        Me.lblGenreInvValue.Size = New System.Drawing.Size(75, 20)
        Me.lblGenreInvValue.TabIndex = 74
        Me.lblGenreInvValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(20, 20)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(110, 15)
        Me.label12.TabIndex = 66
        Me.label12.Text = "Genre Book Count:"
        '
        'lblGenreCount
        '
        Me.lblGenreCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenreCount.Location = New System.Drawing.Point(134, 15)
        Me.lblGenreCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenreCount.Name = "lblGenreCount"
        Me.lblGenreCount.Size = New System.Drawing.Size(75, 20)
        Me.lblGenreCount.TabIndex = 70
        Me.lblGenreCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(6, 46)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(129, 15)
        Me.label14.TabIndex = 73
        Me.label14.Text = "Genre Inventory Value:"
        '
        'cboGenres
        '
        Me.cboGenres.FormattingEnabled = True
        Me.cboGenres.Location = New System.Drawing.Point(17, 20)
        Me.cboGenres.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGenres.Name = "cboGenres"
        Me.cboGenres.Size = New System.Drawing.Size(210, 25)
        Me.cboGenres.TabIndex = 0
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 17
        Me.lstBooks.Location = New System.Drawing.Point(17, 47)
        Me.lstBooks.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(210, 89)
        Me.lstBooks.TabIndex = 1
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.txtSearch)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(328, 29)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Size = New System.Drawing.Size(232, 54)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Search Titles"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(5, 28)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 15)
        Me.label5.TabIndex = 45
        Me.label5.Text = "Title:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(40, 25)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 23)
        Me.txtSearch.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 414)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Book Inventory Application"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNavigator1.ResumeLayout(False)
        Me.bindingNavigator1.PerformLayout()
        CType(Me.bsBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents bindingNavigatorPositionItem As ToolStripTextBox
    Private WithEvents bindingNavigatorMoveNextItem As ToolStripButton
    Private WithEvents bindingNavigatorMoveLastItem As ToolStripButton
    Private WithEvents bindingNavigatorSeparator2 As ToolStripSeparator
    Private WithEvents groupBox3 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Private WithEvents btnAdd As Button
    Friend WithEvents label10 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents label9 As Label
    Friend WithEvents label11 As Label
    Private WithEvents bindingNavigatorSeparator1 As ToolStripSeparator
    Private WithEvents groupBox5 As GroupBox
    Friend WithEvents lblGenre As Label
    Private WithEvents groupBox6 As GroupBox
    Private WithEvents bindingNavigator1 As BindingNavigator
    Private WithEvents bindingNavigatorAddNewItem As ToolStripButton
    Private WithEvents bsBooks As BindingSource
    Private WithEvents bindingNavigatorCountItem As ToolStripLabel
    Private WithEvents bindingNavigatorDeleteItem As ToolStripButton
    Private WithEvents bindingNavigatorMoveFirstItem As ToolStripButton
    Private WithEvents bindingNavigatorMovePreviousItem As ToolStripButton
    Private WithEvents bindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblInventoryValue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cboGenres As ComboBox
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents label5 As Label
    Friend WithEvents txtSearch As TextBox
    Private WithEvents btnRaiseMargin As Button
    Private WithEvents lblMargin As Label
    Private WithEvents btnLowerMargin As Button
    Private WithEvents groupBox4 As GroupBox
    Friend WithEvents lblGenreInvValue As Label
    Friend WithEvents label12 As Label
    Friend WithEvents lblGenreCount As Label
    Friend WithEvents label14 As Label
End Class
