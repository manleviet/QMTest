using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuAn_GiaoDien
{
    public partial class frmConnectSql : Form
    {
        public frmConnectSql()
        {
            InitializeComponent();
        }

        private void BarButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BarButtonItemConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //    if (TextEditServer.Text.Length == 0)  
            //    {
            //        MessageBox.Show("Please enter a server name");
            //        return;
            //    }
            //if( TextEditDatabaseName.Text.Length == 0)
            //{
            //     MessageBox.Show("Please enter a database name");
            //     return;
            //}
            //SqlConnectionStringBuilder cbd1 = new SqlConnectionStringBuilder();
            // SqlConnection cnn1 = new SqlConnection();

            ////Assign connection string
            // if(this.RadioGroup1.SelectedIndex == 0)
            // {
            //     //Windows authentication
            //    cbd1.DataSource = this.TextEditServer.Text;
            //    cbd1.InitialCatalog = this.TextEditDatabaseName.Text;
            //    cbd1.IntegratedSecurity = true;
            //    cbd1.ConnectTimeout = 30;
            //    cnn1.ConnectionString = cbd1.ConnectionString;
            // } 

            //if (this.RadioGroup1.SelectedIndex ==1) //SQL server authentication
            //{
            //    cbd1.DataSource = TextEditServer.Text;
            //    cbd1.InitialCatalog = TextEditDatabaseName.Text;
            //    cbd1.UserID = TextEditUserName.Text;
            //    cbd1.Password = TextEditPassword.Text;
            //    cbd1.ConnectTimeout = 30;
            //    cnn1.ConnectionString = cbd1.ConnectionString;
            //}

            ////Open connection and always close it when done
            ////Catch exceptions from attempt to connect
            //try
            //{
            //    cnn1.Open();
            //    // MessageBox.Show("Connection succeeded for server: " & cbd1.ConnectionString, "Connection succeeded")

            //    //Save settings for successful connectuon
            //    if (RadioGroup1.SelectedIndex == 0) //Windows authentication
            //        //My.Settings.GSMedicalConnectionString = cbd1.ConnectionString ' does not work as read only
            //        My.Settings("GSMedicalConnectionString") = cbd1.ConnectionString 'Using a string makes it read/write rather than just read - weird
            //        My.Settings.SQLServer = cbd1.DataSource
            //        My.Settings.SQLDatabase = cbd1.InitialCatalog
            //        My.Settings.Save()
            //    End If

            //    If Me.RadioGroup1.SelectedIndex = 1 Then 'SQL server authentication
            //        My.Settings("GSMedicalConnectionString") = cbd1.ConnectionString
            //        My.Settings.SQLServer = cbd1.DataSource
            //        My.Settings.SQLDatabase = cbd1.InitialCatalog
            //        My.Settings.SQLUser = cbd1.UserID
            //        My.Settings.Save()
            //    End If
            //    cnn1.Close()

            //    My.Forms.MainSwitch.BarStaticItemServer.Caption = "Database - " & My.Settings.SQLDatabase
            //    closeCheck = True
            //    Close()
            //    Me.Close()
            //Catch ex As Exception
            //    MessageBox.Show(ex.Message, "Connection failed")
            //    My.Forms.MainSwitch.Close()
            //    Me.Close()
            //End Try

            //}
        }
    }
}