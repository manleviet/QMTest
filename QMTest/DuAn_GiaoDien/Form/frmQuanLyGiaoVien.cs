using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_BussinessLogicLayer;
using Test_PublicLayer;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraEditors.Controls;
using System.Drawing.Imaging;

namespace DuAn_GiaoDien
{
    public partial class frmQuanLyGiaoVien : XtraForm
    {
        public frmQuanLyGiaoVien()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Khoa_BLL kbll = new Khoa_BLL();
        ToBoMon_BLL tbmbll = new ToBoMon_BLL();

        GiaoVien_Public gv;
        GiaoVien_BLL gvbll = new GiaoVien_BLL();

        ChucDanh_BLL cdbll = new ChucDanh_BLL();
        ChiTietChucDanh_BLL ctcdbll = new ChiTietChucDanh_BLL();
        ChiTietChucDanh_Public ctcd = new ChiTietChucDanh_Public();

        ChucVu_BLL cvbll = new ChucVu_BLL();
        ChiTietChucVu_BLL ctcvbll;
        ChucVu_Public cv;
        ChiTietChucVu_Public ctcv;
        DataTable dt;
        Quyen_BLL q_bll = new Quyen_BLL();
        ChiTietQuyen_BLL ctq_bll = new ChiTietQuyen_BLL();
        ChiTietQuyen_Public ctq;
        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            
            
            cbbKhoa.ValueMember = "IdKhoa";
            cbbKhoa.DataSource = kbll.Khoa_Select();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.SelectedIndex = 0;
            
            
            cbbChucDanh.ValueMember = "IdChucDanh";
            cbbChucDanh.DisplayMember = "TenChucDanh";
            cbbChucDanh.DataSource = cdbll.ChucDanh_Select();
            cbbChucDanh.SelectedIndex = 0;
            

            dt = new DataTable();
            dt = q_bll.Quyen_Select();
            if (dt.Rows.Count > 0)
            {
                radioGroup1.Properties.Items.Clear(); // remove item trước đó

                object[] itemValues = new object[dt.Rows.Count];
                string[] itemDescriptions = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    itemValues[i] = dt.Rows[i]["IdQuyen"].ToString();
                    itemDescriptions[i] = dt.Rows[i]["TenQuyen"].ToString();
                    radioGroup1.Properties.Items.Add(new RadioGroupItem(itemValues[i], itemDescriptions[i]));
                }
                radioGroup1.SelectedIndex = 0;
            }

            //tvVaiTroHeThong.ExpandAll();   
            //DataTable dt = new DataTable();
            //dt = cvbll.ChucVu_Select();
            //int i=0;
            //foreach (DataRow dr in dt.Rows)
            //{  
            //    TreeNode td = new TreeNode();
            //    td.Text = dr.Table.Rows[i]["TenChucVu"].ToString();
            //    td.Name = dr.Table.Rows[i]["IdChucVu"].ToString();
            //    tvVaiTroHeThong.Nodes["NodeVaiTroHeThong"].Nodes.Add(td);
            //    i++;
            //}    
        }
        private static Khoa_Public GetKp()
        {
            Khoa_Public kp = new Khoa_Public();
            return kp;
        }

       

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int kq1, kq2;
            gv = new GiaoVien_Public();
            gv.TenGiaoVien = txtHoTen.Text.Trim();
            gv.IdToBoMon = cbbToBoMon.SelectedValue.ToString();
            gv.MatKhau = txtMatKhau.Text.Trim();
            gv.NgaySinh = DateTime.Parse(dateEditNgaySinh.EditValue.ToString());
            gv.SoDienThoai = txtSoDienThoai.Text.Trim();
            gv.TaiKhoan = txtTenDangNhap.Text.Trim();
            gv.TrangThai = checkEditTrangThai.Checked;
            gv.DiaChi = txtDiaChi.Text.Trim();
            gv.GhiChu = txtGhiChu.Text.Trim();
            gv.Image = anh;
            gv.Quyen.IdQuyen = int.Parse(radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value.ToString());
            ctcd.ChucDanh.IdChucDanh = cbbChucDanh.SelectedValue.ToString();

            // chèn thông tin vào 2 bảng chi tiết chức danh và giáo viên
            kq1 = gvbll.GiaoVien_Insert(gv);
            kq2 = ctcdbll.ChiTietChucDanh_Insert(ctcd);
           

            //ctq = new ChiTietQuyen_Public();
            //ctq.Quyen.IdQuyen = int.Parse(radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value.ToString());
            //kq3 = ctq_bll.ChiTietQuyen_Insert(ctq);

            if ((kq1 > 0) && (kq2 > 0)) XtraMessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else XtraMessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //foreach (TreeNode tn in tvVaiTroHeThong.Nodes["NodeVaiTroHeThong"].Nodes)
            //{
            //    if (tn.Checked == true)
            //    {
            //        ctcv = new ChiTietChucVu_Public();
            //        ctcv.Cv.IdChucVu = tn.Name;
            //        ctcv.Gv.IdGiaoVien=gv.IdGiaoVien;
            //        ctcvbll.ChiTietChucVu_Insert(ctcv);
            //   }
            //}





        }

        private void txtXacNhanMK_Validated(object sender, EventArgs e)
        {
            if (string.Equals(txtMatKhau.Text.Trim(), txtXacNhanMK.Text.Trim()) == false)
            {
                checkEditXacNhanMK.Visible = false;
                XtraMessageBox.Show("Sai mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox2.Enabled = false;
                btnLuu.Enabled = false;
            }
            else
            {
                checkEditXacNhanMK.Visible = true;
                groupBox2.Enabled = true;
                btnLuu.Enabled = true;
            }

        }
        ToBoMon_Public tbm;
        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            //Khoa_Public kp = GetKp();
            try
            {
                tbm = new ToBoMon_Public();
                tbm.Khoa.IdKhoa = int.Parse(cbbKhoa.SelectedValue.ToString());
                //cbbToBoMon.SelectedIndex = -1;
                cbbToBoMon.DataSource = tbmbll.ToBoMon_Select_IdKhoa(tbm);
                cbbToBoMon.DisplayMember = "TenToBoMon";
                cbbToBoMon.ValueMember = "IdToBoMon";
            }
            catch { }
        }

        private void txtTenDangNhap_Validated(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                txtTenDangNhap.Focus();
                XtraMessageBox.Show("Tên đăng nhập không được trống !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Trim()=="")
            {
                txtTenDangNhap.Focus();
                XtraMessageBox.Show("Họ tên không được trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvVaiTroHeThong_AfterCheck(object sender, TreeViewEventArgs e)
        {

            //tvVaiTroHeThong.BeginUpdate();
            //foreach (TreeNode node in tvVaiTroHeThong.Nodes)
            //{
            //    //If node has child nodes
            //    if (node.Checked == true)   //it is better to first check if it is "checked" then proceed to count child nodes
            //    {
            //        if (node.GetNodeCount(false) > 0)   //check if node has any child nodes
            //        {
            //            //Check all the child nodes.
            //            foreach (TreeNode childNode in node.Nodes)
            //            {
            //                childNode.Checked = true;
            //            }
            //        }
            //    }
            //}
            //tvVaiTroHeThong.EndUpdate();
           
            //if (tvVaiTroHeThong.Nodes["NodeVaiTroHeThong"].Checked == true)
            //{
            //    foreach (TreeNode childnode in tvVaiTroHeThong.Nodes["NodeVaiTroHeThong"].Nodes)
            //        childnode.Checked = true;
            //}
            if (e.Node.Checked == true)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);    
                }
            }
            else
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
        //public void CheckNodes(TreeNode startNode)
        //{
        //    startNode.Checked = true;
        //    foreach (TreeNode node in startNode.Nodes)
        //        CheckNodes(node);
        //}
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
           
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively. 
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        byte[] anh = { };
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            anh = null;
            dlg.Filter = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }
            dlg.DefaultExt = ".PNG";// Default file extension 
            dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, "All Files", "*.*");
            
            if (dlg.ShowDialog(this) == DialogResult.OK) 
            {
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    anh = new Byte[fs.Length];
                    fs.Read(anh, 0, (int)fs.Length);
                    //Đưa ảnh lên picturedit1
                    MemoryStream str = new MemoryStream(anh);
                    pictureBox1.Image = Image.FromStream(str);
                }
            }
        }

    }
}
