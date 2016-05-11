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
using Test_PublicLayer;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit;

namespace DuAn_GiaoDien
{
    public partial class frmEditCauHoi : Form
    {
        public frmEditCauHoi()
        {
            InitializeComponent();
        }
        GiaThietChung_BLL gtc_bll = new GiaThietChung_BLL();
        public frmEditCauHoi(string idgiathietchung,string idcauhoi,string noidungcauhoi,string idloaicauhoi)
        {
            InitializeComponent();
            NoiDungCauHoi = noidungcauhoi;
            IdGTC = idgiathietchung;
            IdLoaiCauHoi = idloaicauhoi;
            IdCauHoi = idcauhoi;
            splitContainerControl2.PanelVisibility = SplitPanelVisibility.Both;
            GiaThietChung_Public gtc = new GiaThietChung_Public();
            gtc.IdGiaThietChung = int.Parse(IdGTC);
            MessageBox.Show(IdGTC);
            NoiDungGTC = gtc_bll.GiaThietChung_Select_NoiDung(gtc).Rows[0]["NoiDung"].ToString();
            richEditControl1.Document.RtfText = NoiDungGTC;
        }
        public frmEditCauHoi(string idcauhoi,string noidungcauhoi,string idloaicauhoi)
        {
            InitializeComponent();
            NoiDungCauHoi = noidungcauhoi;
            IdLoaiCauHoi = idloaicauhoi;
            IdCauHoi = idcauhoi;
            splitContainerControl2.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        string IdGTC;
        string NoiDungCauHoi;
        string IdLoaiCauHoi;
        string IdCauHoi;
        string NoiDungGTC;
        CauTraLoi_Public ctl;
        CauTraLoi_BLL ctl_bll = new CauTraLoi_BLL();
        DataTable TableCauTraLoi;
        private void frmEditCauHoi_Load(object sender, EventArgs e)
        {
            
            richEditControl2.Document.RtfText = NoiDungCauHoi;
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            switch (int.Parse(IdLoaiCauHoi))
            {
                case 1:
                    gridView1.Columns["DapAn"].Visible = true;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridView1.Columns["CoDinh"].Visible = true;
                    gridView1.Columns["CoDinh"].Caption = "Chọn đáp án cố định";
                    break;
                case 2:
                    gridView1.Columns["DapAn"].Visible = true;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    gridView1.Columns["CoDinh"].Visible = false;
                    break;
                case 3:
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";
                    break;
                case 4:
                    gridView1.Columns["NoiDung1"].Caption = "Mệnh đề 1";
                    gridView1.Columns["NoiDung2"].Caption = "Mệnh đề 2";
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = true;
                    gridView1.Columns["CoDinh"].Visible = false;

                    break;
                case 5:
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Đáp án";
                    break;
                case 6:
                    gridView1.Columns["DapAn"].Visible = false;
                    gridView1.Columns["NoiDung2"].Visible = false;
                    gridView1.Columns["CoDinh"].Visible = false;
                    gridView1.Columns["NoiDung1"].Caption = "Câu trả lời";

                    break;
                default:

                    break;
            }
            ctl = new CauTraLoi_Public();
            ctl.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
            TableCauTraLoi=ctl_bll.CauTraLoi_Select_IdCauHoi(ctl);
            if (TableCauTraLoi.Rows.Count > 0)
            {
                gridControl_CauTraLoiVaDapAn.DataSource = TableCauTraLoi;
                //btnLuuThayDoiDapAn.Enabled = false;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            if ((int.Parse(IdCauHoi) == 2) && (gridView1.RowCount == 2))
                btnThemDapAn.Enabled = false;
        }

        //private void simpleButton1_Click(object sender, EventArgs e)// chọn giả thiết chung khác
        //{
        //    frmCustomGiaThietChung frm = new frmCustomGiaThietChung(true);
        //    frm.ShowDialog();

        //    richEditControl1.Document.RtfText = frmCustomGiaThietChung.recContent.Document.RtfText;
        //    if (string.Equals(NoiDungGTC, richEditControl1.Document.RtfText))
        //        btnLuuThayDoiGTC.Enabled = false;
        //    else
        //    {
        //        btnLuuThayDoiGTC.Enabled = true;
        //    }
        //}
        CauHoi_Public ch;
        CauHoi_BLL ch_bll = new CauHoi_BLL();
        private void simpleButton2_Click(object sender, EventArgs e) // lưu thay đổi id giả thiết chung
        {
            int kq;
            if (radioGroup1.SelectedIndex == 0)
            {
                try
                {
                    ch = new CauHoi_Public();
                    ch.IdCauHoi = int.Parse(IdCauHoi);
                    kq = ch_bll.CauHoi_SetNullIdGiaThietChung(ch);
                    if (kq > 0)
                        XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch { }
            }
            else
            {
                try
                {
                    ch = new CauHoi_Public();
                    ch.Gtc.IdGiaThietChung = int.Parse(IdGTC);
                    ch.IdCauHoi = int.Parse(IdCauHoi);
                    kq = ch_bll.CauHoi_Update_IdGiaThietChung(ch);
                    if (kq > 0)
                        XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch { }
            }


            

        }

        private void btnLuuThayDoiNoiDungCH_Click(object sender, EventArgs e)
        {
            try
            {
                ch = new CauHoi_Public();
                ch.NoiDung = richEditControl2.Document.RtfText;
                ch.IdCauHoi = int.Parse(IdCauHoi);
                int kq = ch_bll.CauHoi_Update_NoiDung(ch);
                if (kq > 0)
                    XtraMessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }

        }

        private void richEditControl2_Validated(object sender, EventArgs e)
        {
            if (string.Equals(NoiDungCauHoi, richEditControl1.Document.RtfText))
                btnLuuThayDoiNoiDungCH.Enabled = false;
            else
            {
                btnLuuThayDoiNoiDungCH.Enabled = true;
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                frmCustomGiaThietChung frm = new frmCustomGiaThietChung(true);
                frm.ShowDialog();
                richEditControl1.Document.RtfText = frmCustomGiaThietChung.recContent.Document.RtfText;
                if (frmCustomGiaThietChung.GetIdGiaThietChung==int.Parse(IdGTC))
                    btnLuuThayDoiGTC.Enabled = false;
                else
                {
                    btnLuuThayDoiGTC.Enabled = true;
                    IdGTC = frmCustomGiaThietChung.GetIdGiaThietChung.ToString();
                }

            }
            else
                btnLuuThayDoiGTC.Enabled = true;

        }
        CauTraLoi_Public Answer;
        CauTraLoi_BLL Answer_bll = new CauTraLoi_BLL();
        int kq1;
        RichTextBox rtb;
        private void btnLuuThayDoiDapAn_Click(object sender, EventArgs e) // lưu thay đổi đáp án
        {
            kq1 = 0;
            if (TableCauTraLoi.Rows.Count > 0)
            {
                if (int.Parse(IdLoaiCauHoi) == 1)  // nếu là dạng đa lựa chọn
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        kq1 = 0;
                        Answer = new CauTraLoi_Public();
                        Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(i)["IdCauTraLoi"].ToString());
                        Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                        try
                        {
                            Answer.CoDinh = Convert.ToBoolean(gridView1.GetDataRow(i)["CoDinh"].ToString());

                        }
                        catch { }
                        try
                        {
                            Answer.DapAn = Convert.ToBoolean(gridView1.GetDataRow(i)["DapAn"].ToString());
                        }
                        catch { }
                        kq1 = Answer_bll.CauTraLoi_Update(Answer, 1);
                    }
                }
                else
                    if (int.Parse(IdLoaiCauHoi) == 2) // dạng đúng/sai
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            Answer = new CauTraLoi_Public();
                            try
                            {
                                Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(i)["IdCauTraLoi"].ToString());
                                Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                Answer.DapAn = bool.Parse(gridView1.GetDataRow(i)["DapAn"].ToString());
                            }
                            catch { }
                            kq1 = Answer_bll.CauTraLoi_Update(Answer, 2);
                        }
                    }
                    else
                        if (int.Parse(IdLoaiCauHoi) == 3) // điền khuyết
                        {
                            try
                            {
                                for (int i = 0; i < gridView1.RowCount; i++)
                                {
                                    Answer = new CauTraLoi_Public();

                                    Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(i)["IdCauTraLoi"].ToString());
                                    Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                    kq1 = Answer_bll.CauTraLoi_Update(Answer, 3);

                                }
                            }
                            catch { }
                        }
                        else
                            if (int.Parse(IdLoaiCauHoi) == 6) //dạng trả lời ngắn
                            {
                                Answer = new CauTraLoi_Public();
                                try
                                {
                                    Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(0)["IdCauTraLoi"].ToString());
                                    Answer.NoiDung1 = gridView1.GetDataRow(0)["NoiDung1"].ToString();                      
                                    kq1 = Answer_bll.CauTraLoi_Update(Answer, 6);
                                }
                                catch { }

                            }
                            else
                                if (int.Parse(IdLoaiCauHoi) == 4) // dạng ghép đôi
                                {
                                    try
                                    {
                                        for (int i = 0; i < gridView1.RowCount; i++)
                                        {
                                            Answer = new CauTraLoi_Public();

                                            Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(0)["IdCauTraLoi"].ToString());
                                            Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                            Answer.NoiDung2 = gridView1.GetDataRow(i)["NoiDung2"].ToString();
                                            kq1 = Answer_bll.CauTraLoi_Update(Answer, 4);
                                        }
                                    }
                                    catch { }
                                }
                                else
                                {
                                    Answer = new CauTraLoi_Public();
                                    Answer.IdCauTraLoi = int.Parse(gridView1.GetDataRow(0)["IdCauTraLoi"].ToString());
                                    RichEditControl r = new RichEditControl();
                                    r.Text = gridView1.GetDataRow(0)["NoiDung1"].ToString();
                                    Answer.NoiDung1 = r.RtfText;
                                    kq1 = Answer_bll.CauTraLoi_Update(Answer, 3);
                                  
                                }

                             
                if(kq1 >0) XtraMessageBox.Show("Lưu thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (check == false)
                    ThemDapAn();
                if (int.Parse(IdLoaiCauHoi) == 1)  // nếu là dạng đa lựa chọn
                {
                    for (int i = 0; i < gridView1.RowCount - 1; i++)
                    {
                        Answer = new CauTraLoi_Public();
                        Answer.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
                        string NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                        rtb = new RichTextBox();
                        rtb.Rtf = NoiDung1;
                        if (string.IsNullOrEmpty(rtb.Text))
                            continue;
                        Answer.NoiDung1 = NoiDung1;
                        try
                        {
                            Answer.CoDinh = Convert.ToBoolean(gridView1.GetDataRow(i)["CoDinh"].ToString());

                        }
                        catch { }
                        try
                        {
                            Answer.DapAn = Convert.ToBoolean(gridView1.GetDataRow(i)["DapAn"].ToString());
                        }
                        catch { }
                        kq1 = Answer_bll.CauTraLoi_Add(Answer);
                    }
                }
                else
                    if (int.Parse(IdLoaiCauHoi) == 2) // dạng đúng/sai
                    {
                        for (int i = 0; i < gridView1.RowCount - 1; i++)
                        {
                            Answer = new CauTraLoi_Public();
                            try
                            {
                                Answer.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
                                string NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                rtb = new RichTextBox();
                                rtb.Rtf = NoiDung1;
                                if (string.IsNullOrEmpty(rtb.Text))
                                    continue;
                                Answer.NoiDung1 = NoiDung1;
                                Answer.DapAn = bool.Parse(gridView1.GetDataRow(i)["DapAn"].ToString());
                            }
                            catch { }
                            kq1 = Answer_bll.CauTraLoi_Insert(Answer);
                        }
                    }
                    else
                        if (int.Parse(IdLoaiCauHoi) == 3) // điền khuyết
                        {
                            for (int i = 0; i < gridView1.RowCount - 1; i++)
                            {
                                Answer = new CauTraLoi_Public();
                                try
                                {
                                    Answer.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
                                    string NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                    rtb = new RichTextBox();
                                    rtb.Rtf = NoiDung1;
                                    if (string.IsNullOrEmpty(rtb.Text))
                                        continue;
                                    Answer.NoiDung1 = NoiDung1;
                                }
                                catch { }
                                kq1 = Answer_bll.CauTraLoi_Insert(Answer);

                            }
                        }
                        else
                            if (int.Parse(IdLoaiCauHoi) == 6) //dạng trả lời ngắn
                            {
                                Answer = new CauTraLoi_Public();
                                try
                                {
                                    Answer.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
                                    string NoiDung1 = gridView1.GetDataRow(0)["NoiDung1"].ToString();
                                    rtb = new RichTextBox();
                                    rtb.Rtf = NoiDung1;
                                    if (string.IsNullOrEmpty(rtb.Text))
                                    {
                                        MessageBox.Show("Đáp án rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return;
                                    }
                                    Answer.NoiDung1 = NoiDung1;
                                }
                                catch { }
                                kq1 = Answer_bll.CauTraLoi_Insert(Answer);

                            }

                            else
                                if (int.Parse(IdLoaiCauHoi) == 4) // dạng ghép đôi
                                {
                                    for (int i = 0; i < gridView1.RowCount - 1; i++)
                                    {
                                        Answer = new CauTraLoi_Public();
                                        try
                                        {
                                            Answer.NoiDung1 = gridView1.GetDataRow(i)["NoiDung1"].ToString();
                                            Answer.NoiDung2 = gridView1.GetDataRow(i)["NoiDung2"].ToString();
                                        }
                                        catch { }
                                        kq1 = Answer_bll.CauTraLoi_Insert(Answer);

                                    }
                                }
                                else
                                {
                                    Answer = new CauTraLoi_Public();
                                    try
                                    {
                                        Answer.CauHoi.IdCauHoi = int.Parse(IdCauHoi);
                                        string NoiDung1 = gridView1.GetDataRow(0)["NoiDung1"].ToString();
                                        rtb = new RichTextBox();
                                        rtb.Rtf = NoiDung1;
                                        if (string.IsNullOrEmpty(rtb.Text))
                                        {
                                            MessageBox.Show("Đáp án rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                            return;
                                        }
                                        Answer.NoiDung1 = NoiDung1;
                                    }
                                    catch { }
                                    kq1 = Answer_bll.CauTraLoi_Insert(Answer);
                                }
                if (kq1 > 0) XtraMessageBox.Show("Thêm câu trả lời và đáp án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataTable dt;
        bool check;
        private void btnThemDapAn_Click(object sender, EventArgs e) // thêm đáp án
        {
            check = true;
            ThemDapAn();
        }
        void ThemDapAn()
        {
            btnLuuThayDoiDapAn.Enabled = true;
            TableCauTraLoi.Clear();
            gridControl_CauTraLoiVaDapAn.DataSource = null;
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            switch (int.Parse(IdLoaiCauHoi))
            {
                case 1:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1", Type.GetType("System.String")));
                    DataColumn dc = new DataColumn("DapAn");
                    dc.DataType = System.Type.GetType("System.Boolean");
                    DataColumn dc1 = new DataColumn("CoDinh") { DataType = System.Type.GetType("System.Boolean") };
                    dt.Columns.Add(dc1);
                    dt.Columns.Add(dc);
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    break;
                case 2:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    //dt.Columns.Add(new DataColumn("DapAn"));
                    DataColumn dc2 = new DataColumn("DapAn");
                    dc2.DataType = System.Type.GetType("System.Boolean");
                    dt.Columns.Add(dc2);
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    break;
                case 3:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("DapAn"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    break;
                case 4:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("NoiDung2"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    break;
                case 5:
                    break;
                case 6:
                    dt = new DataTable();
                    dt.Columns.Add(new DataColumn("NoiDung1"));
                    dt.Columns.Add(new DataColumn("DapAn"));
                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                    break;
                default:
                    break;
            }              
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            if ((int.Parse(IdLoaiCauHoi)==6) && (gridView1.RowCount > 1))
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }  
        }

        private void xóaĐpaToolStripMenuItem_Click(object sender, EventArgs e) // xóa đáp án
        {
            try
            {
                Answer = new CauTraLoi_Public();
                Answer.IdCauTraLoi = int.Parse(gridView1.GetFocusedRowCellValue("IdCauTraLoi").ToString());
                int kq = ctl_bll.CauTraLoi_Delete(Answer);
                if (kq > 0)
                {
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
            catch { }
        }

        private void thêmĐápÁnKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThemDapAn_Click(sender, e);
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {
            richEditBarController1.RichEditControl = richEditControl1;
        }

        private void richEditControl2_Click(object sender, EventArgs e)
        {
            if (ribbonControl1.Visible == true)
                richEditBarController1.RichEditControl = richEditControl2;
            else
                richEditBarController2.RichEditControl = richEditControl2;
        }
        int dem;
        int ktra;
        private void richEditControl2_ContentChanged(object sender, EventArgs e)
        {
                if (int.Parse(IdLoaiCauHoi) == 5)
                {
                    DocumentImageCollection images = richEditControl2.Document.GetImages(richEditControl2.Document.Range);
                    if (images.Count > 1)
                    {
                        //richEditControl_SoanCauHoi.Document.BeginUpdate();
                        for (int i = 1; i < images.Count; i++)
                        {
                            richEditControl2.Document.Delete(images[i].Range);
                            dem = 0;
                        }
                        //richEditControl_SoanCauHoi.Document.EndUpdate();
                    }
                    if (images.Count == 0)
                    {
                        dem = 0;
                        ktra = 0;
                    }
                    if (dem < 1)
                    {

                        if (images.Count == 1)
                        {
                            OfficeImage img = images[0].Image;
                            Image imgs = img.NativeImage;
                            if (ktra == 0)
                            {
                                if (string.IsNullOrEmpty(gridView1.GetDataRow(0)["NoiDung1"].ToString()))
                                {
                                    frmLayToaDoAnh frm = new frmLayToaDoAnh(imgs);
                                    ktra++;
                                    frm.ShowDialog();

                                }
                                else
                                {
                                    RichEditControl r = new RichEditControl();
                                    r.RtfText = gridView1.GetDataRow(0)["NoiDung1"].ToString();
                                    frmLayToaDoAnh frm = new frmLayToaDoAnh(imgs, r.Text);
                                    ktra++;
                                    frm.ShowDialog();
                                }
                                if (!string.IsNullOrEmpty(frmLayToaDoAnh.chuoi))
                                {
                                    btnLuuThayDoiDapAn.Enabled = true;
                                    DataTable dt = new DataTable();
                                    dt.Columns.Add(new DataColumn("NoiDung1"));
                                    dt.Columns.Add(new DataColumn("IdCauTraLoi"));
                                    DataRow dr = dt.NewRow();
                                    dr["NoiDung1"] = frmLayToaDoAnh.chuoi;
                                    dr["IdCauTraLoi"] = TableCauTraLoi.Rows[0]["IdCauTraLoi"].ToString();
                                    dt.Rows.Add(dr);
                                    gridControl_CauTraLoiVaDapAn.DataSource = dt;
                                }
                                else
                                {
                                    XtraMessageBox.Show("Bạn chưa chọn đáp án !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnLuuThayDoiDapAn.Enabled = false;
                                }
                            }
                            dem++;

                        }
                    }
                }         
        }
     
    }
}
