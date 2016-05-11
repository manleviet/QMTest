namespace DuAn_GiaoDien
{
    partial class frm_QuanLyHeThong
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Danh sách giáo viên");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Danh sách vai trò hệ thống");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Danh sách quyền truy nhập");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cây phân cấp môn học");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Danh mục khoa ngành");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Danh mục chức danh");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Danh sách loại câu hỏi");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Danh sách độ khó");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ngân hàng câu hỏi", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ngân hàng bố cục");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Ngân hàng đề thi");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Sao lưu");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Phục hồi");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ngân hàng trắc nghiệm", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Thông tin truy nhập hệ thống");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Quản lý hệ thống", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode14,
            treeNode15});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pQuanLyHeThong = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.hiệuChỉnhToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.inDanhSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 92);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // hiệuChỉnhToolStripMenuItem
            // 
            this.hiệuChỉnhToolStripMenuItem.Name = "hiệuChỉnhToolStripMenuItem";
            this.hiệuChỉnhToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hiệuChỉnhToolStripMenuItem.Text = "Hiệu chỉnh";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // inDanhSáchToolStripMenuItem
            // 
            this.inDanhSáchToolStripMenuItem.Name = "inDanhSáchToolStripMenuItem";
            this.inDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.inDanhSáchToolStripMenuItem.Text = "In danh sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 375);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pQuanLyHeThong);
            this.splitContainer1.Size = new System.Drawing.Size(692, 375);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ContextMenuStrip = this.contextMenuStrip1;
            treeNode1.Name = "NodeDanhSachGiaoVien";
            treeNode1.Text = "Danh sách giáo viên";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Danh sách vai trò hệ thống";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Danh sách quyền truy nhập";
            treeNode4.Name = "NodeCayPhanCapMonHoc";
            treeNode4.Text = "Cây phân cấp môn học";
            treeNode5.Name = "NodeDanhMucKhoa";
            treeNode5.Text = "Danh mục khoa ngành";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Danh mục chức danh";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Danh sách loại câu hỏi";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Danh sách độ khó";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Ngân hàng câu hỏi";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Ngân hàng bố cục";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Ngân hàng đề thi";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Sao lưu";
            treeNode13.Name = "Node5";
            treeNode13.Text = "Phục hồi";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Ngân hàng trắc nghiệm";
            treeNode15.Name = "Node9";
            treeNode15.Text = "Thông tin truy nhập hệ thống";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Quản lý hệ thống";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(214, 375);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // pQuanLyHeThong
            // 
            this.pQuanLyHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuanLyHeThong.Location = new System.Drawing.Point(0, 0);
            this.pQuanLyHeThong.Name = "pQuanLyHeThong";
            this.pQuanLyHeThong.Size = new System.Drawing.Size(474, 375);
            this.pQuanLyHeThong.TabIndex = 0;
            // 
            // frm_QuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_QuanLyHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hệ thống";
            this.Load += new System.EventHandler(this.frm_QuanLyHeThong_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệuChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDanhSáchToolStripMenuItem;
        private System.Windows.Forms.Panel pQuanLyHeThong;
    }
}