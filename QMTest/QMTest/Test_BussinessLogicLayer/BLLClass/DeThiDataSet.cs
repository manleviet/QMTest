using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Test_BussinessLogicLayer.BLLClass
{
    public class DeThiDataSet:DataSet
    {
        public DeThiDataSet()
        {
            DataTable cauhoi = new DataTable("CauHoi");
            DataTable cautraloi = new DataTable("CauTraLoi");
            DataSetName = "DeThi";
            cauhoi.Columns.Add("STT", typeof(Int32));
            cauhoi.Columns.Add("IdCauHoi", typeof(Int32));
            cauhoi.Columns.Add("NoiDung", typeof(String));


            cautraloi.Columns.Add("IdCauHoi", typeof(Int32));
            cautraloi.Columns.Add("STTChar", typeof(String));
            cautraloi.Columns.Add("NoiDung1", typeof(String));
            cautraloi.Columns.Add("STTNum", typeof(String));
            cautraloi.Columns.Add("NoiDung2", typeof(String));

            // create relation         
            Tables.AddRange(new DataTable[] { cauhoi, cautraloi });
            Relations.Add("DevThi", cauhoi.Columns["IdCauHoi"], cautraloi.Columns["IdCauHoi"]);
        }
    }
}
