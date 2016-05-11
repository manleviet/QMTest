using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_BussinessLogicLayer;
using DevExpress.XtraRichEdit;
using Test_PublicLayer;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraRichEdit.API.Native;

namespace DuAn_GiaoDien
{
    public partial class frmCustomGiaThietChung : Form
    {
        public frmCustomGiaThietChung()
        {
            InitializeComponent();
        }
        GiaThietChung_BLL gtc_bll = new GiaThietChung_BLL();
        private void frmCustomGiaThietChung_Load(object sender, EventArgs e)
        {
            splitContainerControl3.PanelVisibility = SplitPanelVisibility.Panel2;
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            this.Size = new Size(490, 234);
            btnLuu.Enabled = false;
            recContent.Document.Delete(recContent.Document.Range);
            _IndexSelectedRadioGroup1 = 0;
        }
        
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 2)
            {
                this.Size = new Size(490, 455);
                splitContainerControl3.PanelVisibility = SplitPanelVisibility.Both;
                gridControl1.DataSource = gtc_bll.GiaThietChung_Select();
                _IndexSelectedRadioGroup1 = 2;
            }
            else
            {
                splitContainerControl3.PanelVisibility = SplitPanelVisibility.Panel2;
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
                this.Size = new Size(490, 234);
                recContent.Document.Delete(recContent.Document.Range);
                if (radioGroup1.SelectedIndex == 1)
                {
                    richEditControl_SoanGiaThietChung.Document.Delete(richEditControl_SoanGiaThietChung.Document.Range); // xóa sạch nội dung trong richEdit
                    SetIdGiaThietChung = 0;
                    _IndexSelectedRadioGroup1 = 1;
                }
                else
                {
                    _IndexSelectedRadioGroup1 = 0; 
                }
            }
        }
        public static RichEditControl recContent=new RichEditControl(); // truyền nội dung qua form 1
        GiaThietChung_Public gtc;
        static int _IdGiaThietChung;
        static int _IndexSelectedRadioGroup1; // lấy index để truyền qua form 1

         static int SetIndexSelected
        {
            set { _IndexSelectedRadioGroup1 = value; }
        }

        public static int GetIndexSelected
        {
            get { return _IndexSelectedRadioGroup1; }
        }
        

        public static int GetIdGiaThietChung
        {
            get { return _IdGiaThietChung; }
        }
        static int SetIdGiaThietChung
        {
            set { _IdGiaThietChung = value; }
        }
        bool IsCheck;
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int kq;
            if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Xoa)
            {
                if (XtraMessageBox.Show("Bạn chắc chắn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    IsCheck = false;
                    gtc = new GiaThietChung_Public();
                    gtc.IdGiaThietChung = int.Parse(gridView1.GetFocusedRowCellValue("IdGiaThietChung").ToString());
                    kq = gtc_bll.GiaThietChung_Delete(gtc);
                    if (kq > 0) XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    gridControl1.DataSource = gtc_bll.GiaThietChung_Select();
                }

            }
            else
                if (gridView1.FocusedColumn.ColumnEdit == repositoryItemHyperLinkEdit_Sua)
                {
                    splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
                    this.Size = new Size(1190, 455);
                    IsCheck= true;
                    gridView1.OptionsBehavior.ReadOnly = true;
                    //gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    //MessageBox.Show(gridView1.FocusedRowHandle.ToString());

                    gridView1.FocusedColumn = gridView1.VisibleColumns[0];
                    gridView1.ShowEditor();
                    richEditControl_SoanGiaThietChung.Document.RtfText = gridView1.GetFocusedRowCellValue("NoiDung").ToString();

                    btnLuu.Enabled = true;
                    gtc = new GiaThietChung_Public();
                    gtc.IdGiaThietChung = int.Parse(gridView1.GetFocusedRowCellValue("IdGiaThietChung").ToString());
                    
                }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyData==Keys.Enter)
            //MessageBox.Show(gridView1.GetFocusedRowCellDisplayText("NoiDung").ToString());
            //if (IsCheck == true)
            //{
            //    int kq;
            //    if (gridView1.FocusedColumn.FieldName == "NoiDung")
            //    {
            //        if (e.KeyValue == 13)
            //        {

            //            if (XtraMessageBox.Show("Bạn chắc chắn cập nhật ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //            {
            //                gtc = new GiaThietChung_Public();
            //                gtc.IdGiaThietChung = gridView1.GetFocusedRowCellValue("IdGiaThietChung").ToString(); 
            //                gridView1.FocusedColumn = gridView1.Columns["IdGiaTChietChung"];
            //                gtc.NoiDung = gridView1.GetFocusedRowCellValue("NoiDung").ToString();
            //                //dk.TenDoKho = gridView1.GetFocusedRowCellValue("TenDoKho").ToString();
            //                ////kq = dk_bll.DoKho_Update(dk);
            //                //if (kq > 0) XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                //else
            //                //    XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            }
            //        }
            //    }
            //}
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int kq;
            if (XtraMessageBox.Show("Bạn chắc chắn cập nhật ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gtc.NoiDung = richEditControl_SoanGiaThietChung.Document.RtfText;
                kq = gtc_bll.GiaThietChung_Update(gtc);
                if (kq > 0)
                {
                    XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = gtc_bll.GiaThietChung_Select();
                }
                else
                    XtraMessageBox.Show("Lỗi, vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

            if (radioGroup1.SelectedIndex == 0 || radioGroup1.SelectedIndex == 1)
            {
              
                this.Close();
            }

            if ((radioGroup1.SelectedIndex == 2)&&(gridView1.RowCount>0))
            {
                recContent.Document.RtfText = gridView1.GetFocusedRowCellValue("NoiDung").ToString();
                if (recContent.Document.IsEmpty == true)
                    if (XtraMessageBox.Show("Bạn chưa chọn giả thiết nào !\n Bạn có muốn kết thúc không ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else return;
                try
                {
                    SetIdGiaThietChung = int.Parse(gridView1.GetFocusedRowCellValue("IdGiaThietChung").ToString());
                }
                catch { }
                this.Close();
            }
         
        }

    }
}
