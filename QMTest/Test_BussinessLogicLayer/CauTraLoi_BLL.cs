﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_DataAccess;
using Test_PublicLayer;
namespace Test_BussinessLogicLayer
{
    public class CauTraLoi_BLL
    {
        CauTraLoi_DAL ctl_dal = new CauTraLoi_DAL();
        public int CauTraLoi_Insert(CauTraLoi_Public ctl)
        {
            return ctl_dal.CauTraLoi_Insert(ctl);
        }
        public DataTable CauTraLoi_Select_IdCauHoi(CauTraLoi_Public ctl)
        {
            return ctl_dal.CauTraLoi_Select_IdCauHoi(ctl);
        }
    }
}
