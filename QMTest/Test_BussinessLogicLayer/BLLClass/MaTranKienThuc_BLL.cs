using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class MaTranKienThuc_BLL
    {
        MaTranKienThuc_DAL mtkt_dal = new MaTranKienThuc_DAL();
        public DataTable MucTriNang_Select_IdMucKienThuc(MucKienThuc_Public mkt)
        {
            return mtkt_dal.MucTriNang_Select_IdMucKienThuc(mkt);
        }
        public DataTable MaTranKienThuc_Select_IdMonHoc(MonHoc_Public mh)
        {
            return mtkt_dal.MaTranKienThuc_Select_IdMonHoc(mh);
        }
        public int MaTranKienThuc_Insert(MaTranKienThuc_Public mtkt)
        {
            return mtkt_dal.MaTranKienThuc_Insert(mtkt);
        }
        public int MaTranKienThuc_Update(MaTranKienThuc_Public mtkt)
        {
            return mtkt_dal.MaTranKienThuc_Update(mtkt);
        }
        public DataTable MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(MaTranKienThuc_Public mtkt)
        {
            return mtkt_dal.MaTranKienThuc_Select_IdMucKienThucIdMucTriNang(mtkt);
        }
        public int MaTranKienThuc_Delete(MaTranKienThuc_Public mtkt)
        {
            return mtkt_dal.MaTranKienThuc_Delete(mtkt);
        }
        public DataTable MaTranKienThuc_Select_IdMucKienThuc(MaTranKienThuc_Public mtkt)
        {
            return mtkt_dal.MaTranKienThuc_Select_IdMucKienThuc(mtkt);
        }
    }
}
