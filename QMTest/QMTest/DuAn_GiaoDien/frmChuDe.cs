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
    public partial class frmChuDe : XtraForm
    {
        public frmChuDe()
        {
            InitializeComponent();
        }
        public frmChuDe(int GetIdChuong)
        {
            InitializeComponent();
            this.GetIdChuong=GetIdChuong;
        }
        DataTable dt;
        ChuDe_BLL cd_bll=new ChuDe_BLL();
        ChuDe_Public cd;
        int GetIdChuong;
        private void frmChuDe_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(549, 374);
            dt = new DataTable();
            cd=new ChuDe_Public();
            cd.Chuong.IdChuong = GetIdChuong;
            gridControl1.DataSource = cd_bll.ChuDe_Select_IdChuong(cd);
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void lbThemChuDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Size = new Size(549, 486);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cd = new ChuDe_Public();
            int kq;
            try
            {
                cd.TenChuDe = txtTenChuDe.Text;
                cd.MoTa = meMoTa.Text;
                cd.Chuong.IdChuong = GetIdChuong;
            }
            catch { }
            kq= cd_bll.ChuDe_Insert(cd);
            if (kq > 0)
            {
                XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = cd_bll.ChuDe_Select_IdChuong(cd);
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
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa chủ đề {0}", gridView1.GetFocusedRowCellValue("TenChuDe")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bKiemTraClickSua = false;
                    cd=new ChuDe_Public();
                    try
                    {
                        cd.IdChuDe = int.Parse(gridView1.GetFocusedRowCellValue("IdChuDe").ToString());
                        //cd.Chuong.IdChuong = GetIdChuong;
                        cd.Chuong.IdChuong = GetIdChuong;
                    }
                    catch { }
                    kq = cd_bll.ChuDe_Delete(cd);
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
                else if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_ThemMucKienThuc)
                {
                    frmMucKienThuc frm=new frmMucKienThuc();
                    frm.ShowDialog();
                }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if ((gridView1.FocusedColumn.FieldName == "TenChuDe")||(gridView1.FocusedColumn.FieldName == "MoTa"))
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật lại chủ đề {0}", gridView1.GetFocusedRowCellValue("TenChuDe")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            cd = new ChuDe_Public();
                            try
                            {
                                cd.IdChuDe = int.Parse(gridView1.GetFocusedRowCellValue("IdChuDe").ToString());
                                gridView1.FocusedColumn = gridView1.Columns["IdChuDe"];
                                cd.TenChuDe = gridView1.GetFocusedRowCellValue("TenChuDe").ToString();
                                cd.MoTa = gridView1.GetFocusedRowCellValue("MoTa").ToString();
                            }
                            catch { }
                            kq = cd_bll.ChuDe_Update(cd);
                            if (kq > 0) XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }


    }
}
