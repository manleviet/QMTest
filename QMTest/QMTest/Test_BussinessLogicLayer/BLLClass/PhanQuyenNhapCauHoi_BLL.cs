using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using Test_DataAccess;
using System.Data;

namespace Test_BussinessLogicLayer
{
    public class PhanQuyenNhapCauHoi_BLL
    {
        PhanQuyenNhapCauHoi_DAL pgnch_dal = new PhanQuyenNhapCauHoi_DAL();
        public DataTable PhanQuyenNhapCauHoi_Select(MaTranKienThuc_Public mtkt)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Select(mtkt);
        }
        public int PhanQuyenNhapCauHoi_Insert(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Insert(pqnch);
        }
        public int PhanQuyenNhapCauHoi_Update(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Update(pqnch);
        }
        public int PhanQuyenNhapCauHoi_Delete(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Delete(pqnch);
        }
        public DataTable PhanQuyenNhapCauHoi_Select_IdMaTranKienThuc(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Select_IdMaTranKienThuc(pqnch);
        }
        public DataTable KiemTraPhanQuyenSoanCauHoi(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.KiemTraPhanQuyenSoanCauHoi(pqnch);
        }
        public DataTable PhanQuyenNhapCauHoi_Select_IdMaTranIdGiaoVien(PhanQuyenNhapCauHoi_Public pqnch)
        {
            return pgnch_dal.PhanQuyenNhapCauHoi_Select_IdMaTranIdGiaoVien(pqnch);
        }
    }
}
