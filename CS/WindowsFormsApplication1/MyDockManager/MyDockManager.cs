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
    [System.ComponentModel.DesignerCategory("")]
    public class MyDockManager : DockManager
    {

        public MyDockManager()
        {

        }
        public MyDockManager(IContainer container)
            : base(container)
        {

        }
        public MyDockManager(ContainerControl form)
            : base(form)
        {

        }

        protected override DockPanel CreateDockPanel(DockingStyle dock, bool createControlContainer)
        {
            return new MyDockPanel(createControlContainer, dock, this);
        }


        static readonly object customDraw = new object();
        public event CustomDrawEventHandler CustomDrawPanelCaption
        {
            add { this.Events.AddHandler(customDraw, value); }
            remove { this.Events.RemoveHandler(customDraw, value); }
        }


        protected internal virtual void RaiseCustomDraw(MyCustomDrawArgs args)
        {
            CustomDrawEventHandler handler = (CustomDrawEventHandler)this.Events[customDraw];
            if (handler != null) handler(this, args);
        }

    }
}