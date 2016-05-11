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
            const int Npar = 11;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            name[1] = "@TenGiaoVien";
            name[2] = "@TaiKhoan";
            name[3] = "@MatKhau";
            name[4] = "@IdToBoMon";
            name[5] = "@NgaySinh";
            name[6] = "@DiaChi";
            name[7] = "@SoDienThoai";
            name[8] = "@TrangThai";
            name[9] = "@HinhAnh";
            name[10] = "@IdQuyen";
            obj[0] = gv.IdGiaoVien;
            obj[1] = gv.TenGiaoVien;
            obj[2] = gv.TaiKhoan;
            obj[3] = gv.MatKhau;
            obj[4] = gv.IdToBoMon;
            obj[5] = gv.NgaySinh;
            obj[6] = gv.DiaChi;
            obj[7] = gv.SoDienThoai;
            obj[8] = gv.TrangThai;
            obj[9] = gv.Image;
            obj[10] = gv.Quyen.IdQuyen;
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
    }
}
