using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class PhanQuyenNhapCauHoi_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable PhanQuyenNhapCauHoi_Select(MaTranKienThuc_Public mtkt)
        {
            const int Npar = 2;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            name[1] = "@IdMucTriNang";
            obj[1] = mtkt.Mtn.IdMucTriNang;
            return dp.SQL_Laydulieu("PhanQuyenNhapCauHoi_Select", name, obj, Npar);
        }
        public int PhanQuyenNhapCauHoi_Insert(PhanQuyenNhapCauHoi_Public pqnch)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMaTranKienThuc";
            obj[0] = pqnch.Mtkt.IdMaTranKienThuc;
            name[1] = "@IdGiaoVien";
            obj[1] = pqnch.Gv.IdGiaoVien;
            name[2] = "@SoCauPhaiNhap";
            obj[2] = pqnch.SoCauPhaiNhap;
            return dp.SQL_Thuchien("PhanQuyenNhapCauHoi_Insert", name, obj, Npar);
        }
        public int PhanQuyenNhapCauHoi_Update(PhanQuyenNhapCauHoi_Public pqnch)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMaTranKienThuc";
            obj[0] = pqnch.Mtkt.IdMaTranKienThuc;
            name[1] = "@IdGiaoVien";
            obj[1] = pqnch.Gv.IdGiaoVien;
            name[2] = "@SoCauPhaiNhap";
            obj[2] = pqnch.SoCauPhaiNhap;
            return dp.SQL_Thuchien("PhanQuyenNhapCauHoi_Update", name, obj, Npar);
        }
        public int PhanQuyenNhapCauHoi_Delete(PhanQuyenNhapCauHoi_Public pqnch)
        {
            const int Npar = 2;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMaTranKienThuc";
            obj[0] = pqnch.Mtkt.IdMaTranKienThuc;
            name[1] = "@IdGiaoVien";
            obj[1] = pqnch.Gv.IdGiaoVien;
            return dp.SQL_Thuchien("PhanQuyenNhapCauHoi_Delete", name, obj, Npar);
        }
        public DataTable PhanQuyenNhapCauHoi_Select_IdMaTranKienThuc(PhanQuyenNhapCauHoi_Public pqnch)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMaTranKienThuc";
            obj[0] = pqnch.Mtkt.IdMaTranKienThuc;
            return dp.SQL_Laydulieu("PhanQuyenNhapCauHoi_Select_IdMaTranKienThuc", name, obj, Npar);
        }
        public DataTable KiemTraPhanQuyenSoanCauHoi(PhanQuyenNhapCauHoi_Public pqnch)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = pqnch.Gv.IdGiaoVien;

            return dp.SQL_Laydulieu("KiemTraPhanQuyenSoanCauHoi", name, obj, Npar);
        }
    }
}
