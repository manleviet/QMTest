using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class ToBoMon_BLL
    {
        ToBoMon_DAL tbm_dal = new ToBoMon_DAL();
       
        public DataTable ToBoMon_Select()
        {
            return tbm_dal.ToBoMon_Select();
        }
        public DataTable ToBoMon_Select_IdKhoa(ToBoMon_Public tbm)
        {
            return this.tbm_dal.ToBoMon_Select_IdKhoa(tbm);
        }
        public DataTable ToBoMon_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            return this.tbm_dal.ToBoMon_Select_IdToBoMon(tbm);
        }
        public int ToBoMon_Insert(ToBoMon_Public tbm)
        {
            return this.tbm_dal.ToBoMon_Insert(tbm);
        }
        public int ToBoMon_Delete(ToBoMon_Public tbm)
        {
            return this.tbm_dal.ToBoMon_Delete(tbm);
        }
        public int ToBoMon_Update(ToBoMon_Public tbm)
        {
            return this.tbm_dal.ToBoMon_Update(tbm);
        }
    }
}
