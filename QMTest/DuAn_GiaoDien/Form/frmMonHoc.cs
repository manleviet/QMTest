using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_BussinessLogicLayer;
using Test_PublicLayer;


namespace DuAn_GiaoDien
{
    public partial class frmMonHoc : XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        MonHoc_BLL mhbll = new MonHoc_BLL();
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        ToBoMon_Public tbm;
        Khoa_BLL kbll = new Khoa_BLL();
        MonHoc_Public mh;
        ChiTietGiangDay_BLL ctgd_bll = new ChiTietGiangDay_BLL();
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource = mh.Laybang();
            if (Form1.Enable_ThemMoi == true)
            {
                pCapNhatMH.Enabled = true;
            }
            gridControlMonHoc.DataSource = mhbll.MonHoc_Select();

            cbbKhoa.DataSource=kbll.Khoa_Select();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "IdKhoa";
           
        }


        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            //k = new Khoa_Public();
            tbm = new ToBoMon_Public();
            if (cbbKhoa.SelectedIndex != -1) 
            {
                tbm.Khoa.IdKhoa = int.Parse(cbbKhoa.SelectedValue.ToString());
                cbbToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
                cbbToBoMon.ValueMember = "IdToBoMon";
                cbbToBoMon.DisplayMember = "TenToBoMon";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (capnhat == true)
            {
                MonHoc_Public mh2 = new MonHoc_Public();
                mh2.IdMonHoc = int.Parse(txtIdMonHoc.Text.Trim());
                mh2.TenMonHoc = txtTenMonHoc.Text.Trim();
                mh2.MoTa = txtMoTa.Text.Trim();
                mh2.ToBoMon.IdToBoMon = int.Parse(cbbToBoMon.SelectedValue.ToString());
                int kq1 = 0;
                kq1 = mhbll.MonHoc_Update(mh2);
                if (kq1 > 0)
                {
                    XtraMessageBox.Show(string.Format("Cập nhật môn học {0} thành công!", mh2.TenMonHoc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControlMonHoc.DataSource = mhbll.MonHoc_Select();
                }
                else XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Thêm mới môn học
                mh = new MonHoc_Public() { IdMonHoc = int.Parse(txtIdMonHoc.Text.Trim()), TenMonHoc = txtTenMonHoc.Text.Trim(), MoTa = txtTenMonHoc.Text.Trim() };
                mh.ToBoMon.IdToBoMon = int.Parse(cbbToBoMon.SelectedValue.ToString());

                int kq = 0;
                kq = mhbll.MonHoc_Insert(mh);
                if (kq > 0)
                {
                    XtraMessageBox.Show(string.Format("Thêm môn học {0} thành công!", mh.TenMonHoc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControlMonHoc.DataSource = mhbll.MonHoc_Select();
                }
                else XtraMessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
        int row;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            row = gridView1.FocusedRowHandle;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kq=0;
            string IdMonHoc = gridView1.GetRowCellValue(row, gridView1.Columns["IdMonHoc"]).ToString() ;
            if (XtraMessageBox.Show(String.Format("Bạn muốn xóa môn {0}?", gridView1.GetRowCellValue(row, gridView1.Columns["TenMonHoc"]).ToString()), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt = ctgd_bll.ChiTietGiangDay_Select_IdMonHoc(IdMonHoc);
                if (dt.Rows.Count>0)
                    XtraMessageBox.Show("Môn học đã được giảng dạy, KHÔNG ĐƯỢC XÓA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    mh=new MonHoc_Public();
                    mh.IdMonHoc=int.Parse(IdMonHoc);
                    kq=mhbll.MonHoc_Delete(mh);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMonHoc_Load(sender, e);
                    }
                    else XtraMessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
               
            }
        }
        bool capnhat;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capnhat = true;
            pCapNhatMH.Enabled = true;
            LayThongTin_CapNhat();            
        }

        private void LayThongTin_CapNhat()
        {
            // Cập nhật môn học        
            txtIdMonHoc.Text = gridView1.GetRowCellValue(row, gridView1.Columns["IdMonHoc"]).ToString();
            txtTenMonHoc.Text = gridView1.GetRowCellValue(row, gridView1.Columns["TenMonHoc"]).ToString();
            txtMoTa.Text = gridView1.GetRowCellValue(row, gridView1.Columns["MoTa"]).ToString();

            tbm = new ToBoMon_Public();
            tbm.IdToBoMon = int.Parse(gridView1.GetRowCellValue(row, gridView1.Columns["IdToBoMon"]).ToString());

            if (tbm.IdToBoMon == 0)
            {
                cbbToBoMon.DataSource = tbm_bll.ToBoMon_Select();
                cbbToBoMon.DisplayMember = "TenToBoMon";
                cbbToBoMon.ValueMember = "IdToBoMon";
                cbbToBoMon.Text = "";
                cbbKhoa.Text = "";
            }
            else
            {
                cbbToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdToBoMon(tbm);
                cbbToBoMon.DisplayMember = "TenToBoMon";
                cbbToBoMon.ValueMember = "IdToBoMon";
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            capnhat = false;
            pCapNhatMH.Enabled = true;
        }

        private void cbbToBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //hiển thị tất cả các khoa
                cbbKhoa.DataSource = kbll.Khoa_Select();
                cbbKhoa.DisplayMember = "TenKhoa";
                cbbKhoa.ValueMember = "IdKhoa";
                //lấy khóa của ToBoMon
                tbm.IdToBoMon = int.Parse(cbbToBoMon.SelectedValue.ToString());
               //hiển thị Khoa tương ứng với ToBoMon
                DataTable dt = new DataTable();
                dt= kbll.Khoa_Select_IdToBoMon(tbm);
                cbbKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
                cbbKhoa.ValueMember = "IdKhoa";
            }
            catch
            {

            }
            
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
