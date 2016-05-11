using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class frm_QuanLyHeThong : XtraForm
    {
        public frm_QuanLyHeThong()
        {
            InitializeComponent();
        }

        private void frm_QuanLyHeThong_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
        public void AddUserControl(UserControl uc)
        {
            pQuanLyHeThong.Controls.Clear();
            pQuanLyHeThong.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;    
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            if (e.Node.Name=="NodeDanhSachGiaoVien")
            {
                UcNguoiSuDung uc = new UcNguoiSuDung();
                AddUserControl(uc);
            }
            if (e.Node.Name == "NodeCayPhanCapMonHoc")
            {
                UserControlCayPhanCapMonHoc uc_pcmh = new UserControlCayPhanCapMonHoc();
                AddUserControl(uc_pcmh);
                
            }
            if (e.Node.Name == "NodeDanhMucKhoa")
            {
                UcDanhMucKhoa uc_dmk = new UcDanhMucKhoa();
                AddUserControl(uc_dmk);
            }
        }

    }
}
