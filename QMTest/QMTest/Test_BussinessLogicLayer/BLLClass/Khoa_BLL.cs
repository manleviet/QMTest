using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_DataAccess;
using System.Data;
using Test_PublicLayer;
namespace Test_BussinessLogicLayer
{
    public class Khoa_BLL
    {
        Khoa_DAL k = new Khoa_DAL();
        public DataTable Khoa_Select()
        {
            return k.Khoa_Select();
        }
        public DataTable Khoa_Select_IdToBoMon(ToBoMon_Public tbm)
        {
            return k.Khoa_Select_IdToBoMon(tbm);
        }
        public int Khoa_Insert(Khoa_Public k)
        {
            return this.k.Khoa_Insert(k);
        }
        public int Khoa_Update(Khoa_Public k)
        {
            return this.k.Khoa_Update(k);
        }
        public int Khoa_Delete(Khoa_Public k)
        {
            return this.k.Khoa_Delete(k);
        }

    }
}
