using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            catch(Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
