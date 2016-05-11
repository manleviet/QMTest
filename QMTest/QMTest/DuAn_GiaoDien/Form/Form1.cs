using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraRichEdit;
using DevExpress.XtraBars.Docking;
using DevExpress.Utils;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
//using PopupControl;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Office.Utils;
using System.IO;
using System.Drawing.Imaging;
using DuAn_GiaoDien.Report;
using DevExpress.XtraReports.UI;

namespace DuAn_GiaoDien
{
    public partial class Form1 : XtraForm
    {
        //Popup gridToolTip;
        //PivotGridToolTip gridCustomToolTip;
        public Form1()
        {
            
            InitializeComponent();
            InitSkinGallery();

            //gridToolTip = new Popup(gridCustomToolTip = new PivotGridToolTip());
            //gridToolTip.AutoClose = false;
            //gridToolTip.FocusOnOpen = false;
            //gridToolTip.ShowingAnimation = gridToolTip.HidingAnimation = PopupAnimations.LeftToRight | PopupAnimations.Slide;        
        }
        private void InitSkinGallery()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Top = Left = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            // đổ dữ liệu in đề
            comboBox8.DataSource = mhbll.GetMonHocCoDe();
            comboBox8.DisplayMember = "TenMonHoc";
            comboBox8.ValueMember = "IdMonHoc";
            comboBox8.SelectedIndex = -1;
            
            // TODO: This line of code loads data into the 'qm_testDataSet.tbl_matrankienthuc' table. You can move, or remove it, as needed
            //UserControl1 us = new UserControl1();
            //showControl(us);
            xtraTabPage_SoanCauHoi.PageVisible = false;
            xtraTabPageQuanLyHeThong.PageVisible = false;
            xtraTabPageMaTranKienThuc.PageVisible = false;
            xtraTabPageNganHangCauHoi.PageVisible = false;
            xtraTabPage_NganHangSoBo.PageVisible = false;
            xtraTabPage_DanhMucCauHoiDangSoan.PageVisible = false;
            xtraTabPage_NhiemVu.PageVisible = true;
            ShowTabNhiemVu();
            if ((frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2) || (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3))
            {
                //navBarItem5.Enabled = true;
                //navBarItem4.Enabled = true;
                navBarGroup3.Visible = true;
            }
            else
            {
                //navBarItem5.Enabled = false;
                //navBarItem4.Enabled = false;
                navBarGroup3.Visible = false;
            }

            xtraTabPage_NganHangChinhThuc.PageVisible = false;
            if ((frm_DangNhap.GiaoVien.Quyen.IdQuyen == 1) || (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2))
            {
                quảnLýHệThốngToolStripMenuItem.Enabled = false;
                toolStripMenuItem_TaoTaiKhoan.Enabled = false;
            }
        }

        public void showControl(Control obj)
        {
            panelControl2.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            panelControl2.Controls.Add(obj);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) // Danh mục mức trí năng
        {
            frmMucTriNang frm = new frmMucTriNang();
            frm.ShowDialog();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowTabSoanCauHoi();

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).PageVisible = false;
        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            quảnLýHệThốngToolStripMenuItem.Enabled = true;
            xtraTabPageQuanLyHeThong.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPageQuanLyHeThong);
            xtraTabControl1.SelectedTabPage = xtraTabPageQuanLyHeThong;

            treeView_QuanLyHeThong.ExpandAll(); // bung tất cả các node ra
            pQuanLyHeThong.Controls.Clear();

        }
        public void AddUserControl(UserControl uc)
        {
            pQuanLyHeThong.Controls.Clear();
            pQuanLyHeThong.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        public void AddUserControl(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pQuanLyHeThong.Controls.Clear();
            pQuanLyHeThong.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void thôngTinNgườiSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNguoiSuDung frm = new frmThongTinNguoiSuDung();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemLog_Public sys = new SystemLog_Public();
            sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
            sys.MoTa = "Thoát hệ thống";
            sys_bll.SystemLog_Insert(sys);
            Application.Exit();
        }
        MonHoc_BLL mhbll = new MonHoc_BLL();
        MonHoc_Public mh;
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        ToBoMon_Public tbm;
        Khoa_BLL kbll = new Khoa_BLL();
        //Khoa_Public k;
        ChiTietGiangDay_BLL ctgd_bll = new ChiTietGiangDay_BLL();

        private void navBarItemDanhMucMonHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemMonHoc frm = new frmThemMonHoc();
            frm.ShowDialog();
            //MoTabDanhMucMonHoc();
            //pCapNhatMH.Enabled = false;
            #region "Load data on Listview"
            //if (kt == false)
            //{
            //    xtraTabPageDanhMucMonHoc.PageVisible = true;
            //    xtraTabControl1.TabPages.Add(xtraTabPageDanhMucMonHoc);
            //    xtraTabControl1.SelectedTabPage = xtraTabPageDanhMucMonHoc;
            //    DataTable dt = new DataTable();
            //    dt = mhbll.MonHoc_Select();
            //    for (int i = 0; i < dt.Columns.Count; i++)
            //    {
            //        listViewDanhMucMonHoc.Columns.Add(dt.Columns[i].ColumnName.ToString());
            //    }

            //    string[] header = new string[] { "ID Môn học", "Tên môn học", "Mô tả" }; // thiết lập tên tiêu đề listview
            //    int k = 0;
            //    foreach (ColumnHeader LWC in listViewDanhMucMonHoc.Columns)
            //    {
            //        LWC.Text = header[k];
            //        k++;
            //    }

            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        ListViewItem row = new ListViewItem(dt.Rows[i][0].ToString());
            //        for (int j = 1; j < dt.Columns.Count; j++)
            //        {
            //            row.SubItems.Add(dt.Rows[i][j].ToString());
            //        }
            //        listViewDanhMucMonHoc.Items.Add(row);
            //    }
            //    kt = true;
            //}
            #endregion

        }


        #region "Danh Mục Môn học"
        public static bool Enable_ThemMoi;
      
        private void treeView_QuanLyHeThong_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "NodeDanhSachGiaoVien")
            {
                UcNguoiSuDung uc = new UcNguoiSuDung();
                AddUserControl(uc);

                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Xem danh sách giáo viên";
                sys_bll.SystemLog_Insert(sys);
            }
            if (e.Node.Name == "NodeCayPhanCapMonHoc")
            {
                UserControlCayPhanCapMonHoc uc_pcmh = new UserControlCayPhanCapMonHoc();
                AddUserControl(uc_pcmh);

                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Xem cây phân cấp môn học";
                sys_bll.SystemLog_Insert(sys);

            }
            if (e.Node.Name == "NodeDanhMucKhoa")
            {
                //UcDanhMucKhoa uc_dmk = new UcDanhMucKhoa();
                //AddUserControl(uc_dmk);
                frmKhoa frmk = new frmKhoa();
                AddUserControl(frmk);

                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Xem danh mục khoa";
                sys_bll.SystemLog_Insert(sys);

            }
            if (e.Node.Name=="Node9")
            {
                UcSystemLog ucSystemLog = new UcSystemLog();
                AddUserControl(ucSystemLog);
                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Xem thông tin truy nhập hệ thống";
                sys_bll.SystemLog_Insert(sys);
            }
            else if (e.Node.Name == "NodeDoKho") // độ khó
            {
                frmTuyChonDoKho frmdokho = new frmTuyChonDoKho();
                AddUserControl(frmdokho);
            }
            else if (e.Node.Name == "NodeToBoMon") // tổ bộ môn
            {
                frmToBoMon frmtbm = new frmToBoMon();
                frmtbm.lbThemToBoMon_LinkClicked(null, null);
                AddUserControl(frmtbm);
            }
            else if (e.Node.Name == "NodeMonHoc") // môn học
            {
                frmThemMonHoc frmmh = new frmThemMonHoc();
                frmmh.lbThemMonHoc_LinkClicked(null, null);
                AddUserControl(frmmh);
            }
            else if (e.Node.Name == "NodeSaoLuu") // môn học
            {
                UcSaoLuuCSDL ucsaoluu = new UcSaoLuuCSDL();
                AddUserControl(ucsaoluu);
            }

        }
        #endregion
        private void ChonKhoa()
        {
            if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3)
            {
                //cbbChonKhoa.Items.Clear();
                cbbChonKhoa.ValueMember = "IdKhoa";
                cbbChonKhoa.DisplayMember = "TenKhoa";
                cbbChonKhoa.DataSource = kbll.Khoa_Select();

            }
            else
            {
                tbm = new ToBoMon_Public();
                tbm.IdToBoMon = frm_DangNhap.GiaoVien.ToBoMon.IdToBoMon;
                cbbChonKhoa.ValueMember = "IdKhoa";
                cbbChonKhoa.DisplayMember = "TenKhoa";
                cbbChonKhoa.DataSource = kbll.Khoa_Select_IdToBoMon(tbm);
            }

        }
        private void navBarItemMaTranKienThuc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowTabMaTranKienThuc();
        }

        private void CreateColumns(TreeList tl)
        {
            tl.BeginUpdate();
            tl.Columns.Add();
            tl.Columns[0].VisibleIndex = 0;
            tl.Columns.Add();
            tl.Columns[1].VisibleIndex = 1;
            tl.Columns[1].Visible = false;
            tl.EndUpdate();
        }
        Chuong_Public ch;
        ChuDe_Public cd;
        MucKienThuc_Public mkt;
        Chuong_BLL ch_bll = new Chuong_BLL();
        ChuDe_BLL cd_bll = new ChuDe_BLL();
        MucKienThuc_BLL mkt_bll = new MucKienThuc_BLL();
        MaTranKienThuc_BLL mtkt_bll = new MaTranKienThuc_BLL();
        void CreateNode(TreeList tl, string[] GetInfoMonHoc)
        {
            tl.BeginUnboundLoad();
            TreeListNode root = tl.AppendNode(null, null);
            root.SetValue(0, this.GetInfoMonHoc[1]);

            TreeListNode rootNode1 = tl.AppendNode(new object[] { GetInfoMonHoc[2] }, root);
            TreeListNode rootNode2 = tl.AppendNode(new object[] { GetInfoMonHoc[3] }, rootNode1);
            TreeListNode rootNode3 = tl.AppendNode(new object[] { GetInfoMonHoc[4] }, rootNode2);
            TreeListNode rootNode4 = tl.AppendNode(new object[] { GetInfoMonHoc[5] }, rootNode3);
            tl.EndUnboundLoad();
        }
        private void CreateNodes(TreeList tl, string TenMonHoc, int IDMonHoc)
        {

            tl.BeginUnboundLoad();
            TreeListNode root = tl.AppendNode(null, null);
            root.SetValue(0, TenMonHoc);
            DataTable dt1 = new DataTable();
            ch = new Chuong_Public();
            ch.Mh.IdMonHoc = IDMonHoc;
            dt1 = ch_bll.Chuong_Select_IdMonHoc(ch);
            foreach (DataRow row in dt1.Rows)
            {
                TreeListNode rootNode = tl.AppendNode(new object[] { row["TenChuong"].ToString() }, root);
                rootNode.SetValue(1, row["IdChuong"].ToString());
                //ch = new Chuong_Public();
                //ch.IdChuong = int.Parse(row["IdChuong"].ToString());
                cd = new ChuDe_Public();
                cd.Chuong.IdChuong = int.Parse(row["IdChuong"].ToString());
                DataTable dt2 = new DataTable();
                dt2 = cd_bll.ChuDe_Select_IdChuong(cd);
                foreach (DataRow row2 in dt2.Rows)
                {
                    TreeListNode rootNode2 = tl.AppendNode(new object[] { row2["TenChuDe"].ToString() }, rootNode);
                    rootNode2.SetValue(1, row2["IdChuDe"].ToString());
                    DataTable dt3 = new DataTable();
                    //cd = new ChuDe_Public();
                    mkt = new MucKienThuc_Public();
                    mkt.Cd.IdChuDe = int.Parse(row2["IdChuDe"].ToString());
                    //cd.IdChuDe = int.Parse(row2["IdChuDe"].ToString());
                    dt3 = mkt_bll.MucKienThuc_Select_IdChuDe(mkt);
                    foreach (DataRow row3 in dt3.Rows)
                    {
                        TreeListNode rootNode3 = tl.AppendNode(new object[] { row3["TenMucKienThuc"].ToString() }, rootNode2);
                        rootNode3.SetValue(1, row3["IdMucKienThuc"].ToString());
                        DataTable dt4 = new DataTable();
                        mkt = new MucKienThuc_Public();
                        mkt.IdMucKienThuc = row3["IdMucKienThuc"].ToString();
                        dt4 = mtkt_bll.MucTriNang_Select_IdMucKienThuc(mkt);
                        foreach (DataRow row4 in dt4.Rows)
                        {
                            TreeListNode rootNode4 = tl.AppendNode(new object[] { row4["TenMucTriNang"].ToString() }, rootNode3);
                            rootNode4.SetValue(1, row4["IdMucTriNang"].ToString());
                        }
                    }
                }
            }

            tl.EndUnboundLoad();
        }

        private void cbbChonMonHoc_SelectedValueChanged(object sender, EventArgs e) // chọn môn học ==> treeview, pivot table tự động load 
        {
            if (cbbChonMonHoc.SelectedValue == null) return;
            string TenMonHoc = cbbChonMonHoc.Text;
            int IDMonHoc = int.Parse(cbbChonMonHoc.SelectedValue.ToString());

            treeListMucKienThuc.ClearNodes();
            CreateColumns(treeListMucKienThuc);
            CreateNodes(treeListMucKienThuc, TenMonHoc, IDMonHoc);
            treeListMucKienThuc.ExpandAll();

            mh = new MonHoc_Public();
            mh.IdMonHoc = int.Parse(cbbChonMonHoc.SelectedValue.ToString());
            pivotGridControlMaTranKienThuc.DataSource = mtkt_bll.MaTranKienThuc_Select_IdMonHoc(mh);
        }

        private void TabMaTranKienThuc_btnThemKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.ShowDialog();
            //if (frm.KiemTraThemKhoa == true)
            //    ChonKhoa();

        }


        private void TabMaTranKienThuc_btnThemMonHoc_Click(object sender, EventArgs e)
        {
            frmThemMonHoc frm = new frmThemMonHoc();
            frm.ShowDialog();
        }
        string _IdMucKienThuc;

        public string SetIdMucKienThuc
        {
            get { return _IdMucKienThuc; }
            set { _IdMucKienThuc = value; }
        }
        string _SetIdChuong;

        public string SetIdChuong
        {
            get { return _SetIdChuong; }
            set { _SetIdChuong = value; }
        }
        string _SetIdChuDe;

        public string SetIdChuDe
        {
            get { return _SetIdChuDe; }
            set { _SetIdChuDe = value; }
        }
        string _SetIdMonHoc;

        public string SetIdMonHoc
        {
            get { return _SetIdMonHoc; }
            set { _SetIdMonHoc = value; }
        }

        private void treeListMucKienThuc_MouseClick(object sender, MouseEventArgs e)
        {
            if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 1)
            {
            }
            else
            {
                SetIdMonHoc = cbbChonMonHoc.SelectedValue.ToString();
                int level = treeListMucKienThuc.FocusedNode.Level;
                switch (level)
                {
                    case 0:
                        contextMenuStrip_MonHoc.Items["chươngToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["chủĐềToolStripMenuItem"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["mụcKiếnThứcToolStripMenuItem1"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["mứcTríNăngToolStripMenuItem1"].Enabled = false;
                        break;
                    case 1:
                        contextMenuStrip_MonHoc.Items["chủĐềToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["chươngToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["mụcKiếnThứcToolStripMenuItem1"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["mứcTríNăngToolStripMenuItem1"].Enabled = false;
                        SetIdChuong = treeListMucKienThuc.FocusedNode.GetValue(1).ToString();
                        break;
                    case 2:
                        contextMenuStrip_MonHoc.Items["mụcKiếnThứcToolStripMenuItem1"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["chủĐềToolStripMenuItem"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["chươngToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["mứcTríNăngToolStripMenuItem1"].Enabled = false;
                        SetIdChuDe = treeListMucKienThuc.FocusedNode.GetValue(1).ToString();
                        break;
                    case 3:
                        contextMenuStrip_MonHoc.Items["mứcTríNăngToolStripMenuItem1"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["chủĐềToolStripMenuItem"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["chươngToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["mụcKiếnThứcToolStripMenuItem1"].Enabled = false;
                        SetIdMucKienThuc = treeListMucKienThuc.FocusedNode.ParentNode.GetValue(1).ToString();
                        break;
                    default:
                        contextMenuStrip_MonHoc.Items["mứcTríNăngToolStripMenuItem1"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["chủĐềToolStripMenuItem"].Enabled = false;
                        contextMenuStrip_MonHoc.Items["chươngToolStripMenuItem"].Enabled = true;
                        contextMenuStrip_MonHoc.Items["mụcKiếnThứcToolStripMenuItem1"].Enabled = false;
                        SetIdMucKienThuc = treeListMucKienThuc.FocusedNode.ParentNode.GetValue(1).ToString();
                        break;
                }
                if ((e.Button == MouseButtons.Left) && (treeListMucKienThuc.FocusedNode.Level != 0))
                {
                    SetIdMucKienThuc = treeListMucKienThuc.FocusedNode.GetValue(1).ToString();
                }
            }

        }


        DataTable dt;
        public DataTable Dt
        {
            get { return dt; }
        }
        PhanQuyenNhapCauHoi_BLL pqnch_bll = new PhanQuyenNhapCauHoi_BLL();
        GiaoVien_BLL gv_bll = new GiaoVien_BLL();
        int _rowCount;

        public int RowCount
        {
            get { return _rowCount; }
        }

        string[] GetInfoMonHoc = new string[11];
        private void pivotGridControlMaTranKienThuc_CellClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            // IdMonHoc, TenMonHoc, TenChuong, TenChuDe, TenMucKienThuc, TenMucTriNang, IdMucKienThuc,IdMucTriNang,SoCauPhaiNhap,SoCauDaNhap, IdMaTranKienThuc
            GetInfoMonHoc[0] = cbbChonMonHoc.SelectedValue.ToString();
            GetInfoMonHoc[1] = cbbChonMonHoc.Text;

            if (e.RowField == null) return; //Grand Total cell

            PivotGridField[] columnFields = e.GetColumnFields(); // lấy tên các cột
            object[] columnValues = new object[columnFields.Length];
            for (int i = 0; i < columnFields.Length; i++)
                columnValues[i] = e.GetFieldValue(columnFields[i]);

            PivotGridField[] rowFields = e.GetRowFields();  // lấy tên các hàng
            //MessageBox.Show(rowFields.Length.ToString());
            object[] rowValues = new object[rowFields.Length];
            for (int i = 0; i < rowFields.Length - 1; i++)
                rowValues[i] = e.GetFieldValue(rowFields[i]);
            dt = new DataTable();

            foreach (PivotGridField field in columnFields)
                dt.Columns.Add(field.ToString(), field.DataType);
            foreach (PivotGridField field in rowFields)
                dt.Columns.Add(field.ToString(), field.DataType);
            //dt.Columns.Add(e.DataField.ToString(), e.DataField.DataType);

            PivotGridField[] dataField = pivotGridControlMaTranKienThuc.GetFieldsByArea(PivotArea.DataArea).ToArray(); // lấy tên các cột trong dataArea
            for (int i = 0; i < dataField.Length; i++)
            {
                dt.Columns.Add(dataField[i].ToString(), e.DataField.DataType);
            }

            foreach (object lastLevelValue in e.RowField.GetVisibleValues())
            {
                rowValues[rowFields.Length - 1] = lastLevelValue;
                object cellValue = e.GetCellValue(columnValues, rowValues, e.DataField);

                if (cellValue == null) continue;
                DataRow row = dt.NewRow();

                for (int i = 0; i < columnFields.Length; i++)
                    row[columnFields[i].ToString()] = columnValues[i];
                for (int i = 0; i < rowFields.Length; i++)
                    row[rowFields[i].ToString()] = rowValues[i];
                for (int i = 0; i < dataField.Length; i++)
                {
                    //row[e.DataField.ToString()] = cellValue;
                    row[dataField[i].ToString()] = pivotGridControlMaTranKienThuc.GetCellValue(columnValues, rowValues, dataField[i]);
                }
                dt.Rows.Add(row);
            }
            try
            {
                if (dt.Rows.Count > 0)
                {

                    groupControl_MucTriNang.Text = "Mức trí năng: " + dt.Rows[0]["Mức trí năng"];
                    lbTenChuong.Text = dt.Rows[0]["Chương"].ToString();
                    lbTenChuDe.Text = dt.Rows[0]["Chủ đề"].ToString();
                    lbTenMucKienThuc.Text = dt.Rows[0]["Mục kiến thức"].ToString();
                    spinEdit_SoCauNhap.EditValue = dt.Rows[0]["Số câu nhập"];
                    spinEdit_SoCauQuyDinh.EditValue = dt.Rows[0]["Số câu quy định"];
                    GetInfoMonHoc[2] = lbTenChuong.Text;
                    GetInfoMonHoc[3] = lbTenChuDe.Text;
                    GetInfoMonHoc[4] = lbTenMucKienThuc.Text;
                    GetInfoMonHoc[5] = dt.Rows[0]["Mức trí năng"].ToString();
                    GetInfoMonHoc[8] = spinEdit_SoCauNhap.EditValue.ToString();
                    GetInfoMonHoc[9] = spinEdit_SoCauQuyDinh.EditValue.ToString();
                    btn_CapNhatSLCauNhapQuyDinh.Enabled = false;
                    btn_HuyBoSLCauNhapQuyDinh.Enabled = false;

                }
            }
            catch
            {
            }
            if (dt.Rows.Count > 0)
            {
                mtkt = new MaTranKienThuc_Public();
                try
                {
                    mtkt.Mkt.IdMucKienThuc = dt.Rows[0]["IdMucKienThuc"].ToString();
                    mtkt.Mtn.IdMucTriNang = dt.Rows[0]["IdMucTriNang"].ToString();
                    GetInfoMonHoc[6] = mtkt.Mkt.IdMucKienThuc;
                    GetInfoMonHoc[7] = mtkt.Mtn.IdMucTriNang;
                    if (mtkt_bll.MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(mtkt).Rows.Count > 0)
                    {
                        GetInfoMonHoc[10] = mtkt_bll.MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(mtkt).Rows[0]["IdMaTranKienThuc"].ToString();
                    }
                    DataTable TablePhanQuyenNhapCauHoi = new DataTable();
                    TablePhanQuyenNhapCauHoi = pqnch_bll.PhanQuyenNhapCauHoi_Select(mtkt);
                    _rowCount = TablePhanQuyenNhapCauHoi.Rows.Count;
                    gridControl_PhanQuyenNhapCauHoi.DataSource = TablePhanQuyenNhapCauHoi;
                }
                catch { }
            }
            if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3)
            {
                repositoryItemGridLookUpEdit_TenGiaoVien.DataSource = gv_bll.GiaoVien_Select_TrangThai();
                repositoryItemGridLookUpEdit_TenGiaoVien.DisplayMember = "TenGiaoVien";
                repositoryItemGridLookUpEdit_TenGiaoVien.ValueMember = "IdGiaoVien";
            }
            else if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2)
            {
                gv = new GiaoVien_Public();
                gv.ToBoMon.IdToBoMon = frm_DangNhap.GetIdToBoMon;
                repositoryItemGridLookUpEdit_TenGiaoVien.DataSource = gv_bll.GiaoVien_Select_IdToBoMon(gv);
                repositoryItemGridLookUpEdit_TenGiaoVien.DisplayMember = "TenGiaoVien";
                repositoryItemGridLookUpEdit_TenGiaoVien.ValueMember = "IdGiaoVien";
            }
            
            repositoryItemGridLookUpEdit_TenGiaoVien.PopulateViewColumns();
            repositoryItemGridLookUpEdit_TenGiaoVien.View.Columns["IdGiaoVien"].Visible = false;
            repositoryItemGridLookUpEdit_TenGiaoVien.View.Columns["TenGiaoVien"].Caption = "Tên giảng viên";
            repositoryItemGridLookUpEdit_TenGiaoVien.View.Columns["TenToBoMon"].Caption = "Tổ bộ môn";

            ArrayList arrIdGiaoVien = new ArrayList();
            for (int i = 0; i < gridView2.RowCount - 1; i++)
            {
                CriteriaOperator exprIdGiaoVien = new BinaryOperator("TenGiaoVien", gridView2.GetRowCellDisplayText(i, "IdGiaoVien"), BinaryOperatorType.NotEqual);
                arrIdGiaoVien.Add(exprIdGiaoVien);
            }
            CriteriaOperator[] criIdGiaoVien = new CriteriaOperator[arrIdGiaoVien.Count];
            int j = 0;
            foreach (CriteriaOperator criter in arrIdGiaoVien)
            {
                criIdGiaoVien[j] = criter;
                j++;
            }
            repositoryItemGridLookUpEdit1View.ActiveFilterEnabled = false;
            repositoryItemGridLookUpEdit1View.ActiveFilterEnabled = true;
            repositoryItemGridLookUpEdit1View.ActiveFilterCriteria = GroupOperator.And(criIdGiaoVien);

            if ((frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2) || (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3)) // nếu là quản trị hệ thống hay giảng viên ra đề
            {
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
                btnLuuPhanQuyen.Enabled = false;
                gridView2.OptionsBehavior.ReadOnly = true;
            }
            else
            {

                pqnch = new PhanQuyenNhapCauHoi_Public();
                pqnch.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                DataTable data = new DataTable();
                data = pqnch_bll.KiemTraPhanQuyenSoanCauHoi(pqnch);
                if (data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if ((GetInfoMonHoc[6] == data.Rows[i]["IdMucKienThuc"].ToString()) && (GetInfoMonHoc[7] == data.Rows[i]["IdMucTriNang"].ToString()))
                        {
                            splitContainerControl8.Visible = true;
                            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
                            splitContainerControl10.Visible = false;
                            splitContainerControl9.PanelVisibility = SplitPanelVisibility.Panel1;
                            splitContainerControl8.PanelVisibility = SplitPanelVisibility.Panel1;
                        }
                        else
                        {
                            splitContainerControl8.Visible = false;
                        }
                    }
                }

            }
        }

        private void pivotGridControlMaTranKienThuc_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            //xtraTabPage_SoanCauHoi.PageVisible = true;
            //xtraTabControl1.TabPages.Add(xtraTabPage_SoanCauHoi);
            //xtraTabControl1.SelectedTabPage = xtraTabPage_SoanCauHoi;
            //PivotGridField[] rowFields = e.GetRowFields();
            //MessageBox.Show(pivotGridControlMaTranKienThuc.GetFieldValue(rowFields[3], e.RowIndex).ToString());
            //PivotGridField[] columnFields = e.GetColumnFields();
            //MessageBox.Show(pivotGridControlMaTranKienThuc.GetFieldValue(columnFields[1], e.ColumnIndex).ToString());

            //frmMaTranKienThuc_Update frm = new frmMaTranKienThuc_Update(dt);
            //frm.ShowDialog();
            //cbbChonMonHoc_SelectedValueChanged(sender, e);

            // DataTable tbl = new DataTable();
            // if (pivotGridControlMaTranKienThuc.Cells.RowCount == 0) return;

            // List<PivotGridField> rowFields = c.GetFieldsByArea(PivotArea.RowArea);
            // foreach (PivotGridField rowField in rowFields)
            //     tbl.Columns.Add(rowField.ToString());
            // for (int i = 0; i < pivotGridControlMaTranKienThuc.Cells.ColumnCount; i++)
            //     tbl.Columns.Add(GetColumnFieldValueText(pivotGridControlMaTranKienThuc, pivotGridControlMaTranKienThuc.Cells.GetCellInfo(i, 0)));

            // //for (int rowIndex = 0; rowIndex < pivotGridControlMaTranKienThuc.Cells.RowCount; rowIndex++)
            // //{
            //     DataRow row = tbl.NewRow();
            //     DevExpress.XtraPivotGrid.PivotCellEventArgs cellInfo = pivotGridControlMaTranKienThuc.Cells.GetCellInfo(0, e.RowIndex);

            //     foreach (PivotGridField rowField in rowFields)
            //         row[rowField.AreaIndex] = cellInfo.GetFieldValue(rowField);

            //     for (int columnIndex = 0; columnIndex < pivotGridControlMaTranKienThuc.Cells.ColumnCount; columnIndex++)
            //         row[columnIndex + rowFields.Count] = cc.Cells.GetCellInfo(columnIndex, e.RowIndex).Value;
            //     tbl.Rows.Add(row);
            //// }
            // gridControl2.DataSource = tbl;

            //if (dt.Rows.Count == 0) return;
            //else
            //    MessageBox.Show(dt.Rows[0]["IdMucKienThuc"].ToString());

        }
        MaTranKienThuc_Public mtkt;
        bool CheckBtnCapNhatSLCauNhapQuyDinh;
        int SoCauNhap, SoCauQuyDinh;

        private void btn_CapNhatSLCauNhapQuyDinh_Click(object sender, EventArgs e)
        {
            int result;

            if (!int.TryParse(spinEdit_SoCauNhap.EditValue.ToString(), out result))
            {
                XtraMessageBox.Show("Số câu nhập phải là số nguyên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!int.TryParse(spinEdit_SoCauQuyDinh.EditValue.ToString(), out result))
            {
                XtraMessageBox.Show("Số câu quy định phải là số nguyên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int kq = 0;
            mtkt = new MaTranKienThuc_Public();

            mtkt.Mkt.IdMucKienThuc = dt.Rows[0]["IdMucKienThuc"].ToString();
            mtkt.Mtn.IdMucTriNang = dt.Rows[0]["IdMucTriNang"].ToString();
            mtkt.SoCauNhap = int.Parse(spinEdit_SoCauNhap.EditValue.ToString());
            mtkt.SoCauQuyDinh = int.Parse(spinEdit_SoCauQuyDinh.EditValue.ToString());
            kq = mtkt_bll.MaTranKienThuc_Update(mtkt);
            if (kq > 0)
            {
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CapNhatSLCauNhapQuyDinh.Enabled = false;
                btn_HuyBoSLCauNhapQuyDinh.Enabled = false;
                CheckBtnCapNhatSLCauNhapQuyDinh = true;
                SoCauNhap = mtkt.SoCauNhap;
                SoCauQuyDinh = mtkt.SoCauQuyDinh;
                cbbChonMonHoc_SelectedValueChanged(sender, e);
                try
                {
                    SystemLog_Public sys = new SystemLog_Public();
                    sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                    sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                    sys.MoTa = "Cập nhật lại số câu nhập, số câu quy định";
                    sys_bll.SystemLog_Insert(sys);
                }
                catch { }
            }
            else XtraMessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btn_HuyBoSLCauNhapQuyDinh_Click(object sender, EventArgs e)
        {
            if (CheckBtnCapNhatSLCauNhapQuyDinh == true)
            {
                spinEdit_SoCauNhap.EditValue = SoCauNhap;
                spinEdit_SoCauQuyDinh.EditValue = SoCauQuyDinh;
            }
            else
            {
                spinEdit_SoCauNhap.EditValue = dt.Rows[0]["Số câu nhập"].ToString();
                spinEdit_SoCauQuyDinh.EditValue = dt.Rows[0]["Số câu quy định"].ToString();
            }

        }
        void EnableBtnCapnhatHuybo()
        {
            btn_CapNhatSLCauNhapQuyDinh.Enabled = true;
            btn_HuyBoSLCauNhapQuyDinh.Enabled = true;
        }



        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ArrayList arrIdGiaoVien = new ArrayList();
            for (int i = 0; i < gridView2.RowCount - 1; i++)
            {
                CriteriaOperator exprIdGiaoVien = new BinaryOperator("TenGiaoVien", gridView2.GetRowCellDisplayText(i, "IdGiaoVien"), BinaryOperatorType.NotEqual);
                arrIdGiaoVien.Add(exprIdGiaoVien);
            }
            CriteriaOperator[] criIdGiaoVien = new CriteriaOperator[arrIdGiaoVien.Count];
            int j = 0;
            foreach (CriteriaOperator criter in arrIdGiaoVien)
            {
                criIdGiaoVien[j] = criter;
                j++;
            }
            repositoryItemGridLookUpEdit1View.ActiveFilterEnabled = false;
            repositoryItemGridLookUpEdit1View.ActiveFilterEnabled = true;
            repositoryItemGridLookUpEdit1View.ActiveFilterCriteria = GroupOperator.And(criIdGiaoVien);


        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {



        }
        PhanQuyenNhapCauHoi_Public pqnch;
        private void btnLuuPhanQuyen_Click(object sender, EventArgs e)
        {

            int kq = 0;
            DataRow dr;
            if (RowCount == 0)
            {
                for (int i = 0; i < gridView2.RowCount - 1; i++)
                {
                    pqnch = new PhanQuyenNhapCauHoi_Public();
                    dr = gridView2.GetDataRow(i);
                    try
                    {
                        pqnch.Gv.IdGiaoVien = int.Parse(dr["IdGiaoVien"].ToString());
                    }
                    catch { }
                    int result;
                    if (int.TryParse(dr["SoCauPhaiNhap"].ToString(), out result))
                    {
                        pqnch.SoCauPhaiNhap = int.Parse(dr["SoCauPhaiNhap"].ToString());
                        mtkt = new MaTranKienThuc_Public();
                        mtkt.Mkt.IdMucKienThuc = Dt.Rows[0]["IdMucKienThuc"].ToString();
                        mtkt.Mtn.IdMucTriNang = Dt.Rows[0]["IdMucTriNang"].ToString();

                        pqnch.Mtkt.IdMaTranKienThuc = mtkt_bll.MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(mtkt).Rows[0]["IdMaTranKienThuc"].ToString();
                        try
                        {
                            kq = kq + pqnch_bll.PhanQuyenNhapCauHoi_Insert(pqnch);
                        }
                        catch
                        {
                        }
                    }
                    else MessageBox.Show("Số Câu Phải Nhập phải là số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else
            {
                for (int i = RowCount; i < gridView2.RowCount - 1; i++)
                {
                    pqnch = new PhanQuyenNhapCauHoi_Public();
                    dr = gridView2.GetDataRow(i);
                    try
                    {
                        pqnch.Gv.IdGiaoVien = int.Parse(dr["IdGiaoVien"].ToString());
                    }
                    catch { }
                    int result;
                    if (int.TryParse(dr["SoCauPhaiNhap"].ToString(), out result))
                    {
                        pqnch.SoCauPhaiNhap = int.Parse(dr["SoCauPhaiNhap"].ToString());
                        mtkt = new MaTranKienThuc_Public();
                        mtkt.Mkt.IdMucKienThuc = Dt.Rows[0]["IdMucKienThuc"].ToString();
                        mtkt.Mtn.IdMucTriNang = Dt.Rows[0]["IdMucTriNang"].ToString();

                        pqnch.Mtkt.IdMaTranKienThuc = mtkt_bll.MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(mtkt).Rows[0]["IdMaTranKienThuc"].ToString();
                        try
                        {
                            kq = kq + pqnch_bll.PhanQuyenNhapCauHoi_Insert(pqnch);
                        }
                        catch
                        {

                        }
                    }
                    else MessageBox.Show("Số Câu Phải Nhập phải là số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (kq > 0)
                {
                    XtraMessageBox.Show("Phân quyền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = string.Format("{0} {1}", "Phân quyền soạn thảo cho môn", cbbChonMonHoc.SelectedText);
                        sys_bll.SystemLog_Insert(sys);
                    }
                    catch { }
                }
            }
        }

        private void xóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gridView2.OptionsBehavior.ReadOnly = false;
            gridView2.Columns["IdGiaoVien"].OptionsColumn.ReadOnly = false;
            gridView2.Columns["SoCauDaNhap"].OptionsColumn.ReadOnly = false;
        }

        private void xóaHếtToolStripMenuItem_Click(object sender, EventArgs e) // sửa phân quyền soạn thảo
        {
            gridView2.OptionsBehavior.ReadOnly = false;
            gridView2.Columns["IdGiaoVien"].OptionsColumn.ReadOnly = true;
            gridView2.Columns["SoCauDaNhap"].OptionsColumn.ReadOnly = true;
            gridView2.FocusedColumn = gridView2.VisibleColumns[1];
            gridView2.ShowEditor();
            gridView2.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
        }


        private void btnHuyPhanQuyen_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gridView2.IsNewItemRow(gridView2.FocusedRowHandle))
                btnLuuPhanQuyen.Enabled = true;
        }
        //MucTriNang_Public mtn;
        MucTriNang_BLL mtn_bll = new MucTriNang_BLL();
        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            int kq;

            if ((e.KeyValue == 13) && (!string.IsNullOrEmpty(gridView2.GetFocusedRowCellValue("IdMaTranKienThuc").ToString())))
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc chắn cập nhật lại Số Câu Phải Nhập cho giảng viên {0}", gridView2.GetFocusedRowCellDisplayText("IdGiaoVien")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    pqnch = new PhanQuyenNhapCauHoi_Public();
                    pqnch.Gv.IdGiaoVien = int.Parse(gridView2.GetFocusedRowCellValue("IdGiaoVien").ToString());
                    pqnch.Mtkt.IdMaTranKienThuc = gridView2.GetFocusedRowCellValue("IdMaTranKienThuc").ToString();
                    gridView2.FocusedColumn = gridView2.Columns["IdMaTranKienThuc"];
                    pqnch.SoCauPhaiNhap = int.Parse(gridView2.GetRowCellDisplayText(gridView2.FocusedRowHandle, gridView2.Columns["SoCauPhaiNhap"]));
                    kq = pqnch_bll.PhanQuyenNhapCauHoi_Update(pqnch);
                    if (kq > 0) XtraMessageBox.Show("Cập nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {
            if ((frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2) || (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3))
            {
                if (int.Parse(gridView2.Columns["SoCauPhaiNhap"].SummaryText) > int.Parse(spinEdit_SoCauNhap.EditValue.ToString()))
                {
                    btnLuuPhanQuyen.Enabled = false;
                    XtraMessageBox.Show("Tổng số câu phân quyền vượt quá số câu cần nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);
                }
                else btnLuuPhanQuyen.Enabled = true;
            }
        }

        private void xóaToolStripMenuItem5_Click(object sender, EventArgs e) // xóa phân quyền soạn thảo
        {
            int kq;
            if((gridView2.GetFocusedRowCellValue("IdMaTranKienThuc")==null)||(gridView2.GetFocusedRowCellValue("IdMaTranKienThuc").ToString()==""))
            {
                gridView2.DeleteRow(gridView2.FocusedRowHandle);
                return;
            }
            if ((gridView2.GetFocusedDataRow() != null) && XtraMessageBox.Show(string.Format("Xóa phân quyền cho giảng viên {0}", gridView2.GetFocusedRowCellDisplayText("IdGiaoVien")), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (int.Parse(gridView2.GetFocusedRowCellValue("SoCauDaNhap").ToString()) == 0)
                {
                    pqnch = new PhanQuyenNhapCauHoi_Public();
                    pqnch.Gv.IdGiaoVien = int.Parse(gridView2.GetFocusedRowCellValue("IdGiaoVien").ToString());
                    pqnch.Mtkt.IdMaTranKienThuc = gridView2.GetFocusedRowCellValue("IdMaTranKienThuc").ToString();
                    kq = pqnch_bll.PhanQuyenNhapCauHoi_Delete(pqnch);
                    gridControl_PhanQuyenNhapCauHoi.DataSource = pqnch_bll.PhanQuyenNhapCauHoi_Select_IdMaTranKienThuc(pqnch);
                }
                else
                {
                    XtraMessageBox.Show(string.Format("Giảng viên {0} đã thực hiện soạn câu hỏi, Thay vì Xóa thì hãy thiết lập lại Số câu phải nhập", gridView2.GetFocusedRowCellDisplayText("IdGiaoVien")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void treeListMucKienThuc_ShowingEditor(object sender, CancelEventArgs e)
        {
            if ((treeListMucKienThuc.FocusedNode.Level == 4) || (treeListMucKienThuc.FocusedNode.Level == 0))
            {
                e.Cancel = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // đi đến vùng soạn thảo
        {
            ShowTabSoanCauHoi();

            treeList_ThongTinKienThucST.ClearNodes();
            CreateColumns(treeList_ThongTinKienThucST);
            CreateNode(treeList_ThongTinKienThucST, GetInfoMonHoc);
            treeList_ThongTinKienThucST.ExpandAll();
            dt = new DataTable();
            pqnch = new PhanQuyenNhapCauHoi_Public();
            pqnch.Mtkt.IdMaTranKienThuc = GetInfoMonHoc[10];
            pqnch.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            dt = pqnch_bll.PhanQuyenNhapCauHoi_Select_IdMaTranIdGiaoVien(pqnch);
            if (dt.Rows.Count > 0)
            {
                lb_SoCauPhaiNhap.Text = dt.Rows[0]["SoCauPhaiNhap"].ToString();
                lb_SoCauDaNhap.Text = dt.Rows[0]["SoCauDaNhap"].ToString();
            }
            else
            {
                lb_SoCauPhaiNhap.Text = "";
                lb_SoCauDaNhap.Text = "";
            }

        }
        void ShowTabMaTranKienThuc()
        {
            xtraTabPageMaTranKienThuc.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPageMaTranKienThuc);
            xtraTabControl1.SelectedTabPage = xtraTabPageMaTranKienThuc;
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            ChonKhoa();
            if ((frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2) || (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3))
            {
                treeListMucKienThuc.ContextMenuStrip = contextMenuStrip_MonHoc;
            }
        }
        DoKho_BLL dk_bll = new DoKho_BLL();
        //DoKho_Public dk;
        LoaiCauHoi_BLL lch_bll = new LoaiCauHoi_BLL();
        //LoaiCauHoi_Public lch;
        void ShowTabSoanCauHoi()
        {

            xtraTabPage_SoanCauHoi.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_SoanCauHoi);
            xtraTabControl1.SelectedTabPage = xtraTabPage_SoanCauHoi;

            //splitContainerControl15.PanelVisibility = SplitPanelVisibility.Panel2;
            splitContainerControl15.SplitterPosition = 117;
            //btn_ShowHideVungSoanGTC.ImageIndex = 8;
            cbb_DoKho.DataSource = dk_bll.DoKho_Select();
            cbb_DoKho.DisplayMember = "TenDoKho";
            cbb_DoKho.ValueMember = "IdDoKho";
            dt = new DataTable();
            dt = lch_bll.LoaiCauHoi_Select();

            if (dt.Rows.Count > 0)
            {
                radioGroup_LuaChonDangCauHoi.Properties.Items.Clear(); // remove item trước đó

                object[] itemValues = new object[dt.Rows.Count];
                string[] itemDescriptions = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    itemValues[i] = dt.Rows[i]["IdLoaiCauHoi"].ToString();
                    itemDescriptions[i] = dt.Rows[i]["TenLoaiCauHoi"].ToString();
                    radioGroup_LuaChonDangCauHoi.Properties.Items.Add(new RadioGroupItem(itemValues[i], itemDescriptions[i]));
                }
                radioGroup_LuaChonDangCauHoi.SelectedIndex = 0;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // đi đến ma trận kiến thức
        {
            ShowTabMaTranKienThuc();
        }

        private void spinEdit_SoCauNhap_EditValueChanged(object sender, EventArgs e)
        {
            EnableBtnCapnhatHuybo();
        }

        private void spinEdit_SoCauQuyDinh_EditValueChanged(object sender, EventArgs e)
        {
            EnableBtnCapnhatHuybo();
        }

        private void radioGroup_LuaChonDangCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            switch (radioGroup_LuaChonDangCauHoi.SelectedIndex)
            {
                case 0:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    //dt.Columns.Add(new DataColumn("DapAn"));
                    DataColumn dc = new DataColumn("DapAn");
                    dc.DataType = System.Type.GetType("System.Boolean");
                    DataColumn dc1 = new DataColumn("CoDinh") { DataType = System.Type.GetType("System.Boolean") };
                    dt.Columns.Add(dc1);
                    dt.Columns.Add(dc);
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    gridView1.Columns["DapAn"].Visible = true;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridView1.Columns["CoDinh"].Visible = true;
                    gridView1.Columns["CoDinh"].Caption = "Chọn đáp án cố định";
                    gridControl_CauTraLoiVaDapAn.Enabled = true;
                    break;
                case 1:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    //dt.Columns.Add(new DataColumn("DapAn"));
                    DataColumn dc2 = new DataColumn("DapAn");
                    dc2.DataType = System.Type.GetType("System.Boolean");
                    dt.Columns.Add(dc2);
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    gridView1.Columns["DapAn"].Visible = true;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridControl_CauTraLoiVaDapAn.Enabled = true;
                    break;
                case 2:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("DapAn"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridControl_CauTraLoiVaDapAn.Enabled = true;
                    break;
                case 3:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("NoiDung2"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    gridView1.Columns["NoiDung1"].Caption = "Mệnh đề 1";
                    gridView1.Columns["NoiDung2"].Caption = "Mệnh đề 2";
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = true;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridControl_CauTraLoiVaDapAn.Enabled = true;
                    break;

                case 4:
                    gridControl_CauTraLoiVaDapAn.Enabled = false;
                    break;
                case 5:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("DapAn"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridControl_CauTraLoiVaDapAn.Enabled = true;

                    break;
                default:

                    break;
            }
        }

        private void richEditControl_SoanGiaThietChung_Click(object sender, EventArgs e)
        {
            richEditBarController1.RichEditControl = richEditControl_SoanGiaThietChung;
        }

        private void richEditControl_SoanCauHoi_Click(object sender, EventArgs e)
        {
            if (ribbonControl1.Visible == true)
                richEditBarController1.RichEditControl = richEditControl_SoanCauHoi;
            else
                richEditBarController2.RichEditControl = richEditControl_SoanCauHoi;

        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {

            if ((radioGroup_LuaChonDangCauHoi.SelectedIndex == 1) && (gridView1.RowCount > 2))
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if ((radioGroup_LuaChonDangCauHoi.SelectedIndex == 5) && (gridView1.RowCount > 1))
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }
        CauHoi_Public Question;
        GiaThietChung_Public gtc;
        CauTraLoi_Public Answer;
        CauHoi_BLL Question_bll = new CauHoi_BLL();
        CauTraLoi_BLL Answer_bll = new CauTraLoi_BLL();
        static RichEditControl Rec = new RichEditControl(); // lưu giữ nội dung của giả thiết chung sau khi insert
        static int SetIdGiaThietChung; // lưu giữu id giả thiết chung cho trường hợp chọn GTC ở ngân hàng sau đó tiếp tục soạn vs giả thiết này
        private void btn_LuuCauHoi_Click(object sender, EventArgs e)
        {
            //RichEditControl documentImage = new RichEditControl();
            //int start = documentImage.Range.Start.ToInt();
            //MemoryStream ms = new MemoryStream();
            //documentImage.Image.NativeImage.Save(ms, ImageFormat.Jpeg);
            //richEditControl1.Document.Delete(documentImage.Range);
            //ms.Position = 0;
            //richEditControl1.Document.InsertImage(richEditControl1.Document.CreatePosition(start), Image.FromStream(ms));

            int kq1 = 0, kq2 = 0;
            gtc = new GiaThietChung_Public();
            try
            {
                Question = new CauHoi_Public();
                if (XtraMessageBox.Show("Bạn có muốn công khai duyệt câu hỏi này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Question.CongKhai = 1;
                else Question.CongKhai = 0;
                Question.Dk.IdDoKho = cbb_DoKho.SelectedValue.ToString();
                Question.Lch.IdLoaiCauHoi = int.Parse(radioGroup_LuaChonDangCauHoi.Properties.Items[radioGroup_LuaChonDangCauHoi.SelectedIndex].Value.ToString());
                Question.NgayTao = DateTime.Now;
                Question.NgayCapNhat = DateTime.Now;
                Question.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                Question.Mh.IdMonHoc = int.Parse(GetInfoMonHoc[0]);

            }
            catch { }

            if (string.IsNullOrEmpty(GetInfoMonHoc[10]))
            {
                XtraMessageBox.Show("Bạn chưa chọn phần kiến thức cho câu hỏi! Hãy quay lại ma trận kiến thức để chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ShowTabMaTranKienThuc();
                return;
            }
            else Question.Mtkt.IdMaTranKienThuc = GetInfoMonHoc[10];


            if (frmCustomGiaThietChung.GetIndexSelected == 1)  // nhập mới
            {
                if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
                {
                    XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                    Question.NoiDung = richEditControl_SoanCauHoi.RtfText;

                if (richEditControl_SoanGiaThietChung.Document.IsEmpty == true)
                {
                    XtraMessageBox.Show("Bạn chưa nhập giả thiết chung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                //else
                //{
                //    gtc.NoiDung = richEditControl_SoanGiaThietChung.RtfText;
                //}
                if (!richEditControl_SoanGiaThietChung.Document.RtfText.Equals(Rec.Document.RtfText)) // nếu nội dung trước và sau của GTC khác nhau
                {
                    gtc.NoiDung = richEditControl_SoanGiaThietChung.RtfText;

                    kq1 = Question_bll.CauHoiGiaThietChung_Insert(Question, gtc);
                }
                else
                {
                    kq1 = Question_bll.CauHoi_Insert_IndentCurrent(Question);
                }
                Rec.Document.RtfText = richEditControl_SoanGiaThietChung.Document.RtfText; // gán lại để kiểm tra sự thay đổi sau khi lưu (Nội dung GTC)
            }
            else
                if (frmCustomGiaThietChung.GetIndexSelected == 2)
                {
                    Question.Gtc.IdGiaThietChung = frmCustomGiaThietChung.GetIdGiaThietChung;
                    if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
                    {
                        XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                        Question.NoiDung = richEditControl_SoanCauHoi.RtfText;
                    kq1 = Question_bll.CauHoi_Insert(Question);
                    SetIdGiaThietChung = frmCustomGiaThietChung.GetIdGiaThietChung; // gán lại để kiểm tra sự thay đổi sau khi lưu thay (ID GTC)
                }
                else
                {
                    Question.Gtc.IdGiaThietChung = 0;
                    if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
                    {
                        XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                        Question.NoiDung = richEditControl_SoanCauHoi.Document.RtfText;
                    kq1 = Question_bll.CauHoi_Insert(Question);
                }

            //if (btn_ShowHideVungSoanGTC.Text == "Không soạn với giả thiết chung") // khi nút sử dụng giả thiết chung được click
            //{
            //    if (frmCustomGiaThietChung.GetIdGiaThietChung == 0)  // nhập mới
            //    {
            //        if (richEditControl_SoanGiaThietChung.Document.IsEmpty == true)
            //        {
            //            XtraMessageBox.Show("Bạn chưa nhập giả thiết chung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            return;
            //        }
            //        else
            //            gtc.NoiDung = richEditControl_SoanGiaThietChung.RtfText;
            //        if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
            //        {
            //            XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            return;
            //        }
            //        Question.NoiDung = richEditControl_SoanCauHoi.RtfText;
            //        kq1 = Question_bll.CauHoiGiaThietChung_Insert(Question, gtc);  
            //    }
            //    else 
            //    {
            //        Question.Gtc.IdGiaThietChung = frmCustomGiaThietChung.GetIdGiaThietChung;
            //        if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
            //        {
            //            XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            return;
            //        }
            //        Question.NoiDung = richEditControl_SoanCauHoi.RtfText;
            //        kq1 = Question_bll.CauHoi_Insert(Question);
            //    }
            //}
            //else
            //{
            //    Question.Gtc.IdGiaThietChung = 0;
            //    if (richEditControl_SoanCauHoi.Document.IsEmpty == true)
            //    {
            //        XtraMessageBox.Show("Bạn chưa nhập nội dung cho câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        return;
            //    }
            //    Question.NoiDung = richEditControl_SoanCauHoi.Document.RtfText;
            //    kq1 = Question_bll.CauHoi_Insert(Question);
            //}

            if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 0)  // nếu là dạng đa lựa chọn
            {
                for (int i = 0; i < gridView1.RowCount - 1; i++)
                {
                    Answer = new CauTraLoi_Public();
                    Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                    try
                    {
                        Answer.CoDinh = Convert.ToBoolean(gridView1.GetDataRow(i)["CoDinh"].ToString());

                    }
                    catch { }
                    try
                    {
                        Answer.DapAn = Convert.ToBoolean(gridView1.GetDataRow(i)["DapAn"].ToString());
                    }
                    catch { }
                    kq2 = kq2 + Answer_bll.CauTraLoi_Insert(Answer);
                }
            }
            else
                if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 1) // dạng đúng/sai
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        Answer = new CauTraLoi_Public();
                        try
                        {
                            Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                            Answer.DapAn = bool.Parse(gridView1.GetDataRow(i)["DapAn"].ToString());
                        }
                        catch { }
                        kq2 = kq2 + Answer_bll.CauTraLoi_Insert(Answer);
                    }
                }
                else
                    if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 2) // dạng điền khuyết
                    {
                        for (int i = 0; i < gridView1.RowCount - 1; i++)
                        {
                            Answer = new CauTraLoi_Public();
                            try
                            {
                                Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                            }
                            catch { }
                            kq2 = kq2 + Answer_bll.CauTraLoi_Insert(Answer);
                        }
                    }
                    else
                        if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 5) //dạng trả lời ngắn
                        {
                            Answer = new CauTraLoi_Public();
                            try
                            {
                                Answer.NoiDung1 = gridView1.GetDataRow(0)["NoiDung1"].ToString();
                            }
                            catch { }
                            kq2 = kq2 + Answer_bll.CauTraLoi_Insert(Answer);
                        }
                        else
                            if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 4) //dạng hình ảnh
                            {
                                Answer = new CauTraLoi_Public();
                                RichEditControl r=new RichEditControl();
                                if (!string.IsNullOrEmpty(frmLayToaDoAnh.chuoi))
                                {
                                    r.Text = frmLayToaDoAnh.chuoi;
                                    Answer.NoiDung1 = r.RtfText;
                                    kq2 = Answer_bll.CauTraLoi_Insert(Answer);
                                }
                            }

                            else
                                if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 3) // dạng ghép đôi
                                {
                                    for (int i = 0; i < gridView1.RowCount - 1; i++)
                                    {
                                        Answer = new CauTraLoi_Public();
                                        try
                                        {
                                            RichEditControl r = new RichEditControl();
                                            r.RtfText = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                            if (string.IsNullOrEmpty(r.Text.Trim()))
                                                Answer.NoiDung1 = null;
                                            else Answer.NoiDung1 = r.RtfText;
                                            Answer.NoiDung2 = gridView1.GetDataRow(i)["NoiDung2"].ToString();
                                        }
                                        catch { }
                                        kq2 = kq2 + Answer_bll.CauTraLoi_Insert(Answer);
                                    }
                                }

            if ((kq1 > 0) && (kq2 > 0))
            {
                pqnch = new PhanQuyenNhapCauHoi_Public();
                pqnch.Mtkt.IdMaTranKienThuc = GetInfoMonHoc[10];
                pqnch.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                dt = pqnch_bll.PhanQuyenNhapCauHoi_Select_IdMaTranIdGiaoVien(pqnch);
                if (dt.Rows.Count > 0)
                {
                    lb_SoCauPhaiNhap.Text = dt.Rows[0]["SoCauPhaiNhap"].ToString();
                    lb_SoCauDaNhap.Text = dt.Rows[0]["SoCauDaNhap"].ToString();
                }
                else
                {
                    lb_SoCauPhaiNhap.Text = "...";
                    lb_SoCauDaNhap.Text = "...";
                }
                XtraMessageBox.Show("Thêm câu hỏi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Soạn câu hỏi";
                sys_bll.SystemLog_Insert(sys);
            }

        }
        private void cbbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbm = new ToBoMon_Public();
                tbm.Khoa.IdKhoa = int.Parse(cbbChonKhoa.SelectedValue.ToString());
                cbbChonToBoMon.DisplayMember = "TenToBoMon";
                cbbChonToBoMon.ValueMember = "IdToBoMon";
                cbbChonToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
            }
            catch
            { }
        }

        private void cbbChonToBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbm = new ToBoMon_Public();
                tbm.IdToBoMon = int.Parse(cbbChonToBoMon.SelectedValue.ToString());

                cbbChonMonHoc.DisplayMember = "TenMonHoc";
                cbbChonMonHoc.ValueMember = "IdMonHoc";
                cbbChonMonHoc.DataSource = mhbll.MonHoc_Select_IdToBoMon(tbm);
            }
            catch { }

        }
        private void navBarItemNganHangCauHoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPageNganHangCauHoi.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPageNganHangCauHoi);
            xtraTabControl1.SelectedTabPage = xtraTabPageNganHangCauHoi;
            gridView4.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView4.OptionsView.ColumnAutoWidth = false;
            ShowTabDanhMucCauHoiCanDuyet();
        }
        void ShowTabDanhMucCauHoiCanDuyet()
        {
            mh = new MonHoc_Public();
            mh.ToBoMon.IdToBoMon = int.Parse(frm_DangNhap.GetIdToBoMon.ToString());
            dt = new DataTable();
            dt = mhbll.MonHoc_Select_IdToBoMon(mh);
            cbbChonMonHoc_TabNganHangSoBo.DisplayMember = "TenMonHoc";
            cbbChonMonHoc_TabNganHangSoBo.ValueMember = "IdMonHoc";
            cbbChonMonHoc_TabNganHangSoBo.DataSource = dt;

        }
        void ShowTabSoBoNganHang()
        {
            Count = 0;
            if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3)
            {
                comboBox1.DisplayMember = "TenMonHoc";
                comboBox1.ValueMember = "IdMonHoc";
                comboBox1.DataSource = mhbll.MonHoc_Select();
                comboBox1.SelectedIndex = -1;
            }
            else
                //if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2)
                {
                    mh = new MonHoc_Public();
                    mh.ToBoMon.IdToBoMon = int.Parse(frm_DangNhap.GetIdToBoMon.ToString());
                    dt = new DataTable();
                    dt = mhbll.MonHoc_Select_IdToBoMon(mh);
                    comboBox1.DisplayMember = "TenMonHoc";
                    comboBox1.ValueMember = "IdMonHoc";
                    comboBox1.DataSource = dt;
                    comboBox1.SelectedIndex = -1;
                }
        }


        private void cbbChonMonHoc_TabNganHangSoBo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbChonMonHoc_TabNganHangSoBo.SelectedValue == null) return;

            //string TenMonHoc = cbbChonMonHoc_TabNganHangSoBo.Text;
            int IDMonHoc = int.Parse(cbbChonMonHoc_TabNganHangSoBo.SelectedValue.ToString());
            //treeListKienThuc_TabNganHangSoBo.ClearNodes();
            //CreateColumns(treeListKienThuc_TabNganHangSoBo);
            //CreateNodes(treeListKienThuc_TabNganHangSoBo, TenMonHoc, IDMonHoc);
            //treeListKienThuc_TabNganHangSoBo.ExpandAll();

            Question = new CauHoi_Public();
            Question.Mh.IdMonHoc = IDMonHoc;
            Question.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            gridControl1.DataSource = Question_bll.CauHoi_Select_IdMonHoc(Question);
        }

        private void gridView4_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridView4.OptionsView.RowAutoHeight = true;
        }

        private void btnTuyChonGiaThietChung_Click(object sender, EventArgs e)
        {

            frmCustomGiaThietChung frm = new frmCustomGiaThietChung();
            frm.ShowDialog();
            if (frmCustomGiaThietChung.GetIndexSelected == 0)
            {
                richEditControl_SoanGiaThietChung.Enabled = true;
                splitContainerControl15.SplitterPosition = 117;
                richEditControl_SoanGiaThietChung.Document.RtfText = frmCustomGiaThietChung.recContent.Document.RtfText;
            }
            else
            {
                splitContainerControl15.SplitterPosition = 250;
                richEditControl_SoanGiaThietChung.Document.RtfText = frmCustomGiaThietChung.recContent.Document.RtfText;
                if (frmCustomGiaThietChung.GetIndexSelected == 1)
                    richEditControl_SoanGiaThietChung.Enabled = true;
                else
                    richEditControl_SoanGiaThietChung.Enabled = false;
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            richEditControl_SoanCauHoi.Document.Delete(richEditControl_SoanCauHoi.Document.Range);
            richEditControl_SoanCauHoi.Focus();
            gridView1.SelectAll();
            gridView1.DeleteSelectedRows();
            gridView1.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
        }
        GiaThietChung_BLL gtc_bll = new GiaThietChung_BLL();
        CauTraLoi_BLL ctl_bll = new CauTraLoi_BLL();
        CauTraLoi_Public ctl;
        char[] GetListCharItem(int Npar) // hàm trả về list kí tự A-->Z
        {
            string[] CharList = new string[26];
            char[] CharListItem = new char[Npar];
            for (int i = 0; i < 26; i++)
            {
                CharList[i] = Convert.ToChar(i + 65).ToString();
            }
            for (int i = 0; i < Npar; i++)
            {
                CharListItem[i] = char.Parse(CharList[i]);
            }
            return CharListItem;
        }
        void InsertInRichEdit(RichEditControl ric, GridView gv, string IdGiaThietChung, int IdCauHoi, int IdLoaiCauHoi)
        {
            ric.Document.Delete(ric.Document.Range);
            DocumentPosition pos = ric.Document.CaretPosition;
            string GetIdGiaThietChung = IdGiaThietChung;
            int GetIdCauHoi = IdCauHoi;
            int GetIdLoaiCauHoi = IdLoaiCauHoi;
            int result;
            int Npar;

            dt = new DataTable();
            if (int.TryParse(GetIdGiaThietChung, out result)) // kiểm tra câu hỏi có giả thiết chung hay không
            {
                try
                {
                    GiaThietChung_Public gtc = new GiaThietChung_Public();
                    gtc.IdGiaThietChung = result;
                    dt = gtc_bll.GiaThietChung_Select_NoiDung(gtc);
                    string GetNoiDung = dt.Rows[0][0].ToString();
                    ric.Document.InsertRtfText(pos, GetNoiDung);
                    ric.Document.InsertText(pos, Characters.LineBreak.ToString()); // ngắt dòng
                }
                catch { }
            }
            ric.Document.InsertRtfText(pos, gv.GetDataRow(rowHandle)["NoiDung"].ToString()); // chèn nội dung câu hỏi vảo richedit
            ric.Document.InsertText(pos, Characters.LineBreak.ToString()); // ngắt dòng
            ctl = new CauTraLoi_Public();
            ctl.CauHoi.IdCauHoi = GetIdCauHoi;
            DataTable dt1 = new DataTable();
            dt1 = ctl_bll.CauTraLoi_Select_IdCauHoi(ctl);
            if (dt1.Rows.Count > 0)
            {
                Rec = new RichEditControl();
                Npar = dt1.Rows.Count;
                if ((GetIdLoaiCauHoi == 1) || (GetIdLoaiCauHoi == 2)) // loại đa lựa chọn or đúng sai
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        ric.Document.InsertText(pos, GetListCharItem(Npar)[i] + ". ");
                        pos = ric.Document.Range.End;
                        if (bool.Parse(dt1.Rows[i]["DapAn"].ToString()))
                        {
                            Rec.Document.RtfText = dt1.Rows[i]["NoiDung1"].ToString();
                            CharacterProperties characterProperties = Rec.Document.BeginUpdateCharacters(Rec.Document.Range);
                            //Change font
                            characterProperties.ForeColor = Color.Red;
                            ////End update
                            Rec.Document.EndUpdateCharacters(characterProperties);
                            ric.Document.InsertRtfText(pos, Rec.Document.RtfText);
                        }
                        else
                        {
                            ric.Document.InsertRtfText(pos, dt1.Rows[i]["NoiDung1"].ToString());
                        }
                    }
                }
                else
                    if ((GetIdLoaiCauHoi == 6)||(GetIdLoaiCauHoi == 5)) // dạng trả lời ngắn
                    {
                        Rec.Document.RtfText = dt1.Rows[0]["NoiDung1"].ToString();
                        CharacterProperties characterProperties = Rec.Document.BeginUpdateCharacters(Rec.Document.Range);
                        //Change font
                        characterProperties.ForeColor = Color.Red;
                        ////End update
                        Rec.Document.EndUpdateCharacters(characterProperties);
                        ric.Document.InsertRtfText(pos, Rec.Document.RtfText);
                    }
                    else
                        if (GetIdLoaiCauHoi == 3) // dạng điền khuyết
                        {
                            for (int i = 0; i < Npar; i++)
                            {
                                ric.Document.InsertText(pos, GetListCharItem(Npar)[i] + ". ");
                                pos = ric.Document.Range.End;
                                Rec.Document.RtfText = dt1.Rows[i]["NoiDung1"].ToString();
                                CharacterProperties characterProperties = Rec.Document.BeginUpdateCharacters(Rec.Document.Range);
                                //Change font
                                characterProperties.ForeColor = Color.Red;
                                ////End update
                                Rec.Document.EndUpdateCharacters(characterProperties);
                                ric.Document.InsertRtfText(pos, Rec.Document.RtfText);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < Npar; i++)
                            {
                                Rec.Document.RtfText = dt1.Rows[i]["NoiDung1"].ToString();
                                if ((Rec.Text.Trim()!="")&&(!string.Equals(Rec.Document.Text.Trim(), null)))
                                {
                                    ric.Document.InsertText(pos, GetListCharItem(Npar)[i] + ". ");
                                    pos = ric.Document.Range.End;
                                    ric.Document.InsertRtfText(pos, Rec.Document.RtfText);
                                }
                            }
                            for (int i = 0; i < Npar; i++)
                            {
                                Rec.Document.RtfText = dt1.Rows[i]["NoiDung2"].ToString();
                                if (!string.Equals(Rec.Document.Text.Trim(), ""))
                                {
                                    ric.Document.InsertText(pos, (i + 1).ToString() + ". ");
                                    pos = ric.Document.Range.End;
                                    ric.Document.InsertRtfText(pos, Rec.Document.RtfText);
                                }
                            }
                        }
            }
            else
                XtraMessageBox.Show("Câu hỏi này chưa có câu trả lời hoặc đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void CheckDuyet(int IdCauHoi)
        {
            ttd = new ThongTinDuyet_Public();
            ttd.CauHoi.IdCauHoi = IdCauHoi;
            ttd.GiaoVien.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            dt = new DataTable();
            dt = ttd_bll.ThongTinDuyet_Select(ttd);
            if (dt.Rows.Count > 0)
                btnDuyet.Enabled = false;
            else btnDuyet.Enabled = true;
        }
        ThaoLuan_BLL tl_bll = new ThaoLuan_BLL();
        ThaoLuan_Public tl;
        void LoadDataTableThaoLuan()
        {
            tl = new ThaoLuan_Public();
            tl.CauHoi.IdCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdCauHoi"].ToString());

            dt = new DataTable();
            dt = tl_bll.ThaoLuan_Select(tl);
            gridControl2.DataSource = dt;
            gridView5.MakeRowVisible(dt.Rows.Count - 1);
        }
        int rowHandle;
        private void gridView4_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnBoQua.Enabled = true;
            rowHandle = gridView4.FocusedRowHandle;
            string GetIdGiaThietChung = gridView4.GetDataRow(rowHandle)["IdGiaThietChung"].ToString();
            int GetIdCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdCauHoi"].ToString());
            int GetIdLoaiCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdLoaiCauHoi"].ToString());
            InsertInRichEdit(richEditControl_NganHangSoBo, gridView4, GetIdGiaThietChung, GetIdCauHoi, GetIdLoaiCauHoi); // hàm insert rtf vào rich
            CheckDuyet(GetIdCauHoi); // hàm kiểm tra câu hỏi đã duyệt chưa
            LoadDataTableThaoLuan();

        }

        private void mứcTríNăngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMucTriNang frm = new frmMucTriNang(SetIdMucKienThuc);
            frm.ShowDialog();
            cbbChonMonHoc_SelectedValueChanged(sender, e); // load lại sau khi thay đổi ở form MucTriNang   
        }

        private void chươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(SetIdMonHoc, out result))
            {
                frmChuong frm = new frmChuong(result);
                frm.ShowDialog();
                cbbChonMonHoc_SelectedValueChanged(sender, e);
            }
        }

        private void chủĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(SetIdChuong, out result))
            {
                frmChuDe frm = new frmChuDe(result);
                frm.ShowDialog();
                cbbChonMonHoc_SelectedValueChanged(sender, e);
            }
        }

        private void mụcKiếnThứcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(SetIdChuDe, out result))
            {
                frmMucKienThuc frm = new frmMucKienThuc(result);
                frm.ShowDialog();
                cbbChonMonHoc_SelectedValueChanged(sender, e);

            }
        }
        private void clbShowFindColumn_TabNganHangSoBo_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (clbShowFindColumn_TabNganHangSoBo.Items[0].CheckState == CheckState.Checked)
                gridView4.Columns["TenDoKho"].Visible = true;
            else gridView4.Columns["TenDoKho"].Visible = false;
            if (clbShowFindColumn_TabNganHangSoBo.Items[1].CheckState == CheckState.Checked)
                gridView4.Columns["DoPhanCach"].Visible = true;
            else gridView4.Columns["DoPhanCach"].Visible = false;
            if (clbShowFindColumn_TabNganHangSoBo.Items[2].CheckState == CheckState.Checked)
                gridView4.Columns["NgayTao"].Visible = true;
            else gridView4.Columns["NgayTao"].Visible = false;
            if (clbShowFindColumn_TabNganHangSoBo.Items[3].CheckState == CheckState.Checked)
                gridView4.Columns["NgayCapNhat"].Visible = true;
            else gridView4.Columns["NgayCapNhat"].Visible = false;
            if (clbShowFindColumn_TabNganHangSoBo.Items[4].CheckState == CheckState.Checked)
                gridView4.Columns["TenLoaiCauHoi"].Visible = true;
            else gridView4.Columns["TenLoaiCauHoi"].Visible = false;
            if (clbShowFindColumn_TabNganHangSoBo.Items[5].CheckState == CheckState.Checked)
                gridView4.Columns["TenGiaoVien"].Visible = true;
            else gridView4.Columns["TenGiaoVien"].Visible = false;
        }
        ThongTinDuyet_BLL ttd_bll = new ThongTinDuyet_BLL();
        ThongTinDuyet_Public ttd;
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            int kq;
            ttd = new ThongTinDuyet_Public();
            try
            {
                ttd.CauHoi.IdCauHoi = int.Parse(gridView4.GetFocusedRowCellValue("IdCauHoi").ToString());
                ttd.GiaoVien.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                kq = ttd_bll.ThongTinDuyet_Insert(ttd);
                if (kq > 0)
                {
                    XtraMessageBox.Show("Đã duyệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDuyet.Enabled = false;
                    gridView4.DeleteRow(rowHandle);
                    try
                    {
                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = string.Format("{0} {1}", "Duyệt câu hỏi có mã là",ttd.CauHoi.IdCauHoi);
                        sys_bll.SystemLog_Insert(sys);
                    }
                    catch { }

                }
                else
                    XtraMessageBox.Show("Duyệt thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (rowHandle == gridView4.RowCount - 1)
                rowHandle = 0;
            else
                rowHandle++;

            string GetIdGiaThietChung = gridView4.GetDataRow(rowHandle)["IdGiaThietChung"].ToString();
            int GetIdCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdCauHoi"].ToString());
            int GetIdLoaiCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdLoaiCauHoi"].ToString());
            InsertInRichEdit(richEditControl_NganHangSoBo, gridView4, GetIdGiaThietChung, GetIdCauHoi, GetIdLoaiCauHoi);
            CheckDuyet(GetIdCauHoi);
            LoadDataTableThaoLuan();
        }

        private void btnLuuNoiDungThaoLuan_Click(object sender, EventArgs e)
        {
            tl = new ThaoLuan_Public();
            tl.GiaoVien.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            tl.NoiDung = meNoiDungThaoLuan.EditValue.ToString();
            tl.CauHoi.IdCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdCauHoi"].ToString());
            int kq = tl_bll.ThaoLuan_Insert(tl);
            LoadDataTableThaoLuan();
            meNoiDungThaoLuan.ResetText();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e) // xóa thảo luận tab ngân hàng sơ bộ
        {
            if (gridView5.RowCount > 0)
            {
                int rowHandle = gridView5.FocusedRowHandle;
                tl = new ThaoLuan_Public();
                tl.IdThaoLuan = int.Parse(gridView5.GetDataRow(rowHandle)["IdThaoLuan"].ToString());
                int kq = tl_bll.ThaoLuan_Delete(tl);
                if (kq > 0)
                    gridView5.DeleteRow(rowHandle);
            }
        }

        private void xóaHếtToolStripMenuItem_Click_1(object sender, EventArgs e) // xóa hết thảo luận tab ngân hàng sơ bộ
        {
            if (gridView5.RowCount > 0)
            {
                int kq = 0;
                //int[] ListIdThaoLuan = new int[gridView5.SelectedRowsCount];
                //int[] ListRowHandle = gridView5.GetSelectedRows();
                //for (int i = 0; i < ListIdThaoLuan.Length; i++)
                //{
                //    ListIdThaoLuan[i]=int.Parse(gridView5.GetDataRow(ListRowHandle[i])["IdThaoLuan"].ToString());
                //}
                //for (int i = 0; i < ListRowHandle.Length; i++)
                //{
                //    tl=new ThaoLuan_Public();
                //    tl.IdThaoLuan=ListIdThaoLuan[i];
                //    kq=tl_bll.ThaoLuan_Delete(tl);
                //}
                tl = new ThaoLuan_Public();
                tl.CauHoi.IdCauHoi = int.Parse(gridView4.GetDataRow(rowHandle)["IdCauHoi"].ToString());
                kq = tl_bll.ThaoLuan_Delete_IdCauHoi(tl);
                if (kq > 0)
                {
                    XtraMessageBox.Show("Đã xóa hết !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView5.SelectAll();
                    gridView5.DeleteSelectedRows();
                }
            }

        }

        private void TabMaTranKienThuc_btnThemToBoMon_Click(object sender, EventArgs e)
        {
            frmToBoMon frm = new frmToBoMon();
            frm.ShowDialog();
        }

        private void toolStripMenuItem_TaoTaiKhoan_Click(object sender, EventArgs e)
        {

            toolStripMenuItem_TaoTaiKhoan.Enabled = true;
            frmQuanLyGiaoVien frm = new frmQuanLyGiaoVien();
            frm.ShowDialog();
        }

        private void clbShowFindColumn_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (clbShowFindColumn.Items[0].CheckState == CheckState.Checked)
            {
                gridView6.Columns["IdDoKho"].Visible = true;
                repositoryItemLookUpEdit_DoKhoTabNganHangSoBo.DataSource = dk_bll.DoKho_Select();
                repositoryItemLookUpEdit_DoKhoTabNganHangSoBo.DisplayMember = "TenDoKho";
                repositoryItemLookUpEdit_DoKhoTabNganHangSoBo.ValueMember = "IdDoKho";
            }
            else gridView6.Columns["IdDoKho"].Visible = false;
            if (clbShowFindColumn.Items[1].CheckState == CheckState.Checked)
                gridView6.Columns["DoPhanCach"].Visible = true;
            else gridView6.Columns["DoPhanCach"].Visible = false;
            if (clbShowFindColumn.Items[2].CheckState == CheckState.Checked)
                gridView6.Columns["NgayTao"].Visible = true;
            else gridView6.Columns["NgayTao"].Visible = false;
            if (clbShowFindColumn.Items[3].CheckState == CheckState.Checked)
                gridView6.Columns["NgayCapNhat"].Visible = true;
            else gridView6.Columns["NgayCapNhat"].Visible = false;
            if (clbShowFindColumn.Items[4].CheckState == CheckState.Checked)
            {
                gridView6.Columns["IdLoaiCauHoi"].Visible = true;
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangSoBo.DataSource = lch_bll.LoaiCauHoi_Select();
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangSoBo.ValueMember = "IdLoaiCauHoi";
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangSoBo.DisplayMember = "TenLoaiCauHoi";
            }
            else gridView6.Columns["IdLoaiCauHoi"].Visible = false;
            if (clbShowFindColumn.Items[5].CheckState == CheckState.Checked)
            {
                gridView6.Columns["IdGiaoVien"].Visible = true;
                repositoryItemLookUpEdit_GiaoVienTabNganHangSoBo.DataSource = gv_bll.GiaoVien_Select();
                repositoryItemLookUpEdit_GiaoVienTabNganHangSoBo.ValueMember = "IdGiaoVien";
                repositoryItemLookUpEdit_GiaoVienTabNganHangSoBo.DisplayMember = "TenGiaoVien";
            }
            else gridView6.Columns["IdGiaoVien"].Visible = false;
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) // tab ngan hang so bo
        {
            xtraTabPage_NganHangSoBo.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_NganHangSoBo);
            xtraTabControl1.SelectedTabPage = xtraTabPage_NganHangSoBo;
            ShowTabSoBoNganHang();
        }
      

        private void chuyểnSangNgânHàngCâuHỏiChínhThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //try
            //{
                Question.IdCauHoi = int.Parse(gridView6.GetFocusedRowCellValue("IdCauHoi").ToString());
                int kq = Question_bll.CauHoiChinhThuc_Insert(Question);
                if (kq > 0)
                {
                    gridView6.DeleteRow(gridView6.FocusedRowHandle);
                    XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //catch { }

        }

        private void xóaCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Question.IdCauHoi = int.Parse(gridView6.GetFocusedRowCellValue("IdCauHoi").ToString());
                int kq = Question_bll.CauHoi_Delete(Question);
                if (kq > 0)
                {
                    gridView6.DeleteRow(gridView6.FocusedRowHandle);
                    XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView6.RowCount; i++)
                {
                    Question = new CauHoi_Public();
                    Question.IdCauHoi = int.Parse(gridView6.GetDataRow(i)["IdCauHoi"].ToString());
                    Question_bll.CauHoiChinhThuc_Insert(Question);
                }
                gridView6.SelectAll();
                gridView6.DeleteSelectedRows();
                XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }

        }
        int paginate = 1;
        int demcauhoiNHSB;
        int demcauhoiNHCT;
        int SoTrang;
        int SoTrangNHCT;
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) // chọn môn học ngân hàng sơ bộ
        {
            while (Count < 3)
            {
                Count++;
                return;
            }
            paginate = 1;
            IsGoToNganHangSoBo = false;
            gridControl3.DataSource = null;
            if (comboBox1.SelectedIndex != -1)
            {
                layoutControlGroup2.Text = "Danh mục câu hỏi thuộc môn " + comboBox1.GetItemText(comboBox1.SelectedItem);
                int IdMonHoc = int.Parse(comboBox1.SelectedValue.ToString());
                Question = new CauHoi_Public();
                Question.Mh.IdMonHoc = IdMonHoc;
                DataTable dt1 = new DataTable();
                dt1 = Question_bll.CauHoi_Select_Paginate(Question, paginate);
                DataTable CountSoCauHoi = new DataTable();
                CountSoCauHoi = Question_bll.CountCauHoi_Select_IdMonHoc(Question);
                demcauhoiNHSB = int.Parse(CountSoCauHoi.Rows[0][0].ToString());
                if (demcauhoiNHSB % 10 == 0)
                {
                    SoTrang = demcauhoiNHSB / 10;
                }
                else
                    SoTrang = (demcauhoiNHSB / 10) + 1;
                if (dt1.Rows.Count > 0)
                {
                    gridControl3.DataSource = Question_bll.CauHoi_Select_Paginate(Question, paginate);
                    lbsoluongcauhoi.Text = string.Format("{0}/{1}", gridView6.RowCount, demcauhoiNHSB);
                }
            }
        }
        private void btnNextTabNganHangSoBo_Click(object sender, EventArgs e)
        {
            gridControl3.DataSource = null;
            dt = new DataTable();
            if (IsGoToNganHangSoBo == false)
                dt = Question_bll.CauHoi_Select_Paginate(Question, paginate + 1);
            else
                dt = Question_bll.CauHoi_SelectAll(Question, paginate + 1);
            if (dt.Rows.Count > 0)
            {
                gridControl3.DataSource = dt;
                paginate++;
            }
            else
            {
                paginate = 1;
                DataTable dt1 = new DataTable();
                if(IsGoToNganHangSoBo==false)
                dt1 = Question_bll.CauHoi_Select_Paginate(Question, paginate);
                else
                    dt1 = Question_bll.CauHoi_SelectAll(Question, paginate);
                if (dt1.Rows.Count > 0)
                    gridControl3.DataSource = dt1;
            }
            if (paginate == SoTrang)
                lbsoluongcauhoi.Text = string.Format("{0}/{1}", demcauhoiNHSB, demcauhoiNHSB);
            else lbsoluongcauhoi.Text = string.Format("{0}/{1}", paginate * 10, demcauhoiNHSB);
        }

        private void btnPreviewNganHangSoBo_Click(object sender, EventArgs e)
        {
            gridControl3.DataSource = null;
            if (paginate > 1)
            {
                dt = new DataTable();
                if(IsGoToNganHangSoBo==false)
                dt = Question_bll.CauHoi_Select_Paginate(Question, paginate - 1);
                else dt = Question_bll.CauHoi_SelectAll(Question, paginate - 1);
                if (dt.Rows.Count > 0)
                {
                    gridControl3.DataSource = dt;
                    paginate--;
                }
            }
            else
            {
                paginate = 1;
                DataTable dt1 = new DataTable();
                if(IsGoToNganHangSoBo==false)
                dt1 = Question_bll.CauHoi_Select_Paginate(Question, paginate);
                else dt1 = Question_bll.CauHoi_SelectAll(Question, paginate);
                if (dt1.Rows.Count > 0)
                    gridControl3.DataSource = dt1;
            }
            if (paginate == SoTrang)
                lbsoluongcauhoi.Text = string.Format("{0}/{1}", demcauhoiNHSB, demcauhoiNHSB);
            else lbsoluongcauhoi.Text = string.Format("{0}/{1}", paginate * 10, demcauhoiNHSB);
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThongTinNguoiSuDung frm = new frmThongTinNguoiSuDung();
            frm.ShowDialog();

        }
        int Paginate = 1;
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e) // chon mon ngan hang chinh thuc
        {
            while (Count < 3)
            {
                Count++;
                return;
            }
            try
            {
                Paginate = 1;
                IsGoToNganHangChinhThuc = false;
                gridControl4.DataSource = null;
                if (comboBox2.SelectedIndex != -1)
                {
                    IsGoToNganHangChinhThuc = false;
                    layoutControlGroup4.Text = "Danh mục câu hỏi thuộc môn " + comboBox2.GetItemText(comboBox2.SelectedItem);
                    int IdMonHoc = int.Parse(comboBox2.SelectedValue.ToString());
                    Question = new CauHoi_Public();
                    Question.Mh.IdMonHoc = IdMonHoc;
                    DataTable dt1 = new DataTable();
                    dt1 = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate);

                    // trả về số câu hỏi và số trang
                    DataTable CountSoCauHoi = new DataTable(); 
                    CountSoCauHoi = Question_bll.CountCauHoiChinhThuc_Select_IdMonHoc(Question);
                    demcauhoiNHCT = int.Parse(CountSoCauHoi.Rows[0][0].ToString());
                    if (demcauhoiNHCT % 10 == 0)
                    {
                        SoTrangNHCT = demcauhoiNHCT / 10;
                    }
                    else
                        SoTrangNHCT = (demcauhoiNHCT / 10) + 1;
                    if (dt1.Rows.Count > 0)
                    {
                        gridControl4.DataSource = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate);
                        lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", gridView7.RowCount, demcauhoiNHCT);
                    }
                }
            }
            catch { }

        }
        int Count;
        void ShowTabChinhThucNganHang()
        {
            Count = 0;
            if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 3)
            {
                comboBox2.DisplayMember = "TenMonHoc";
                comboBox2.ValueMember = "IdMonHoc";
                comboBox2.DataSource = mhbll.MonHoc_Select();
                comboBox2.SelectedIndex = -1;
            }
            else
                //if (frm_DangNhap.GiaoVien.Quyen.IdQuyen == 2)
                {
                    mh = new MonHoc_Public();
                    mh.ToBoMon.IdToBoMon = int.Parse(frm_DangNhap.GetIdToBoMon.ToString());
                    dt = new DataTable();
                    dt = mhbll.MonHoc_Select_IdToBoMon(mh);
                    comboBox2.DisplayMember = "TenMonHoc";
                    comboBox2.ValueMember = "IdMonHoc";
                    comboBox2.DataSource = dt;  
                    comboBox2.SelectedIndex = -1;
                }


        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) // show tab ngan hang chinh thuc
        {
            xtraTabPage_NganHangChinhThuc.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_NganHangChinhThuc);
            xtraTabControl1.SelectedTabPage = xtraTabPage_NganHangChinhThuc;
            ShowTabChinhThucNganHang();
        }

        private void checkedListBoxControl2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (checkedListBoxControl2.Items[0].CheckState == CheckState.Checked)
            {
                gridView7.Columns["IdDoKho"].Visible = true;
                repositoryItemLookUpEdit_DoKhoTabNganHangChinhThuc.DataSource = dk_bll.DoKho_Select();
                repositoryItemLookUpEdit_DoKhoTabNganHangChinhThuc.DisplayMember = "TenDoKho";
                repositoryItemLookUpEdit_DoKhoTabNganHangChinhThuc.ValueMember = "IdDoKho";
            }
            else gridView7.Columns["IdDoKho"].Visible = false;
            if (checkedListBoxControl2.Items[1].CheckState == CheckState.Checked)
                gridView7.Columns["DoPhanCach"].Visible = true;
            else gridView7.Columns["DoPhanCach"].Visible = false;
            if (checkedListBoxControl2.Items[2].CheckState == CheckState.Checked)
                gridView7.Columns["NgayTao"].Visible = true;
            else gridView7.Columns["NgayTao"].Visible = false;
            if (checkedListBoxControl2.Items[3].CheckState == CheckState.Checked)
                gridView7.Columns["NgayCapNhat"].Visible = true;
            else gridView7.Columns["NgayCapNhat"].Visible = false;
            if (checkedListBoxControl2.Items[4].CheckState == CheckState.Checked)
            {
                gridView7.Columns["IdLoaiCauHoi"].Visible = true;
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangChinhThuc.DataSource = lch_bll.LoaiCauHoi_Select();
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangChinhThuc.ValueMember = "IdLoaiCauHoi";
                repositoryItemLookUpEdit_LoaiCauHoiTabNganHangChinhThuc.DisplayMember = "TenLoaiCauHoi";
            }
            else gridView7.Columns["IdLoaiCauHoi"].Visible = false;
            if (checkedListBoxControl2.Items[5].CheckState == CheckState.Checked)
            {
                gridView7.Columns["IdGiaoVien"].Visible = true;
                repositoryItemLookUpEdit_TenGiaoVienTabNganHangChinhThuc.DataSource = gv_bll.GiaoVien_Select();
                repositoryItemLookUpEdit_TenGiaoVienTabNganHangChinhThuc.ValueMember = "IdGiaoVien";
                repositoryItemLookUpEdit_TenGiaoVienTabNganHangChinhThuc.DisplayMember = "TenGiaoVien";
            }
            else gridView7.Columns["IdGiaoVien"].Visible = false;
        }

        private void btnPreviewNganHangChinhThuc_Click(object sender, EventArgs e)
        {
            gridControl4.DataSource = null;
            if (Paginate > 1)
            {
                dt = new DataTable();
                if(IsGoToNganHangChinhThuc==false)
                dt = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate - 1);
                else dt = Question_bll.CauHoiChinhThuc_SelectAll(Question, Paginate-1);
                if (dt.Rows.Count > 0)
                {
                    gridControl4.DataSource = dt;
                    Paginate--;
                }
            }
            else
            {
                Paginate = 1;
                DataTable dt1 = new DataTable();
                if(IsGoToNganHangChinhThuc==false)
                dt1 = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate);
                else dt1 = Question_bll.CauHoiChinhThuc_SelectAll(Question, Paginate);
                if (dt1.Rows.Count > 0)
                    gridControl4.DataSource = dt1;
            }
            if (Paginate == SoTrangNHCT)
                lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", demcauhoiNHCT, demcauhoiNHCT);
            else lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", Paginate * 10, demcauhoiNHCT);
        }

        private void btnNextNganHangChinhThuc_Click(object sender, EventArgs e)
        {
            gridControl4.DataSource = null;
            dt = new DataTable();
            if(IsGoToNganHangChinhThuc==false)
            dt = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate + 1);
            else dt = Question_bll.CauHoiChinhThuc_SelectAll(Question, Paginate+1);
            if (dt.Rows.Count > 0)
            {
                gridControl4.DataSource = dt;
                Paginate++;
            }
            else
            {
                Paginate = 1;
                DataTable dt1 = new DataTable();
                if(IsGoToNganHangChinhThuc==false)
                dt1 = Question_bll.CauHoiChinhThuc_Select_Paginate(Question, Paginate);
                else dt1 = Question_bll.CauHoiChinhThuc_SelectAll(Question, Paginate);
                if (dt1.Rows.Count > 0)
                    gridControl4.DataSource = dt1;
            }
            if (Paginate == SoTrangNHCT)
                lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", demcauhoiNHCT, demcauhoiNHCT);
            else lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", Paginate * 10, demcauhoiNHCT);
        }
      

        private void chuyểnCâuHỏiQuaNgânHàngSơBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question = new CauHoi_Public();
            //try
            //{
                Question.IdCauHoi = int.Parse(gridView7.GetFocusedRowCellValue("IdCauHoiChinhThuc").ToString());
                int kq;
                kq = Question_bll.ChuyenCauHoiChoNHSB(Question);
                if (kq > 0)
                {
                    gridView7.DeleteRow(gridView7.FocusedRowHandle);
                    XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //}
            //catch { }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmThayDoiThongTinDangNhap frm = new frmThayDoiThongTinDangNhap();
            frm.ShowDialog();
        }



        private void comboBox3_SelectedValueChanged(object sender, EventArgs e) // chọn môn học tab danh mục câu hỏi đang soạn
        {

            gridControl5.DataSource = null;
            if (comboBox3.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                layoutControlGroup7.Text = "Danh mục câu hỏi thuộc môn " + comboBox3.GetItemText(comboBox3.SelectedItem);
                Question = new CauHoi_Public();
                Question.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                Question.Mh.IdMonHoc = int.Parse(comboBox3.SelectedValue.ToString());
                gridControl5.DataSource = Question_bll.GetCauHoiDangSoan(Question);
            }
        }

        private void navBarItem9_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_DanhMucCauHoiDangSoan.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_DanhMucCauHoiDangSoan);
            xtraTabControl1.SelectedTabPage = xtraTabPage_DanhMucCauHoiDangSoan;
            richEditControl1.Document.Delete(richEditControl1.Document.Range);
            GiaoVien_Public gv = new GiaoVien_Public();
            gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            try
            {
                comboBox3.DisplayMember = "TenMonHoc";
                comboBox3.ValueMember = "IdMonHoc";
                comboBox3.DataSource = mhbll.MonHoc_Select_IdGiaoVien(gv);
                comboBox3.SelectedIndex = -1;
            }
            catch { }
        }

        private void gridView8_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            rowHandle = gridView8.FocusedRowHandle;
            string GetIdGiaThietChung = gridView8.GetDataRow(rowHandle)["IdGiaThietChung"].ToString();
            int GetIdCauHoi = int.Parse(gridView8.GetDataRow(rowHandle)["IdCauHoi"].ToString());
            int GetIdLoaiCauHoi = int.Parse(gridView8.GetDataRow(rowHandle)["IdLoaiCauHoi"].ToString());
            InsertInRichEdit(richEditControl1, gridView8, GetIdGiaThietChung, GetIdCauHoi, GetIdLoaiCauHoi); // hàm insert rtf vào rich
        }
        private void sửaCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e) // sửa câu hỏi
        {
            if (string.IsNullOrEmpty(gridView8.GetFocusedRowCellValue("IdGiaThietChung").ToString()))
            {
                frmEditCauHoi frm = new frmEditCauHoi(gridView8.GetFocusedRowCellValue("IdCauHoi").ToString(), gridView8.GetFocusedRowCellValue("NoiDung").ToString(), gridView8.GetFocusedRowCellValue("IdLoaiCauHoi").ToString());
                frm.ShowDialog();
            }
            else
            {
                frmEditCauHoi frm = new frmEditCauHoi(gridView8.GetFocusedRowCellValue("IdGiaThietChung").ToString(), gridView8.GetFocusedRowCellValue("IdCauHoi").ToString(), gridView8.GetFocusedRowCellValue("NoiDung").ToString(), gridView8.GetFocusedRowCellValue("IdLoaiCauHoi").ToString());
                frm.ShowDialog();
            }
        }

        private void xóaCâuHỏiToolStripMenuItem1_Click(object sender, EventArgs e) // xóa câu hỏi
        {
            try
            {
                Question = new CauHoi_Public();
                Question.IdCauHoi = int.Parse(gridView8.GetFocusedRowCellValue("IdCauHoi").ToString());
                int kq = Question_bll.CauHoi_Delete(Question);
                if (kq > 0)
                {
                    gridView8.DeleteRow(gridView8.FocusedRowHandle);
                    richEditControl1.Document.Delete(richEditControl1.Document.Range);
                    XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
        }

        private void côngKhaiXétDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Question = new CauHoi_Public();
                Question.IdCauHoi = int.Parse(gridView8.GetFocusedRowCellValue("IdCauHoi").ToString());
                int kq = Question_bll.CauHoi_SetCongKhai(Question);
                if (kq > 0)
                {
                    gridView8.DeleteRow(gridView8.FocusedRowHandle);
                    XtraMessageBox.Show("Đã công khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
        }

        int dem = 0;
        private void richEditControl_SoanCauHoi_ContentChanged(object sender, EventArgs e)
        {
            if (radioGroup_LuaChonDangCauHoi.SelectedIndex == 4)
            {
                DocumentImageCollection images = richEditControl_SoanCauHoi.Document.GetImages(richEditControl_SoanCauHoi.Document.Range);
                if (images.Count > 1)
                {
                    //richEditControl_SoanCauHoi.Document.BeginUpdate();
                    for (int i = 1; i < images.Count; i++)
                    {
                        richEditControl_SoanCauHoi.Document.Delete(images[i].Range);
                        dem = 0;
                    }
                    //richEditControl_SoanCauHoi.Document.EndUpdate();
                }
                if (images.Count == 0) dem = 0;
                if (dem < 1)
                {

                    if (images.Count == 1)
                    {
                        OfficeImage img = images[0].Image;
                        Image imgs = img.NativeImage;
                        frmLayToaDoAnh frm = new frmLayToaDoAnh(imgs);
                        frm.ShowDialog();
                        dem++;
                    }
                }
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { 
            ShowTabNhiemVu();
        }
        GiaoVien_Public gv;
        void ShowTabNhiemVu()
        {
            xtraTabPage_NhiemVu.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_NhiemVu);
            xtraTabControl1.SelectedTabPage = xtraTabPage_NhiemVu;
            gv=new GiaoVien_Public();
            gv.IdGiaoVien=frm_DangNhap.GetIdGiaoVien;
            comboBox4.DisplayMember = "TenMonHoc";
            comboBox4.ValueMember = "IdMonHoc";
            comboBox4.DataSource = mhbll.GetMonHoc_IdGiaoVien(gv);
            comboBox4.SelectedIndex = -1;
        }
        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridControl6.DataSource = null;
                gridControl7.DataSource = null;
                if (comboBox4.SelectedIndex != -1)
                {
                    MonHoc_Public mh = new MonHoc_Public();
                    mh.IdMonHoc = int.Parse(comboBox4.SelectedValue.ToString());
                    dt = new DataTable();
                    dt = gv_bll.GetNhiemVu(gv, mh);
                    if (dt.Rows.Count > 0)
                    {
                        gridControl6.DataSource = dt;
                        gridView10.ExpandAllGroups();
                    }
                    Question = new CauHoi_Public();
                    Question.Mh.IdMonHoc = mh.IdMonHoc;
                    Question.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                    gridControl7.DataSource = Question_bll.CauHoi_Select_IdMonHoc(Question);
                }
            }
            catch { }
        }
        private void gridView10_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            ShowTabSoanCauHoi();
            if (gridView10.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_DiDenVungSoanThao)
            {
                // IdMonHoc, TenMonHoc, TenChuong, TenChuDe, TenMucKienThuc, TenMucTriNang, IdMucKienThuc,IdMucTriNang,SoCauPhaiNhap,SoCauDaNhap, IdMaTranKienThuc
                GetInfoMonHoc[0] = gridView10.GetFocusedRowCellValue("IdMonHoc").ToString();
                GetInfoMonHoc[10] = gridView10.GetFocusedRowCellValue("IdMaTranKienThuc").ToString();
                GetInfoMonHoc[1] = gridView10.GetFocusedRowCellValue("TenMonHoc").ToString();
                GetInfoMonHoc[2] = gridView10.GetFocusedRowCellValue("TenChuong").ToString();
                GetInfoMonHoc[3] = gridView10.GetFocusedRowCellValue("TenChuDe").ToString();
                GetInfoMonHoc[4] = gridView10.GetFocusedRowCellValue("TenMucKienThuc").ToString();
                GetInfoMonHoc[5] = gridView10.GetFocusedRowCellValue("TenMucTriNang").ToString();
                treeList_ThongTinKienThucST.ClearNodes();
                CreateColumns(treeList_ThongTinKienThucST);
                CreateNode(treeList_ThongTinKienThucST, GetInfoMonHoc);
                treeList_ThongTinKienThucST.ExpandAll();
                dt = new DataTable();
                pqnch = new PhanQuyenNhapCauHoi_Public();
                pqnch.Mtkt.IdMaTranKienThuc = GetInfoMonHoc[10];
                pqnch.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                dt = pqnch_bll.PhanQuyenNhapCauHoi_Select_IdMaTranIdGiaoVien(pqnch);
                if (dt.Rows.Count > 0)
                {
                    lb_SoCauPhaiNhap.Text = dt.Rows[0]["SoCauPhaiNhap"].ToString();
                    lb_SoCauDaNhap.Text = dt.Rows[0]["SoCauDaNhap"].ToString();
                }
                else
                {
                    lb_SoCauPhaiNhap.Text = "";
                    lb_SoCauDaNhap.Text = "";
                }
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e) // đi đến danh mục câu hỏi cần duyệt
        {
            xtraTabPageNganHangCauHoi.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPageNganHangCauHoi);
            xtraTabControl1.SelectedTabPage = xtraTabPageNganHangCauHoi;
            gridView4.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView4.OptionsView.ColumnAutoWidth = false;
            ShowTabDanhMucCauHoiCanDuyet();
            cbbChonMonHoc_TabNganHangSoBo.SelectedIndex = comboBox4.SelectedIndex;
        }
        bool IsGoToNganHangChinhThuc;
        bool IsGoToNganHangSoBo;
        private void simpleButton2_Click(object sender, EventArgs e) // đi đến danh mục câu hỏi đã soạn ngân hàng chính thức
        {
            IsGoToNganHangChinhThuc = true;
            Paginate = 1;
            xtraTabPage_NganHangChinhThuc.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_NganHangChinhThuc);
            xtraTabControl1.SelectedTabPage = xtraTabPage_NganHangChinhThuc;
            ShowTabChinhThucNganHang();
            Question=new CauHoi_Public();
            Question.Gv.IdGiaoVien=frm_DangNhap.GetIdGiaoVien;
            gridControl4.DataSource = Question_bll.CauHoiChinhThuc_SelectAll(Question, Paginate);
            DataTable CountSoCauHoi = new DataTable();
            CountSoCauHoi = Question_bll.CountCauHoiChinhThuc_SelectAll(Question);
            demcauhoiNHCT = int.Parse(CountSoCauHoi.Rows[0][0].ToString());
            if (demcauhoiNHCT % 10 == 0)
            {
                SoTrangNHCT = demcauhoiNHCT / 10;
            }
            else
                SoTrangNHCT = (demcauhoiNHCT / 10) + 1;
            lbsoluongcauhoiNHCT.Text = string.Format("{0}/{1}", gridView7.RowCount, demcauhoiNHCT);
        }
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        private void toolStripMenuItem8_Click(object sender, EventArgs e) // đăng xuất
        {
            this.Hide();
            SystemLog_Public sys = new SystemLog_Public();
            sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
            sys.MoTa = "Đăng xuất";
            sys_bll.SystemLog_Insert(sys);
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
        }

        private void xemĐầyĐủNộiDungCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)// xem đầy đủ nội dung môn học
        {
            //gridView7.OptionsView.RowAutoHeight = true;
            string noidung=gridView7.GetFocusedRowCellValue("NoiDung").ToString();
            if (!string.IsNullOrEmpty(noidung))
            {
                frmXemNoiDungCauHoi frmxem = new frmXemNoiDungCauHoi(noidung);
                frmxem.ShowDialog();
            }
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox7.DataSource = mhbll.GetMaDeTheoMonHoc((int)comboBox8.SelectedValue);
                comboBox7.DisplayMember = "IdDe";
                comboBox7.ValueMember = "IdDe";
            }
            catch { }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e) // chọn mã đề
        {
            try
            {
                 
            }
            catch { }
        }

        private void btnXemDe_Click(object sender, EventArgs e)
        {
            string TenMonHoc=comboBox8.GetItemText(comboBox8.SelectedItem);
            int ThoiGianThi = 0;
            //DataTable ThoiGianTable = new DataTable();
            //ThoiGianTable = mhbll.GetThoiGianThi((int)comboBox7.SelectedValue);
            //if (ThoiGianTable.Rows.Count > 0)
            //    ThoiGianThi = (int)ThoiGianTable.Rows[0][0];
            int made = (int)comboBox7.SelectedValue;
            if(XtraMessageBox.Show(string.Format("Bạn có muốn xem thêm Phiếu đáp án của mã đề {0} không ?",made),"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                rptPhieuDapAn rpt1 = new rptPhieuDapAn(made.ToString());
                rpt1.DataSource = mhbll.GetMaDe_DapAn(made);
                rpt1.BinData();
                rpt1.ShowPreview();
            }
            rptDeThi rpt = new rptDeThi(TenMonHoc, ThoiGianThi, made);
            rpt.ShowPreview();
        }

        private void simpleButton3_Click(object sender, EventArgs e) // đi đến danh mục câu hỏi đã soạn ngân hàng sơ bộ
        {
            IsGoToNganHangSoBo = true;
            paginate = 1;
            xtraTabPage_NganHangSoBo.PageVisible = true;
            xtraTabControl1.TabPages.Add(xtraTabPage_NganHangSoBo);
            xtraTabControl1.SelectedTabPage = xtraTabPage_NganHangSoBo;
            ShowTabSoBoNganHang();
            Question = new CauHoi_Public();
            Question.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
            gridControl3.DataSource = Question_bll.CauHoi_SelectAll(Question, paginate);

            DataTable CountSoCauHoi = new DataTable();
            CountSoCauHoi = Question_bll.CountCauHoi_SelectAll(Question);
            demcauhoiNHSB = int.Parse(CountSoCauHoi.Rows[0][0].ToString());
            if (demcauhoiNHSB % 10 == 0)
            {
                SoTrang = demcauhoiNHSB / 10;
            }
            else
                SoTrang = (demcauhoiNHSB / 10) + 1;
                lbsoluongcauhoi.Text = string.Format("{0}/{1}", gridView6.RowCount, demcauhoiNHSB);
        }

        private void ThemTootipMenuStrip_Click(object sender, EventArgs e)
        {
            gridView2.OptionsBehavior.ReadOnly = false;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)// chuyển cho giáo viên soạn thảo
        {
            try
            {
                Question = new CauHoi_Public();
                Question.IdCauHoi = int.Parse(gridView6.GetFocusedRowCellValue("IdCauHoi").ToString());
                int kq = Question_bll.CauHoi_SetKoCongKhai(Question);
                if (kq > 0) XtraMessageBox.Show("Chuyển cho giáo viên soạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else XtraMessageBox.Show("Chuyển cho giáo viên soạn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void soạnCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e) // menu soạn câu hỏi
        {
            navBarItem1_LinkClicked(null, null);
        }

        private void danhMụcCâuHỏiĐangSoạnToolStripMenuItem_Click(object sender, EventArgs e) // menu danh mục câu hỏi đang soạn
        {
            navBarItem9_LinkClicked_1(null, null);
        }

        private void danhMụcCâuHỏiCầnDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItemNganHangCauHoi_LinkClicked(null, null);
        }

        private void ngânHàngCâuHỏiChínhThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItem4_LinkClicked(null, null);
        }

        private void ngânHàngCâuHỏiSơBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItem5_LinkClicked(null, null);
        }

        private void danhMụcMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItemDanhMucMonHoc_LinkClicked(null, null);
        }

        private void mứcTríNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItem9_LinkClicked(null, null);
        }

        private void maTrậnKiếnThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navBarItemMaTranKienThuc_LinkClicked(null, null);
        }

        private void gridView7_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "gridColumn48" && e.IsGetData)
            {
                object value = ((GridView)sender).GetListSourceRowCellValue(e.ListSourceRowIndex,"NoiDung");
                e.Value = repositoryItemRichTextEdit3.ConvertEditValueToPlainText(value);
            }
        }
    }
}



