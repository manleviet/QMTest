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
using System.Drawing.Imaging;
using System.IO;

namespace DuAn_GiaoDien
{
    public partial class frmHieuChinhThongTinGiaoVien : XtraForm
    {
        public frmHieuChinhThongTinGiaoVien()
        {
            InitializeComponent();
        }
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        GiaoVien_BLL gvbll = new GiaoVien_BLL();
        Khoa_BLL k_bll = new Khoa_BLL();
        private void frmThemGiaoVien_Load(object sender, EventArgs e)
        {
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "IdKhoa";
            cbbKhoa.DataSource = k_bll.Khoa_Select();
            cbbKhoa.SelectedIndex = 0;
            cbbToBoMon.Text = frmThongTinNguoiSuDung.tbm.TenToBoMon;
            txtMaSo.Text = frmThongTinNguoiSuDung.gv.IdGiaoVien.ToString();
            txtHoTen.Text = frmThongTinNguoiSuDung.gv.TenGiaoVien;
            txtDiaChi.Text = frmThongTinNguoiSuDung.gv.DiaChi;
            dateEditNgaySinh.Text = frmThongTinNguoiSuDung.gv.NgaySinh.ToShortDateString();
            txtSoDienThoai.Text = frmThongTinNguoiSuDung.gv.SoDienThoai;
            txtTaiKhoan.Text = frmThongTinNguoiSuDung.gv.TaiKhoan;
            //txtMatKhau.Text = frmThongTinNguoiSuDung.gv.MatKhau;
            //frmThemGiaoVien frm = new frmThemGiaoVien() { AcceptButton = btnLuu };
       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int kq;
            if (!Equals(txtMatKhau.Text.Trim(), frmThongTinNguoiSuDung.gv.MatKhau))
                XtraMessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Equals(txtXacNhanMKM.Text.Trim(), txtMKM.Text.Trim()))
                XtraMessageBox.Show("Mật khẩu mới không giống nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GiaoVien_Public gv = new GiaoVien_Public() { IdGiaoVien = int.Parse(txtMaSo.Text), TenGiaoVien = txtHoTen.Text, NgaySinh = DateTime.Parse(dateEditNgaySinh.EditValue.ToString()), SoDienThoai = txtSoDienThoai.Text, TaiKhoan = txtTaiKhoan.Text, MatKhau = txtXacNhanMKM.Text, IdToBoMon = cbbToBoMon.SelectedValue.ToString(), TrangThai = checkEditTrangThai.Checked, DiaChi = txtDiaChi.Text,Image=anh };
                kq = gvbll.GiaoVien_Update(gv);
                if (kq > 0)
                {
                    //frm_DangNhap.tk = gv.TaiKhoan;
                    //frm_DangNhap.mk = gv.MatKhau;
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue==null) return;

            ToBoMon_Public tbm = new ToBoMon_Public();
            tbm.Khoa.IdKhoa = int.Parse(cbbKhoa.SelectedValue.ToString());
            //Khoa_Public k=new Khoa_Public();
            //k.IdKhoa=cbbKhoa.SelectedValue.ToString();

            try
            {
                cbbToBoMon.DisplayMember = "TenToBoMon";
                cbbToBoMon.ValueMember = "IdToBoMon";
                cbbToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
            }
            catch { }
        }

        private void txtMatKhau_Validated(object sender, EventArgs e)
        {
            if (Equals(txtMatKhau.Text.Trim(), frmThongTinNguoiSuDung.gv.MatKhau))
            {
                btnMKC_NoError.Visible = true;
                btnMKC_Error.Visible = false;
            }
            else
            {
                btnMKC_Error.Visible = true;
                btnMKC_NoError.Visible = false;
            }
       
            
        }

        private void txtXacNhanMKM_Validated(object sender, EventArgs e)
        {
            if (Equals(txtMKM.Text.Trim(),txtXacNhanMKM.Text.Trim()))
            {
                btnMKM_NoError.Visible = true;
                btnMKM_Error.Visible = false;
            }
            else
            {
                btnMKM_Error.Visible = true;
                btnMKM_NoError.Visible = false;
            }
        }

        private void txtMKM_Validated(object sender, EventArgs e)
        {
            if (Equals(txtMKM.Text.Trim(), txtXacNhanMKM.Text.Trim()))
            {
                btnMKM_NoError.Visible = true;
                btnMKM_Error.Visible = false;
            }
            else
            {
                btnMKM_Error.Visible = true;
                btnMKM_NoError.Visible = false;
            }
        }
        byte[] anh;
        private void simpleButton1_Click(object sender, EventArgs e) // btnChonAnh
        {
            OpenFileDialog dlg = new OpenFileDialog();
            anh = null;
            dlg.Filter = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }
            dlg.DefaultExt = ".PNG";// Default file extension 
            dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, "All Files", "*.*");

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    anh = new Byte[fs.Length];
                    fs.Read(anh, 0, (int)fs.Length);
                    //Đưa ảnh lên picturedit1
                    MemoryStream str = new MemoryStream(anh);
                    pictureBox1.Image = Image.FromStream(str);
                }
            }
        }
        
     


        
    }
}
