using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
using Test_DataAccess;

namespace Test_BussinessLogicLayer
{
    public class Quyen_BLL
    {
        Quyen_DAL q_dal = new Quyen_DAL();
        public DataTable Quyen_Select()
        {
            return q_dal.Quyen_Select();
        }
    }
}
