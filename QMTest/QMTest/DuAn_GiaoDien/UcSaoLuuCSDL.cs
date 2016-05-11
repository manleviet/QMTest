using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_PublicLayer;
using Test_BussinessLogicLayer;
using Test_DataAccess;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien
{
    public partial class UcSaoLuuCSDL : UserControl
    {
        public UcSaoLuuCSDL()
        {
            InitializeComponent();
        }
        DataProvider dp = new DataProvider();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == frm_DangNhap.GetMatKhau)
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "Backup File | *.bak";
                SFD.FileName = "qmtest_Backup";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dp.KetnoiCSDL();
                        dp.Backup(SFD.FileName);
                        dp.Ngatketnoi();
                        XtraMessageBox.Show("Đã sao lưu cơ sở dữ liệu", "Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch
                    {
                        if (SFD.FileName.Contains("C:\\"))
                        {
                            XtraMessageBox.Show("Chú ý: Không được sao lưu trên ổ đĩa hệ thống", "Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            XtraMessageBox.Show("Có lỗi, mời thử lại", "Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                XtraMessageBox.Show("Không đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
