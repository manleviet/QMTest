using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_PublicLayer;
using Test_BussinessLogicLayer;

namespace DuAn_GiaoDien
{
    public partial class frmChuong : XtraForm
    {
        public frmChuong()
        {
            InitializeComponent();
        }
        public frmChuong(int GetIdMonHoc)
        {
            InitializeComponent();
            this.GetIdMonHoc = GetIdMonHoc;
        }
        Chuong_Public ch;
        Chuong_BLL ch_bll = new Chuong_BLL();
        int GetIdMonHoc;
        private void frmChuong_Load(object sender, EventArgs e)
        {
            this.Size = new Size(549, 374);
            ch = new Chuong_Public();
            ch.Mh.IdMonHoc = GetIdMonHoc;
            gridControl1.DataSource = ch_bll.Chuong_Select_IdMonHoc(ch);
            if (gridView1.RowCount > 0)
                gridView1.OptionsBehavior.ReadOnly = true;
            else
                gridView1.OptionsBehavior.ReadOnly = false;
        }

        private void lbThemChuong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(549, 486);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ch = new Chuong_Public();
            int kq;
            try
            {
                ch.TenChuong = txtTenChuong.EditValue.ToString();
                ch.MoTa = meMoTa.EditValue.ToString();
                ch.Mh.IdMonHoc = GetIdMonHoc;
            }
            catch { }
            kq= ch_bll.Chuong_Insert(ch);
            if (kq > 0)
            {
                XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = ch_bll.Chuong_Select_IdMonHoc(ch);
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
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa chương {0}", gridView1.GetFocusedRowCellValue("TenChuong")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    ch = new Chuong_Public();
                    ch.IdChuong = int.Parse(gridView1.GetFocusedRowCellValue("IdChuong").ToString());
                    kq = ch_bll.Chuong_Delete(ch);
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
                    //DevExpress.XtraGrid.Views.Base.ColumnView View = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.FocusedView;
                    //View.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.OptionsBehavior.ReadOnly = false;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.ShowEditor();
                }
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ThemChuDe)
                {
                    frmChuDe frm = new frmChuDe();
                    frm.ShowDialog();
                }

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if ((gridView1.FocusedColumn.FieldName == "TenChuong")||(gridView1.FocusedColumn.FieldName == "MoTa"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại chương {0}", gridView1.GetFocusedRowCellValue("TenChuong")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            ch = new Chuong_Public();
                            ch.IdChuong = int.Parse(gridView1.GetFocusedRowCellValue("IdChuong").ToString());
                            gridView1.FocusedColumn = gridView1.Columns["IdChuong"];
                            ch.TenChuong = gridView1.GetFocusedRowCellValue("TenChuong").ToString();
                            ch.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            kq = ch_bll.Chuong_Update(ch);
                            if (kq > 0)
                                XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }
    }
}
