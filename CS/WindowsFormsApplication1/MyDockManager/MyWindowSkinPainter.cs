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
using DevExpress.XtraBars.Docking;
using DevExpress.Utils;

namespace WindowsFormsApplication1
{
    public class MyWindowSkinPainter : WindowSkinPainter
    {
        public MyWindowSkinPainter(DockElementsSkinPainter painter) : base(painter) { }

        private static bool _DefaultDrawFirst = true;
        public static bool DefaultDrawFirst
        {
            get { return _DefaultDrawFirst; }
            set { _DefaultDrawFirst = value; }
        }

        private DockPanel _CurrentDockPanel;
        public DockPanel CurrentDockPanel
        {
            get { return _CurrentDockPanel; }
            set { _CurrentDockPanel = value; }
        }

        public bool RaiseCustomDraw(object args)
        {
            MyDockManager manager = CurrentDockPanel.DockManager as MyDockManager;
            MyCustomDrawArgs e = new MyCustomDrawArgs(args, CurrentDockPanel);
            if (manager != null)
            {
                manager.RaiseCustomDraw(e);
            }
            return e.Handled;
        }


        protected override void DrawWindowCaptionBackground(DrawWindowCaptionArgs args)
        {
            if (DefaultDrawFirst)
                base.DrawWindowCaptionBackground(args);
            if (!RaiseCustomDraw(args))
                base.DrawWindowCaptionBackground(args);
            
        }
        protected override void DrawApplicationCaptionBackgroud(DrawApplicationCaptionArgs args)
        {
            if (DefaultDrawFirst)
                base.DrawApplicationCaptionBackgroud(args);
            if (!RaiseCustomDraw(args)) 
                base.DrawApplicationCaptionBackgroud(args);
        }

        protected override void DrawCaptionText(DrawApplicationCaptionArgs e)
        {
            if (DefaultDrawFirst)
                base.DrawCaptionText(e);
            if (!RaiseCustomDraw(e))
                base.DrawCaptionText(e);
        }
    }
}
