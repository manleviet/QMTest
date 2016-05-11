using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class GiaoVien_BLL
    {
        
        GiaoVien_DAL dv = new GiaoVien_DAL();
        public DataTable GiaoVien_Select()
        {
            return dv.GiaoVien_Select();
        }
        public int GiaoVien_Insert(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Insert(gv);
        }
        public int GiaoVien_Update(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Update(gv);
        }
        public DataTable GiaoVien_DangNhap(string[] name, object[] obj, int Npar)
        {
            return dv.GiaoVien_DangNhap(name, obj, Npar);
        }
        public DataTable GiaoVien_ThongTin(GiaoVien_Public gv)
        {
            return dv.GiaoVien_ThongTin(gv);
        }
        public DataTable GiaoVien_Select_IdGiaoVien(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Select_IdGiaoVien(gv);
        }
        public DataTable GiaoVien_Select_TrangThai()
        {
            return dv.GiaoVien_Select_TrangThai();
        }
        public int DoiTenTaiKhoan(GiaoVien_Public gv)
        {
            return dv.DoiTenTaiKhoan(gv);
        }
        public int DoiMatKhau(GiaoVien_Public gv)
        {
            return dv.DoiMatKhau(gv);
        }
        public DataTable GiaoVien_Select_TaiKhoan(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Select_TaiKhoan(gv);
        }
        public DataTable GetNhiemVu(GiaoVien_Public gv, MonHoc_Public mh)
        {
            return dv.GetNhiemVu(gv, mh);
        }
        public DataTable GiaoVien_Select_IdToBoMon(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Select_IdToBoMon(gv);
        }
        public int GiaoVien_Delete(GiaoVien_Public gv)
        {
            return dv.GiaoVien_Delete(gv);
        }
        public DataTable KiemTraSoanCauHoiNHCT(GiaoVien_Public gv)
        {
            return dv.KiemTraSoanCauHoiNHCT(gv);
        }
        public DataTable KiemTraSoanCauHoiNHSB(GiaoVien_Public gv)
        {
            return dv.KiemTraSoanCauHoiNHSB(gv);
        }
    }
}
