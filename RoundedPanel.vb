Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits Panel

    ' --- Properties ---
    Private _cornerRadius As Integer = 20
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            UpdateRegion()
            Me.Invalidate()
        End Set
    End Property

    ' --- Constructor ---
    Public Sub New()
        ' Enable double buffering and optimized painting
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.OptimizedDoubleBuffer Or
                    ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    ' --- Override OnResize to update Region once ---
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        UpdateRegion()
        Me.Invalidate()
    End Sub

    ' --- Paint the rounded border ---
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Using path As GraphicsPath = BuildPath(rect, CornerRadius)
            Using pen As New Pen(Me.BackColor, 1)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    ' --- Build the rounded rectangle path ---
    Private Function BuildPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ' --- Update the Region (for rounded corners) ---
    Private Sub UpdateRegion()
        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Me.Region = New Region(BuildPath(rect, CornerRadius))
    End Sub

End Class
