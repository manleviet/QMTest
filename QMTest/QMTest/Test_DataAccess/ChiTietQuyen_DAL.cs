using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;

namespace Test_DataAccess
{
    public class ChiTietQuyen_DAL
    {
        DataProvider dp = new DataProvider();
        public int ChiTietQuyen_Insert(ChiTietQuyen_Public ctq)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdQuyen";
            obj[0] = ctq.Quyen.IdQuyen;
            return dp.SQL_Thuchien("ChiTietQuyen_Insert", name, obj, Npar);
        }
    }
}
