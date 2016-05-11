using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DuAn_GiaoDien.Report
{
    public partial class rpPhieuDapAn : DevExpress.XtraReports.UI.XtraReport
    {
        public rpPhieuDapAn()
        {
            InitializeComponent();
        }
        public rpPhieuDapAn(string made)
        {
            InitializeComponent();
            xrLabel_MaDe.Text = made;

        }
        public void BinData()
        {
            xrRichText1.DataBindings.Add("Text", DataSource, "DapAn");
            lbCauSo.DataBindings.Add("Text", DataSource, "STT");
            lbIdCauHoi.DataBindings.Add("Text", DataSource, "IdCauHoi");
        }

    }
}
