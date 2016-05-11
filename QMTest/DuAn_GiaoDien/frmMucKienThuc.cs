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
    public partial class frmMucKienThuc : XtraForm
    {
        public frmMucKienThuc()
        {
            InitializeComponent();
        }
        int GetIdChuDe;
        public frmMucKienThuc(int GetIdChuDe)
        {
            InitializeComponent();
            this.GetIdChuDe = GetIdChuDe;
        }
        DataTable dt;
        MucKienThuc_BLL mkt_bll = new MucKienThuc_BLL();
        MucKienThuc_Public mkt;
        private void frmMucKienThuc_Load(object sender, EventArgs e)
        {
            this.Size = new Size(549, 374);
            dt = new DataTable();
            mkt = new MucKienThuc_Public();
            mkt.Cd.IdChuDe = GetIdChuDe;
            gridControl1.DataSource = mkt_bll.MucKienThuc_Select_IdChuDe(mkt);
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void lbThemMucKienThuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(549, 486);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            mkt = new MucKienThuc_Public();
            int kq;
            try
            {
                mkt.TenMucKienThuc = txtTenMucKienThuc.Text;
                mkt.MoTa = meMoTa.Text;
                mkt.Cd.IdChuDe = GetIdChuDe;
            }
            catch { }
            kq = mkt_bll.MucKienThuc_Insert(mkt);
            if (kq > 0)
            {
                XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = mkt_bll.MucKienThuc_Select_IdChuDe(mkt);
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
                if ((gridView1.FocusedColumn.FieldName == "TenMucKienThuc") || (gridView1.FocusedColumn.FieldName == "MoTa"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại mục kiến thức {0}", gridView1.GetFocusedRowCellValue("TenMucKienThuc")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            mkt = new MucKienThuc_Public();
                            try
                            {
                                mkt.IdMucKienThuc = gridView1.GetFocusedRowCellValue("IdMucKienThuc").ToString();
                                gridView1.FocusedColumn = gridView1.Columns["IdMucKienThuc"];
                                mkt.TenMucKienThuc = gridView1.GetFocusedRowCellValue("TenMucKienThuc").ToString();
                                mkt.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            }
                            catch { }
                            kq = mkt_bll.MucKienThuc_Update(mkt);
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
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa mục kiến thức {0}", gridView1.GetFocusedRowCellValue("TenMucKienThuc")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    mkt = new MucKienThuc_Public();
                    mkt.IdMucKienThuc = gridView1.GetFocusedRowCellValue("IdMucKienThuc").ToString();
                    kq = mkt_bll.MucKienThuc_Delete(mkt);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                    else
                        XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //gridControl1.DataSource = ch_bll.Chuong_Select();

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
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ChonMucTriNang)
                {

                    frmMucTriNang frm = new frmMucTriNang(gridView1.GetFocusedRowCellValue("IdMucKienThuc").ToString());
                    frm.ShowDialog();
                }
        }
    }
}
