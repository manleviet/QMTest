using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class DoKho_DAL
    {
        DataProvider dp = new DataProvider();
        public int DoKho_Insert(DoKho_Public dk)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdDoKho";
            obj[0] = dk.IdDoKho;
            name[1] = "@TenDoKho";
            obj[1] = dk.TenDoKho;
            return dp.SQL_Thuchien("DoKho_Insert", name, obj, Npar);
        }
        public DataTable DoKho_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("DoKho_Select");
        }
        public int DoKho_Delete(DoKho_Public dk)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdDoKho";
            obj[0] = dk.IdDoKho;
            return dp.SQL_Thuchien("DoKho_Delete", name, obj, Npar);
        }
        public int DoKho_Update(DoKho_Public dk)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;

            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdDoKho";
            obj[0] = dk.IdDoKho;
            name[1] = "@TenDoKho";
            obj[1] = dk.TenDoKho;
            return dp.SQL_Thuchien("DoKho_Update", name, obj, Npar);
        }
    }
}
