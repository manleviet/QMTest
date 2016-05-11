using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using Test_BussinessLogicLayer;
using Test_PublicLayer;

namespace DuAn_GiaoDien
{
    public partial class UserControlCayPhanCapMonHoc : UserControl
    {
        public UserControlCayPhanCapMonHoc()
        {
            InitializeComponent();
        }
        Khoa_BLL k_bll = new Khoa_BLL();
        ToBoMon_BLL tbm_bll = new ToBoMon_BLL();
        //Khoa_Public k = new Khoa_Public();
        MonHoc_BLL mh_bll = new MonHoc_BLL();
        ToBoMon_Public tbm;
        private void UserControlCayPhanCapMonHoc_Load(object sender, EventArgs e)
        {
            
            CreateColumns(treeList1);
            CreateNodes(treeList1);
            treeList1.ExpandAll();
        }

        private void CreateColumns(TreeList tl)
        {
            tl.BeginUpdate();
            tl.Columns.Add();
            tl.Columns[0].Caption = "Ten";
            tl.Columns[0].VisibleIndex = 0;
            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl)
        {
            tbm = new ToBoMon_Public();
            DataTable dt = new DataTable();
            dt = k_bll.Khoa_Select();
            tl.BeginUnboundLoad();
            TreeListNode root = treeList1.AppendNode(null, null); 
            root.SetValue("Ten", "Trường Đại Học Kinh tế Huế");
            foreach (DataRow row in dt.Rows)
            {
                tbm.Khoa.IdKhoa =int.Parse(row[0].ToString());
                TreeListNode rootNode = tl.AppendNode(new object[] {row["TenKhoa"].ToString()},root);
                DataTable dt2 = new DataTable();
                dt2 = tbm_bll.ToBoMon_Select_IdKhoa(tbm);
                foreach (DataRow row2 in dt2.Rows)
                {
                    TreeListNode rootNode2 = tl.AppendNode(new object[] {row2["TenToBoMon"].ToString() }, rootNode);
                    DataTable dt3 = new DataTable();
                    tbm = new ToBoMon_Public() { IdToBoMon = int.Parse(row2["IdToBoMon"].ToString()) };
                    dt3 = mh_bll.MonHoc_Select_IdToBoMon(tbm);
                    foreach (DataRow row3 in dt3.Rows)
                    {
                        TreeListNode rootNode3 = tl.AppendNode(new object[] {row3["TenMonHoc"].ToString() }, rootNode2);
                    }
                }
            }
            
            tl.EndUnboundLoad();
        }
    }
}
