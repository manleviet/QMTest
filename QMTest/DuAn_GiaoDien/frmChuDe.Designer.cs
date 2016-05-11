namespace DuAn_GiaoDien
{
    partial class frmChuDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuDe));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.meMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenChuDe = new DevExpress.XtraEditors.TextEdit();
            this.lbThemChuDe = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_ThemMucKienThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChuDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLuu);
            this.splitContainerControl1.Panel2.Controls.Add(this.meMoTa);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtTenChuDe);
            this.splitContainerControl1.Panel2.Controls.Add(this.lbThemChuDe);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(546, 463);
            this.splitContainerControl1.SplitterPosition = 301;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(546, 301);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh mục chủ đề thuộc chương";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Sua,
            this.repositoryItemHyperLinkEdit_Xoa,
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc});
            this.gridControl1.Size = new System.Drawing.Size(542, 278);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Sua,
            this.Xoa,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên chủ đề";
            this.gridColumn1.FieldName = "TenChuDe";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Sua
            // 
            this.Sua.Caption = "Sửa";
            this.Sua.ColumnEdit = this.repositoryItemHyperLinkEdit_Sua;
            this.Sua.FieldName = "Sua";
            this.Sua.Name = "Sua";
            this.Sua.OptionsColumn.AllowEdit = false;
            this.Sua.Visible = true;
            this.Sua.VisibleIndex = 2;
            // 
            // repositoryItemHyperLinkEdit_Sua
            // 
            this.repositoryItemHyperLinkEdit_Sua.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemHyperLinkEdit_Sua.Caption = "Sửa";
            this.repositoryItemHyperLinkEdit_Sua.Name = "repositoryItemHyperLinkEdit_Sua";
            this.repositoryItemHyperLinkEdit_Sua.NullText = "Sửa";
            // 
            // Xoa
            // 
            this.Xoa.Caption = "Xóa";
            this.Xoa.ColumnEdit = this.repositoryItemHyperLinkEdit_Xoa;
            this.Xoa.FieldName = "Xoa";
            this.Xoa.Name = "Xoa";
            this.Xoa.OptionsColumn.AllowEdit = false;
            this.Xoa.Visible = true;
            this.Xoa.VisibleIndex = 3;
            // 
            // repositoryItemHyperLinkEdit_Xoa
            // 
            this.repositoryItemHyperLinkEdit_Xoa.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Xoa.Caption = "Xóa";
            this.repositoryItemHyperLinkEdit_Xoa.Name = "repositoryItemHyperLinkEdit_Xoa";
            this.repositoryItemHyperLinkEdit_Xoa.NullText = "Xóa";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "IdChuDe";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô tả";
            this.gridColumn3.FieldName = "MoTa";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thêm mục kiến thức";
            this.gridColumn4.ColumnEdit = this.repositoryItemHyperLinkEdit_ThemMucKienThuc;
            this.gridColumn4.FieldName = "ThemChuDe";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // repositoryItemHyperLinkEdit_ThemMucKienThuc
            // 
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc.Caption = "Thêm mục kiến thức";
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc.Name = "repositoryItemHyperLinkEdit_ThemMucKienThuc";
            this.repositoryItemHyperLinkEdit_ThemMucKienThuc.NullText = "Thêm mục kiến thức";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLuu.Location = new System.Drawing.Point(423, 48);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 87);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // meMoTa
            // 
            this.meMoTa.Location = new System.Drawing.Point(120, 80);
            this.meMoTa.Name = "meMoTa";
            this.meMoTa.Size = new System.Drawing.Size(260, 55);
            this.meMoTa.TabIndex = 3;
            this.meMoTa.UseOptimizedRendering = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mô tả";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên chủ đề";
            // 
            // txtTenChuDe
            // 
            this.txtTenChuDe.Location = new System.Drawing.Point(120, 45);
            this.txtTenChuDe.Name = "txtTenChuDe";
            this.txtTenChuDe.Size = new System.Drawing.Size(260, 20);
            this.txtTenChuDe.TabIndex = 1;
            // 
            // lbThemChuDe
            // 
            this.lbThemChuDe.Image = ((System.Drawing.Image)(resources.GetObject("lbThemChuDe.Image")));
            this.lbThemChuDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbThemChuDe.Location = new System.Drawing.Point(12, -2);
            this.lbThemChuDe.Name = "lbThemChuDe";
            this.lbThemChuDe.Size = new System.Drawing.Size(132, 23);
            this.lbThemChuDe.TabIndex = 0;
            this.lbThemChuDe.TabStop = true;
            this.lbThemChuDe.Text = "Thêm chủ đề";
            this.lbThemChuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThemChuDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbThemChuDe_LinkClicked);
            // 
            // frmChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 463);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmChuDe";
            this.Text = "Chủ đề";
            this.Load += new System.EventHandler(this.frmChuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_ThemMucKienThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChuDe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_ThemMucKienThuc;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.MemoEdit meMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenChuDe;
        private System.Windows.Forms.LinkLabel lbThemChuDe;
    }
}