using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_PublicLayer;
using Test_BussinessLogicLayer;
//using PopupControl;

namespace DuAn_GiaoDien
{
    public partial class frmMaTranKienThuc_Update : DevExpress.XtraEditors.XtraForm
    {
        //Popup gridToolTip;
        //PivotGridToolTip gridCustomToolTip;
        public frmMaTranKienThuc_Update()
        {
            InitializeComponent();
            
        
        }
       

        DataTable dt;
        public frmMaTranKienThuc_Update(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            //gridToolTip = new Popup(gridCustomToolTip = new PivotGridToolTip());
            //gridToolTip.AutoClose = true;
            //gridToolTip.FocusOnOpen = false;
            //gridToolTip.ShowingAnimation = gridToolTip.HidingAnimation = PopupAnimations.LeftToRight | PopupAnimations.Slide;
        }
        MaTranKienThuc_BLL mtkt_bll = new MaTranKienThuc_BLL();
        MaTranKienThuc_Public mtkt;

        private void frmMaTranKienThuc_Update_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = dt;
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        //bool _resizableLeft, _resizableTop;
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //Point location = new Point();
         
            //Rectangle screen = Screen.FromControl(gridControl1).WorkingArea;
            //if (location.X + Size.Width > (screen.Left + screen.Width))
            //{
            //    _resizableLeft = true;
            //    location.X = (screen.Left + screen.Width) - Size.Width;
            //}
            //if (location.Y + Size.Height > (screen.Top + screen.Height))
            //{
            //    _resizableTop = true;
            //    location.Y -= Size.Height + screen.Height;
            //}
            //location = gridControl1.PointToClient(location);
            
            
            ////gridToolTip = new Popup(gridCustomToolTip = new PivotGridToolTip());
            ////gridToolTip.AutoClose = false;
            ////gridToolTip.FocusOnOpen = false;
            ////gridToolTip.ShowingAnimation = gridToolTip.HidingAnimation = PopupAnimations.LeftToRight | PopupAnimations.Slide;
            //gridToolTip.Show(gridControl1, screen);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            //MessageBox.Show(gridView1.GetFocusedRowCellValue("Id Mục kiến thức").ToString());
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int kq = 0;
            mtkt=new MaTranKienThuc_Public();
         
            mtkt.Mkt.IdMucKienThuc=gridView1.GetFocusedRowCellValue("IdMucKienThuc").ToString();
            mtkt.Mtn.IdMucTriNang = gridView1.GetFocusedRowCellValue("IdMucTriNang").ToString();
            mtkt.SoCauNhap=int.Parse(gridView1.GetFocusedRowCellValue("Số câu nhập").ToString());
            mtkt.SoCauQuyDinh=int.Parse(gridView1.GetFocusedRowCellValue("Số câu quy định").ToString());         
            kq = mtkt_bll.MaTranKienThuc_Update(mtkt);
            if(kq > 0) XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else XtraMessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

           
        }

        private void gridView1_MouseEnter(object sender, EventArgs e)
        {
           
         
            
            
            
        }


      
    }
}