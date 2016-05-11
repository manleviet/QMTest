using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using Test_PublicLayer;
namespace Test_BussinessLogicLayer
{
    public class ChiTietChucDanh_BLL
    {
        ChiTietChucDanh_DAL ctcd = new ChiTietChucDanh_DAL();
        public int ChiTietChucDanh_Insert(ChiTietChucDanh_Public cd)
        {
            return ctcd.ChiTietChucDanh_Insert(cd);
        }
    }
}
