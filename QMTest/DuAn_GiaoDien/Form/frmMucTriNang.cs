using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
namespace DuAn_GiaoDien
{
    public partial class frmMucTriNang : DevExpress.XtraEditors.XtraForm
    {
        public frmMucTriNang()
        {
            InitializeComponent();
        }
        string IdMucKienThuc;
        public frmMucTriNang(string IdMucKienThuc)
        {
            InitializeComponent();
            this.IdMucKienThuc = IdMucKienThuc;
            simpleButton1.ImageIndex = 0;
            
        }
        MucTriNang_BLL mtn_bll = new MucTriNang_BLL();
        MucTriNang_Public mtn;
        MucKienThuc_Public mkt;
        MaTranKienThuc_BLL mtkt_bll = new MaTranKienThuc_BLL();
        MaTranKienThuc_Public mtkt;
        string[] LuuIdMucTriNang; // lưu những item đã check của Mục kiến thức cụ thể
        List<string> LuuIdMucTriNang_Item;
        List<string> LuuIdMucTriNang_ItemCheck;
        private void frmMucTriNang_Load(object sender, EventArgs e)
        {
            this.Size = new Size(354, 357);
            splitContainerControl3.PanelVisibility = SplitPanelVisibility.Panel1;
            checkedListBoxMucTriNang.BeginUpdate();
            checkedListBoxMucTriNang.DataSource = mtn_bll.MucTriNang_Select();
            checkedListBoxMucTriNang.DisplayMember = "TenMucTriNang";
            checkedListBoxMucTriNang.ValueMember = "IdMucTriNang";
            checkedListBoxMucTriNang.SelectedIndex = 1;
            //DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem() { Value = "Chọn tất cả" };
            //checkedListBoxMucTriNang.Items.Insert(0, item);
            checkedListBoxMucTriNang.EndUpdate();

            DataTable dt = new DataTable();
            mkt = new MucKienThuc_Public() { IdMucKienThuc = IdMucKienThuc };
            dt = mtkt_bll.MucTriNang_Select_IdMucKienThuc(mkt); 
            LuuIdMucTriNang = new string[dt.Rows.Count];
            

            LuuIdMucTriNang_Item = new List<string>(); 
            for (int i = 0; i <  dt.Rows.Count   ; i++)
            {
                //LuuIdMucTriNang[i]=dt.Rows[i]["IdMucTriNang"].ToString();
                LuuIdMucTriNang_Item.Add(dt.Rows[i]["IdMucTriNang"].ToString());
            }

            // check item trên checklistbox
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < checkedListBoxMucTriNang.ItemCount; j++)
                {
                    if (dt.Rows[i]["IdMucTriNang"].ToString() == checkedListBoxMucTriNang.GetItemValue(j).ToString())
                    {
                        this.checkedListBoxMucTriNang.SetItemChecked(j, true);
                    }
                }
            }         
        }

        private void btnThemMucTriNang_Click(object sender, EventArgs e)
        {
            int kq;
            mtn = new MucTriNang_Public() { TenMucTriNang = txtTenMucTriNang.Text.Trim() };
            kq = mtn_bll.MucTriNang_Insert(mtn);
            if (kq > 0)
            {
                XtraMessageBox.Show(string.Format("Thêm mức trí năng {0} thành công!", mtn.TenMucTriNang), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMucTriNang_Load(sender, e);
            }
            else XtraMessageBox.Show(string.Format("Thêm mức trí năng {0} thất bại!", mtn.TenMucTriNang), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

     
        int KiemTraInsert,KiemTraDelete;
        private void btnDongY_Click(object sender, EventArgs e)
        {
            LuuIdMucTriNang_ItemCheck = new List<string>();
            if (checkedListBoxMucTriNang.CheckedIndices == null)
                return;
            foreach (int indexChecked in checkedListBoxMucTriNang.CheckedIndices)
            {
                LuuIdMucTriNang_ItemCheck.Add(checkedListBoxMucTriNang.GetItemValue(indexChecked).ToString());  // lưu những item sau khi check trên checklistbox
                // The indexChecked variable contains the index of the item.
                // MessageBox.Show("Index#: " + indexChecked + ", is checked. Checked state is:" +
                //                 checkedListBoxMucTriNang.GetItemValue(indexChecked) + ".");
            }

   
            foreach (string item in LuuIdMucTriNang_ItemCheck) 
            {
                if (!LuuIdMucTriNang_Item.Contains(item))
                {

                    mtkt = new MaTranKienThuc_Public();
                    mtkt.Mkt.IdMucKienThuc = this.IdMucKienThuc;
                    mtkt.Mtn.IdMucTriNang = item;
                    KiemTraInsert = mtkt_bll.MaTranKienThuc_Insert(mtkt);             
                }
                    
            }

            //foreach (string item in LuuIdMucTriNang_Item)
            //    if (!LuuIdMucTriNang_ItemCheck.Contains(item))
            //        MessageBox.Show(item);
            foreach (string item in LuuIdMucTriNang_Item)
            {
                if (!LuuIdMucTriNang_ItemCheck.Contains(item))
                {
                    mtkt = new MaTranKienThuc_Public();
                    mtkt.Mkt.IdMucKienThuc = this.IdMucKienThuc;
                    mtkt.Mtn.IdMucTriNang = item;
                    KiemTraDelete = mtkt_bll.MaTranKienThuc_Delete(mtkt);
                }
            }
            if (KiemTraDelete > 0 || KiemTraInsert > 0)
            {

                if (XtraMessageBox.Show("Cập nhật thành công ! \nBạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
                LuuIdMucTriNang_Item = new List<string>();
                LuuIdMucTriNang_Item = LuuIdMucTriNang_ItemCheck;
            }


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)// btn mở rộng
        {
            if (simpleButton1.Text == "Mở rộng")
            {
                simpleButton1.ImageIndex = 1;
                simpleButton1.Text = "Thu hẹp";
                this.Size = new Size(354, 600);
                splitContainerControl3.PanelVisibility = SplitPanelVisibility.Both;
                gridControl1.DataSource = mtn_bll.MucTriNang_Select();
                
            }
            else
                if (simpleButton1.Text == "Thu hẹp")
                {
                    simpleButton1.ImageIndex = 0;
                    simpleButton1.Text = "Mở rộng";
                    this.Size = new Size(354, 357);                   
                }
  
        }
        bool IsCheck;
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsCheck == true)
            {
                int kq;
                if (gridView1.FocusedColumn.FieldName == "TenMucTriNang")
                {
                    if (e.KeyValue == 13)
                    {

                        if (XtraMessageBox.Show(string.Format("Bạn chắcc chắn cập nhật Mức trí năng có tên {0}", gridView1.GetFocusedRowCellValue("TenMucTriNang")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            mtn = new MucTriNang_Public();
                            mtn.IdMucTriNang = gridView1.GetFocusedRowCellValue("IdMucTriNang").ToString();
                            gridView1.FocusedColumn = gridView1.Columns["IdMucTriNang"];
                            mtn.TenMucTriNang = gridView1.GetFocusedRowCellValue("TenMucTriNang").ToString();
                            kq = mtn_bll.MucTriNang_Update_TenMucTriNang(mtn);
                            if (kq > 0) XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //MessageBox.Show(gridView1.GetFocusedRowCellValue("IdMucTriNang").ToString());
            int kq;
            if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Xoa)
            {
                if (XtraMessageBox.Show(string.Format("Bạn chắc chắn xóa Mức trí năng có tên {0}", gridView1.GetFocusedRowCellValue("TenMucTriNang")), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    IsCheck = false;
                    mtn = new MucTriNang_Public();
                    mtn.IdMucTriNang = gridView1.GetFocusedRowCellValue("IdMucTriNang").ToString();
                    kq = mtn_bll.MucTriNang_Delete(mtn);
                    if (kq > 0) XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    gridControl1.DataSource = mtn_bll.MucTriNang_Select();
                }

            }
            else
                if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Sua)
                {
                    IsCheck = true;
                    gridView1.OptionsBehavior.ReadOnly = false;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.ShowEditor();
                }
        }
      
    }
}