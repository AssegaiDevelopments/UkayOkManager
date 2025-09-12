<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnRemoveItemFromCart = New Button()
        btnAddItemToCart = New Button()
        Label1 = New Label()
        cbClothingType = New ComboBox()
        Label2 = New Label()
        nudQuantity = New NumericUpDown()
        Label3 = New Label()
        dgvCart = New DataGridView()
        txtbItemPrice = New TextBox()
        Label4 = New Label()
        chbxDiscount = New CheckBox()
        tbDiscount = New TrackBar()
        lDiscount = New Label()
        Panel1 = New Panel()
        lGrandTotal = New Label()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbDiscount, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRemoveItemFromCart
        ' 
        btnRemoveItemFromCart.Location = New Point(543, 445)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(86, 23)
        btnRemoveItemFromCart.TabIndex = 1
        btnRemoveItemFromCart.Text = "Remove Item"
        btnRemoveItemFromCart.UseVisualStyleBackColor = True
        ' 
        ' btnAddItemToCart
        ' 
        btnAddItemToCart.Location = New Point(462, 445)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(75, 23)
        btnAddItemToCart.TabIndex = 3
        btnAddItemToCart.Text = "Add Item"
        btnAddItemToCart.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 4
        Label1.Text = "Total"
        ' 
        ' cbClothingType
        ' 
        cbClothingType.FormattingEnabled = True
        cbClothingType.Location = New Point(416, 387)
        cbClothingType.Name = "cbClothingType"
        cbClothingType.Size = New Size(121, 23)
        cbClothingType.TabIndex = 5
        cbClothingType.Text = "Jeans"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(376, 394)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 6
        Label2.Text = "Type:"
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Location = New Point(576, 390)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(37, 23)
        nudQuantity.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(541, 392)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 8
        Label3.Text = "Qty:"
        ' 
        ' dgvCart
        ' 
        dgvCart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvCart.BackgroundColor = Color.White
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCart.GridColor = Color.White
        dgvCart.Location = New Point(238, 26)
        dgvCart.Name = "dgvCart"
        dgvCart.Size = New Size(600, 358)
        dgvCart.TabIndex = 9
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Location = New Point(416, 415)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(121, 23)
        txtbItemPrice.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(374, 418)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 11
        Label4.Text = "Price:"
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.AutoSize = True
        chbxDiscount.Location = New Point(688, 391)
        chbxDiscount.Name = "chbxDiscount"
        chbxDiscount.Size = New Size(116, 19)
        chbxDiscount.TabIndex = 12
        chbxDiscount.Text = "Enable Discount?"
        chbxDiscount.UseVisualStyleBackColor = True
        ' 
        ' tbDiscount
        ' 
        tbDiscount.Enabled = False
        tbDiscount.Location = New Point(688, 415)
        tbDiscount.Maximum = 80
        tbDiscount.Name = "tbDiscount"
        tbDiscount.Size = New Size(116, 45)
        tbDiscount.TabIndex = 13
        tbDiscount.TickStyle = TickStyle.Both
        tbDiscount.Value = 1
        ' 
        ' lDiscount
        ' 
        lDiscount.AutoSize = True
        lDiscount.Enabled = False
        lDiscount.Location = New Point(707, 445)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(76, 15)
        lDiscount.TabIndex = 14
        lDiscount.Text = "Discount: 0%"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lGrandTotal)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(238, 392)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(101, 69)
        Panel1.TabIndex = 15
        ' 
        ' lGrandTotal
        ' 
        lGrandTotal.AutoSize = True
        lGrandTotal.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lGrandTotal.Location = New Point(33, 27)
        lGrandTotal.Name = "lGrandTotal"
        lGrandTotal.Size = New Size(16, 18)
        lGrandTotal.TabIndex = 5
        lGrandTotal.Text = "0"
        lGrandTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(172), CByte(199), CByte(199))
        ClientSize = New Size(886, 504)
        Controls.Add(Panel1)
        Controls.Add(lDiscount)
        Controls.Add(tbDiscount)
        Controls.Add(chbxDiscount)
        Controls.Add(Label4)
        Controls.Add(txtbItemPrice)
        Controls.Add(dgvCart)
        Controls.Add(Label3)
        Controls.Add(nudQuantity)
        Controls.Add(Label2)
        Controls.Add(cbClothingType)
        Controls.Add(btnAddItemToCart)
        Controls.Add(btnRemoveItemFromCart)
        Name = "Form2"
        Text = "Form2"
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(tbDiscount, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnRemoveItemFromCart As Button
    Friend WithEvents btnAddItemToCart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbClothingType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents txtbItemPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chbxDiscount As CheckBox
    Friend WithEvents tbDiscount As TrackBar
    Friend WithEvents lDiscount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lGrandTotal As Label
End Class
