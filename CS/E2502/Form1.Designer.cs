namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.myDockManager1 = new WindowsFormsApplication1.MyDockManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.myDockPanel1 = new WindowsFormsApplication1.MyDockPanel();
            this.myDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.myDockPanel2 = new WindowsFormsApplication1.MyDockPanel();
            this.myDockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.myDockPanel3 = new WindowsFormsApplication1.MyDockPanel();
            this.myDockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.myDockPanel1.SuspendLayout();
            this.myDockPanel2.SuspendLayout();
            this.myDockPanel3.SuspendLayout();
            this.myDockPanel3_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myDockManager1
            // 
            this.myDockManager1.Controller = this.barAndDockingController1;
            this.myDockManager1.Form = this;
            this.myDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.myDockPanel1,
            this.myDockPanel2,
            this.myDockPanel3});
            this.myDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // myDockPanel1
            // 
            this.myDockPanel1.Controls.Add(this.myDockPanel1_Container);
            this.myDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.myDockPanel1.ID = new System.Guid("5aff35d9-6ceb-4045-aae4-86b326df826e");
            this.myDockPanel1.Location = new System.Drawing.Point(0, 404);
            this.myDockPanel1.Name = "myDockPanel1";
            this.myDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.myDockPanel1.Size = new System.Drawing.Size(739, 200);
            this.myDockPanel1.Text = "myDockPanel1";
            // 
            // myDockPanel1_Container
            // 
            this.myDockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.myDockPanel1_Container.Name = "myDockPanel1_Container";
            this.myDockPanel1_Container.Size = new System.Drawing.Size(733, 172);
            this.myDockPanel1_Container.TabIndex = 0;
            // 
            // myDockPanel2
            // 
            this.myDockPanel2.Controls.Add(this.myDockPanel2_Container);
            this.myDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.myDockPanel2.ID = new System.Guid("db5ddd68-6739-4045-a16d-244cd39a8442");
            this.myDockPanel2.Location = new System.Drawing.Point(0, 0);
            this.myDockPanel2.Name = "myDockPanel2";
            this.myDockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.myDockPanel2.Size = new System.Drawing.Size(739, 200);
            this.myDockPanel2.Text = "myDockPanel2";
            // 
            // myDockPanel2_Container
            // 
            this.myDockPanel2_Container.Location = new System.Drawing.Point(3, 25);
            this.myDockPanel2_Container.Name = "myDockPanel2_Container";
            this.myDockPanel2_Container.Size = new System.Drawing.Size(733, 172);
            this.myDockPanel2_Container.TabIndex = 0;
            // 
            // myDockPanel3
            // 
            this.myDockPanel3.Controls.Add(this.myDockPanel3_Container);
            this.myDockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.myDockPanel3.FloatLocation = new System.Drawing.Point(283, 431);
            this.myDockPanel3.ID = new System.Guid("622b280f-a2a9-4eb5-b118-c7972c758f5f");
            this.myDockPanel3.Location = new System.Drawing.Point(0, 0);
            this.myDockPanel3.Name = "myDockPanel3";
            this.myDockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
            this.myDockPanel3.Size = new System.Drawing.Size(200, 200);
            this.myDockPanel3.Text = "myDockPanel3";
            // 
            // myDockPanel3_Container
            // 
            this.myDockPanel3_Container.Controls.Add(this.checkEdit1);
            this.myDockPanel3_Container.Controls.Add(this.simpleButton1);
            this.myDockPanel3_Container.Location = new System.Drawing.Point(2, 24);
            this.myDockPanel3_Container.Name = "myDockPanel3_Container";
            this.myDockPanel3_Container.Size = new System.Drawing.Size(196, 174);
            this.myDockPanel3_Container.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(66, 54);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Switch skin";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(14, 101);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Custom draw";
            this.checkEdit1.Size = new System.Drawing.Size(100, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 604);
            this.Controls.Add(this.myDockPanel2);
            this.Controls.Add(this.myDockPanel1);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.myDockPanel1.ResumeLayout(false);
            this.myDockPanel2.ResumeLayout(false);
            this.myDockPanel3.ResumeLayout(false);
            this.myDockPanel3_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyDockManager myDockManager1;
        private MyDockPanel myDockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer myDockPanel2_Container;
        private MyDockPanel myDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer myDockPanel1_Container;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private MyDockPanel myDockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer myDockPanel3_Container;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;







    }
}

