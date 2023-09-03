Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1

    Public Delegate Sub CustomDrawEventHandler(ByVal sender As Object, ByVal e As MyCustomDrawArgs)

    Public Class MyCustomDrawArgs

        Public Sub New(ByVal args As Object, ByVal panel As DockPanel)
            _Args = args
            _Panel = panel
            Handled = False
        End Sub

        Private _Handled As Boolean

        Public Property Handled As Boolean
            Get
                Return _Handled
            End Get

            Set(ByVal value As Boolean)
                _Handled = value
            End Set
        End Property

        Private _Args As Object

        Public Property Args As Object
            Get
                Return _Args
            End Get

            Set(ByVal value As Object)
                _Args = value
            End Set
        End Property

        Private _Panel As DockPanel

        Public Property Panel As DockPanel
            Get
                Return _Panel
            End Get

            Set(ByVal value As DockPanel)
                _Panel = value
            End Set
        End Property
    End Class
End Namespace
