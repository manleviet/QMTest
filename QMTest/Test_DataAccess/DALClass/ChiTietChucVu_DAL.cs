using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class ChiTietChucVu_DAL
    {
        DataProvider dp = new DataProvider();
        public int ChiTietChucVu_Insert(ChiTietChucVu_Public cv)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChucVu";
            name[1] = "@IdGiaoVien";
            obj[0] = cv.Cv.IdChucVu;
            obj[1] = cv.Gv.IdGiaoVien;
            return dp.SQL_Thuchien("ChiTietChucVu_Insert", name, obj, Npar);
        }
    }
}
