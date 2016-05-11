using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class UcDanhMucKhoa : UserControl
    {
        Khoa_BLL k_bll = new Khoa_BLL();
        Khoa_Public k;
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        ToBoMon_Public tbm;
        public UcDanhMucKhoa()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KiemTra = true;
            frmKhoa frm = new frmKhoa();
            frm.ShowDialog();
            gridView1.Columns.Clear();
            UcDanhMucKhoa_Load(sender, e);
            
        }

        private void UcDanhMucKhoa_Load(object sender, EventArgs e)
        {
            GridColumn cl1 = new GridColumn();
            cl1.FieldName = "IdKhoa";
            cl1.Caption = "ID Khoa";
            cl1.Visible = true;
            GridColumn cl2 = new GridColumn();
            cl2.FieldName = "TenKhoa";
            cl2.Caption = "Tên khoa";
            cl2.Visible = true;
            GridColumn cl3 = new GridColumn();
            cl3.FieldName = "MoTa";
            cl3.Caption = "Mô tả";
            cl3.Visible = true;
            gridView1.Columns.Add(cl1);
            gridView1.Columns.Add(cl2);
            gridView1.Columns.Add(cl3);
            gridControl1.DataSource = k_bll.Khoa_Select();
            
            
            

            
        }
        static public bool KiemTra;// kiểm tra khi nhấn nút Thêm mới, hay Cập nhật
        private void btnSua_Click(object sender, EventArgs e)
        {
            KiemTra = false;
            k = new Khoa_Public();
            k.IdKhoa = int.Parse(gridView1.GetRowCellValue(row, gridView1.Columns["IdKhoa"]).ToString());
            k.TenKhoa = gridView1.GetRowCellValue(row, gridView1.Columns["TenKhoa"]).ToString();
            k.MoTa = gridView1.GetRowCellValue(row, gridView1.Columns["MoTa"]).ToString();
            frmKhoa frm = new frmKhoa(k,KiemTra);
            frm.ShowDialog();
            gridView1.Columns.Clear();
            UcDanhMucKhoa_Load(sender, e);
        }
        int row;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           row = gridView1.FocusedRowHandle;
           
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            row = gridView1.FocusedRowHandle;       
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbm = new ToBoMon_Public();
            //k = new Khoa_Public();
            tbm.Khoa.IdKhoa =int.Parse(gridView1.GetRowCellValue(row, gridView1.Columns["IdKhoa"]).ToString());
            tbm.Khoa.TenKhoa= gridView1.GetRowCellValue(row, gridView1.Columns["TenKhoa"]).ToString();
            DataTable dt = new DataTable();
            dt = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
            if (dt.Rows.Count > 0) XtraMessageBox.Show(String.Format("Khoa {0} đã được phân Tổ bộ môn, KHÔNG THỂ XÓA", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (XtraMessageBox.Show(String.Format("Bạn muốn xóa khoa {0}?", tbm.Khoa.TenKhoa), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int kq = k_bll.Khoa_Delete(k);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show(string.Format("Xóa khoa {0} thành công!", tbm.Khoa.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcDanhMucKhoa_Load(sender, e);
                    }
                    else XtraMessageBox.Show(string.Format("Xóa khoa {0} thất bại!", tbm.Khoa.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            KiemTra = false;
            btnSua_Click(sender, e);
        }
    }
}
