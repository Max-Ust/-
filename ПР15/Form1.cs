using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox1.Text = "Hello, world!";
            else
                textBox1.Text = "Hello, " + textBox2.Text + "!";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
