using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class UcSystemLog : UserControl
    {
        public UcSystemLog()
        {
            InitializeComponent();
        }
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        SystemLog_Public sys;
        private void UcSystemLog_Load(object sender, EventArgs e)
        {
            dateEdit_DenNgay.DateTime = System.DateTime.Now;
            sys = new SystemLog_Public();
            sys.TuNgay = dateEdit_TuNgay.DateTime.ToShortDateString();
            sys.DenNgay = dateEdit_DenNgay.DateTime.ToShortDateString();
            gridControl1.DataSource = sys_bll.GetAllSystemLog(sys);
            simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sys = new SystemLog_Public();
            sys.TuNgay = dateEdit_TuNgay.DateTime.ToShortDateString();
            sys.DenNgay = dateEdit_DenNgay.DateTime.ToShortDateString();
            gridControl1.DataSource = sys_bll.GetAllSystemLog(sys);
        }
        int Id = 0;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sys = new SystemLog_Public();
                sys.Id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                Id = sys.Id;
                int kq = sys_bll.SystemLog_Delete(sys);
                if (kq > 0) XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString()) > 0)
                simpleButton2.Enabled = true;
            else
                simpleButton2.Enabled = false;

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString()) > 0)
                simpleButton2.Enabled = true;
            else
                simpleButton2.Enabled = false;
        }
    }
}
