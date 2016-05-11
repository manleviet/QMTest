using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using Test_PublicLayer;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class LoaiCauHoi_BLL
    {
        LoaiCauHoi_DAL lch_dal = new LoaiCauHoi_DAL();
        public DataTable LoaiCauHoi_Select()
        {
            return lch_dal.LoaiCauHoi_Select();
        }
    }
}
