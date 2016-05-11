using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuAn_GiaoDien
{
    public partial class frmXemNoiDungCauHoi : Form
    {
        public frmXemNoiDungCauHoi()
        {
            InitializeComponent();
        }
        public frmXemNoiDungCauHoi(string chuoi)
        {
            InitializeComponent();
            richEditControl1.RtfText = chuoi;
        }

        private void frmXemNoiDungCauHoi_Load(object sender, EventArgs e)
        {

        }
    }
}
