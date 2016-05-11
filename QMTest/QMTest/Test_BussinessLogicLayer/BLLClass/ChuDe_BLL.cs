using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using Test_DataAccess;
using System.Data;
namespace Test_BussinessLogicLayer
{
    public class ChuDe_BLL
    {
        ChuDe_DAL cd_dal = new ChuDe_DAL();
        public DataTable ChuDe_Select_IdChuong(ChuDe_Public cd)
        {
            return cd_dal.ChuDe_Select_IdChuong(cd);
        }
        public int ChuDe_Update(ChuDe_Public cd)
        {
            return cd_dal.ChuDe_Update(cd);
        }
        public int ChuDe_Insert(ChuDe_Public cd)
        {
            return cd_dal.ChuDe_Insert(cd);
        }
        public int ChuDe_Delete(ChuDe_Public cd)
        {
            return cd_dal.ChuDe_Delete(cd);
        }
    }
}
