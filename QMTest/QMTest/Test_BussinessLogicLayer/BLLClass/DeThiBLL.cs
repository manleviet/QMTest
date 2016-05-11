using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Test_BussinessLogicLayer;

namespace Test_BussinessLogicLayer.BLLClass
{
    public class DeThiBLL
    {
        MonHoc_BLL mh_bll = new MonHoc_BLL();
        public DataSet GetNoiDungDeThi(int made)
        {
            //lấy đề thi lên

            DataTable dt = new DataTable();
            dt = mh_bll.qm_GetNoiDungDeThi(made);
            //đưa dữ liệu 1-n vào DataSet
            DeThiDataSet dethi = new DeThiDataSet();
            int id = 0;
            int dem = 1;
            int sttchar = 65;
            int sttnum = 1;
            foreach (DataRow dr in dt.Rows)
            {
                if (id != (int)dr[0])
                {
                    dethi.Tables["CauHoi"].Rows.Add(dem, (int)dr[0], dr[1].ToString());
                    id = (int)dr[0];
                    dem++;
                    sttchar = 65;
                    sttnum = 1;
                }
                if ((int)dr[5] != 3 && (int)dr[5] != 5 && (int)dr[5] != 6)
                {
                    if ((int)dr[5] == 1 || (int)dr[5] == 2)//đa lựa chọn, đúng/sai
                    {
                        dethi.Tables["CauTraLoi"].Rows.Add((int)dr[2], Convert.ToChar(sttchar) + ".", dr[3].ToString(), null, dr[4].ToString());
                    }
                    else
                        if ((int)dr[5] == 4)//ghép đôi
                        {
                            if (dr[3] != null && dr[3].ToString() != "")
                                dethi.Tables["CauTraLoi"].Rows.Add((int)dr[2], Convert.ToChar(sttchar) + ".",
                                                                        dr[3].ToString(), sttnum + ".", dr[4].ToString());
                            else
                                dethi.Tables["CauTraLoi"].Rows.Add((int)dr[2], null, dr[3].ToString(), sttnum + ".", dr[4].ToString());
                        }
                    sttchar++; sttnum++;
                }
                else
                    dethi.Tables["CauTraLoi"].Rows.Add((int)dr[2], null, null);
            }
            return dethi;
        }
    }
}
