using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class ThongTinDuyet_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ThongTinDuyet_Select(ThongTinDuyet_Public ttd)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ttd.CauHoi.IdCauHoi;
            name[1] = "@IdGiaoVien";
            obj[1] = ttd.GiaoVien.IdGiaoVien;
            return dp.SQL_Laydulieu("ThongTinDuyet_Select", name, obj, Npar);
        }
        public int ThongTinDuyet_Insert(ThongTinDuyet_Public ttd)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ttd.CauHoi.IdCauHoi;
            name[1] = "@IdGiaoVien";
            obj[1] = ttd.GiaoVien.IdGiaoVien;
            return dp.SQL_Thuchien("ThongTinDuyet_Insert", name, obj, Npar);
        }
    }
}
