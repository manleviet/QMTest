using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class Quyen_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable Quyen_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("Quyen_Select");
        }
    }
}
