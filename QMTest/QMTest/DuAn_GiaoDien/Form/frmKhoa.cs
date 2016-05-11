using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_BussinessLogicLayer;
using Test_PublicLayer;

namespace DuAn_GiaoDien
{
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        public frmKhoa(Khoa_Public k,bool kt)
        {
            InitializeComponent();
            //try
            //{
            //    txtTenKhoa.Text = k.TenKhoa;
            //    meMoTa.Text = k.MoTa;
            //    this.kt = kt;
            //}
            //catch { }
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            //TreeNode td = new TreeNode();
            //td.Text = "Vai trò";
            //treeView1.CheckBoxes = true;
     
            //TreeNode t=new TreeNode();
            //td.Nodes.Add(t);
            //t.Text = "Quản trị hệ thống";
            //t.Checked = true;
            //treeView1.Nodes.Add(td);
            dt = k_bll.Khoa_Select();
            if(dt.Rows.Count>0)
            gridControl1.DataSource = k_bll.Khoa_Select();
        }
        Khoa_Public k;
        Khoa_BLL k_bll = new Khoa_BLL();
        DataTable dt;
        public bool KiemTraThemKhoa;
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //k = new Khoa_Public();
            //if (kt == true)
            //{
            //    k.IdKhoa = int.Parse(txtIdKhoa.Text.Trim());
            //    k.TenKhoa = txtTenKhoa.Text.Trim();
            //    k.MoTa = txtMoTa.Text.Trim();
            //    kq = k_bll.Khoa_Insert(k);
            //    if (kq > 0)
            //    {
            //       KiemTraThemKhoa = true;
            //        XtraMessageBox.Show(string.Format("Thêm khoa {0} thành công!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else XtraMessageBox.Show(string.Format("Thêm khoa {0} thất bại!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    KiemTraThemKhoa = true;
            //    k.IdKhoa =int.Parse(txtIdKhoa.Text.Trim());
            //    k.TenKhoa = txtTenKhoa.Text.Trim();
            //    k.MoTa = txtMoTa.Text.Trim();
            //    kq = k_bll.Khoa_Update(k);
            //    if (kq > 0)
            //    {
            //        XtraMessageBox.Show(string.Format("Cập nhật thông tin khoa {0} thành công!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else XtraMessageBox.Show(string.Format("Cập nhật thông tin khoa {0} thất bại!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            k = new Khoa_Public();
            int kq;
            try
            {
                k.TenKhoa = txtTenKhoa.EditValue.ToString();
                k.MoTa = meMoTa.EditValue.ToString();
            }
            catch { }
            kq = k_bll.Khoa_Insert(k);
            if (kq > 0)
            {
                XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = k_bll.Khoa_Select();

                SystemLog_Public sys = new SystemLog_Public();
                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                sys.MoTa = "Thêm khoa " + txtTenKhoa.Text.Trim();
                sys_bll.SystemLog_Insert(sys);

            }
            else
                XtraMessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        bool bKiemTraClickSua;
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if ((gridView1.FocusedColumn.FieldName == "TenKhoa") || (gridView1.FocusedColumn.FieldName == "MoTa"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại Khoa {0}", gridView1.GetFocusedRowCellValue("TenKhoa")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            k = new Khoa_Public();
                            k.IdKhoa = int.Parse(gridView1.GetFocusedRowCellValue("IdKhoa").ToString());
                            gridView1.FocusedColumn = gridView1.Columns["IdKhoa"];
                            k.TenKhoa = gridView1.GetFocusedRowCellValue("TenKhoa").ToString();
                            k.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            kq = k_bll.Khoa_Update(k);
                            if (kq > 0)
                            {
                                XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SystemLog_Public sys = new SystemLog_Public();
                                sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                                sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                                sys.MoTa = string.Format("{0} {1}","Chỉnh sửa thông tin khoa có mã khoa là",k.IdKhoa);
                                sys_bll.SystemLog_Insert(sys);
                            }

                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int kq;
            if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Xoa)
            {
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa khoa {0}", gridView1.GetFocusedRowCellValue("TenKhoa")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    k = new Khoa_Public();
                    k.IdKhoa = int.Parse(gridView1.GetFocusedRowCellValue("IdKhoa").ToString());
                    kq = k_bll.Khoa_Delete(k);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = string.Format("{0} {1}", "Xóa khoa có mã khoa là", k.IdKhoa);
                        sys_bll.SystemLog_Insert(sys);
                    }
                    else
                        XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else
                if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Sua)
                {
                    bKiemTraClickSua = true;
                    XtraMessageBox.Show("Sau khi chỉnh sửa xong, nhấn Enter để xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DevExpress.XtraGrid.Views.Base.ColumnView View = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.FocusedView;
                    //View.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.OptionsBehavior.ReadOnly = false;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.ShowEditor();
                }
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ThemToBoMon)
                {
                    frmToBoMon frm = new frmToBoMon();
                    frm.ShowDialog();
                }
        }

       
    
    }
}