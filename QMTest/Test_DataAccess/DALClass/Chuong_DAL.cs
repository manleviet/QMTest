using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class Chuong_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable Chuong_Select_IdMonHoc(Chuong_Public ch)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMonHoc";
            obj[0] = ch.Mh.IdMonHoc;
            return dp.SQL_Laydulieu("Chuong_Select_IdMonHoc", name, obj, Npar);
        }
        public int Chuong_Update(Chuong_Public ch)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuong";
            obj[0] = ch.IdChuong;
            name[1] = "@TenChuong";
            obj[1] = ch.TenChuong;
            name[2] = "@MoTa";
            obj[2] = ch.MoTa;

            return dp.SQL_Thuchien("Chuong_Update", name, obj, Npar);
        }
        public DataTable Chuong_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("Chuong_Select");
        }
        public int Chuong_Delete(Chuong_Public ch)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuong";
            obj[0] = ch.IdChuong;
            return dp.SQL_Thuchien("Chuong_Delete", name, obj, Npar);
        }
        public int Chuong_Insert(Chuong_Public ch)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenChuong";
            obj[0] = ch.TenChuong;
            name[1] = "@MoTa";
            obj[1] = ch.MoTa;
            name[2] = "@IdMonHoc";
            obj[2] = ch.Mh.IdMonHoc;
            return dp.SQL_Thuchien("Chuong_Insert", name, obj, Npar);
        }
       


    }
}
