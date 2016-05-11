using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{

    public class CauHoi_DAL
    {
        DataProvider dp = new DataProvider();
        public int CauHoi_Insert(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 10;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung";
            obj[0] = ch.NoiDung;
            name[1] = "@IdLoaiCauHoi";
            obj[1] = ch.Lch.IdLoaiCauHoi;
            name[2] = "@IdMaTranKienThuc";
            obj[2] = ch.Mtkt.IdMaTranKienThuc;
            name[3] = "@IdGiaoVien";
            obj[3] = ch.Gv.IdGiaoVien;
            name[4] = "@IdDoKho";
            obj[4] = ch.Dk.IdDoKho;
            name[5] = "@NgayTao";
            obj[5] = ch.NgayTao;
            name[6] = "@NgayCapNhat";
            obj[6] = ch.NgayCapNhat;
            name[7] = "@IdGiaThietChung";
            obj[7] = ch.Gtc.IdGiaThietChung;
            name[8] = "@IdMonHoc";
            obj[8] = ch.Mh.IdMonHoc;
            name[9] = "@CongKhai";
            obj[9] = ch.CongKhai;
            return dp.SQL_Thuchien("CauHoi_Insert", name, obj, Npar);
        }
        public DataTable CauHoi_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("CauHoi_Select");
        }
        public int CauHoi_Update(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 10;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            name[1] = "@NoiDung";
            obj[1] = ch.NoiDung;
            name[2] = "@IdGiaThietChung";
            obj[2] = ch.Gtc.IdGiaThietChung;
            name[3] = "@IdLoaiCauHoi";
            obj[3] = ch.Lch.IdLoaiCauHoi;
            name[4] = "@IdMaTranKienThuc";
            obj[4] = ch.Mtkt.IdMaTranKienThuc;
            name[5] = "@IdGiaoVien";
            obj[5] = ch.Gv.IdGiaoVien;
            name[6] = "@IdDoKho";
            obj[6] = ch.Dk.IdDoKho;
            name[7] = "@DoPhanCach";
            obj[7] = ch.DoPhanCach;
            name[8] = "@NgayTao";
            obj[8] = ch.NgayTao;
            name[9] = "@NgayCapNhat";
            obj[9] = ch.NgayCapNhat;
            return dp.SQL_Thuchien("CauHoi_Update", name, obj, Npar);
        }
        public int CauHoi_Delete(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("CauHoi_Delete", name, obj, Npar);
        }
        public int CauHoiGiaThietChung_Insert(CauHoi_Public ch, GiaThietChung_Public gtc)
        {
            dp.KetnoiCSDL();
            const int Npar = 10;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung";
            obj[0] = ch.NoiDung;
            name[1] = "@NgayTao";
            obj[1] = ch.NgayTao;
            name[2] = "@NgayCapNhat";
            obj[2] = ch.NgayCapNhat;
            name[3] = "@IdLoaiCauHoi";
            obj[3] = ch.Lch.IdLoaiCauHoi;
            name[4] = "@IdMaTranKienThuc";
            obj[4] = int.Parse(ch.Mtkt.IdMaTranKienThuc);
            name[5] = "@IdGiaoVien";
            obj[5] = ch.Gv.IdGiaoVien;
            name[6] = "@IdDoKho";
            obj[6] = ch.Dk.IdDoKho;
            name[7] = "@NoiDungGTC";
            obj[7] = gtc.NoiDung;
            name[8] = "@IdMonHoc";
            obj[8] = ch.Mh.IdMonHoc;
            name[9] = "@IdCongKhai";
            obj[9] = ch.CongKhai;
            return dp.SQL_Thuchien("CauHoiGiaThietChung_Insert", name, obj, Npar);
        }
        public DataTable CauHoi_Select_IdMonHoc(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = mh.IdMonHoc;
            return dp.SQL_Laydulieu("CauHoi_Select_IdMonHoc", name, obj, Npar);
        }
        public int CauHoi_Insert_IndentCurrent(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 9;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung";
            obj[0] = ch.NoiDung;
            name[1] = "@NgayTao";
            obj[1] = ch.NgayTao;
            name[2] = "@NgayCapNhat";
            obj[2] = ch.NgayCapNhat;
            name[3] = "@IdLoaiCauHoi";
            obj[3] = ch.Lch.IdLoaiCauHoi;
            name[4] = "@IdMaTranKienThuc";
            obj[4] = int.Parse(ch.Mtkt.IdMaTranKienThuc);
            name[5] = "@IdGiaoVien";
            obj[5] = ch.Gv.IdGiaoVien;
            name[6] = "@IdDoKho";
            obj[6] = ch.Dk.IdDoKho;
            name[7] = "@IdMonHoc";
            obj[7] = ch.Mh.IdMonHoc;
            name[8] = "@CongKhai";
            obj[8] = ch.CongKhai;

            return dp.SQL_Thuchien("CauHoi_Insert_IndentCurrent", name, obj, Npar);
        }
        public DataTable CauHoi_Select_IdMonHoc(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            name[1] = "@IdGiaoVien";
            obj[1] = ch.Gv.IdGiaoVien;
            return dp.SQL_Laydulieu("CauHoi_Select_IdMonHoc", name, obj, Npar);
        }
        public int CauHoi_NganHangSoBo(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            return dp.SQL_Thuchien("NganHangSoBo", name, obj, Npar);
        }
        public int CauHoiChinhThuc_Insert(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("cauhoichinhthuc_insert", name, obj, Npar);
        }
        public DataTable CauHoi_Select_Paginate(CauHoi_Public ch,int trangthu)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            name[1] = "@trangthu";
            obj[1] = trangthu;
            return dp.SQL_Laydulieu("CauHoi_Select_Paginate", name, obj, Npar);
        }
        public DataTable CauHoiChinhThuc_Select_Paginate(CauHoi_Public ch, int trangthu)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            name[1] = "@trangthu";
            obj[1] = trangthu;
            return dp.SQL_Laydulieu("CauHoiChinhThuc_Select_Paginate", name, obj, Npar);
        }
        public int CauHoiChinhThuc_Delete(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("CauHoiChinhThuc_Delete", name, obj, Npar);
        }
        public int ChuyenCauHoiChoNHSB(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("ChuyenCauHoiChoNHSB", name, obj, Npar);
        }
        public DataTable GetCauHoiDangSoan(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            name[1] = "@IdGiaoVien";
            obj[1] = ch.Gv.IdGiaoVien;
            return dp.SQL_Laydulieu("GetCauHoiDangSoan", name, obj, Npar);
        }
        public int CauHoi_Update_IdGiaThietChung(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            name[1] = "@IdGiaThietChung";
            obj[1] = ch.Gtc.IdGiaThietChung;
            return dp.SQL_Thuchien("CauHoi_Update_IdGiaThietChung", name, obj, Npar);
        }
        public int CauHoi_SetNullIdGiaThietChung(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("CauHoi_SetNullIdGiaThietChung", name, obj, Npar);
        }
        public int CauHoi_Update_NoiDung(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            name[1] = "@NoiDung";
            obj[1] = ch.NoiDung;
            return dp.SQL_Thuchien("CauHoi_Update_NoiDung", name, obj, Npar);
        }
        public int CauHoi_SetCongKhai(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("CauHoi_SetCongKhai", name, obj, Npar);
        }
        public int CauHoi_SetKoCongKhai(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ch.IdCauHoi;
            return dp.SQL_Thuchien("CauHoi_SetKoCongKhai", name, obj, Npar);
        }
        public DataTable CauHoiChinhThuc_SelectAll(CauHoi_Public ch,int trangthu)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = ch.Gv.IdGiaoVien;
            name[1] = "@trangthu";
            obj[1] = trangthu;
            return dp.SQL_Laydulieu("CauHoiChinhThuc_SelectAll", name, obj, Npar);
        }
        public DataTable CauHoi_SelectAll(CauHoi_Public ch, int trangthu)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = ch.Gv.IdGiaoVien;
            name[1] = "@trangthu";
            obj[1] = trangthu;
            return dp.SQL_Laydulieu("CauHoi_SelectAll", name, obj, Npar);
        }
        public DataTable CountCauHoi_SelectAll(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = ch.Gv.IdGiaoVien;
            return dp.SQL_Laydulieu("CountCauHoi_SelectAll", name, obj, Npar);
        }
        public DataTable CountCauHoi_Select_IdMonHoc(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            return dp.SQL_Laydulieu("CountCauHoi_Select_IdMonHoc", name, obj, Npar);
        }
        public DataTable CountCauHoiChinhThuc_SelectAll(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = ch.Gv.IdGiaoVien;
            return dp.SQL_Laydulieu("CountCauHoiChinhThuc_SelectAll", name, obj, Npar);
        }
        public DataTable CountCauHoiChinhThuc_Select_IdMonHoc(CauHoi_Public ch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            return dp.SQL_Laydulieu("CountCauHoiChinhThuc_Select_IdMonHoc", name, obj, Npar);
        }
    }
}