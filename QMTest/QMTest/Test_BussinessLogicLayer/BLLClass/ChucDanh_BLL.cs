using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
using Test_DataAccess;

namespace Test_BussinessLogicLayer
{

    public class ChucDanh_BLL
    {
        ChucDanh_DAL cd = new ChucDanh_DAL();
        public DataTable ChucDanh_Select()
        {
            return cd.ChucDanh_Select();
        }
    }
}
