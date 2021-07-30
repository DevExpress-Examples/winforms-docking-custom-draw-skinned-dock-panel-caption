Imports System

Namespace WindowsFormsApplication1
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
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
            components = New ComponentModel.Container()
            myDockManager1 = New MyDockManager(components)
            barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(components)
            myDockPanel1 = New MyDockPanel()
            myDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            myDockPanel2 = New MyDockPanel()
            myDockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            myDockPanel3 = New MyDockPanel()
            myDockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType(myDockManager1, ComponentModel.ISupportInitialize).BeginInit()
            CType(barAndDockingController1, ComponentModel.ISupportInitialize).BeginInit()
            myDockPanel1.SuspendLayout()
            myDockPanel2.SuspendLayout()
            myDockPanel3.SuspendLayout()
            myDockPanel3_Container.SuspendLayout()
            CType(checkEdit1.Properties, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' myDockManager1
            ' 
            myDockManager1.Controller = barAndDockingController1
            myDockManager1.Form = Me
            myDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {myDockPanel1, myDockPanel2, myDockPanel3})
            myDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' myDockPanel1
            ' 
            myDockPanel1.Controls.Add(myDockPanel1_Container)
            myDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            myDockPanel1.ID = New Guid("5aff35d9-6ceb-4045-aae4-86b326df826e")
            myDockPanel1.Location = New Drawing.Point(0, 404)
            myDockPanel1.Name = "myDockPanel1"
            myDockPanel1.OriginalSize = New Drawing.Size(200, 200)
            myDockPanel1.Size = New Drawing.Size(739, 200)
            myDockPanel1.Text = "myDockPanel1"
            ' 
            ' myDockPanel1_Container
            ' 
            myDockPanel1_Container.Location = New Drawing.Point(3, 25)
            myDockPanel1_Container.Name = "myDockPanel1_Container"
            myDockPanel1_Container.Size = New Drawing.Size(733, 172)
            myDockPanel1_Container.TabIndex = 0
            ' 
            ' myDockPanel2
            ' 
            myDockPanel2.Controls.Add(myDockPanel2_Container)
            myDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
            myDockPanel2.ID = New Guid("db5ddd68-6739-4045-a16d-244cd39a8442")
            myDockPanel2.Location = New Drawing.Point(0, 0)
            myDockPanel2.Name = "myDockPanel2"
            myDockPanel2.OriginalSize = New Drawing.Size(200, 200)
            myDockPanel2.Size = New Drawing.Size(739, 200)
            myDockPanel2.Text = "myDockPanel2"
            ' 
            ' myDockPanel2_Container
            ' 
            myDockPanel2_Container.Location = New Drawing.Point(3, 25)
            myDockPanel2_Container.Name = "myDockPanel2_Container"
            myDockPanel2_Container.Size = New Drawing.Size(733, 172)
            myDockPanel2_Container.TabIndex = 0
            ' 
            ' myDockPanel3
            ' 
            myDockPanel3.Controls.Add(myDockPanel3_Container)
            myDockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            myDockPanel3.FloatLocation = New Drawing.Point(283, 431)
            myDockPanel3.ID = New Guid("622b280f-a2a9-4eb5-b118-c7972c758f5f")
            myDockPanel3.Location = New Drawing.Point(0, 0)
            myDockPanel3.Name = "myDockPanel3"
            myDockPanel3.OriginalSize = New Drawing.Size(200, 200)
            myDockPanel3.Size = New Drawing.Size(200, 200)
            myDockPanel3.Text = "myDockPanel3"
            ' 
            ' myDockPanel3_Container
            ' 
            myDockPanel3_Container.Controls.Add(checkEdit1)
            myDockPanel3_Container.Controls.Add(simpleButton1)
            myDockPanel3_Container.Location = New Drawing.Point(2, 24)
            myDockPanel3_Container.Name = "myDockPanel3_Container"
            myDockPanel3_Container.Size = New Drawing.Size(196, 174)
            myDockPanel3_Container.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            simpleButton1.Location = New Drawing.Point(66, 54)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New Drawing.Size(75, 23)
            simpleButton1.TabIndex = 0
            simpleButton1.Text = "Switch skin"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf simpleButton1_Click)
            ' 
            ' checkEdit1
            ' 
            checkEdit1.Location = New Drawing.Point(14, 101)
            checkEdit1.Name = "checkEdit1"
            checkEdit1.Properties.Caption = "Custom draw"
            checkEdit1.Size = New Drawing.Size(100, 19)
            checkEdit1.TabIndex = 1
            AddHandler checkEdit1.CheckedChanged, New EventHandler(AddressOf checkEdit1_CheckedChanged)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(739, 604)
            Controls.Add(myDockPanel2)
            Controls.Add(myDockPanel1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(myDockManager1, ComponentModel.ISupportInitialize).EndInit()
            CType(barAndDockingController1, ComponentModel.ISupportInitialize).EndInit()
            myDockPanel1.ResumeLayout(False)
            myDockPanel2.ResumeLayout(False)
            myDockPanel3.ResumeLayout(False)
            myDockPanel3_Container.ResumeLayout(False)
            CType(checkEdit1.Properties, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
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
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
