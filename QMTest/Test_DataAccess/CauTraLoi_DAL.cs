using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class CauTraLoi_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable CauTraLoi_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("CauTraLoi_Select");
        }
        public int CauTraLoi_Insert(CauTraLoi_Public ctl)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung1";
            obj[0] = ctl.NoiDung1;
            name[1] = "@DapAn";
            obj[1] = ctl.DapAn;
            name[2] = "@NoiDung2";
            obj[2] = ctl.NoiDung2;
            return dp.SQL_Thuchien("CauTraLoi_Insert", name, obj, Npar);
        }
        public int CauTraLoi_Update(CauTraLoi_Public ctl)
        {
            const int Npar = 5;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauTraLoi";
            obj[0] = ctl.IdCauTraLoi;
            name[1] = "@IdCauHoi";
            obj[1] = ctl.IdCauHoi;
            name[2] = "@NoiDung1";
            obj[2] = ctl.NoiDung1;
            name[3] = "@DapAn";
            obj[3] = ctl.DapAn;
            name[4] = "@NoiDung2";
            obj[4] = ctl.NoiDung2;
            return dp.SQL_Thuchien("CauTraLoi_Update", name, obj, Npar);
        }
        public int CauTraLoi_Delete(CauTraLoi_Public ctl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauTraLoi";
            obj[0] = ctl.IdCauTraLoi;
            return dp.SQL_Thuchien("CauTraLoi_Delete", name, obj, Npar);
        }
        public DataTable CauTraLoi_Select_IdCauHoi(CauTraLoi_Public ctl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ctl.CauHoi.IdCauHoi;
            return dp.SQL_Laydulieu("CauTraLoi_Select_IdCauHoi", name, obj, Npar);
        }
    }
}
