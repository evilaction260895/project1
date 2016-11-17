using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tp1_button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Tp1_textBox1.Text);
            b = Convert.ToInt32(Tp1_textBox2.Text);
            c = a + b;
            Tp1_textBox3.Text = c.ToString();
        }

        private void Tp2_button1_Click(object sender, EventArgs e)
        {
            int d, f, g;
            d = Convert.ToInt32(Tp2_textBox1.Text);
            f = Convert.ToInt32(Tp2_textBox2.Text);
            g = d - f;
            Tp2_textBox3.Text = g.ToString();
        }

        private void Tp3_button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = Convert.ToInt32(Tp3_textBox1.Text);
            b = Convert.ToInt32(Tp3_textBox2.Text);
            c = Convert.ToInt32(Tp3_textBox3.Text);
            d = a * b * c;
            Tp3_textBox4.Text = d.ToString();
        }
    }
}
