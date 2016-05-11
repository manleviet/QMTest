using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Configuration;
using System.Data.Common;

namespace Test_DataAccess
{
    class DataProvider : IDisposable
    {
        //public MySqlConnection cn;
        static SqlConnection cn;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (cn != null)
                {
                    cn.Dispose();
                    cn = null;
                }
        }
        ~DataProvider()
        {
            Dispose(false);
        }
        public void KetnoiCSDL()
        {
            if ((cn == null) || (cn.State == ConnectionState.Closed))
            {

                //cn = new SqlConnection();
                //string ketnoi = ConfigurationManager.ConnectionStrings["chuoiketnoi"].ConnectionString;
                try
                {
                    //cn = new MySqlConnection(@"server=27.122.14.165;User Id=u242562270_2;database=u242562270_1;password=1234;Persist Security Info=True");
                    //cn = new MySqlConnection(@"server=localhost;User Id=root;database=qm_test;password=admin1234;Persist Security Info=True");
                    cn = new SqlConnection(@"Data Source=112.213.91.246;Initial Catalog=qm_test;Persist Security Info=True;User ID=qmtest;Password=25292");
                    //if (cn.State == ConnectionState.Closed)
                        cn.Open();
                }

                catch (SqlException se)
                {
                    XtraMessageBox.Show("Lỗi kết nối - Xem hổ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    XtraMessageBox.Show(se.Message);
                }
            }
        }
        public void Ngatketnoi()
        {
            cn.Close();
            cn = null;
        }

        public DataTable SQL_Laydulieu(string tenSP)
        {
            SqlCommand cmd = new SqlCommand(tenSP, cn) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Ngatketnoi();
            cmd.Dispose(); da.Dispose(); dt.Dispose();
            return dt;
        }
        public DataTable SQL_Laydulieu(string tenSP, string[] name, object[] value, int Npara)
        {

                SqlCommand cmd = new SqlCommand(tenSP, cn) { CommandType = CommandType.StoredProcedure };
                for (int i = 0; i < Npara; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], value[i]);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Ngatketnoi();
                cmd.Dispose(); da.Dispose(); dt.Dispose();
                return dt;
        }
        public int SQL_Thuchien(string tenSP, string[] name, object[] value, int Npara)
        {
           
            SqlCommand cmd = new SqlCommand(tenSP, cn) { CommandType = CommandType.StoredProcedure };
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            cmd.Dispose();
            return cmd.ExecuteNonQuery();
        }
    }
}
