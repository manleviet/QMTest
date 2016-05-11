using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class MucKienThuc_BLL
    {
        MucKienThuc_DAL mkt_dal = new MucKienThuc_DAL();
        public DataTable MucKienThuc_Select_IdChuDe(MucKienThuc_Public mkt)
        {
            return mkt_dal.MucKienThuc_Select_IdChuDe(mkt);
        }
        public int MucKienThuc_Update(MucKienThuc_Public mkt)
        {
            return mkt_dal.MucKienThuc_Update(mkt);
        }
        public int MucKienThuc_Delete(MucKienThuc_Public mkt)
        {
            return mkt_dal.MucKienThuc_Delete(mkt);
        }
        public int MucKienThuc_Insert(MucKienThuc_Public mkt)
        {
            return mkt_dal.MucKienThuc_Insert(mkt);
        }
    }
}
