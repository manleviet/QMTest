using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
using System.Windows.Forms;

namespace Test_DataAccess
{
   public class GiaoVien_DAL
    {
        
        DataProvider dp = new DataProvider();
        public DataTable GiaoVien_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("GiaoVien_Select");
        }
        public int GiaoVien_Insert(GiaoVien_Public gv)
        {
            const int Npar=11;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenGiaoVien";
            name[1] = "@TaiKhoan";
            name[2] = "@MatKhau";
            name[3] = "@IdToBoMon";
            name[4] = "@NgaySinh";
            name[5] = "@DiaChi";
            name[6] = "@SoDienThoai";
            name[7] = "@TrangThai";
            name[8] = "@GhiChu";
            name[9] = "@HinhAnh";
            name[10] = "@IdQuyen";
            obj[0] = gv.TenGiaoVien;
            obj[1] = gv.TaiKhoan;
            obj[2] = gv.MatKhau;
            obj[3] = gv.IdToBoMon;
            obj[4] = gv.NgaySinh;
            obj[5] = gv.DiaChi;
            obj[6] = gv.SoDienThoai;
            obj[7] = gv.TrangThai;
            obj[8] = gv.GhiChu;
            obj[9] = gv.Image;
            obj[10] = gv.Quyen.IdQuyen;
            return dp.SQL_Thuchien("GiaoVien_Insert", name, obj, Npar);            
        }
        public int GiaoVien_Update(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 8;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            name[1] = "@TenGiaoVien";
            name[2] = "@NgaySinh";
            name[3] = "@DiaChi";
            name[4] = "@SoDienThoai";
            name[5] = "@TrangThai";
            name[6] = "@HinhAnh";
            name[7] = "@Email";
            obj[0] = gv.IdGiaoVien;
            obj[1] = gv.TenGiaoVien;
            obj[2] = gv.NgaySinh;
            obj[3] = gv.DiaChi;
            obj[4] = gv.SoDienThoai;
            obj[5] = gv.TrangThai;
            obj[6] = gv.Image;
            obj[7] = gv.Email;
            return dp.SQL_Thuchien("GiaoVien_Update", name, obj, Npar);
        }
        public DataTable GiaoVien_DangNhap(string[] name, object[] obj, int Npar)
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("GiaoVien_DangNhap", name, obj, Npar);
        }
        public DataTable GiaoVien_ThongTin(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("GiaoVien_ThongTin", name, obj, Npar);
        }
        public DataTable GiaoVien_Select_IdGiaoVien(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("GiaoVien_Select_IdGiaoVien", name, obj, Npar);  
        }
        public DataTable GiaoVien_Select_TrangThai()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("GiaoVien_Select_TrangThai");
        }
        public int DoiTenTaiKhoan(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            name[1] = "@TaiKhoan";    
            obj[0] = gv.IdGiaoVien;
            obj[1] = gv.TaiKhoan;
         
            return dp.SQL_Thuchien("DoiTenTaiKhoan", name, obj, Npar);
        }
        public int DoiMatKhau(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            name[1] = "@MatKhau";
            obj[0] = gv.IdGiaoVien;
            obj[1] = gv.MatKhau;

            return dp.SQL_Thuchien("DoiMatKhau", name, obj, Npar);
        }
        public DataTable GiaoVien_Select_TaiKhoan(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TaiKhoan";
            obj[0] = gv.TaiKhoan;
            return dp.SQL_Laydulieu("GiaoVien_Select_TaiKhoan",name,obj,Npar);
        }
        public DataTable GetNhiemVu(GiaoVien_Public gv,MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            name[1] = "@IdMonHoc";
            obj[1] = mh.IdMonHoc;
            return dp.SQL_Laydulieu("NhiemVu", name, obj, Npar);
        }
        public DataTable GiaoVien_Select_IdToBoMon(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = gv.ToBoMon.IdToBoMon;
            return dp.SQL_Laydulieu("GiaoVien_Select_IdToBoMon", name, obj, Npar);
        }
        public int GiaoVien_Delete(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Thuchien("GiaoVien_Delete", name, obj, Npar);
        }
        public DataTable KiemTraSoanCauHoiNHCT(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("KiemTraSoanCauHoiNHCT", name, obj, Npar);
        }
        public DataTable KiemTraSoanCauHoiNHSB(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("KiemTraSoanCauHoiNHSB", name, obj, Npar);
        }

    }
}
