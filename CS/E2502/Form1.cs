using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking.Paint;
using DevExpress.XtraBars.Styles;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            barAndDockingController1.PaintStyles.Add(new MyPaintStyle(barAndDockingController1.PaintStyles));
            barAndDockingController1.PaintStyleName = "MyScheme";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDockManager1.CustomDrawPanelCaption += new CustomDrawEventHandler(myDockManager1_CustomDrawPanelCaption);
        }

        void myDockManager1_CustomDrawPanelCaption(object sender, MyCustomDrawArgs e)
        {
            if (!checkEdit1.Checked)
                return;
            DrawWindowCaptionArgs args = e.Args as DrawWindowCaptionArgs;
            if (args != null)
            {
                AppearanceObject appearance = new AppearanceObject();
                appearance.BackColor = e.Panel == myDockPanel1 ? Color.Yellow : Color.LightCyan;
                appearance.BackColor2 = e.Panel == myDockPanel1 ? Color.Orange: Color.SkyBlue;
                appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                Rectangle rect = args.Bounds;
                rect.Inflate(-1,-1);
                appearance.FillRectangle(args.Cache, rect);
            }

            DrawApplicationCaptionArgs appArgs = e.Args as DrawApplicationCaptionArgs;
            if (appArgs != null && args == null)
            {
                AppearanceObject appearance = new AppearanceObject();
                appearance.BackColor = Color.LightCyan;
                appearance.BackColor2 = Color.LightGreen;
                appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                Rectangle rect = appArgs.Bounds;
                rect.Inflate(-1, -1);
                appearance.FillRectangle(appArgs.Cache, rect);
            }


        }

        int i = 0;
        public void SwitchSkin()
        {
            i++;
            if (i > SkinManager.Default.Skins.Count - 1)
                i = 0;
            UserLookAndFeel.Default.SkinName = SkinManager.Default.Skins[i].SkinName;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SwitchSkin();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            myDockManager1.BeginUpdate();
            myDockManager1.EndUpdate();
        }
    }
}