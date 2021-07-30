Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myDockManager1 = New WindowsFormsApplication1.MyDockManager(Me.components)
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			Me.myDockPanel1 = New WindowsFormsApplication1.MyDockPanel()
			Me.myDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.myDockPanel2 = New WindowsFormsApplication1.MyDockPanel()
			Me.myDockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.myDockPanel3 = New WindowsFormsApplication1.MyDockPanel()
			Me.myDockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.myDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myDockPanel1.SuspendLayout()
			Me.myDockPanel2.SuspendLayout()
			Me.myDockPanel3.SuspendLayout()
			Me.myDockPanel3_Container.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myDockManager1
			' 
			Me.myDockManager1.Controller = Me.barAndDockingController1
			Me.myDockManager1.Form = Me
			Me.myDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.myDockPanel1, Me.myDockPanel2, Me.myDockPanel3})
			Me.myDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' myDockPanel1
			' 
			Me.myDockPanel1.Controls.Add(Me.myDockPanel1_Container)
			Me.myDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
			Me.myDockPanel1.ID = New System.Guid("5aff35d9-6ceb-4045-aae4-86b326df826e")
			Me.myDockPanel1.Location = New System.Drawing.Point(0, 404)
			Me.myDockPanel1.Name = "myDockPanel1"
			Me.myDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.myDockPanel1.Size = New System.Drawing.Size(739, 200)
			Me.myDockPanel1.Text = "myDockPanel1"
			' 
			' myDockPanel1_Container
			' 
			Me.myDockPanel1_Container.Location = New System.Drawing.Point(3, 25)
			Me.myDockPanel1_Container.Name = "myDockPanel1_Container"
			Me.myDockPanel1_Container.Size = New System.Drawing.Size(733, 172)
			Me.myDockPanel1_Container.TabIndex = 0
			' 
			' myDockPanel2
			' 
			Me.myDockPanel2.Controls.Add(Me.myDockPanel2_Container)
			Me.myDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
			Me.myDockPanel2.ID = New System.Guid("db5ddd68-6739-4045-a16d-244cd39a8442")
			Me.myDockPanel2.Location = New System.Drawing.Point(0, 0)
			Me.myDockPanel2.Name = "myDockPanel2"
			Me.myDockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
			Me.myDockPanel2.Size = New System.Drawing.Size(739, 200)
			Me.myDockPanel2.Text = "myDockPanel2"
			' 
			' myDockPanel2_Container
			' 
			Me.myDockPanel2_Container.Location = New System.Drawing.Point(3, 25)
			Me.myDockPanel2_Container.Name = "myDockPanel2_Container"
			Me.myDockPanel2_Container.Size = New System.Drawing.Size(733, 172)
			Me.myDockPanel2_Container.TabIndex = 0
			' 
			' myDockPanel3
			' 
			Me.myDockPanel3.Controls.Add(Me.myDockPanel3_Container)
			Me.myDockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.myDockPanel3.FloatLocation = New System.Drawing.Point(283, 431)
			Me.myDockPanel3.ID = New System.Guid("622b280f-a2a9-4eb5-b118-c7972c758f5f")
			Me.myDockPanel3.Location = New System.Drawing.Point(0, 0)
			Me.myDockPanel3.Name = "myDockPanel3"
			Me.myDockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
			Me.myDockPanel3.Size = New System.Drawing.Size(200, 200)
			Me.myDockPanel3.Text = "myDockPanel3"
			' 
			' myDockPanel3_Container
			' 
			Me.myDockPanel3_Container.Controls.Add(Me.checkEdit1)
			Me.myDockPanel3_Container.Controls.Add(Me.simpleButton1)
			Me.myDockPanel3_Container.Location = New System.Drawing.Point(2, 24)
			Me.myDockPanel3_Container.Name = "myDockPanel3_Container"
			Me.myDockPanel3_Container.Size = New System.Drawing.Size(196, 174)
			Me.myDockPanel3_Container.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(66, 54)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Switch skin"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(14, 101)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Custom draw"
			Me.checkEdit1.Size = New System.Drawing.Size(100, 19)
			Me.checkEdit1.TabIndex = 1
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(739, 604)
			Me.Controls.Add(Me.myDockPanel2)
			Me.Controls.Add(Me.myDockPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myDockPanel1.ResumeLayout(False)
			Me.myDockPanel2.ResumeLayout(False)
			Me.myDockPanel3.ResumeLayout(False)
			Me.myDockPanel3_Container.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myDockManager1 As MyDockManager
		Private myDockPanel2 As MyDockPanel
		Private myDockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private myDockPanel1 As MyDockPanel
		Private myDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Private myDockPanel3 As MyDockPanel
		Private myDockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit







	End Class
End Namespace

