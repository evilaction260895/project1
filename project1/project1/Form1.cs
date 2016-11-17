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
    }
}
