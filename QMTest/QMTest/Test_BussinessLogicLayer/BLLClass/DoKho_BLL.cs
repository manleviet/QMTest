using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using Test_DataAccess;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class DoKho_BLL
    {
        DoKho_DAL dk_dal = new DoKho_DAL();
        public int DoKho_Insert(DoKho_Public dk)
        {
            return dk_dal.DoKho_Insert(dk);
        }
        public DataTable DoKho_Select()
        {
            return dk_dal.DoKho_Select();
        }
        public int DoKho_Update(DoKho_Public dk)
        {
            return dk_dal.DoKho_Update(dk);
        }
        public int DoKho_Delete(DoKho_Public dk)
        {
            return dk_dal.DoKho_Delete(dk);
        }
    }
}
