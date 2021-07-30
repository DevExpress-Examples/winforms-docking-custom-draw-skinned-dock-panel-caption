Imports DevExpress.XtraBars.Styles

Namespace WindowsFormsApplication1
    Public Class MyPaintStyle
        Inherits SkinBarManagerPaintStyle

        Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
            MyBase.New(collection)
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "MyScheme"
            End Get
        End Property

        Protected Overrides Sub CreatePainters()
            MyBase.CreatePainters()
            fElementsPainter = New MyDockElementsSkinPainter(Me)
        End Sub
    End Class
End Namespace
