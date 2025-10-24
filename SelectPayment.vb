Public Class SelectPayment
    Private Sub SelectPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attach hover behavior to all subcontrols of pnlCash
        For Each ctrl As Control In pnlCash.Controls
            AddHandler ctrl.Click, AddressOf pnlCash_Click
            AddHandler ctrl.MouseEnter, AddressOf pnlCash_MouseEnter
            AddHandler ctrl.MouseLeave, AddressOf pnlCash_MouseLeave
        Next

        ' And for pnlGCash
        For Each ctrl As Control In pnlGCash.Controls
            AddHandler ctrl.Click, AddressOf pnlGCash_Click
            AddHandler ctrl.MouseEnter, AddressOf pnlGCash_MouseEnter
            AddHandler ctrl.MouseLeave, AddressOf pnlGCash_MouseLeave
        Next
    End Sub


    Public SelectedMethod As String = ""

    ' --- Cash Panel ---
    Private Sub pnlCash_Click(sender As Object, e As EventArgs) Handles pnlCash.Click
        SelectedMethod = "Cash"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' --- GCash Panel ---
    Private Sub pnlGCash_Click(sender As Object, e As EventArgs) Handles pnlGCash.Click
        SelectedMethod = "GCash"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' --- Cancel Button ---
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        SelectedMethod = ""
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' --- Optional: Hover effect for panels ---
    Private Sub pnlCash_MouseEnter(sender As Object, e As EventArgs) Handles pnlCash.MouseEnter
        pnlCash.BackColor = Color.FromArgb(192, 41, 41)
    End Sub

    Private Sub pnlCash_MouseLeave(sender As Object, e As EventArgs) Handles pnlCash.MouseLeave
        pnlCash.BackColor = Color.FromArgb(178, 34, 34)
    End Sub

    Private Sub pnlGCash_MouseEnter(sender As Object, e As EventArgs) Handles pnlGCash.MouseEnter
        pnlGCash.BackColor = Color.PowderBlue
    End Sub

    Private Sub pnlGCash_MouseLeave(sender As Object, e As EventArgs) Handles pnlGCash.MouseLeave
        pnlGCash.BackColor = Color.White
    End Sub


End Class
