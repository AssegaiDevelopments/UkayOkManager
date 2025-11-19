Public Class BufferedPanel
    Inherits Panel
    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.OptimizedDoubleBuffer Or
                    ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub
End Class
