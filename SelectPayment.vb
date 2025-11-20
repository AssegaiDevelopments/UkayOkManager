Public Class SelectPayment
    Public Property CartTotal As Decimal
    Public Property AmountReceived As Decimal
    Public Property ChangeGiven As Decimal

    Public Property PaymentConfirmed As Boolean = False
    Public SelectedMethod As String = ""

    ' --- Utility method: set hover + click handlers for a panel and its children ---
    Private Sub SetupPanel(panel As Panel, enterColor As Color, leaveColor As Color, clickHandler As EventHandler)
        ' Hover behavior for the panel itself
        AddHandler panel.MouseEnter, Sub() panel.BackColor = enterColor
        AddHandler panel.MouseLeave, Sub() panel.BackColor = leaveColor

        ' Click handler for the panel itself
        AddHandler panel.Click, clickHandler

        ' Apply the same hover and click to all child controls
        For Each ctrl As Control In panel.Controls
            AddHandler ctrl.MouseEnter, Sub() panel.BackColor = enterColor
            AddHandler ctrl.MouseLeave, Sub() panel.BackColor = leaveColor
            AddHandler ctrl.Click, clickHandler
        Next
    End Sub

    Private Sub SelectPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCashReceived.Visible = False
        pnlGCashReceived.Visible = False
        txtCashReceived.Clear()
        lblChange.Text = ""


        lblCartTotal.Text = "₱" & CartTotal.ToString("N2")
        lblCartTotalB.Text = "₱" & CartTotal.ToString("N2")

        ' Setup both panels with consistent behavior; programmatically add handlers/hover effects
        SetupPanel(pnlCash, Color.MediumSeaGreen, Color.FromArgb(69, 204, 129), AddressOf pnlCash_Click)
        SetupPanel(pnlGCash, Color.PowderBlue, Color.White, AddressOf pnlGCash_Click)
    End Sub

    ' --- Panel Click Handlers ---
    Private Sub pnlCash_Click(sender As Object, e As EventArgs) Handles pnlCash.Click
        SelectedMethod = "Cash"
        pnlCashReceived.Visible = True
        pnlCashReceived.BringToFront()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlCashReceived.Visible = False
    End Sub

    Private Sub txtCashReceived_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashReceived.KeyPress
        ' Allow digits, one decimal point, and backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso txtCashReceived.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCashReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCashReceived.TextChanged
        Dim received As Decimal

        ' TryParse prevents crashes on empty/invalid input
        If Not Decimal.TryParse(txtCashReceived.Text, received) Then
            received = 0
        End If

        Dim change = received - CartTotal

        ' Update label and button states
        If change < 0 Then
            lblChange.ForeColor = Color.Red
            lblChange.Text = $"Insufficient Cash (₱{Math.Abs(change):N2})"
            btnConfirmCash.Enabled = False
        Else
            lblChange.ForeColor = Color.Black
            lblChange.Text = "₱" & change.ToString("N2")
            btnConfirmCash.Enabled = True
        End If
    End Sub

    Private Sub btnConfirmCash_Click(sender As Object, e As EventArgs) Handles btnConfirmCash.Click
        PaymentConfirmed = True
        DialogResult = DialogResult.OK
        Close()
    End Sub



    Private Sub pnlGCash_Click(sender As Object, e As EventArgs) Handles pnlGCash.Click
        pnlGCashReceived.Visible = True
        pnlGCashReceived.BringToFront()
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        pnlGCashReceived.Visible = False
    End Sub

    ' --- Cancel Button ---
    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        SelectedMethod = ""
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnConfirmGCash_Click(sender As Object, e As EventArgs) Handles btnConfirmGCash.Click
        SelectedMethod = "GCash"
        PaymentConfirmed = True
        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
