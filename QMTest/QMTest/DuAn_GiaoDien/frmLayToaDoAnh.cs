using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DuAn_GiaoDien
{
    public partial class frmLayToaDoAnh : Form
    {
        public frmLayToaDoAnh()
        {
            InitializeComponent();
        }
        Image Img;
        public frmLayToaDoAnh(Image img)
        {
            InitializeComponent();
            Img = img;
        }
        string DapAn;
        public frmLayToaDoAnh(Image img, string DapAn)
        {
            InitializeComponent();
            Img = img;
            this.DapAn = DapAn;
            string[] listDapAn = this.DapAn.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (listDapAn.Length > 0)
            {
                textBox3.Text = listDapAn[0];
                textBox4.Text = listDapAn[1];
                textBox1.Text = listDapAn[2];
                textBox2.Text = listDapAn[3];
                x1 = int.Parse(textBox3.Text);
                y1 = int.Parse(textBox4.Text);
                x2 = int.Parse(textBox1.Text);
                y2 = int.Parse(textBox2.Text);
            }

            
        }
        public static string chuoi;
        int x1, x2, y1, y2;
        private bool isMoving = false;
        private Point mouseDownPosition = Point.Empty;
        private Point mouseMovePosition = Point.Empty;
        private Dictionary<Point, Point> Circles = new Dictionary<Point, Point>();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text))
            {
                if (XtraMessageBox.Show("Bạn chưa chọn đáp án cho câu hỏi ! Có muốn đóng lại không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    chuoi = String.Format("{0},{1},{2},{3}", 0, 0, 0, 0);
                    this.Close();
                }
            }
            else
            {
                chuoi = String.Format("{0},{1},{2},{3}", x1, y1, x2, y2);
                this.Close();
            }

        }

        private void frmLayToaDoAnh_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Img;

        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureEdit1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 2f);
            var g = e.Graphics;
            if (isMoving)
            {
                //g.Clear(pictureBox1.BackColor);
                g.DrawRectangle(p, new Rectangle(mouseDownPosition, new Size(mouseMovePosition.X - mouseDownPosition.X, mouseMovePosition.Y - mouseDownPosition.Y)));
                //foreach (var circle in Circles)
                //{
                //    //g.DrawRectangle(p, new Rectangle(circle.Key, new Size(circle.Value.X - circle.Key.X, circle.Value.Y - circle.Key.Y)));
                //}
            }
        }

        private void pictureEdit1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                mouseMovePosition = e.Location;
                textBox1.Text = e.X.ToString();
                textBox2.Text = e.Y.ToString();
                pictureBox1.Invalidate();
            }
        }

        private void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            isMoving = true;
            mouseDownPosition = e.Location;
            x1 = mouseDownPosition.X;
            y1 = mouseDownPosition.Y;
            textBox3.Text = e.X.ToString();
            textBox4.Text = e.Y.ToString();
        }

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
            //if (isMoving)
            //{
            //    //Circles.Add(mouseDownPosition, mouseMovePosition);
            //}
            isMoving = false;
            x2 = e.X;
            y2 = e.Y;
        }

      
    }
}
