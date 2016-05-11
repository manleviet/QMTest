using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class Khoa_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable Khoa_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("Khoa_Select");
        }
        public DataTable Khoa_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdToBoMon";
            obj[0] = tbm.IdToBoMon;
            return dp.SQL_Laydulieu("Khoa_Select_IdToBoMon", name, obj, Npar);
        }
        public int Khoa_Insert(Khoa_Public k)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdKhoa";
            obj[0] = k.IdKhoa;
            name[1] = "@TenKhoa";
            obj[1] = k.TenKhoa;
            name[2] = "@MoTa";
            obj[2] = k.MoTa;
            return dp.SQL_Thuchien("Khoa_Insert", name, obj, Npar);
        }
        public int Khoa_Update(Khoa_Public k)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdKhoa";
            obj[0] = k.IdKhoa;
            name[1] = "@TenKhoa";
            obj[1] = k.TenKhoa;
            name[2] = "@MoTa";
            obj[2] = k.MoTa;
            return dp.SQL_Thuchien("Khoa_Update", name, obj, Npar);
        }
        public int Khoa_Delete(Khoa_Public k)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdKhoa";
            obj[0] = k.IdKhoa;
            return dp.SQL_Thuchien("Khoa_Delete", name, obj, Npar);
        }
    }
}
