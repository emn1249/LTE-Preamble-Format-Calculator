using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PFCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label5.Visible = true;
            Int32 sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi >= 0 & sayi < 15900)
            {
                label3.Text = "0";
                label3.Visible = true;
                label5.BackColor = Color.Green;
                label4.Visible = true;

            }
            else if (sayi >= 15900 & sayi <= 29500)
            {
                label3.Text = "2";
                label3.Visible = true;
                label5.BackColor = Color.Green;
                label4.Visible = true;

            }
            else if (sayi > 29500 & sayi < 107300)
            {
                label3.Text = "1";
                label3.Visible = true;
                label5.BackColor = Color.Green;
                label4.Visible = true;

            }
            else if (sayi >= 107300)
            {
                label3.Text = "3";
                label3.Visible = true;
                label5.BackColor = Color.Green;
                label4.Visible = true;

            }
            else if (sayi < 0)
            {
                string message = "Lütfen geçerli değer giriniz";
                MessageBox.Show(message);
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }
    }
}
