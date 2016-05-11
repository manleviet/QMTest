using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
namespace Test_DataAccess
{
    public class MonHoc_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable MonHoc_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("MonHoc_Select");
        }

        public int MonHoc_Insert(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 3;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenMonHoc";
            name[1] = "@MoTa";
            name[2] = "@IdToBoMon";
            obj[0] = mh.TenMonHoc;
            obj[1] = mh.MoTa;
            obj[2] = mh.ToBoMon.IdToBoMon;
            return dp.SQL_Thuchien("MonHoc_Insert", name, obj, Npar);
        }
        public int MonHoc_Delete(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = mh.IdMonHoc;
            return dp.SQL_Thuchien("MonHoc_Delete", name, obj, Npar);
        }
        public int MonHoc_Update(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 4;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            name[1] = "@TenMonHoc";
            name[2] = "@MoTa";
            name[3] = "@IdToBoMon";


            obj[0] = mh.IdMonHoc;
            obj[1] = mh.TenMonHoc;
            obj[2] = mh.MoTa;
            obj[3] = mh.ToBoMon.IdToBoMon;


            return dp.SQL_Thuchien("MonHoc_Update", name, obj, Npar);
        }
        public DataTable MonHoc_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = tbm.IdToBoMon;
            return dp.SQL_Laydulieu("MonHoc_Select_IdToBoMon", name, obj, Npar);
        }
        public DataTable MonHoc_Select_IdToBoMon(MonHoc_Public mh)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = mh.ToBoMon.IdToBoMon;
            return dp.SQL_Laydulieu("MonHoc_Select_IdToBoMon", name, obj, Npar);
        }
        public DataTable MonHoc_Select_IdGiaoVien(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("GetMonHoc_IdGiaoVien", name, obj, Npar);
        }
        public DataTable GetMonHoc_IdGiaoVien(GiaoVien_Public gv)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = gv.IdGiaoVien;
            return dp.SQL_Laydulieu("MonHoc_Select_IdGiaoVien", name, obj, Npar);
        }
        public DataTable GetMonHocCoDe()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("GetMonHocCoDe");
        }
        public DataTable GetMaDeTheoMonHoc(int IdMonHoc)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = IdMonHoc;
            return dp.SQL_Laydulieu("GetMaDeTheoMonHoc", name, obj, Npar);
        }
        public DataTable GetThoiGianThi(int IdDe)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdDe";
            obj[0] = IdDe;
            return dp.SQL_Laydulieu("GetThoiGianThi", name, obj, Npar);
        }
        public DataTable qm_GetNoiDungDeThi(int IdDe)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@made";
            obj[0] = IdDe;
            return dp.SQL_Laydulieu("qm_GetNoiDungDeThi", name, obj, Npar);
        }
        public DataTable GetMaDe_DapAn(int IdDe)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@made";
            obj[0] = IdDe;
            return dp.SQL_Laydulieu("GetMaDe_DapAn", name, obj, Npar);
        }


        
    }
}
