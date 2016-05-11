using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;
namespace Test_BussinessLogicLayer
{
    public class ChiTietChucVu_BLL
    {
        ChiTietChucVu_DAL ctcv = new ChiTietChucVu_DAL();
        public int ChiTietChucVu_Insert(ChiTietChucVu_Public cv)
        {
            return ctcv.ChiTietChucVu_Insert(cv);
        }
    }
}
