using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;

namespace DuAn_GiaoDien
{
    public partial class UcNguoiSuDung : UserControl
    {
        GiaoVien_BLL gv = new GiaoVien_BLL();
        public UcNguoiSuDung()
        {
            InitializeComponent();
            gridControl1.DataSource = gv.GiaoVien_Select();
            DataTable dt=new DataTable();
            //foreach (DataRow x in dt.Rows)
            //{
            //    cardView1.CardCaptionFormat = dt.Rows
            //}
            for (int i = 0; i <    dt.Rows.Count; i++)
            {
                cardView1.CardCaptionFormat = string.Format("{0}", dt.Rows[i]["TenGiaoVien"]);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmQuanLyGiaoVien frm = new frmQuanLyGiaoVien();
            frm.Show();
            gridControl1.DataSource = gv.GiaoVien_Select();  
        }
 
    }
}
