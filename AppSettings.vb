Module AppSettings
    Public CurrentCurrency As String = "₱"

    Public Sub LoadSettings()
        CurrentCurrency = My.Settings.SelectedCurrency
    End Sub

    Public Sub SaveSettings()
        My.Settings.SelectedCurrency = CurrentCurrency
        My.Settings.Save()
    End Sub
End Module
