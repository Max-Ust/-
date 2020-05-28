using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР15_3
{
    public partial class Form1 : Form
    {
        static bool b = true;

        public Form1()
        {
            InitializeComponent();

            button1.Font = new Font(button1.Font.FontFamily, 50, button1.Font.Style);
            Text = "Кнопка";

            button1.Text = "НАЖМИ МЕНЯ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (b)
            {
                button1.Text = "Кнопка нажата";
                b = false;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
