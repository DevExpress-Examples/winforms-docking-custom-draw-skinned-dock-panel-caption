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
    public class MyPaintStyle : SkinBarManagerPaintStyle
    {

        public MyPaintStyle(BarManagerPaintStyleCollection collection)
            : base(collection)
        {
        }
        public override string Name { get { return "MyScheme"; } }
        protected override void CreatePainters()
        {
            base.CreatePainters();
            fElementsPainter = new MyDockElementsSkinPainter(this);
        }


    }
}
