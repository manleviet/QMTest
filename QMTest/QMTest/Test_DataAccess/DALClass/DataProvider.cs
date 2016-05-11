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
    public class DataProvider : IDisposable
    {
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

                try
                {
                    cn = new SqlConnection(@"Data Source=112.213.91.246;Initial Catalog=qm_test;Persist Security Info=True;User ID=qmtest;Password=25292");
                    //cn = new SqlConnection(@"Data Source=.;Initial Catalog=qm_test;Persist Security Info=True;User ID=sa;Password=admin1234");
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
        public int Backup(string path)
        {
            string sql = string.Format("BACKUP DATABASE [qm_test] TO DISK='{0}'", path);
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteNonQuery();
        }
    }
}
