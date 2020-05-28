using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР16
{
    public partial class Form1 : Form
    {
        static Class1 X = new Class1();
        static bool b = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(DecimalNumber.Text, out int result) && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                X.Get2 = DecimalNumber.Text;

                if (radioButton1.Checked)
                    textBox2.Text = "2-ичное значение = " + X.Get2;

                if (radioButton2.Checked)
                    textBox2.Text = "8-иричное значение = " + X.Get8;

                if (radioButton3.Checked)
                    textBox2.Text = "16-иричное значение = " + X.Get16;
            }
            else
            {
                textBox2.Text = "Невозможно перевести";
            }

            b = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(b)
            {
                if (Int32.TryParse(DecimalNumber.Text, out int result))
                {
                    X.Get2 = DecimalNumber.Text;

                    if (radioButton1.Checked)
                        textBox2.Text = "2-ичное значение = " + X.Get2;

                    if (radioButton2.Checked)
                        textBox2.Text = "8-иричное значение = " + X.Get8;

                    if (radioButton3.Checked)
                        textBox2.Text = "16-иричное значение = " + X.Get16;
                }
                else
                {
                    textBox2.Text = "Невозможно перевести";
                }
            }
        }

        private void DecimalNumber_TextChanged(object sender, EventArgs e)
        {
            if(b)
            {
                if (Int32.TryParse(DecimalNumber.Text, out int result))
                {
                    X.Get2 = DecimalNumber.Text;

                    if (radioButton1.Checked)
                        textBox2.Text = "2-ичное значение = " + X.Get2;

                    if (radioButton2.Checked)
                        textBox2.Text = "8-иричное значение = " + X.Get8;

                    if (radioButton3.Checked)
                        textBox2.Text = "16-иричное значение = " + X.Get16;
                }
                else
                {
                    textBox2.Text = "Невозможно перевести";
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(b)
            {
                if (Int32.TryParse(DecimalNumber.Text, out int result))
                {
                    X.Get2 = DecimalNumber.Text;

                    if (radioButton1.Checked)
                        textBox2.Text = "2-ичное значение = " + X.Get2;

                    if (radioButton2.Checked)
                        textBox2.Text = "8-иричное значение = " + X.Get8;

                    if (radioButton3.Checked)
                        textBox2.Text = "16-иричное значение = " + X.Get16;
                }
                else
                {
                    textBox2.Text = "Невозможно перевести";
                }
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(b)
            {
                if (Int32.TryParse(DecimalNumber.Text, out int result))
                {
                    X.Get2 = DecimalNumber.Text;

                    if (radioButton1.Checked)
                        textBox2.Text = "2-ичное значение = " + X.Get2;

                    if (radioButton2.Checked)
                        textBox2.Text = "8-иричное значение = " + X.Get8;

                    if (radioButton3.Checked)
                        textBox2.Text = "16-иричное значение = " + X.Get16;
                }
                else
                {
                    textBox2.Text = "Невозможно перевести";
                }
            }
        }
    }
}
