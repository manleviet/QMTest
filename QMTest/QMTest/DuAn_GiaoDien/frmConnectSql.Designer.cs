namespace DuAn_GiaoDien
{
    partial class frmConnectSql
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectSql));
            this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TextEditServer = new DevExpress.XtraEditors.TextEdit();
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarButtonItemConnect = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemFindServers = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ImageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.RibbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.RadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.TextEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.TextEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.TextEditDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControlGroup1
            // 
            this.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1";
            this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LayoutControlGroup1.GroupBordersVisible = false;
            this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlGroup2,
            this.LayoutControlGroup3});
            this.LayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlGroup1.Name = "LayoutControlGroup1";
            this.LayoutControlGroup1.Size = new System.Drawing.Size(479, 374);
            this.LayoutControlGroup1.Text = "LayoutControlGroup1";
            this.LayoutControlGroup1.TextVisible = false;
            // 
            // LayoutControlGroup2
            // 
            this.LayoutControlGroup2.CustomizationFormText = "Server details";
            this.LayoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2});
            this.LayoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlGroup2.Name = "LayoutControlGroup2";
            this.LayoutControlGroup2.Size = new System.Drawing.Size(459, 91);
            this.LayoutControlGroup2.Text = "Server details";
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.TextEditServer;
            this.LayoutControlItem1.CustomizationFormText = "Server";
            this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Size = new System.Drawing.Size(435, 24);
            this.LayoutControlItem1.Text = "Server";
            this.LayoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // TextEditServer
            // 
            this.TextEditServer.Location = new System.Drawing.Point(122, 43);
            this.TextEditServer.MenuManager = this.RibbonControl;
            this.TextEditServer.Name = "TextEditServer";
            this.TextEditServer.Size = new System.Drawing.Size(333, 20);
            this.TextEditServer.StyleController = this.LayoutControl1;
            this.TextEditServer.TabIndex = 4;
            // 
            // RibbonControl
            // 
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.BarButtonItemConnect,
            this.BarButtonItemFindServers,
            this.BarButtonItemCancel});
            this.RibbonControl.LargeImages = this.ImageCollection1;
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 4;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonPage1});
            this.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.RibbonControl.Size = new System.Drawing.Size(479, 117);
            this.RibbonControl.StatusBar = this.RibbonStatusBar;
            this.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BarButtonItemConnect
            // 
            this.BarButtonItemConnect.Caption = "Connect";
            this.BarButtonItemConnect.Id = 1;
            this.BarButtonItemConnect.LargeImageIndex = 1;
            this.BarButtonItemConnect.Name = "BarButtonItemConnect";
            this.BarButtonItemConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemConnect_ItemClick);
            // 
            // BarButtonItemFindServers
            // 
            this.BarButtonItemFindServers.Caption = "Find servers";
            this.BarButtonItemFindServers.Id = 2;
            this.BarButtonItemFindServers.LargeImageIndex = 2;
            this.BarButtonItemFindServers.Name = "BarButtonItemFindServers";
            // 
            // BarButtonItemCancel
            // 
            this.BarButtonItemCancel.Caption = "Cancel";
            this.BarButtonItemCancel.Id = 3;
            this.BarButtonItemCancel.LargeImageIndex = 0;
            this.BarButtonItemCancel.Name = "BarButtonItemCancel";
            this.BarButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCancel_ItemClick);
            // 
            // ImageCollection1
            // 
            this.ImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.ImageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection1.ImageStream")));
            this.ImageCollection1.Images.SetKeyName(0, "cancel.png");
            this.ImageCollection1.Images.SetKeyName(1, "network.png");
            this.ImageCollection1.Images.SetKeyName(2, "search.png");
            // 
            // RibbonPage1
            // 
            this.RibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroup1});
            this.RibbonPage1.Name = "RibbonPage1";
            this.RibbonPage1.Text = "Actions";
            // 
            // RibbonPageGroup1
            // 
            this.RibbonPageGroup1.ItemLinks.Add(this.BarButtonItemConnect);
            this.RibbonPageGroup1.ItemLinks.Add(this.BarButtonItemFindServers);
            this.RibbonPageGroup1.ItemLinks.Add(this.BarButtonItemCancel);
            this.RibbonPageGroup1.Name = "RibbonPageGroup1";
            this.RibbonPageGroup1.Text = "connect";
            // 
            // RibbonStatusBar
            // 
            this.RibbonStatusBar.Location = new System.Drawing.Point(0, 491);
            this.RibbonStatusBar.Name = "RibbonStatusBar";
            this.RibbonStatusBar.Ribbon = this.RibbonControl;
            this.RibbonStatusBar.Size = new System.Drawing.Size(479, 27);
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.RadioGroup1);
            this.LayoutControl1.Controls.Add(this.TextEditPassword);
            this.LayoutControl1.Controls.Add(this.TextEditUserName);
            this.LayoutControl1.Controls.Add(this.TextEditServer);
            this.LayoutControl1.Controls.Add(this.TextEditDatabaseName);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 117);
            this.LayoutControl1.Name = "LayoutControl1";
            this.LayoutControl1.Root = this.LayoutControlGroup1;
            this.LayoutControl1.Size = new System.Drawing.Size(479, 374);
            this.LayoutControl1.TabIndex = 5;
            this.LayoutControl1.Text = "LayoutControl1";
            // 
            // RadioGroup1
            // 
            this.RadioGroup1.EditValue = true;
            this.RadioGroup1.Location = new System.Drawing.Point(122, 134);
            this.RadioGroup1.MenuManager = this.RibbonControl;
            this.RadioGroup1.Name = "RadioGroup1";
            this.RadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Use Windows Authentication"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Use SQL Server Authentication")});
            this.RadioGroup1.Size = new System.Drawing.Size(333, 168);
            this.RadioGroup1.StyleController = this.LayoutControl1;
            this.RadioGroup1.TabIndex = 8;
            // 
            // TextEditPassword
            // 
            this.TextEditPassword.Enabled = false;
            this.TextEditPassword.Location = new System.Drawing.Point(122, 330);
            this.TextEditPassword.MenuManager = this.RibbonControl;
            this.TextEditPassword.Name = "TextEditPassword";
            this.TextEditPassword.Size = new System.Drawing.Size(333, 20);
            this.TextEditPassword.StyleController = this.LayoutControl1;
            this.TextEditPassword.TabIndex = 7;
            // 
            // TextEditUserName
            // 
            this.TextEditUserName.Enabled = false;
            this.TextEditUserName.Location = new System.Drawing.Point(122, 306);
            this.TextEditUserName.MenuManager = this.RibbonControl;
            this.TextEditUserName.Name = "TextEditUserName";
            this.TextEditUserName.Size = new System.Drawing.Size(333, 20);
            this.TextEditUserName.StyleController = this.LayoutControl1;
            this.TextEditUserName.TabIndex = 6;
            // 
            // TextEditDatabaseName
            // 
            this.TextEditDatabaseName.Location = new System.Drawing.Point(122, 67);
            this.TextEditDatabaseName.MenuManager = this.RibbonControl;
            this.TextEditDatabaseName.Name = "TextEditDatabaseName";
            this.TextEditDatabaseName.Size = new System.Drawing.Size(333, 20);
            this.TextEditDatabaseName.StyleController = this.LayoutControl1;
            this.TextEditDatabaseName.TabIndex = 5;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.TextEditDatabaseName;
            this.LayoutControlItem2.CustomizationFormText = "Database name";
            this.LayoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Size = new System.Drawing.Size(435, 24);
            this.LayoutControlItem2.Text = "Database name";
            this.LayoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LayoutControlGroup3
            // 
            this.LayoutControlGroup3.CustomizationFormText = "Authentication";
            this.LayoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem3,
            this.LayoutControlItem5,
            this.LayoutControlItem4});
            this.LayoutControlGroup3.Location = new System.Drawing.Point(0, 91);
            this.LayoutControlGroup3.Name = "LayoutControlGroup3";
            this.LayoutControlGroup3.Size = new System.Drawing.Size(459, 263);
            this.LayoutControlGroup3.Text = "Authentication";
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.TextEditUserName;
            this.LayoutControlItem3.CustomizationFormText = "User name";
            this.LayoutControlItem3.Location = new System.Drawing.Point(0, 172);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Size = new System.Drawing.Size(435, 24);
            this.LayoutControlItem3.Text = "User name";
            this.LayoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LayoutControlItem5
            // 
            this.LayoutControlItem5.Control = this.RadioGroup1;
            this.LayoutControlItem5.CustomizationFormText = "Authentication type";
            this.LayoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem5.Name = "LayoutControlItem5";
            this.LayoutControlItem5.Size = new System.Drawing.Size(435, 172);
            this.LayoutControlItem5.Text = "Authentication type";
            this.LayoutControlItem5.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.TextEditPassword;
            this.LayoutControlItem4.CustomizationFormText = "Password";
            this.LayoutControlItem4.Location = new System.Drawing.Point(0, 196);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Size = new System.Drawing.Size(435, 24);
            this.LayoutControlItem4.Text = "Password";
            this.LayoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // frmConnectSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 518);
            this.ControlBox = false;
            this.Controls.Add(this.LayoutControl1);
            this.Controls.Add(this.RibbonStatusBar);
            this.Controls.Add(this.RibbonControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnectSql";
            this.Text = "Cấu hình kết nối cơ sở dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup2;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
        internal DevExpress.XtraEditors.TextEdit TextEditServer;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItemConnect;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItemFindServers;
        internal DevExpress.XtraBars.BarButtonItem BarButtonItemCancel;
        internal DevExpress.Utils.ImageCollection ImageCollection1;
        internal DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage1;
        internal DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup1;
        internal DevExpress.XtraBars.Ribbon.RibbonStatusBar RibbonStatusBar;
        internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
        internal DevExpress.XtraEditors.RadioGroup RadioGroup1;
        internal DevExpress.XtraEditors.TextEdit TextEditPassword;
        internal DevExpress.XtraEditors.TextEdit TextEditUserName;
        internal DevExpress.XtraEditors.TextEdit TextEditDatabaseName;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup3;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem3;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem5;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem4;
    }
}