using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class ToBoMon_DAL
    {
        DataProvider dp = new DataProvider();

        public DataTable ToBoMon_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("ToBoMon_Select");
        }
        public DataTable ToBoMon_Select_IdKhoa(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdKhoa";
            obj[0] = tbm.Khoa.IdKhoa;
            return dp.SQL_Laydulieu("ToBoMon_Select_IdKhoa", name, obj, Npar);
        }
        public DataTable ToBoMon_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = tbm.IdToBoMon;
            return dp.SQL_Laydulieu("ToBoMon_Select_IdToBoMon", name, obj, Npar);
        }
        public int ToBoMon_Insert(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 3;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenToBoMon";
            name[1] = "@MoTa";
            name[2] = "@IdKhoa";
            obj[0] = tbm.TenToBoMon;
            obj[1] = tbm.MoTa;
            obj[2] = tbm.Khoa.IdKhoa;
            return dp.SQL_Thuchien("ToBoMon_Insert", name, obj, Npar);
        }
        public int ToBoMon_Delete(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = tbm.IdToBoMon;
            return dp.SQL_Thuchien("ToBoMon_Delete", name, obj, Npar);
        }
        public int ToBoMon_Update(ToBoMon_Public tbm)
        {
            dp.KetnoiCSDL();
            const int Npar = 4;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = tbm.IdToBoMon;
            name[1] = "@TenToBoMon";
            name[2] = "@MoTa";
            name[3] = "@IdKhoa";
            obj[1] = tbm.TenToBoMon;
            obj[2] = tbm.MoTa;
            obj[3] = tbm.Khoa.IdKhoa;
            return dp.SQL_Thuchien("ToBoMon_Update", name, obj, Npar);
        }
    }
}
