Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Docking

Namespace WindowsFormsApplication1
	Public Class MyPaintStyle
		Inherits SkinBarManagerPaintStyle

		Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
			MyBase.New(collection)
		End Sub
		Public Overrides ReadOnly Property Name() As String
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
