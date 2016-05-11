using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    
    public class ChucDanh_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ChucDanh_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("ChucDanh_Select");
        }
      
    }
}
