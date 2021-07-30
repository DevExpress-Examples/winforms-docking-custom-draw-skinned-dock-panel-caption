Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1
    <DesignerCategory("")>
    Public Class MyDockManager
        Inherits DockManager

        Public Sub New()
        End Sub

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub

        Public Sub New(ByVal form As ContainerControl)
            MyBase.New(form)
        End Sub

        Protected Overrides Function CreateDockPanel(ByVal dock As DockingStyle, ByVal createControlContainer As Boolean) As DockPanel
            Return New MyDockPanel(createControlContainer, dock, Me)
        End Function

        Private Shared ReadOnly customDraw As Object = New Object()

        Public Custom Event CustomDrawPanelCaption As CustomDrawEventHandler
            AddHandler(ByVal value As CustomDrawEventHandler)
                Events.AddHandler(customDraw, value)
            End AddHandler
            RemoveHandler(ByVal value As CustomDrawEventHandler)
                Events.RemoveHandler(customDraw, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As MyCustomDrawArgs)
            End RaiseEvent
        End Event

        Protected Friend Overridable Sub RaiseCustomDraw(ByVal args As MyCustomDrawArgs)
            Dim handler As CustomDrawEventHandler = CType(Events(customDraw), CustomDrawEventHandler)
            If handler IsNot Nothing Then handler(Me, args)
        End Sub
    End Class
End Namespace
