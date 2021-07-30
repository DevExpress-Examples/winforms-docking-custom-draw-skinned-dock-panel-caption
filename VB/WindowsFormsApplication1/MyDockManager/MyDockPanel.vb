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
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsFormsApplication1
	<System.ComponentModel.DesignerCategory("")> _
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