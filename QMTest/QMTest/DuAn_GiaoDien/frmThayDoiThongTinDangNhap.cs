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
    public partial class frmThayDoiThongTinDangNhap : XtraForm
    {
        public frmThayDoiThongTinDangNhap()
        {
            InitializeComponent();
        }
        GiaoVien_BLL gv_bll = new GiaoVien_BLL();
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                
                GiaoVien_Public gv = new GiaoVien_Public();
                gv.TaiKhoan = meTenTaiKhoan.Text.Trim();
                DataTable dt = new DataTable();
                dt = gv_bll.GiaoVien_Select_TaiKhoan(gv);
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Tên tài khoản đã tồn tại, vui lòng đặt lại tên khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                    int kq = gv_bll.DoiTenTaiKhoan(gv);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Đổi tên tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = "Thay đổi tên tài khoản";
                        sys_bll.SystemLog_Insert(sys);
                    }
                    else XtraMessageBox.Show("Thao tác thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (!string.Equals(txtMKC.Text, frm_DangNhap.GetMatKhau))
            {
                XtraMessageBox.Show("Sai mật khẩu cũ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!string.Equals(txtMKM.Text, txtXacNhanMK.Text))
            {
                XtraMessageBox.Show("Xác nhận lại mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    GiaoVien_Public gv = new GiaoVien_Public();
                    gv.MatKhau = txtXacNhanMK.Text;
                    gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                    int kq = gv_bll.DoiMatKhau(gv);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = "Đổi mật khẩu";
                        sys_bll.SystemLog_Insert(sys);
                    }
                    else XtraMessageBox.Show("Thao tác thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }

            }

        }
    }
}
