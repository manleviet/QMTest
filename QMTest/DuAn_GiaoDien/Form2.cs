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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Name = "1";
            this.Controls.Add(bt);

            if (bt.Name == "1") MessageBox.Show("abc");
        }
    }
}
