using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class ThaoLuan_BLL
    {
        ThaoLuan_DAL tl_dal = new ThaoLuan_DAL();
        public DataTable ThaoLuan_Select(ThaoLuan_Public tl)
        {
            return tl_dal.ThaoLuan_Select(tl);
        }
        public int ThaoLuan_Insert(ThaoLuan_Public tl)
        {
            return tl_dal.ThaoLuan_Insert(tl);
        }
        public int ThaoLuan_Delete(ThaoLuan_Public tl)
        {
            return tl_dal.ThaoLuan_Delete(tl);
        }
        public int ThaoLuan_Delete_IdCauHoi(ThaoLuan_Public tl)
        {
            return tl_dal.ThaoLuan_Delete_IdCauHoi(tl);
        }
    }
}
