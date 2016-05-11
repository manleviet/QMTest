using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;


namespace Test_BussinessLogicLayer
{
    public class MonHoc_BLL
    {
        MonHoc_DAL mh = new MonHoc_DAL();
        public DataTable MonHoc_Select()
        {
            return mh.MonHoc_Select();
        }
        public int MonHoc_Insert(MonHoc_Public mhis)
        {
            return mh.MonHoc_Insert(mhis);
        }
        public int MonHoc_Delete(MonHoc_Public mhis)
        {
            return mh.MonHoc_Delete(mhis);
        }
        public int MonHoc_Update(MonHoc_Public mh)
        {
            return this.mh.MonHoc_Update(mh);
        }
        public DataTable MonHoc_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            return this.mh.MonHoc_Select_IdToBoMon(tbm);
        }
        public DataTable MonHoc_Select_IdToBoMon(MonHoc_Public mh)
        {
            return this.mh.MonHoc_Select_IdToBoMon(mh);
        }
    }
}
