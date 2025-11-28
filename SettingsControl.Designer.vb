<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        cbCurrency = New ComboBox()
        btnClearExpenses = New Button()
        btnClearTransactions = New Button()
        Label1 = New Label()
        RoundedPanel1 = New RoundedPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Panel1 = New Panel()
        btnRunFullBackup = New Button()
        Label13 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RoundedPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbCurrency
        ' 
        cbCurrency.Anchor = AnchorStyles.None
        cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList
        cbCurrency.FormattingEnabled = True
        cbCurrency.Location = New Point(51, 138)
        cbCurrency.Name = "cbCurrency"
        cbCurrency.Size = New Size(160, 23)
        cbCurrency.TabIndex = 0
        ' 
        ' btnClearExpenses
        ' 
        btnClearExpenses.Location = New Point(51, 42)
        btnClearExpenses.Name = "btnClearExpenses"
        btnClearExpenses.Size = New Size(160, 23)
        btnClearExpenses.TabIndex = 1
        btnClearExpenses.Text = "Clear Expenses Data"
        btnClearExpenses.UseVisualStyleBackColor = True
        ' 
        ' btnClearTransactions
        ' 
        btnClearTransactions.Location = New Point(244, 42)
        btnClearTransactions.Name = "btnClearTransactions"
        btnClearTransactions.Size = New Size(160, 23)
        btnClearTransactions.TabIndex = 2
        btnClearTransactions.Text = "Clear Transactions Data"
        btnClearTransactions.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(81, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 3
        Label1.Text = "Currency Symbol:"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(TableLayoutPanel1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(339, 65)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(457, 482)
        RoundedPanel1.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(GroupBox1, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 195F))
        TableLayoutPanel1.Size = New Size(457, 482)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnClearExpenses)
        GroupBox1.Controls.Add(btnClearTransactions)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(3, 290)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(451, 189)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Delete Database Data (Non-reversible)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(51, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(353, 60)
        Label2.TabIndex = 3
        Label2.Text = "WARNING:" & vbCrLf & "These options will delete ALL data of their corresponding buttons." & vbCrLf & "This action is IRREVERSIBLE." & vbCrLf & "Reports, totals, transaction history, and analytics will be affected."
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnRunFullBackup)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cbCurrency)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(451, 281)
        Panel1.TabIndex = 5
        ' 
        ' btnRunFullBackup
        ' 
        btnRunFullBackup.Anchor = AnchorStyles.None
        btnRunFullBackup.Location = New Point(280, 124)
        btnRunFullBackup.Name = "btnRunFullBackup"
        btnRunFullBackup.Size = New Size(104, 23)
        btnRunFullBackup.TabIndex = 4
        btnRunFullBackup.Text = "Full Backup"
        btnRunFullBackup.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(21, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(155, 50)
        Label13.TabIndex = 13
        Label13.Text = "Settings"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(60, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 15)
        Label3.TabIndex = 4
        Label3.Text = "Change currency symbol."
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(269, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 30)
        Label4.TabIndex = 5
        Label4.Text = "Backup all database data" & vbCrLf & "in specified file path."
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SettingsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(RoundedPanel1)
        Name = "SettingsControl"
        Size = New Size(1135, 682)
        RoundedPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbCurrency As ComboBox
    Friend WithEvents btnClearExpenses As Button
    Friend WithEvents btnClearTransactions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRunFullBackup As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label

End Class
