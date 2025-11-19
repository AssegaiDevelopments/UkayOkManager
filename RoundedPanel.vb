Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits Panel

    Public Property CornerRadius As Integer = 20

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = BuildPath(rect, CornerRadius)

        Me.Region = New Region(path)
        Using pen As New Pen(Me.BackColor, 1)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Function BuildPath(rect As Rectangle, r As Integer) As GraphicsPath
        Dim p As New GraphicsPath()
        p.AddArc(rect.X, rect.Y, r, r, 180, 90)
        p.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
        p.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
        p.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
        p.CloseFigure()
        Return p
    End Function
End Class
