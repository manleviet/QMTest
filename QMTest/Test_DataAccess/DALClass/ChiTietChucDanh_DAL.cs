using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    
    public class ChiTietChucDanh_DAL
    {
        DataProvider dp = new DataProvider();
        public int ChiTietChucDanh_Insert(ChiTietChucDanh_Public cd)     
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChucDanh";
            obj[0] = cd.ChucDanh.IdChucDanh;
            return dp.SQL_Thuchien("ChiTietChucDanh_Insert", name, obj, Npar);   
        }
    }
}
