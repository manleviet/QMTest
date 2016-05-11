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
            lbMaSo.Text = frmThongTinNguoiSuDung.gv.IdGiaoVien.ToString();
            txtHoTen.Text = frmThongTinNguoiSuDung.gv.TenGiaoVien;
            txtDiaChi.Text = frmThongTinNguoiSuDung.gv.DiaChi;
            dateEditNgaySinh.Text = frmThongTinNguoiSuDung.gv.NgaySinh.ToShortDateString();
            txtSoDienThoai.Text = frmThongTinNguoiSuDung.gv.SoDienThoai;
            txtEmail.Text = frmThongTinNguoiSuDung.gv.Email;
            if (frmThongTinNguoiSuDung.gv.Image != null)
            {
                MemoryStream str = new MemoryStream(frmThongTinNguoiSuDung.gv.Image);
                pictureBox1.Image = Image.FromStream(str);
            }
            else pictureBox1.Image = null;
       
        }
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int kq;
            GiaoVien_Public gv = new GiaoVien_Public() { IdGiaoVien = int.Parse(lbMaSo.Text), TenGiaoVien = txtHoTen.Text, NgaySinh = DateTime.Parse(dateEditNgaySinh.EditValue.ToString()), SoDienThoai = txtSoDienThoai.Text, IdToBoMon = cbbToBoMon.SelectedValue.ToString(), TrangThai = checkEditTrangThai.Checked, DiaChi = txtDiaChi.Text, Image = imageToByteArray(pictureBox1.Image), Email = txtEmail.Text };
                kq = gvbll.GiaoVien_Update(gv);
                if (kq > 0)
                {
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SystemLog_Public sys = new SystemLog_Public();
                    sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                    sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                    sys.MoTa = "Hiệu chỉnh thông tin cá nhân";
                    sys_bll.SystemLog_Insert(sys);
                }
                else XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
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
            try
            {
                cbbToBoMon.DisplayMember = "TenToBoMon";
                cbbToBoMon.ValueMember = "IdToBoMon";
                cbbToBoMon.DataSource = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
            }
            catch { }
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
