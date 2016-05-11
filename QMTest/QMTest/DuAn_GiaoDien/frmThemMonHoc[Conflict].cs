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
using System.Data;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
        }
        MonHoc_BLL mh_bll = new MonHoc_BLL();
        MonHoc_Public mh;
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        Khoa_BLL k_bll = new Khoa_BLL();
        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {
            this.Size = new Size(736, 368);
            gridControl1.DataSource = mh_bll.MonHoc_Select();
            gridView1.OptionsBehavior.ReadOnly = true;

            repositoryItemGridLookUpEdit_ChonToBoMon.DataSource = tbm_bll.ToBoMon_Select();
            repositoryItemGridLookUpEdit_ChonToBoMon.ValueMember = "IdToBoMon";
            repositoryItemGridLookUpEdit_ChonToBoMon.DisplayMember = "TenToBoMon";
        }

        private void lbThemMonHoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(736, 517);
            
            cbbChonKhoa.ValueMember = "IdKhoa";
            cbbChonKhoa.DisplayMember = "TenKhoa";
            cbbChonKhoa.DataSource = k_bll.Khoa_Select();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbChonToBoMon.SelectedItem == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tổ bộ môn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbChonKhoa.Focus();
            }
            else
                if (string.IsNullOrEmpty(txtTenMonHoc.Text.Trim()))
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên môn học cần thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenMonHoc.Focus();
                }
                else
                {
                    mh = new MonHoc_Public();
                    int kq;
                    try
                    {
                        mh.TenMonHoc = txtTenMonHoc.Text.Trim();
                        mh.MoTa = meMoTa.EditValue.ToString();
                        mh.ToBoMon.IdToBoMon = int.Parse(cbbChonToBoMon.SelectedValue.ToString());
                    }
                    catch { }
                    kq = mh_bll.MonHoc_Insert(mh);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = mh_bll.MonHoc_Insert(mh);
                    }
                    else
                        XtraMessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        
        }
        private void cbbChonKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbChonKhoa.SelectedItem==null)
            {
            }
            else
            {
                ToBoMon_Public tbm=new ToBoMon_Public();
                tbm.Khoa.IdKhoa=int.Parse(cbbChonKhoa.SelectedValue.ToString());
                
                cbbChonToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
                cbbChonToBoMon.DisplayMember = "TenToBoMon";
                cbbChonToBoMon.ValueMember = "IdToBoMon";
            }
        }
        bool bKiemTraClickSua;
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if ((gridView1.FocusedColumn.FieldName == "TenMonHoc") || (gridView1.FocusedColumn.FieldName == "MoTa")||(gridView1.FocusedColumn.FieldName == "IdToBoMon"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại môn học {0}", gridView1.GetFocusedRowCellValue("TenMonHoc")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            mh = new MonHoc_Public();
                            mh.IdMonHoc = int.Parse(gridView1.GetFocusedRowCellValue("IdMonHoc").ToString());
                            gridView1.FocusedColumn = gridView1.Columns["IdMonHoc"];
                            mh.TenMonHoc = gridView1.GetFocusedRowCellValue("TenMonHoc").ToString();
                            mh.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            mh.ToBoMon.IdToBoMon = int.Parse(gridView1.GetFocusedRowCellValue("IdToBoMon").ToString());
                            kq = mh_bll.MonHoc_Update(mh);
                            if (kq > 0)
                                XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa môn {0}", gridView1.GetFocusedRowCellValue("TenMonHoc")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    mh = new MonHoc_Public();
                    mh.IdMonHoc = int.Parse(gridView1.GetFocusedRowCellValue("IdMonHoc").ToString());
                    kq = mh_bll.MonHoc_Delete(mh);
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
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ThemChuong)
                {

                    frmChuong frm = new frmChuong(int.Parse(gridView1.GetFocusedRowCellValue("IdMonHoc").ToString()));
                    frm.ShowDialog();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                }
        }
    }
}
