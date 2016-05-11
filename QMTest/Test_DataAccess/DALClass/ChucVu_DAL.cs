using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class ChucVu_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable ChucVu_Select()
        {
            dp.KetnoiCSDL();

            return dp.SQL_Laydulieu("ChucVu_Select");
        }
    }
}
