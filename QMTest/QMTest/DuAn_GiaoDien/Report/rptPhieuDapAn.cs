using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DuAn_GiaoDien.Report
{
    public partial class rptPhieuDapAn : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPhieuDapAn()
        {
            InitializeComponent();
        }
        public rptPhieuDapAn(string made)
        {
            InitializeComponent();
            xrLabel_MaDe.Text = made;
            
        }
        public void BinData()
        {
            xrLabel_IdCauHoi.DataBindings.Add("Text", DataSource, "IdCauHoi");
            //xrLabel_CauSo.DataBindings.Add("Text", DataSource, "STT");
            xrRichText2.DataBindings.Add("Rtf", DataSource, "DapAn");
            xrLabel6.DataBindings.Add("Text", DataSource, "STT");
            GroupField groupField = new GroupField("IdCauHoi");
            GroupHeader1.GroupFields.Add(groupField);
            Detail.SortFields.Add(new GroupField("STT", XRColumnSortOrder.Ascending));
        }

        private void rptPhieuDapAn_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Detail.SortFields.Add(new GroupField("STT", XRColumnSortOrder.Ascending));
        }


    }
}
