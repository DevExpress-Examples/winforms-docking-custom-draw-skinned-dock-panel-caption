Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1

    Public Class MyWindowSkinPainter
        Inherits WindowSkinPainter

        Public Sub New(ByVal painter As DockElementsSkinPainter)
            MyBase.New(painter)
        End Sub

        Private Shared _DefaultDrawFirst As Boolean = True

        Public Shared Property DefaultDrawFirst As Boolean
            Get
                Return _DefaultDrawFirst
            End Get

            Set(ByVal value As Boolean)
                _DefaultDrawFirst = value
            End Set
        End Property

        Private _CurrentDockPanel As DockPanel

        Public Property CurrentDockPanel As DockPanel
            Get
                Return _CurrentDockPanel
            End Get

            Set(ByVal value As DockPanel)
                _CurrentDockPanel = value
            End Set
        End Property

        Public Function RaiseCustomDraw(ByVal args As Object) As Boolean
            Dim manager As MyDockManager = TryCast(CurrentDockPanel.DockManager, MyDockManager)
            Dim e As MyCustomDrawArgs = New MyCustomDrawArgs(args, CurrentDockPanel)
            If manager IsNot Nothing Then
                manager.RaiseCustomDraw(e)
            End If

            Return e.Handled
        End Function

        Protected Overrides Sub DrawWindowCaptionBackground(ByVal args As DrawWindowCaptionArgs)
            If DefaultDrawFirst Then MyBase.DrawWindowCaptionBackground(args)
            If Not RaiseCustomDraw(args) Then MyBase.DrawWindowCaptionBackground(args)
        End Sub

        Protected Overrides Sub DrawApplicationCaptionBackgroud(ByVal args As DrawApplicationCaptionArgs)
            If DefaultDrawFirst Then MyBase.DrawApplicationCaptionBackgroud(args)
            If Not RaiseCustomDraw(args) Then MyBase.DrawApplicationCaptionBackgroud(args)
        End Sub

        Protected Overrides Sub DrawCaptionText(ByVal e As DrawApplicationCaptionArgs)
            If DefaultDrawFirst Then MyBase.DrawCaptionText(e)
            If Not RaiseCustomDraw(e) Then MyBase.DrawCaptionText(e)
        End Sub
    End Class
End Namespace
