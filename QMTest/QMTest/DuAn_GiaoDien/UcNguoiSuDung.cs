using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;
using DevExpress.XtraEditors;
using Test_PublicLayer;

namespace DuAn_GiaoDien
{
    public partial class UcNguoiSuDung : UserControl
    {
        GiaoVien_BLL gv_bll = new GiaoVien_BLL();
        public UcNguoiSuDung()
        {
            InitializeComponent();
            gridControl1.DataSource = gv_bll.GiaoVien_Select();
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

        private void simpleButton1_Click(object sender, EventArgs e) // thêm người dùng 
        {
            frmQuanLyGiaoVien frm = new frmQuanLyGiaoVien();
            frm.Show();
            gridControl1.DataSource = gv_bll.GiaoVien_Select();  
        }
        SystemLog_BLL sys_bll = new SystemLog_BLL();
        private void simpleButton2_Click(object sender, EventArgs e) // xóa người dùng
        {
            if (XtraMessageBox.Show("Xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                GiaoVien_Public gv = new GiaoVien_Public();
                gv.IdGiaoVien = int.Parse(cardView1.GetFocusedRowCellValue("IdGiaoVien").ToString());
                if ((gv_bll.KiemTraSoanCauHoiNHCT(gv).Rows.Count > 0) || (gv_bll.KiemTraSoanCauHoiNHSB(gv).Rows.Count > 0))
                {
                    XtraMessageBox.Show("Giáo viên này đã soạn câu hỏi, KHÔNG THỂ XÓA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int kq = gv_bll.GiaoVien_Delete(gv);
                    if (kq > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        gridControl1.DataSource = gv_bll.GiaoVien_Select();
                        SystemLog_Public sys = new SystemLog_Public();
                        sys.Gv.IdGiaoVien = frm_DangNhap.GetIdGiaoVien;
                        sys.Gv.TenGiaoVien = frm_DangNhap.GiaoVien.TenGiaoVien;
                        sys.MoTa = "Xóa người dùng có mã là " + cardView1.GetFocusedRowCellValue("IdGiaoVien");
                        sys_bll.SystemLog_Insert(sys);
                    }
                }
            }
        }

        private void cardView1_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
            simpleButton3.Enabled = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }
 
    }
}
