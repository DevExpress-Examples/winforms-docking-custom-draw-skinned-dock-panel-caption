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

namespace WindowsFormsApplication1
{
    public class MyDockElementsSkinPainter : DockElementsSkinPainter
    {
        public MyDockElementsSkinPainter(SkinBarManagerPaintStyle paintStyle) : base(paintStyle) { }
        protected override void CreateElementPainters()
        {
            base.CreateElementPainters();
            fWindowPainter = new MyWindowSkinPainter(this);
        }
        protected override void OnStyleChanged(object sender, EventArgs ea) {
            base.OnStyleChanged(sender, ea);
            fWindowPainter = new MyWindowSkinPainter(this);
        }
        public override void DrawWindowCaption(DrawWindowCaptionArgs e)
        {
            MyWindowSkinPainter painter = WindowPainter as MyWindowSkinPainter;
            if (painter != null)
                painter.CurrentDockPanel = CurrentPanel;
            base.DrawWindowCaption(e);
        }
        public override void DrawApplicationCaption(DrawApplicationCaptionArgs args) {
            MyWindowSkinPainter painter = WindowPainter as MyWindowSkinPainter;
            if(painter != null)
                painter.CurrentDockPanel = CurrentPanel;
            base.DrawApplicationCaption(args);
        }

        private DockPanel _CurrentPanel;
        public DockPanel CurrentPanel
        {
            get { return _CurrentPanel; }
            set { _CurrentPanel = value; }
        }
    }
}
