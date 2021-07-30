Imports System.Drawing
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsFormsApplication1
    Public Class MyDockLayout
        Inherits DockLayout

        Public Sub New(ByVal dock As DockingStyle, ByVal panel As DockPanel)
            MyBase.New(dock, panel)
        End Sub

        Public Sub New(ByVal dock As DockingStyle, ByVal size As Size, ByVal panel As DockPanel)
            MyBase.New(dock, size, panel)
        End Sub

        Protected Overrides Sub DrawCaption(ByVal painter As DockElementsPainter)
            If TypeOf painter Is MyDockElementsSkinPainter Then TryCast(painter, MyDockElementsSkinPainter).CurrentPanel = Panel
            MyBase.DrawCaption(painter)
        End Sub
    End Class
End Namespace
