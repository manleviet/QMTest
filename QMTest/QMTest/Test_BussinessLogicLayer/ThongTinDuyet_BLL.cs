using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using System.Data;
using Test_PublicLayer;
namespace Test_BussinessLogicLayer
{
    public class ThongTinDuyet_BLL
    {
        ThongTinDuyet_DAL ttd_dal = new ThongTinDuyet_DAL();
        public DataTable ThongTinDuyet_Select(ThongTinDuyet_Public ttd)
        {
            return ttd_dal.ThongTinDuyet_Select(ttd);
        }
        public int ThongTinDuyet_Insert(ThongTinDuyet_Public ttd)
        {
            return ttd_dal.ThongTinDuyet_Insert(ttd);
        }
    }
}
