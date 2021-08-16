Imports System.ComponentModel
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1
    <DesignerCategory("")>
    Public Class MyDockPanel
        Inherits DockPanel

        Public Sub New()
            DockLayout = New MyDockLayout(DockingStyle.Float, Me)
        End Sub

        Protected Friend Sub New(ByVal createControlContainer As Boolean, ByVal dock As DockingStyle, ByVal dockManager As DockManager)
            MyBase.New(createControlContainer, dock, dockManager)
            DockLayout = New MyDockLayout(dock, Me)
        End Sub
    End Class
End Namespace
