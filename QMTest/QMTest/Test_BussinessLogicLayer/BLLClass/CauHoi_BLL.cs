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
        public int CauHoi_NganHangSoBo(CauHoi_Public ch)
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
        public DataTable CauHoi_Select_Paginate(CauHoi_Public ch, int trangthu)
        {
            return ch_dal.CauHoi_Select_Paginate(ch, trangthu);
        }
        public DataTable CauHoiChinhThuc_Select_Paginate(CauHoi_Public ch, int trangthu)
        {
            return ch_dal.CauHoiChinhThuc_Select_Paginate(ch, trangthu);
        }
        public int CauHoiChinhThuc_Delete(CauHoi_Public ch)
        {
            return ch_dal.CauHoiChinhThuc_Delete(ch);
        }
        public int ChuyenCauHoiChoNHSB(CauHoi_Public ch)
        {
            return ch_dal.ChuyenCauHoiChoNHSB(ch);
        }
        public DataTable GetCauHoiDangSoan(CauHoi_Public ch)
        {
            return ch_dal.GetCauHoiDangSoan(ch);
        }
        public int CauHoi_Update_IdGiaThietChung(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Update_IdGiaThietChung(ch);
        }
        public int CauHoi_SetNullIdGiaThietChung(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_SetNullIdGiaThietChung(ch);
        }
        public int CauHoi_Update_NoiDung(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_Update_NoiDung(ch);
        }
        public int CauHoi_SetCongKhai(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_SetCongKhai(ch);
        }
        public DataTable CauHoiChinhThuc_SelectAll(CauHoi_Public ch, int trangthu)
        {
            return ch_dal.CauHoiChinhThuc_SelectAll(ch, trangthu);
        }
        public DataTable CauHoi_SelectAll(CauHoi_Public ch, int trangthu)
        {
            return ch_dal.CauHoi_SelectAll(ch, trangthu);
        }
        public DataTable CountCauHoi_SelectAll(CauHoi_Public ch)
        {
            return ch_dal.CountCauHoi_SelectAll(ch);
        }
        public DataTable CountCauHoi_Select_IdMonHoc(CauHoi_Public ch)
        {
            return ch_dal.CountCauHoi_Select_IdMonHoc(ch);
        }
        public DataTable CountCauHoiChinhThuc_SelectAll(CauHoi_Public ch)
        {
            return ch_dal.CountCauHoiChinhThuc_SelectAll(ch);
        }
        public DataTable CountCauHoiChinhThuc_Select_IdMonHoc(CauHoi_Public ch)
        {
            return ch_dal.CountCauHoiChinhThuc_Select_IdMonHoc(ch);
        }
        public int CauHoi_SetKoCongKhai(CauHoi_Public ch)
        {
            return ch_dal.CauHoi_SetKoCongKhai(ch);
        }
    }
}
