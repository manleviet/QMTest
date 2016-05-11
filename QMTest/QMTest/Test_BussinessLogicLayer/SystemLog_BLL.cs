using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;
using Test_DataAccess.DALClass;

namespace Test_BussinessLogicLayer
{
    public class SystemLog_BLL
    {
        SystemLog_DAL sys_dal = new SystemLog_DAL();
        public DataTable GetAllSystemLog(SystemLog_Public sys)
        {
            return sys_dal.GetAllSystemLog(sys);
        }
        public int SystemLog_Insert(SystemLog_Public sys)
        {
            return sys_dal.SystemLog_Insert(sys);
        }
        public int SystemLog_Delete(SystemLog_Public sys)
        {
            return sys_dal.SystemLog_Delete(sys);
        }
    }
}
