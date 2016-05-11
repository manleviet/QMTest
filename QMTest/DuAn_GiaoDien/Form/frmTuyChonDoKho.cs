using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_PublicLayer;
using Test_BussinessLogicLayer;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class frmTuyChonDoKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTuyChonDoKho()
        {
            InitializeComponent();
            
           
        }
        DoKho_Public dk;
        DoKho_BLL dk_bll = new DoKho_BLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int kq=0;
          
                for (int i = 0; i < gridView1.RowCount-1; i++)
                {
                    if (gridView1.GetDataRow(i)[0].ToString() != null)
                    {
                        dk = new DoKho_Public();
                        dk.TenDoKho = gridView1.GetDataRow(i)["TenDoKho"].ToString();
                        kq = kq + dk_bll.DoKho_Insert(dk);
                    }
                }
          

            if (kq> 0) XtraMessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            gridControl1.DataSource = dk_bll.DoKho_Select();
            ShowColSuaXoa();
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gridView1.OptionsBehavior.ReadOnly = true;
        }
        DataTable dt;
        void ShowColSuaXoa()
        {
            gridView1.Columns["Sua"].Visible = true;
            gridView1.Columns["Xoa"].Visible = true;
        }
        void HideColSuaXoa()
        {
            gridView1.Columns["Sua"].Visible = false;
            gridView1.Columns["Xoa"].Visible = false;
        }


        private void frmTuyChonDoKho_Load(object sender, EventArgs e)
        {
       
            dt = new DataTable();
            dt = dk_bll.DoKho_Select();
            //MessageBox.Show(dt.Rows[0][1].ToString());
            if (dt.Rows.Count > 0)
            {
                ShowColSuaXoa();
                gridView1.OptionsBehavior.ReadOnly = true;
                labelControl1.Text = "Danh mục độ khó";
                labelControl1.ForeColor = Color.Blue;
                gridControl1.DataSource = dt;
               
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                HideColSuaXoa();
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

                gridControl1.DataSource = dt;
                
                labelControl1.Text = "- Thiết lập độ khó cho lần đầu cài đặt -";
                labelControl1.ForeColor = Color.Red;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HideColSuaXoa();
            labelControl1.Text = string.Format("Điền tên độ khó vào cột 'Tên độ khó'");
            gridControl1.DataSource = null;
            gridView1.OptionsBehavior.ReadOnly = false;
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("TenDoKho"));
            dt.Columns.Add(new DataColumn("Sua"));
            dt.Columns.Add(new DataColumn("Xoa"));
            gridControl1.DataSource = dt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e)
        {
            //MessageBox.Show("Abc");
        }

        bool bKiemTraClickSua;
        
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
             int kq;
                if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Xoa)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa độ khó có tên {0}", gridView1.GetFocusedRowCellValue("TenDoKho")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                     bKiemTraClickSua = false;               
                    dk=new DoKho_Public();
                    dk.IdDoKho=gridView1.GetFocusedRowCellValue("IdDoKho").ToString();
                    kq = dk_bll.DoKho_Delete(dk);
                    if (kq > 0) XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    gridControl1.DataSource = dk_bll.DoKho_Select();
                }
                    
            }
            else
                    if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Sua)
                    {
                        bKiemTraClickSua = true;
                        labelControl1.Text = "Nhập tên độ khó cần sửa sau đó nhấn Enter để thực hiện sửa";
                        //DevExpress.XtraGrid.Views.Base.ColumnView View = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.FocusedView;
                        //View.FocusedColumn = gridView1.VisibleColumns[0];
                        gridView1.OptionsBehavior.ReadOnly = false;
                        gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                        gridView1.ShowEditor();
                    }

        }



        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKiemTraClickSua == true)
            {
                int kq;
                if (gridView1.FocusedColumn.FieldName == "TenDoKho")
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắc chắn cập nhật độ khó có tên {0}", gridView1.GetFocusedRowCellValue("TenDoKho")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            dk = new DoKho_Public();
                            dk.IdDoKho = gridView1.GetFocusedRowCellValue("IdDoKho").ToString();
                            gridView1.FocusedColumn = gridView1.Columns["IdDoKho"];
                            dk.TenDoKho = gridView1.GetFocusedRowCellValue("TenDoKho").ToString();
                            kq = dk_bll.DoKho_Update(dk);
                            if (kq > 0) XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

    }
}
