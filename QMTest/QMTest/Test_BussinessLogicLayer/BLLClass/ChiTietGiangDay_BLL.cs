using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
using Test_DataAccess;

namespace Test_BussinessLogicLayer
{
    public class ChiTietGiangDay_BLL
    {
        ChiTietGiangDay_DAL ctgd_dal = new ChiTietGiangDay_DAL();
        public DataTable ChiTietGiangDay_Select_IdMonHoc(string IdMonHoc)
        {
            return ctgd_dal.ChiTietGiangDay_Select_IdMonHoc(IdMonHoc);
        }
    }
}
