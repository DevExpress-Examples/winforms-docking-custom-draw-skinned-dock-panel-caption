Imports System
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1
    Public Class MyDockElementsSkinPainter
        Inherits DockElementsSkinPainter

        Public Sub New(ByVal paintStyle As SkinBarManagerPaintStyle)
            MyBase.New(paintStyle)
        End Sub

        Protected Overrides Sub CreateElementPainters()
            MyBase.CreateElementPainters()
            fWindowPainter = New MyWindowSkinPainter(Me)
        End Sub

        Protected Overrides Sub OnStyleChanged(ByVal sender As Object, ByVal ea As EventArgs)
            MyBase.OnStyleChanged(sender, ea)
            fWindowPainter = New MyWindowSkinPainter(Me)
        End Sub

        Public Overrides Sub DrawWindowCaption(ByVal e As DrawWindowCaptionArgs)
            Dim painter As MyWindowSkinPainter = TryCast(WindowPainter, MyWindowSkinPainter)
            If painter IsNot Nothing Then painter.CurrentDockPanel = CurrentPanel
            MyBase.DrawWindowCaption(e)
        End Sub

        Public Overrides Sub DrawApplicationCaption(ByVal args As DrawApplicationCaptionArgs)
            Dim painter As MyWindowSkinPainter = TryCast(WindowPainter, MyWindowSkinPainter)
            If painter IsNot Nothing Then painter.CurrentDockPanel = CurrentPanel
            MyBase.DrawApplicationCaption(args)
        End Sub

        Private _CurrentPanel As DockPanel

        Public Property CurrentPanel As DockPanel
            Get
                Return _CurrentPanel
            End Get
            Set(ByVal value As DockPanel)
                _CurrentPanel = value
            End Set
        End Property
    End Class
End Namespace
