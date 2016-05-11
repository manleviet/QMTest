using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class ChucVu_BLL
    {
        ChucVu_DAL cv = new ChucVu_DAL();
        public DataTable ChucVu_Select()
        {
            return cv.ChucVu_Select();
            
        }
    }
}
