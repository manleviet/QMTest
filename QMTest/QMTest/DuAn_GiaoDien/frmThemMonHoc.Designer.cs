namespace DuAn_GiaoDien
{
    partial class frmThemMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMonHoc));
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
            this.repositoryItemHyperLinkEdit_ThemChuong = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit_ChonToBoMon = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.cbbChonToBoMon = new System.Windows.Forms.ComboBox();
            this.cbbChonKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.meMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbThemMonHoc = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_ThemChuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_ChonToBoMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.txtTenMonHoc);
            this.splitContainerControl1.Panel2.Controls.Add(this.cbbChonToBoMon);
            this.splitContainerControl1.Panel2.Controls.Add(this.cbbChonKhoa);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLuu);
            this.splitContainerControl1.Panel2.Controls.Add(this.meMoTa);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.lbThemMonHoc);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(720, 478);
            this.splitContainerControl1.SplitterPosition = 294;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(720, 294);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh mục môn học";
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
            this.repositoryItemHyperLinkEdit_ThemChuong,
            this.repositoryItemGridLookUpEdit_ChonToBoMon});
            this.gridControl1.Size = new System.Drawing.Size(716, 271);
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
            this.gridColumn4,
            this.gridColumn5});
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
            this.gridColumn1.Caption = "Tên môn học";
            this.gridColumn1.FieldName = "TenMonHoc";
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
            this.Sua.VisibleIndex = 3;
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
            this.Xoa.VisibleIndex = 4;
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
            this.gridColumn2.FieldName = "IdMonHoc";
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
            this.gridColumn4.Caption = "Thêm chương";
            this.gridColumn4.ColumnEdit = this.repositoryItemHyperLinkEdit_ThemChuong;
            this.gridColumn4.FieldName = "ThemChuong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // repositoryItemHyperLinkEdit_ThemChuong
            // 
            this.repositoryItemHyperLinkEdit_ThemChuong.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_ThemChuong.Caption = "Thêm chương";
            this.repositoryItemHyperLinkEdit_ThemChuong.Name = "repositoryItemHyperLinkEdit_ThemChuong";
            this.repositoryItemHyperLinkEdit_ThemChuong.NullText = "Thêm chương";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tổ bộ môn";
            this.gridColumn5.ColumnEdit = this.repositoryItemGridLookUpEdit_ChonToBoMon;
            this.gridColumn5.FieldName = "IdToBoMon";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit_ChonToBoMon
            // 
            this.repositoryItemGridLookUpEdit_ChonToBoMon.AutoHeight = false;
            this.repositoryItemGridLookUpEdit_ChonToBoMon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit_ChonToBoMon.Name = "repositoryItemGridLookUpEdit_ChonToBoMon";
            this.repositoryItemGridLookUpEdit_ChonToBoMon.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(120, 86);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(384, 20);
            this.txtTenMonHoc.TabIndex = 2;
            // 
            // cbbChonToBoMon
            // 
            this.cbbChonToBoMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChonToBoMon.FormattingEnabled = true;
            this.cbbChonToBoMon.Location = new System.Drawing.Point(120, 59);
            this.cbbChonToBoMon.Name = "cbbChonToBoMon";
            this.cbbChonToBoMon.Size = new System.Drawing.Size(384, 21);
            this.cbbChonToBoMon.TabIndex = 1;
            // 
            // cbbChonKhoa
            // 
            this.cbbChonKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChonKhoa.FormattingEnabled = true;
            this.cbbChonKhoa.Location = new System.Drawing.Point(120, 32);
            this.cbbChonKhoa.Name = "cbbChonKhoa";
            this.cbbChonKhoa.Size = new System.Drawing.Size(384, 21);
            this.cbbChonKhoa.TabIndex = 0;
            this.cbbChonKhoa.SelectedValueChanged += new System.EventHandler(this.cbbChonKhoa_SelectedValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(27, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Chọn khoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLuu.Location = new System.Drawing.Point(563, 59);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 87);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // meMoTa
            // 
            this.meMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.meMoTa.Location = new System.Drawing.Point(120, 112);
            this.meMoTa.Name = "meMoTa";
            this.meMoTa.Size = new System.Drawing.Size(384, 55);
            this.meMoTa.TabIndex = 3;
            this.meMoTa.UseOptimizedRendering = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(27, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mô tả";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(27, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên môn học";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(27, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Chọn tổ bộ môn";
            // 
            // lbThemMonHoc
            // 
            this.lbThemMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("lbThemMonHoc.Image")));
            this.lbThemMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbThemMonHoc.Location = new System.Drawing.Point(12, -2);
            this.lbThemMonHoc.Name = "lbThemMonHoc";
            this.lbThemMonHoc.Size = new System.Drawing.Size(159, 23);
            this.lbThemMonHoc.TabIndex = 0;
            this.lbThemMonHoc.TabStop = true;
            this.lbThemMonHoc.Text = "Thêm môn học";
            this.lbThemMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThemMonHoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbThemMonHoc_LinkClicked);
            // 
            // frmThemMonHoc
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 478);
            this.Controls.Add(this.splitContainerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục môn học";
            this.Load += new System.EventHandler(this.frmThemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_ThemChuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_ChonToBoMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_ThemChuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit_ChonToBoMon;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.ComboBox cbbChonKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.MemoEdit meMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.LinkLabel lbThemMonHoc;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private System.Windows.Forms.ComboBox cbbChonToBoMon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}