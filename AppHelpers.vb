Module AppHelpers
    Public Function FormatCurrency(amount As Decimal) As String
        Return AppSettings.CurrentCurrency & amount.ToString("N2")
    End Function
End Module
