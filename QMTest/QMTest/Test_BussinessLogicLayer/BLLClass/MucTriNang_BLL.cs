using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using System.Data;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class MucTriNang_BLL
    {
        MucTriNang_DAL mtn_dal = new MucTriNang_DAL();
        public DataTable MucTriNang_Select()
        {
            return mtn_dal.MucTriNang_Select();
        }
        public int MucTriNang_Insert(MucTriNang_Public mtn)
        {
            return mtn_dal.MucTriNang_Insert(mtn);
        }
        public int MucTriNang_Update_TenMucTriNang(MucTriNang_Public mtn)
        {
            return mtn_dal.MucTriNang_Update_TenMucTriNang(mtn);
        }
        public int MucTriNang_Delete(MucTriNang_Public mtn)
        {
            return mtn_dal.MucTriNang_Delete(mtn);
        }
       
    }
}
