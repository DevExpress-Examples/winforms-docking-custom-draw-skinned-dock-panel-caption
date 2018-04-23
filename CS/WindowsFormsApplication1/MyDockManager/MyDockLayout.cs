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
using DevExpress.XtraBars.Docking.Helpers;

namespace WindowsFormsApplication1
{
    public class MyDockLayout : DockLayout
    {

        public MyDockLayout(DockingStyle dock, DockPanel panel)
            : base(dock, panel)
        {

        }
        public MyDockLayout(DockingStyle dock, Size size, DockPanel panel)
            : base(dock, size, panel)
        {

        }

        protected override void DrawCaption(DockElementsPainter painter)
        {
            if (painter is MyDockElementsSkinPainter)
                (painter as MyDockElementsSkinPainter).CurrentPanel = Panel;
            base.DrawCaption(painter);
        }

    }
}
