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
        chartExpenses = New ScottPlot.WinForms.FormsPlot()
        BufferedPanel1 = New BufferedPanel()
        RoundedPanel1 = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        RoundedPanel6 = New RoundedPanel()
        Label7 = New Label()
        Label8 = New Label()
        RoundedPanel5 = New RoundedPanel()
        Label5 = New Label()
        Label6 = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label3 = New Label()
        Label4 = New Label()
        chartSales = New ScottPlot.WinForms.FormsPlot()
        BufferedPanel1.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' chartExpenses
        ' 
        chartExpenses.DisplayScale = 1F
        chartExpenses.Location = New Point(55, 18)
        chartExpenses.Name = "chartExpenses"
        chartExpenses.Size = New Size(462, 317)
        chartExpenses.TabIndex = 1
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.Controls.Add(chartExpenses)
        BufferedPanel1.Location = New Point(564, 325)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Size = New Size(568, 354)
        BufferedPanel1.TabIndex = 2
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Dock = DockStyle.Fill
        RoundedPanel1.Location = New Point(3, 3)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(277, 94)
        RoundedPanel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(46), CByte(82), CByte(182))
        Label2.Location = New Point(15, 24)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 40)
        Label2.TabIndex = 1
        Label2.Text = "00.00"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 0
        Label1.Text = "Total Sales Today"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(RoundedPanel6, 3, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel5, 2, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel4, 1, 0)
        TableLayoutPanel1.Controls.Add(RoundedPanel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1135, 100)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.White
        RoundedPanel6.Controls.Add(Label7)
        RoundedPanel6.Controls.Add(Label8)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Dock = DockStyle.Fill
        RoundedPanel6.Location = New Point(852, 3)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(280, 94)
        RoundedPanel6.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(83), CByte(117), CByte(124))
        Label7.Location = New Point(13, 24)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 40)
        Label7.TabIndex = 1
        Label7.Text = "00.00"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(15, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(161, 15)
        Label8.TabIndex = 0
        Label8.Text = "Total Number of Transactions"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.Controls.Add(Label5)
        RoundedPanel5.Controls.Add(Label6)
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Dock = DockStyle.Fill
        RoundedPanel5.Location = New Point(569, 3)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(277, 94)
        RoundedPanel5.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(70), CByte(104), CByte(145))
        Label5.Location = New Point(15, 24)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 1
        Label5.Text = "00.00"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 15)
        Label6.TabIndex = 0
        Label6.Text = "Total Expenses Today"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(Label3)
        RoundedPanel4.Controls.Add(Label4)
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Dock = DockStyle.Fill
        RoundedPanel4.Location = New Point(286, 3)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(277, 94)
        RoundedPanel4.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(60), CByte(94), CByte(161))
        Label3.Location = New Point(15, 24)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 40)
        Label3.TabIndex = 1
        Label3.Text = "00.00"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 15)
        Label4.TabIndex = 0
        Label4.Text = "Total Sales This Month"
        ' 
        ' chartSales
        ' 
        chartSales.DisplayScale = 1F
        chartSales.Location = New Point(89, 343)
        chartSales.Name = "chartSales"
        chartSales.Size = New Size(424, 311)
        chartSales.TabIndex = 5
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(chartSales)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(BufferedPanel1)
        Name = "DashboardControl"
        Size = New Size(1135, 682)
        BufferedPanel1.ResumeLayout(False)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents chartExpenses As ScottPlot.WinForms.FormsPlot
    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chartSales As ScottPlot.WinForms.FormsPlot

End Class
