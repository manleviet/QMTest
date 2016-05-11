using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
namespace Test_DataAccess
{
    public class LoaiCauHoi_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable LoaiCauHoi_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("LoaiCauHoi_Select");
        }
        public int LoaiCauHoi_Insert(LoaiCauHoi_Public lch)
        {
            dp.KetnoiCSDL();
            const int Npar = 3;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdLoaiCauHoi";
            obj[0] = lch.IdLoaiCauHoi;
            name[1] = "@TenLoaiCauHoi";
            obj[1] = lch.TenLoaiCauHoi;
            name[2] = "@MoTa";
            obj[2] = lch.MoTa;
            return dp.SQL_Thuchien("LoaiCauHoi_Insert", name, obj, Npar);
        }
        public int LoaiCauHoi_Update(LoaiCauHoi_Public lch)
        {
            dp.KetnoiCSDL();
            const int Npar = 3;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdLoaiCauHoi";
            obj[0] = lch.IdLoaiCauHoi;
            name[1] = "@TenLoaiCauHoi";
            obj[1] = lch.TenLoaiCauHoi;
            name[2] = "@MoTa";
            obj[2] = lch.MoTa;
            return dp.SQL_Thuchien("LoaiCauHoi_Update", name, obj, Npar);
        }
        public int LoaiCauHoi_Delete(LoaiCauHoi_Public lch)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdLoaiCauHoi";
            obj[0] = lch.IdLoaiCauHoi; 
            return dp.SQL_Thuchien("LoaiCauHoi_Delete", name, obj, Npar);
        }
    }
}
