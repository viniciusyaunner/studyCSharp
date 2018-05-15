using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace puz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "C")
            {
                textBox2.Focus();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "A")
            {
                textBox3.Focus();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "V")
            {
                textBox4.Focus();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "A")
            {
                textBox5.Focus();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "L")
            {
                textBox6.Focus();
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "O")
            {
                textBox7.Focus();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "C")
            {
                textBox8.Focus();
            }
            else
            {
                textBox7.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "A")
            {
                textBox9.Focus();
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "S")
            {
                textBox10.Focus();
            }
            else
            {
                textBox9.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "A")
            {
                textBox11.Focus();
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "P")
            {
                textBox12.Focus();
            }
            else
            {
                textBox11.Text = "";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "I")
            {
                textBox13.Focus();
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "P")
            {
                textBox14.Focus();
            }
            else
            {
                textBox13.Text = "";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "A")
            {
                textBox15.Focus();
            }
            else
            {
                textBox14.Text = "";
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "O")
            {
                textBox16.Focus();
            }
            else
            {
                textBox15.Text = "";
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "L")
            {
                textBox17.Focus();
            }
            else
            {
                textBox15.Text = "";
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "H") 
            {
                textBox18.Focus();
            }
            else
            {
                textBox17.Text = "";
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "O")
            {
                textBox19.Focus();
            }
            else
            {
                textBox18.Text = "";
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "R")
            {
                textBox20.Focus();
            }
            else
            {
                textBox19.Text = "";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "E")
            {
                textBox21.Focus();
            }
            else
            {
                textBox20.Text = "";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "I")
            {
                MessageBox.Show("Parabens!!");
            }
            else
            {
                textBox21.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            Hide();
        }
    }
}
