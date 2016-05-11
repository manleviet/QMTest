using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class frmToBoMon : XtraForm
    {
        public frmToBoMon()
        {
            InitializeComponent();
            
        }
        Khoa_BLL k_bll = new Khoa_BLL();
        ToBoMon_Public tbm;
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        void LoadDataTableToBoMon()
        {
            gridControl1.DataSource = tbm_bll.ToBoMon_Select();
        }
        private void lbThemToBoMon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(535, 507);
            try
            {
                DataTable dt = new DataTable();
                dt = k_bll.Khoa_Select();
                cbbChonKhoa.DataSource = dt;
                cbbChonKhoa.DisplayMember = "TenKhoa";
                cbbChonKhoa.ValueMember = "IdKhoa";
                cbbChonKhoa.SelectedIndex = 0;
            }
            catch { }
            
        }
        private void frmToBoMon_Load(object sender, EventArgs e)
        {
            this.Size = new Size(535, 362);
            LoadDataTableToBoMon();
            gridView1.OptionsBehavior.ReadOnly = true;
            repositoryItemGridLookUpEdit_ChonKhoa.DataSource = k_bll.Khoa_Select();
            repositoryItemGridLookUpEdit_ChonKhoa.ValueMember = "IdKhoa";
            repositoryItemGridLookUpEdit_ChonKhoa.DisplayMember = "TenKhoa";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            int kq;
            try
            {
                tbm = new ToBoMon_Public();
                tbm.TenToBoMon = txtTenToBoMon.Text.Trim();
                tbm.Khoa.IdKhoa = int.Parse(cbbChonKhoa.SelectedValue.ToString());
                tbm.MoTa = meMoTa.EditValue.ToString();
                
                
            }
            catch { }
            kq = tbm_bll.ToBoMon_Insert(tbm);
            if (kq > 0)
            {
                XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataTableToBoMon();
            }
            else
                XtraMessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool bKiemTraClickSua;
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int kq;
            if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Xoa)
            {
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa tổ bộ môn {0}", gridView1.GetFocusedRowCellValue("TenToBoMon")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    tbm = new ToBoMon_Public();
                    tbm.IdToBoMon = int.Parse(gridView1.GetFocusedRowCellValue("IdToBoMon").ToString());
                    kq = tbm_bll.ToBoMon_Delete(tbm);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
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
                    gridView1.OptionsBehavior.ReadOnly = false;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.ShowEditor();
                }
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ThemMonHoc)
                {
                    ////gridView1.OptionsBehavior.ReadOnly = false;
                    //frmMonHoc frm = new frmMonHoc();
                    //frm.ShowDialog();
                }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if ((gridView1.FocusedColumn.FieldName == "TenToBoMon") || (gridView1.FocusedColumn.FieldName == "MoTa") || (gridView1.FocusedColumn.FieldName == "IdKhoa"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại tổ bộ môn {0}", gridView1.GetFocusedRowCellValue("TenToBoMon")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            tbm = new ToBoMon_Public();
                            tbm.IdToBoMon =int.Parse(gridView1.GetFocusedRowCellValue("IdToBoMon").ToString());
                            gridView1.FocusedColumn = gridView1.Columns["IdToBoMon"];
                            tbm.TenToBoMon = gridView1.GetFocusedRowCellValue("TenToBoMon").ToString();
                            tbm.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            tbm.Khoa.IdKhoa = int.Parse(gridView1.GetFocusedRowCellValue("IdKhoa").ToString());
                            kq = tbm_bll.ToBoMon_Update(tbm);
                            if (kq > 0)
                                XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void cbbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
