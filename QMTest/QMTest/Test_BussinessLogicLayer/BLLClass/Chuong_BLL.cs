using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;

namespace Test_BussinessLogicLayer
{
    public class Chuong_BLL
    {
        Chuong_DAL ch_dal = new Chuong_DAL();
        public DataTable Chuong_Select_IdMonHoc(Chuong_Public ch)
        {
            return ch_dal.Chuong_Select_IdMonHoc(ch);
        }
        public int Chuong_Update(Chuong_Public ch)
        {
            return ch_dal.Chuong_Update(ch);
        }
        public DataTable Chuong_Select()
        {
            return ch_dal.Chuong_Select();
        }
        public int Chuong_Delete(Chuong_Public ch)
        {
            return ch_dal.Chuong_Delete(ch);
        }
        public int Chuong_Insert(Chuong_Public ch)
        {
            return ch_dal.Chuong_Insert(ch);
        }
        
    }
}
