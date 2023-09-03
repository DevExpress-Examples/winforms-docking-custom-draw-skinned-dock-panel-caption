Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            barAndDockingController1.PaintStyles.Add(New MyPaintStyle(barAndDockingController1.PaintStyles))
            barAndDockingController1.PaintStyleName = "MyScheme"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler myDockManager1.CustomDrawPanelCaption, New CustomDrawEventHandler(AddressOf myDockManager1_CustomDrawPanelCaption)
        End Sub

        Private Sub myDockManager1_CustomDrawPanelCaption(ByVal sender As Object, ByVal e As MyCustomDrawArgs)
            If Not checkEdit1.Checked Then Return
            Dim args As DrawWindowCaptionArgs = TryCast(e.Args, DrawWindowCaptionArgs)
            If args IsNot Nothing Then
                Dim appearance As AppearanceObject = New AppearanceObject()
                appearance.BackColor = If(e.Panel Is myDockPanel1, Color.Yellow, Color.LightCyan)
                appearance.BackColor2 = If(e.Panel Is myDockPanel1, Color.Orange, Color.SkyBlue)
                appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
                Dim rect As Rectangle = args.Bounds
                rect.Inflate(-1, -1)
                appearance.FillRectangle(args.Cache, rect)
            End If

            Dim appArgs As DrawApplicationCaptionArgs = TryCast(e.Args, DrawApplicationCaptionArgs)
            If appArgs IsNot Nothing AndAlso args Is Nothing Then
                Dim appearance As AppearanceObject = New AppearanceObject()
                appearance.BackColor = Color.LightCyan
                appearance.BackColor2 = Color.LightGreen
                appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
                Dim rect As Rectangle = appArgs.Bounds
                rect.Inflate(-1, -1)
                appearance.FillRectangle(appArgs.Cache, rect)
            End If
        End Sub

        Private i As Integer = 0

        Public Sub SwitchSkin()
            i += 1
            If i > SkinManager.Default.Skins.Count - 1 Then i = 0
            UserLookAndFeel.Default.SkinName = SkinManager.Default.Skins(i).SkinName
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            SwitchSkin()
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            myDockManager1.BeginUpdate()
            myDockManager1.EndUpdate()
        End Sub
    End Class
End Namespace
