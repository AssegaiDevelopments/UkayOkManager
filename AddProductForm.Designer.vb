<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        btnConfirmAddItem = New Button()
        btnCancelAddItem = New Button()
        tbProductName = New TextBox()
        nudStock = New NumericUpDown()
        nudPrice = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(nudStock, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnConfirmAddItem
        ' 
        btnConfirmAddItem.Cursor = Cursors.Hand
        btnConfirmAddItem.FlatAppearance.BorderSize = 0
        btnConfirmAddItem.Location = New Point(262, 139)
        btnConfirmAddItem.Name = "btnConfirmAddItem"
        btnConfirmAddItem.Size = New Size(75, 23)
        btnConfirmAddItem.TabIndex = 0
        btnConfirmAddItem.Text = "Add Item"
        btnConfirmAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnCancelAddItem
        ' 
        btnCancelAddItem.BackgroundImageLayout = ImageLayout.Center
        btnCancelAddItem.Cursor = Cursors.Hand
        btnCancelAddItem.FlatAppearance.BorderSize = 0
        btnCancelAddItem.Location = New Point(262, 194)
        btnCancelAddItem.Name = "btnCancelAddItem"
        btnCancelAddItem.Size = New Size(75, 23)
        btnCancelAddItem.TabIndex = 1
        btnCancelAddItem.Text = "Cancel"
        btnCancelAddItem.UseVisualStyleBackColor = True
        ' 
        ' tbProductName
        ' 
        tbProductName.Cursor = Cursors.IBeam
        tbProductName.Location = New Point(74, 84)
        tbProductName.MaxLength = 256
        tbProductName.Name = "tbProductName"
        tbProductName.Size = New Size(263, 23)
        tbProductName.TabIndex = 2
        ' 
        ' nudStock
        ' 
        nudStock.Cursor = Cursors.IBeam
        nudStock.Location = New Point(74, 139)
        nudStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStock.Name = "nudStock"
        nudStock.Size = New Size(165, 23)
        nudStock.TabIndex = 3
        ' 
        ' nudPrice
        ' 
        nudPrice.Cursor = Cursors.IBeam
        nudPrice.DecimalPlaces = 2
        nudPrice.Location = New Point(73, 194)
        nudPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(165, 23)
        nudPrice.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(71, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 5
        Label1.Text = "Product Name"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(74, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 6
        Label2.Text = "Stock"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(77, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 7
        Label3.Text = "Price"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.BackColor = Color.DarkSlateGray
        Label4.Font = New Font("Liberation Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(412, 23)
        Label4.TabIndex = 8
        Label4.Text = "+ Add Product"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AddProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg
        ClientSize = New Size(409, 283)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nudPrice)
        Controls.Add(nudStock)
        Controls.Add(tbProductName)
        Controls.Add(btnCancelAddItem)
        Controls.Add(btnConfirmAddItem)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddProductForm"
        Text = "Add Item"
        CType(nudStock, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConfirmAddItem As Button
    Friend WithEvents btnCancelAddItem As Button
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
