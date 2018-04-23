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

namespace WindowsFormsApplication1
{
    public delegate void CustomDrawEventHandler(object sender, MyCustomDrawArgs e);

    public class MyCustomDrawArgs
    {

        public MyCustomDrawArgs(object args, DockPanel panel)
        {
            _Args = args;
            _Panel = panel;
            Handled = false;
        }

        private bool _Handled;
        public bool Handled
        {
            get { return _Handled; }
            set { _Handled = value; }
        }

        private object _Args;
        public object Args
        {
            get { return _Args; }
            set { _Args = value; }
        }

        private DockPanel _Panel;
        public DockPanel Panel
        {
            get { return _Panel; }
            set { _Panel = value; }
        }
    }


}
