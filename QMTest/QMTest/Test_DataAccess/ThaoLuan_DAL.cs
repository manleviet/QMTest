using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class ThaoLuan_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ThaoLuan_Select(ThaoLuan_Public tl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = tl.CauHoi.IdCauHoi;
            return dp.SQL_Laydulieu("ThaoLuan_Select",name,obj,Npar);
        }
        public int ThaoLuan_Insert(ThaoLuan_Public tl)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = tl.GiaoVien.IdGiaoVien;
            name[1] = "@IdCauHoi";
            obj[1] = tl.CauHoi.IdCauHoi;
            name[2] = "@NoiDung";
            obj[2] = tl.NoiDung;
            return dp.SQL_Thuchien("ThaoLuan_Insert", name, obj, Npar);
        }
        public int ThaoLuan_Delete(ThaoLuan_Public tl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdThaoLuan";
            obj[0] = tl.IdThaoLuan;
            return dp.SQL_Thuchien("ThaoLuan_Delete", name, obj, Npar);
        }
        public int ThaoLuan_Delete_IdCauHoi(ThaoLuan_Public tl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = tl.CauHoi.IdCauHoi;
            return dp.SQL_Thuchien("ThaoLuan_Delete_IdCauHoi", name, obj, Npar);
        }
    }
}
