using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class GiaThietChung_DAL
    {
        DataProvider dp = new DataProvider();       
        public DataTable GiaThietChung_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("GiaThietChung_Select");
        }
        public int GiaThietChung_Insert(GiaThietChung_Public gtc)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaThietChung";
            obj[0] = gtc.IdGiaThietChung;
            name[1] = "@NoiDung";
            obj[1] = gtc.NoiDung;   
            return dp.SQL_Thuchien("GiaThietChung_Insert", name, obj, Npar);
        }
        public DataTable GiaThietChung_Select_NoiDung(GiaThietChung_Public gtc)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaThietChung";
            obj[0] = gtc.IdGiaThietChung;
            return dp.SQL_Laydulieu("GiaThietChung_Select_NoiDung", name, obj, Npar);
        }
        public int GiaThietChung_Update(GiaThietChung_Public gtc)
        {
            dp.KetnoiCSDL();
            const int Npar = 2;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaThietChung";
            obj[0] = gtc.IdGiaThietChung;
            name[1] = "@NoiDung";
            obj[1] = gtc.NoiDung;
            return dp.SQL_Thuchien("GiaThietChung_Update", name, obj, Npar);
        }
        public int GiaThietChung_Delete(GiaThietChung_Public gtc)
        {
            dp.KetnoiCSDL();
            const int Npar = 1;
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdGiaThietChung";
            obj[0] = gtc.IdGiaThietChung;
            return dp.SQL_Thuchien("GiaThietChung_Delete", name, obj, Npar);
        }
    }
}
