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
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        bool kt;
        public frmKhoa(Khoa_Public k,bool kt)
        {
            InitializeComponent();
            try
            {
                txtIdKhoa.Text = k.IdKhoa.ToString();
                txtTenKhoa.Text = k.TenKhoa;
                txtMoTa.Text = k.MoTa;
                this.kt = kt;
            }
            catch { }
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            //TreeNode td = new TreeNode();
            //td.Text = "Vai trò";
            //treeView1.CheckBoxes = true;
     
            //TreeNode t=new TreeNode();
            //td.Nodes.Add(t);
            //t.Text = "Quản trị hệ thống";
            //t.Checked = true;
            //treeView1.Nodes.Add(td);

        }
        Khoa_Public k;
        Khoa_BLL k_bll = new Khoa_BLL();
        int kq;
        public bool KiemTraThemKhoa;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            k = new Khoa_Public();
            if (kt == true)
            {
                k.IdKhoa = int.Parse(txtIdKhoa.Text.Trim());
                k.TenKhoa = txtTenKhoa.Text.Trim();
                k.MoTa = txtMoTa.Text.Trim();
                kq = k_bll.Khoa_Insert(k);
                if (kq > 0)
                {
                   KiemTraThemKhoa = true;
                    XtraMessageBox.Show(string.Format("Thêm khoa {0} thành công!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else XtraMessageBox.Show(string.Format("Thêm khoa {0} thất bại!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KiemTraThemKhoa = true;
                k.IdKhoa =int.Parse(txtIdKhoa.Text.Trim());
                k.TenKhoa = txtTenKhoa.Text.Trim();
                k.MoTa = txtMoTa.Text.Trim();
                kq = k_bll.Khoa_Update(k);
                if (kq > 0)
                {
                    XtraMessageBox.Show(string.Format("Cập nhật thông tin khoa {0} thành công!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else XtraMessageBox.Show(string.Format("Cập nhật thông tin khoa {0} thất bại!", k.TenKhoa), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}