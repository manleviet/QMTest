using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class MaTranKienThuc_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable MucTriNang_Select_IdMucKienThuc(MucKienThuc_Public mkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mkt.IdMucKienThuc;
            return dp.SQL_Laydulieu("MucTriNang_Select_IdMucKienThuc", name, obj, Npar);
        }
        public DataTable MaTranKienThuc_Select_IdMonHoc(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = mh.IdMonHoc;
            return dp.SQL_Laydulieu("MaTranKienThuc_Select_IdMonHoc", name, obj, Npar);
        }
        public int MaTranKienThuc_Insert(MaTranKienThuc_Public mtkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 4;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            name[1] = "@IdMucTriNang";
            obj[1] = mtkt.Mtn.IdMucTriNang;
            name[2] = "@SoCauNhap";
            obj[2] = mtkt.SoCauNhap;
            name[3] = "@SoCauQuyDinh";
            obj[3] = mtkt.SoCauQuyDinh;

            return dp.SQL_Thuchien("MaTranKienThuc_Insert", name, obj, Npar);
        }
        public int MaTranKienThuc_Delete(MaTranKienThuc_Public mtkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            name[1] = "@IdMucTriNang";
            obj[1] = mtkt.Mtn.IdMucTriNang;
            return dp.SQL_Thuchien("MaTranKienThuc_Delete", name, obj, Npar);
        }
        public int MaTranKienThuc_Update(MaTranKienThuc_Public mtkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 4;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            name[1] = "@SoCauNhap";
            obj[1] = mtkt.SoCauNhap;
            name[2] = "@SoCauQuyDinh";
            obj[2] = mtkt.SoCauQuyDinh;
            name[3] = "@IdMucTriNang";
            obj[3] = mtkt.Mtn.IdMucTriNang;
            
            return dp.SQL_Thuchien("MaTranKienThuc_Update", name, obj, Npar);
        }
        public DataTable MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(MaTranKienThuc_Public mtkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            name[1] = "@IdMucTriNang";
            obj[1] = mtkt.Mtn.IdMucTriNang;
            return dp.SQL_Laydulieu("MaTranKienThuc_Select_IdMucKienThucIdMucTriNang", name, obj, Npar);
        }
        public DataTable MaTranKienThuc_Select_IdMucKienThuc(MaTranKienThuc_Public mtkt)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            obj[0] = mtkt.Mkt.IdMucKienThuc;
            return dp.SQL_Laydulieu("MaTranKienThuc_Select_IdMucKienThuc", name, obj, Npar);
        }
    }
}
