Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsFormsApplication1

    <System.ComponentModel.DesignerCategory("")>
    Public Class MyDockPanel
        Inherits DockPanel

        Public Sub New()
            DockLayout = New MyDockLayout(DockingStyle.Float, Me)
        End Sub

        Protected Friend Sub New(ByVal createControlContainer As Boolean, ByVal dock As DockingStyle, ByVal dockManager As DockManager)
            MyBase.New(createControlContainer, dock, dockManager)
        End Sub
    End Class
End Namespace
