using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;
namespace Test_DataAccess
{
    public class MucKienThuc_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable MucKienThuc_Select_IdChuDe(MucKienThuc_Public mkt)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdChuDe";
            obj[0] = mkt.Cd.IdChuDe;
            return dp.SQL_Laydulieu("MucKienThuc_Select_IdChuDe", name, obj, Npar);

        }
        public int MucKienThuc_Update(MucKienThuc_Public mkt)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            try
            {
                obj[0] = int.Parse(mkt.IdMucKienThuc);
            }
            catch { }
            name[1] = "@TenMucKienThuc";
            obj[1] = mkt.TenMucKienThuc;
            name[2] = "@MoTa";
            obj[2] = mkt.MoTa;
            return dp.SQL_Thuchien("MucKienThuc_Update", name, obj, Npar);
        }
        public int MucKienThuc_Insert(MucKienThuc_Public mkt)
        {
            const int Npar = 3;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@TenMucKienThuc";
            obj[0] = mkt.TenMucKienThuc;
            name[1] = "@MoTa";
            obj[1] = mkt.MoTa;
            name[2] = "@IdChuDe";
            obj[2] = mkt.Cd.IdChuDe;
            return dp.SQL_Thuchien("MucKienThuc_Insert", name, obj, Npar);
        }
        public int MucKienThuc_Delete(MucKienThuc_Public mkt)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdMucKienThuc";
            try
            {
                obj[0] = int.Parse(mkt.IdMucKienThuc);
            }
            catch { }

            return dp.SQL_Thuchien("MucKienThuc_Delete", name, obj, Npar);
        }

       
    }
}
