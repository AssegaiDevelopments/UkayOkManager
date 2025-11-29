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
        chartCategory = New ScottPlot.WinForms.FormsPlot()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label13 = New Label()
        RoundedPanel9 = New RoundedPanel()
        lblTotalExpensesPaid = New Label()
        Label10 = New Label()
        RoundedPanel10 = New RoundedPanel()
        lblUpcomingExpensesWeek = New Label()
        Label3 = New Label()
        RoundedPanel8 = New RoundedPanel()
        lblTotalExpensesUnpaid = New Label()
        Label5 = New Label()
        RoundedPanel1 = New RoundedPanel()
        lblTotalSalesToday = New Label()
        Label1 = New Label()
        RoundedPanel7 = New RoundedPanel()
        lblTotalItemsSold = New Label()
        Label9 = New Label()
        RoundedPanel4 = New RoundedPanel()
        lblTotalSalesMonth = New Label()
        Label4 = New Label()
        RoundedPanel2 = New RoundedPanel()
        lblNetProfitLastWeek = New Label()
        Label12 = New Label()
        RoundedPanel6 = New RoundedPanel()
        lblNetProfit = New Label()
        Label8 = New Label()
        RoundedPanel5 = New RoundedPanel()
        lblTodayExpenses = New Label()
        Label6 = New Label()
        chartSales = New ScottPlot.WinForms.FormsPlot()
        TableLayoutPanel2 = New TableLayoutPanel()
        chartHourly = New ScottPlot.WinForms.FormsPlot()
        TableLayoutPanel1.SuspendLayout()
        RoundedPanel9.SuspendLayout()
        RoundedPanel10.SuspendLayout()
        RoundedPanel8.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' chartCategory
        ' 
        chartCategory.DisplayScale = 1F
        chartCategory.Dock = DockStyle.Fill
        chartCategory.Location = New Point(950, 5)
        chartCategory.Margin = New Padding(4, 5, 4, 5)
        chartCategory.Name = "chartCategory"
        chartCategory.Size = New Size(667, 318)
        chartCategory.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(Label13, 0, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel9, 3, 1)
        TableLayoutPanel1.Controls.Add(RoundedPanel10, 2, 1)
        TableLayoutPanel1.Controls.Add(RoundedPanel8, 1, 1)
        TableLayoutPanel1.Controls.Add(RoundedPanel1, 1, 2)
        TableLayoutPanel1.Controls.Add(RoundedPanel7, 1, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel4, 2, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel2, 3, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel6, 3, 2)
        TableLayoutPanel1.Controls.Add(RoundedPanel5, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(1621, 470)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(52, 41)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(301, 74)
        Label13.TabIndex = 12
        Label13.Text = "Dashboard"
        ' 
        ' RoundedPanel9
        ' 
        RoundedPanel9.BackColor = Color.White
        RoundedPanel9.Controls.Add(lblTotalExpensesPaid)
        RoundedPanel9.Controls.Add(Label10)
        RoundedPanel9.CornerRadius = 20
        RoundedPanel9.Dock = DockStyle.Fill
        RoundedPanel9.Location = New Point(1219, 161)
        RoundedPanel9.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel9.Name = "RoundedPanel9"
        RoundedPanel9.Size = New Size(398, 146)
        RoundedPanel9.TabIndex = 9
        ' 
        ' lblTotalExpensesPaid
        ' 
        lblTotalExpensesPaid.AutoSize = True
        lblTotalExpensesPaid.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalExpensesPaid.ForeColor = Color.FromArgb(CByte(70), CByte(104), CByte(145))
        lblTotalExpensesPaid.Location = New Point(21, 40)
        lblTotalExpensesPaid.Margin = New Padding(0)
        lblTotalExpensesPaid.Name = "lblTotalExpensesPaid"
        lblTotalExpensesPaid.Size = New Size(131, 60)
        lblTotalExpensesPaid.TabIndex = 1
        lblTotalExpensesPaid.Text = "00.00"
        lblTotalExpensesPaid.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(21, 107)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(164, 25)
        Label10.TabIndex = 0
        Label10.Text = "Total Expenses Paid"
        ' 
        ' RoundedPanel10
        ' 
        RoundedPanel10.BackColor = Color.White
        RoundedPanel10.Controls.Add(lblUpcomingExpensesWeek)
        RoundedPanel10.Controls.Add(Label3)
        RoundedPanel10.CornerRadius = 20
        RoundedPanel10.Dock = DockStyle.Fill
        RoundedPanel10.Location = New Point(814, 161)
        RoundedPanel10.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel10.Name = "RoundedPanel10"
        RoundedPanel10.Size = New Size(397, 146)
        RoundedPanel10.TabIndex = 13
        ' 
        ' lblUpcomingExpensesWeek
        ' 
        lblUpcomingExpensesWeek.AutoSize = True
        lblUpcomingExpensesWeek.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUpcomingExpensesWeek.ForeColor = Color.Firebrick
        lblUpcomingExpensesWeek.Location = New Point(21, 40)
        lblUpcomingExpensesWeek.Margin = New Padding(0)
        lblUpcomingExpensesWeek.Name = "lblUpcomingExpensesWeek"
        lblUpcomingExpensesWeek.Size = New Size(131, 60)
        lblUpcomingExpensesWeek.TabIndex = 1
        lblUpcomingExpensesWeek.Text = "00.00"
        lblUpcomingExpensesWeek.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 107)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(241, 25)
        Label3.TabIndex = 0
        Label3.Text = "Upcoming Expenses (7 Days)"
        ' 
        ' RoundedPanel8
        ' 
        RoundedPanel8.BackColor = Color.White
        RoundedPanel8.Controls.Add(lblTotalExpensesUnpaid)
        RoundedPanel8.Controls.Add(Label5)
        RoundedPanel8.CornerRadius = 20
        RoundedPanel8.Dock = DockStyle.Fill
        RoundedPanel8.Location = New Point(409, 161)
        RoundedPanel8.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel8.Name = "RoundedPanel8"
        RoundedPanel8.Size = New Size(397, 146)
        RoundedPanel8.TabIndex = 8
        ' 
        ' lblTotalExpensesUnpaid
        ' 
        lblTotalExpensesUnpaid.AutoSize = True
        lblTotalExpensesUnpaid.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalExpensesUnpaid.ForeColor = Color.Firebrick
        lblTotalExpensesUnpaid.Location = New Point(21, 40)
        lblTotalExpensesUnpaid.Margin = New Padding(0)
        lblTotalExpensesUnpaid.Name = "lblTotalExpensesUnpaid"
        lblTotalExpensesUnpaid.Size = New Size(131, 60)
        lblTotalExpensesUnpaid.TabIndex = 1
        lblTotalExpensesUnpaid.Text = "00.00"
        lblTotalExpensesUnpaid.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 107)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 25)
        Label5.TabIndex = 0
        Label5.Text = "Total Expenses Unpaid"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(lblTotalSalesToday)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Dock = DockStyle.Fill
        RoundedPanel1.Location = New Point(409, 317)
        RoundedPanel1.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(397, 148)
        RoundedPanel1.TabIndex = 11
        ' 
        ' lblTotalSalesToday
        ' 
        lblTotalSalesToday.AutoSize = True
        lblTotalSalesToday.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalSalesToday.ForeColor = Color.FromArgb(CByte(46), CByte(82), CByte(182))
        lblTotalSalesToday.Location = New Point(21, 40)
        lblTotalSalesToday.Margin = New Padding(0)
        lblTotalSalesToday.Name = "lblTotalSalesToday"
        lblTotalSalesToday.Size = New Size(131, 60)
        lblTotalSalesToday.TabIndex = 1
        lblTotalSalesToday.Text = "00.00"
        lblTotalSalesToday.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 107)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 25)
        Label1.TabIndex = 0
        Label1.Text = "Total Sales Today"
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.BackColor = Color.White
        RoundedPanel7.Controls.Add(lblTotalItemsSold)
        RoundedPanel7.Controls.Add(Label9)
        RoundedPanel7.CornerRadius = 20
        RoundedPanel7.Dock = DockStyle.Fill
        RoundedPanel7.Location = New Point(409, 5)
        RoundedPanel7.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(397, 146)
        RoundedPanel7.TabIndex = 7
        ' 
        ' lblTotalItemsSold
        ' 
        lblTotalItemsSold.AutoSize = True
        lblTotalItemsSold.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalItemsSold.ForeColor = Color.FromArgb(CByte(46), CByte(82), CByte(182))
        lblTotalItemsSold.Location = New Point(21, 40)
        lblTotalItemsSold.Margin = New Padding(0)
        lblTotalItemsSold.Name = "lblTotalItemsSold"
        lblTotalItemsSold.Size = New Size(73, 60)
        lblTotalItemsSold.TabIndex = 1
        lblTotalItemsSold.Text = "00"
        lblTotalItemsSold.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(21, 107)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 25)
        Label9.TabIndex = 0
        Label9.Text = "Total Items Sold"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(lblTotalSalesMonth)
        RoundedPanel4.Controls.Add(Label4)
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Dock = DockStyle.Fill
        RoundedPanel4.Location = New Point(814, 5)
        RoundedPanel4.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(397, 146)
        RoundedPanel4.TabIndex = 4
        ' 
        ' lblTotalSalesMonth
        ' 
        lblTotalSalesMonth.AutoSize = True
        lblTotalSalesMonth.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalSalesMonth.ForeColor = Color.FromArgb(CByte(60), CByte(94), CByte(161))
        lblTotalSalesMonth.Location = New Point(21, 40)
        lblTotalSalesMonth.Margin = New Padding(0)
        lblTotalSalesMonth.Name = "lblTotalSalesMonth"
        lblTotalSalesMonth.Size = New Size(131, 60)
        lblTotalSalesMonth.TabIndex = 1
        lblTotalSalesMonth.Text = "00.00"
        lblTotalSalesMonth.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 107)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 25)
        Label4.TabIndex = 0
        Label4.Text = "Total Sales This Month"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.White
        RoundedPanel2.Controls.Add(lblNetProfitLastWeek)
        RoundedPanel2.Controls.Add(Label12)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Dock = DockStyle.Fill
        RoundedPanel2.Location = New Point(1219, 5)
        RoundedPanel2.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(398, 146)
        RoundedPanel2.TabIndex = 10
        ' 
        ' lblNetProfitLastWeek
        ' 
        lblNetProfitLastWeek.AutoSize = True
        lblNetProfitLastWeek.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNetProfitLastWeek.ForeColor = Color.FromArgb(CByte(83), CByte(117), CByte(124))
        lblNetProfitLastWeek.Location = New Point(19, 40)
        lblNetProfitLastWeek.Margin = New Padding(0)
        lblNetProfitLastWeek.Name = "lblNetProfitLastWeek"
        lblNetProfitLastWeek.Size = New Size(131, 60)
        lblNetProfitLastWeek.TabIndex = 1
        lblNetProfitLastWeek.Text = "00.00"
        lblNetProfitLastWeek.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(21, 107)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(182, 25)
        Label12.TabIndex = 0
        Label12.Text = "Net Profit (Last Week)"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.White
        RoundedPanel6.Controls.Add(lblNetProfit)
        RoundedPanel6.Controls.Add(Label8)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Dock = DockStyle.Fill
        RoundedPanel6.Location = New Point(1219, 317)
        RoundedPanel6.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(398, 148)
        RoundedPanel6.TabIndex = 6
        ' 
        ' lblNetProfit
        ' 
        lblNetProfit.AutoSize = True
        lblNetProfit.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNetProfit.ForeColor = Color.FromArgb(CByte(83), CByte(117), CByte(124))
        lblNetProfit.Location = New Point(19, 40)
        lblNetProfit.Margin = New Padding(0)
        lblNetProfit.Name = "lblNetProfit"
        lblNetProfit.Size = New Size(131, 60)
        lblNetProfit.TabIndex = 1
        lblNetProfit.Text = "00.00"
        lblNetProfit.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(21, 107)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(150, 25)
        Label8.TabIndex = 0
        Label8.Text = "Net Profit (Today)"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.Controls.Add(lblTodayExpenses)
        RoundedPanel5.Controls.Add(Label6)
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Dock = DockStyle.Fill
        RoundedPanel5.Location = New Point(814, 317)
        RoundedPanel5.Margin = New Padding(4, 5, 4, 5)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(397, 148)
        RoundedPanel5.TabIndex = 5
        ' 
        ' lblTodayExpenses
        ' 
        lblTodayExpenses.AutoSize = True
        lblTodayExpenses.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTodayExpenses.ForeColor = Color.FromArgb(CByte(70), CByte(104), CByte(145))
        lblTodayExpenses.Location = New Point(21, 40)
        lblTodayExpenses.Margin = New Padding(0)
        lblTodayExpenses.Name = "lblTodayExpenses"
        lblTodayExpenses.Size = New Size(131, 60)
        lblTodayExpenses.TabIndex = 1
        lblTodayExpenses.Text = "00.00"
        lblTodayExpenses.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 107)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(178, 25)
        Label6.TabIndex = 0
        Label6.Text = "Total Expenses Today"
        ' 
        ' chartSales
        ' 
        chartSales.DisplayScale = 1F
        chartSales.Dock = DockStyle.Fill
        chartSales.Location = New Point(950, 333)
        chartSales.Margin = New Padding(4, 5, 4, 5)
        chartSales.Name = "chartSales"
        chartSales.Size = New Size(667, 319)
        chartSales.TabIndex = 5
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.1079578F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.5792732F))
        TableLayoutPanel2.Controls.Add(chartCategory, 2, 0)
        TableLayoutPanel2.Controls.Add(chartHourly, 0, 0)
        TableLayoutPanel2.Controls.Add(chartSales, 2, 1)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 480)
        TableLayoutPanel2.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1621, 657)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' chartHourly
        ' 
        TableLayoutPanel2.SetColumnSpan(chartHourly, 2)
        chartHourly.DisplayScale = 1F
        chartHourly.Dock = DockStyle.Fill
        chartHourly.Location = New Point(4, 5)
        chartHourly.Margin = New Padding(4, 5, 4, 5)
        chartHourly.Name = "chartHourly"
        TableLayoutPanel2.SetRowSpan(chartHourly, 2)
        chartHourly.Size = New Size(938, 647)
        chartHourly.TabIndex = 6
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "DashboardControl"
        Size = New Size(1621, 1137)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        RoundedPanel9.ResumeLayout(False)
        RoundedPanel9.PerformLayout()
        RoundedPanel10.ResumeLayout(False)
        RoundedPanel10.PerformLayout()
        RoundedPanel8.ResumeLayout(False)
        RoundedPanel8.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel7.ResumeLayout(False)
        RoundedPanel7.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents chartCategory As ScottPlot.WinForms.FormsPlot
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents lblNetProfit As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents lblTodayExpenses As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents lblTotalSalesMonth As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chartSales As ScottPlot.WinForms.FormsPlot
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents lblTotalItemsSold As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RoundedPanel9 As RoundedPanel
    Friend WithEvents lblTotalExpensesPaid As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RoundedPanel8 As RoundedPanel
    Friend WithEvents lblTotalExpensesUnpaid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNetProfitLastWeek As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblTotalSalesToday As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RoundedPanel10 As RoundedPanel
    Friend WithEvents lblUpcomingExpensesWeek As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chartHourly As ScottPlot.WinForms.FormsPlot

End Class
