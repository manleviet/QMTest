using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess.DALClass
{
    public class SystemLog_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable GetAllSystemLog(SystemLog_Public sys)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TuNgay";
            obj[0] = sys.TuNgay;
            name[1] = "@DenNgay";
            obj[1] = sys.DenNgay;
            return dp.SQL_Laydulieu("GetAllSystemLog", name, obj, Npar);
        }
        public int SystemLog_Insert(SystemLog_Public sys)
        {
            dp.KetnoiCSDL();
            const int Npar = 3;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaoVien";
            obj[0] = sys.Gv.IdGiaoVien;
            name[1] = "@TenGiaoVien";
            obj[1] = sys.Gv.TenGiaoVien;
            name[2] = "@MoTa";
            obj[2] = sys.MoTa;
            return dp.SQL_Thuchien("SystemLog_Insert", name, obj, Npar);
        }
        public int SystemLog_Delete(SystemLog_Public sys)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@ID";
            obj[0] = sys.Id;
            return dp.SQL_Thuchien("SystemLog_Delete", name, obj, Npar);
        }
    }
}
