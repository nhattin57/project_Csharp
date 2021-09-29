using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int kq = a + b;
            txtKetQua.Text = kq.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int kq = a - b;
            txtKetQua.Text = kq.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon thoat", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            
            Close();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int kq = a * b;
            txtKetQua.Text = kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {

            float a = float.Parse(txtSoA.Text);
            float b = float.Parse(txtSoB.Text);
            if (b == 0)
            {
                MessageBox.Show("Mau phai khac 0", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                float kq = a / b;
                txtKetQua.Text = kq.ToString();
            }
        }
    }
}
