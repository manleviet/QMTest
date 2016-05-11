using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
namespace Test_DataAccess
{
    public class ChiTietGiangDay_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ChiTietGiangDay_Select_IdMonHoc(string IdMonHoc)
        {
         const int Npar=1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = IdMonHoc;

            return dp.SQL_Laydulieu("ChiTietGiangDay_Select_IdMonHoc", name, obj, Npar);            
        }
    }
}
