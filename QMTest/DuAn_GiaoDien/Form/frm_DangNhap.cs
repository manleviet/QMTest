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

    public partial class frm_DangNhap : XtraForm
    {
        //NguoiDung_Public ndp = new NguoiDung_Public();
        //NguoiDung_BLL nd = new NguoiDung_BLL();
        //DataTable dt = new DataTable();
        //public static string TenNguoiDung;
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        GiaoVien_Public gv;
        DataTable dt = new DataTable();
        GiaoVien_BLL gvbll = new GiaoVien_BLL();
        private static string _taiKhoan;

        public static string GetTaiKhoan
        {
            get { return frm_DangNhap._taiKhoan; }
        }
        static string SetTaiKhoan
        {
            set { frm_DangNhap._taiKhoan = value; }
        }
        
        private static string _matKhau;

        public static string GetMatKhau
        {
            get { return frm_DangNhap._matKhau; }
        }
        static string SetMatKhau
        {
            set { frm_DangNhap._matKhau = value; }
        }
        private static int _idGiaoVien;

        public static int GetIdGiaoVien
        {
            get { return frm_DangNhap._idGiaoVien; }
        }
        static int SetIdGiaoVien
        {
            set { frm_DangNhap._idGiaoVien = value; }
        }
        static int _idToBoMon;

        public static int GetIdToBoMon
        {
            get { return frm_DangNhap._idToBoMon; }
        }
        static int SetIdToBoMon
        {
            set { frm_DangNhap._idToBoMon = value; }
        }
        public static GiaoVien_Public GiaoVien = new GiaoVien_Public();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            gv = new GiaoVien_Public();
            gv.TaiKhoan = txt_TenDangNhap.Text.Trim();
            gv.MatKhau = txt_MatKhau.Text.Trim();
            string[] name = new string[2];
            object[] obj = new object[2];
            name[0] = "@TaiKhoan";
            name[1] = "@MatKhau";
            obj[0] = gv.TaiKhoan;
            obj[1] = gv.MatKhau;
            dt = gvbll.GiaoVien_DangNhap(name, obj, 2);
            if (dt.Rows.Count > 0)
            {
                SetTaiKhoan = gv.TaiKhoan;
                SetMatKhau = gv.MatKhau;
                SetIdGiaoVien = int.Parse(dt.Rows[0]["IdGiaoVien"].ToString());
                SetIdToBoMon = int.Parse(dt.Rows[0]["IdToBoMon"].ToString());

                GiaoVien.Quyen.IdQuyen = int.Parse(dt.Rows[0]["IdQuyen"].ToString());
                GiaoVien.ToBoMon.IdToBoMon = int.Parse(dt.Rows[0]["IdToBoMon"].ToString());

                XtraMessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);        
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

         
    }
}
