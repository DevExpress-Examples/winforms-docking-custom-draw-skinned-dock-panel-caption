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
    [System.ComponentModel.DesignerCategory("")]
    public class MyDockPanel : DockPanel
    {
        public MyDockPanel()
        {
            DockLayout = new MyDockLayout(DockingStyle.Float, this);   
        }
        protected internal MyDockPanel(bool createControlContainer, DockingStyle dock, DockManager dockManager)
            : base(createControlContainer, dock, dockManager)
        {
            
        }

    }
}