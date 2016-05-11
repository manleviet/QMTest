using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class ChiTietQuyen_BLL
    {
        ChiTietQuyen_DAL ctq_dal = new ChiTietQuyen_DAL();
        public int ChiTietQuyen_Insert(ChiTietQuyen_Public ctq)
        {
            return ctq_dal.ChiTietQuyen_Insert(ctq);
        }
    }
}
