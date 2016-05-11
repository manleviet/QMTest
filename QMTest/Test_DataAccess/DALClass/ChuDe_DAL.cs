using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class ChuDe_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ChuDe_Select_IdChuong(ChuDe_Public cd)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuong";
            obj[0] = cd.Chuong.IdChuong;
            return dp.SQL_Laydulieu("ChuDe_Select_IdChuong", name, obj, Npar);
        }
        public int ChuDe_Update(ChuDe_Public cd)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuDe";
            obj[0] = cd.IdChuDe;
            name[1] = "@TenChuDe";
            obj[1] = cd.TenChuDe;
            name[2] = "@MoTa";
            obj[2] = cd.MoTa;
            return dp.SQL_Thuchien("ChuDe_Update", name, obj, Npar);
        }
        public int ChuDe_Insert(ChuDe_Public cd)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenChuDe";
            obj[0] = cd.TenChuDe;
            name[1] = "@MoTa";
            obj[1] = cd.MoTa;
            name[2] = "@IdChuong";
            obj[2] = cd.Chuong.IdChuong;
            return dp.SQL_Thuchien("ChuDe_Insert", name, obj, Npar);
        }
        public int ChuDe_Delete(ChuDe_Public cd)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuDe";
            obj[0] = cd.IdChuDe;
            return dp.SQL_Thuchien("ChuDe_Delete", name, obj, Npar);
        }

    }
}
