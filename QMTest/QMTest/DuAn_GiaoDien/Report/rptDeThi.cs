using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Test_BussinessLogicLayer.BLLClass;
using DevExpress.XtraEditors;

namespace DuAn_GiaoDien.Report
{
    public partial class rptDeThi : DevExpress.XtraReports.UI.XtraReport
    {
        string _tenmh;
        int _thoigian;
        int _made;
        public rptDeThi()
        {
            InitializeComponent();
        }
        public rptDeThi(string tenmh, int thoigian, int made)
        {
            InitializeComponent();
            _tenmh = tenmh;
            _thoigian = thoigian;
            _made = made;
            xrLabel_ThoiGian.Text = _thoigian.ToString();
            xrLabel_TenMonThi.Text = _tenmh;

            DataSet ds = new DeThiBLL().GetNoiDungDeThi(made);
            this.DataSource = ds;
            this.DataMember = "CauHoi";

            xrLabel_MaDe.Text = made.ToString();
            DetailReport.DataMember = "CauHoi.DevThi";
            xrLabel_STT.DataBindings.Add("Text", ds, "CauHoi.STT");
            xrRichText1.DataBindings.Add("Rtf", ds, "CauHoi.NoiDung");

            xrLabel_STTChar.DataBindings.Add("Text", ds, "CauHoi.DevThi.STTChar");
            xrRichText2.DataBindings.Add("Rtf", ds, "CauHoi.DevThi.NoiDung1");
            xrLabel_STTNum.DataBindings.Add("Text", ds, "CauHoi.DevThi.STTNum");
            xrRichText3.DataBindings.Add("Rtf", ds, "CauHoi.DevThi.NoiDung2");
        }

        int i;
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            i++;
            if (i > 1) e.Cancel = true;
        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //i++;
            if (i > 1) e.Cancel = true;
        }
    }
}
