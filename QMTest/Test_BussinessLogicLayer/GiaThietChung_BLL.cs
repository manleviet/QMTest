using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using Test_PublicLayer;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class GiaThietChung_BLL
    {
        GiaThietChung_DAL gtc_dal = new GiaThietChung_DAL();
        public DataTable GiaThietChung_Select()
        {
            return gtc_dal.GiaThietChung_Select();
        }
        public DataTable GiaThietChung_Select_NoiDung(GiaThietChung_Public gtc)
        {
            return gtc_dal.GiaThietChung_Select_NoiDung(gtc);
        }
        public int GiaThietChung_Delete(GiaThietChung_Public gtc)
        {
            return gtc_dal.GiaThietChung_Delete(gtc);
        }
        public int GiaThietChung_Update(GiaThietChung_Public gtc)
        {
            return gtc_dal.GiaThietChung_Update(gtc);
        }
    }
}
