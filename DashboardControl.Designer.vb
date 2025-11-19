<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardControl
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
        lblExpenses = New Label()
        lblProfit = New Label()
        lblSales = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        RoundedPanel6 = New RoundedPanel()
        RoundedPanel4 = New RoundedPanel()
        RoundedPanel5 = New RoundedPanel()
        dgvLowStock = New DataGridView()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        chartTopSales = New ScottPlot.WinForms.FormsPlot()
        chartExpenses = New ScottPlot.WinForms.FormsPlot()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvLowStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblExpenses
        ' 
        lblExpenses.AutoSize = True
        lblExpenses.Location = New Point(10, 17)
        lblExpenses.Name = "lblExpenses"
        lblExpenses.Size = New Size(55, 15)
        lblExpenses.TabIndex = 0
        lblExpenses.Text = "Expenses"
        ' 
        ' lblProfit
        ' 
        lblProfit.AutoSize = True
        lblProfit.Location = New Point(28, 17)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(36, 15)
        lblProfit.TabIndex = 1
        lblProfit.Text = "Profit"
        ' 
        ' lblSales
        ' 
        lblSales.AutoSize = True
        lblSales.Location = New Point(29, 17)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(33, 15)
        lblSales.TabIndex = 2
        lblSales.Text = "Sales"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(RoundedPanel6, 2, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel4, 0, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel5, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1135, 100)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.White
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Dock = DockStyle.Fill
        RoundedPanel6.Location = New Point(759, 3)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(373, 44)
        RoundedPanel6.TabIndex = 2
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Dock = DockStyle.Fill
        RoundedPanel4.Location = New Point(3, 3)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(372, 44)
        RoundedPanel4.TabIndex = 0
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Dock = DockStyle.Fill
        RoundedPanel5.Location = New Point(381, 3)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(372, 44)
        RoundedPanel5.TabIndex = 1
        ' 
        ' dgvLowStock
        ' 
        dgvLowStock.AllowUserToAddRows = False
        dgvLowStock.AllowUserToDeleteRows = False
        dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLowStock.Location = New Point(215, 385)
        dgvLowStock.Name = "dgvLowStock"
        dgvLowStock.ReadOnly = True
        dgvLowStock.Size = New Size(240, 150)
        dgvLowStock.TabIndex = 2
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' chartTopSales
        ' 
        chartTopSales.DisplayScale = 1F
        chartTopSales.Location = New Point(767, 236)
        chartTopSales.Name = "chartTopSales"
        chartTopSales.Size = New Size(150, 150)
        chartTopSales.TabIndex = 3
        ' 
        ' chartExpenses
        ' 
        chartExpenses.DisplayScale = 1F
        chartExpenses.Location = New Point(577, 236)
        chartExpenses.Name = "chartExpenses"
        chartExpenses.Size = New Size(150, 150)
        chartExpenses.TabIndex = 4
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(chartExpenses)
        Controls.Add(chartTopSales)
        Controls.Add(dgvLowStock)
        Controls.Add(TableLayoutPanel1)
        Name = "DashboardControl"
        Size = New Size(1135, 682)
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvLowStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblExpenses As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvLowStock As DataGridView
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents chartTopSales As ScottPlot.WinForms.FormsPlot
    Friend WithEvents chartExpenses As ScottPlot.WinForms.FormsPlot
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel

End Class
