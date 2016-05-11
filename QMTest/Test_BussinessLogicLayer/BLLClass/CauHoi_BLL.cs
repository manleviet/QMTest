using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using Test_PublicLayer;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class CauHoi_BLL
    {
        CauHoi_DAL ch_dal = new CauHoi_DAL();
        public int CauHoi_Insert(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Insert(ch);
        }
        public DataTable CauHoi_Select()
        {
            return ch_dal.CauHoi_Select();
        }
        public int CauHoiGiaThietChung_Insert(CauHoi_Public ch, GiaThietChung_Public gtc)
        {
            return ch_dal.CauHoiGiaThietChung_Insert(ch, gtc);
        }
        public DataTable CauHoi_Select_IdMonHoc(MonHoc_Public mh)
        {
            return ch_dal.CauHoi_Select_IdMonHoc(mh);
        }
        public int CauHoi_Insert_IndentCurrent(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Insert_IndentCurrent(ch);
        }
        public DataTable CauHoi_Select_IdMonHoc(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Select_IdMonHoc(ch);
        }
        public DataTable CauHoi_NganHangSoBo(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_NganHangSoBo(ch);
        }
        public int CauHoiChinhThuc_Insert(CauHoi_Public ch)
        {
            return ch_dal.CauHoiChinhThuc_Insert(ch);
        }
        public int CauHoi_Delete(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Delete(ch);
        }
    }
}
