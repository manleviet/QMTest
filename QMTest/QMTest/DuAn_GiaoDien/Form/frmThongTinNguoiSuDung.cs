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
using System.IO;

namespace DuAn_GiaoDien
{
    public partial class frmThongTinNguoiSuDung : XtraForm
    {
        public static ChucDanh_Public cd = new ChucDanh_Public();
        public static GiaoVien_Public gv = new GiaoVien_Public();
        public static Khoa_Public k = new Khoa_Public();
        public static ToBoMon_Public tbm = new ToBoMon_Public();
        GiaoVien_BLL gvbll = new GiaoVien_BLL();
        public frmThongTinNguoiSuDung()
        {
            InitializeComponent();
        }
        
        
        public void frmThongTinNguoiSuDung_Load(object sender, EventArgs e)
        {
            string[] name = new string[2];
            object[] obj = new object[2];
            name[0] = "@TaiKhoan";
            name[1] = "@MatKhau";
            obj[0] = frm_DangNhap.GetTaiKhoan;
            obj[1] = frm_DangNhap.GetMatKhau;
            DataTable dt = new DataTable();
            dt = gvbll.GiaoVien_DangNhap(name, obj, 2);
            //try
            //{
                gv.IdGiaoVien = int.Parse(dt.Rows[0]["IdGiaoVien"].ToString());
                gv.TenGiaoVien = dt.Rows[0]["TenGiaoVien"].ToString();
                gv.TaiKhoan = dt.Rows[0]["TaiKhoan"].ToString();
                gv.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                gv.IdToBoMon = dt.Rows[0]["IdToBoMon"].ToString();
                gv.NgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                if (dt.Rows[0]["DiaChi"].ToString() != "")
                    gv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                else gv.DiaChi = "...";
                if (dt.Rows[0]["SoDienThoai"].ToString() != "")
                    gv.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
                else gv.SoDienThoai = "...";
                gv.TrangThai = bool.Parse(dt.Rows[0]["TrangThai"].ToString());
                if (dt.Rows[0]["Email"].ToString() != "")
                    gv.Email = dt.Rows[0]["Email"].ToString();
                else gv.Email = "...";
                DataTable dtb = new DataTable();
                dtb = gvbll.GiaoVien_ThongTin(gv);
                if (dtb.Rows.Count > 0)
                {
                    k.TenKhoa = dtb.Rows[0]["TenKhoa"].ToString();
                    tbm.TenToBoMon = dtb.Rows[0]["TenToBoMon"].ToString();
                    if (dtb.Rows[0]["TenChucDanh"].ToString() != "")
                        cd.TenChucDanh = dtb.Rows[0]["TenChucDanh"].ToString();
                    else cd.TenChucDanh = "";
                }

                lbIdGiaoVien.Text = gv.IdGiaoVien.ToString();
                lbTenGiaoVien.Text = gv.TenGiaoVien;
                lbKhoa.Text = k.TenKhoa;
                lbMatKhau.Text = "";
                foreach (char ch in gv.MatKhau.ToArray())
                {
                    lbMatKhau.Text += "*";
                }

                lbTenDangNhap.Text = gv.TaiKhoan;
                lbToBoMon.Text = tbm.TenToBoMon;
                lbSDT.Text = gv.SoDienThoai;
                lbDiaChi.Text = gv.DiaChi;
                lbChucDanh.Text = cd.TenChucDanh;
                lbNgaySinh.Text = gv.NgaySinh.ToShortDateString();
                checkEditTrangThai.Checked = gv.TrangThai;
                lbEmail.Text = gv.Email;
                if (dt.Rows[0]["HinhAnh"].ToString() != "")
                {
                    MemoryStream str = new MemoryStream((byte[])dt.Rows[0]["HinhAnh"]);
                    pictureBox1.Image = Image.FromStream(str);
                    gv.Image = (byte[])dt.Rows[0]["HinhAnh"];
                }
                else
                {
                    pictureBox1.Image = null;
                    gv.Image = null;
                }
            //}
            //catch { }
            
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHieuChinhThongTinGiaoVien frm = new frmHieuChinhThongTinGiaoVien();
            frm.ShowDialog();
            frmThongTinNguoiSuDung_Load(sender, e);
        }

        private void checkEditTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmThayDoiThongTinDangNhap frm = new frmThayDoiThongTinDangNhap();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
