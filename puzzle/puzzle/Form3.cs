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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 2)
            {
                if (textBox1.Text == "11")
                {
                    textBox21.Focus();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.TextLength == 2)
            {
                if (textBox21.Text == "30")
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox21.Text = "";
                }
            }
        }
    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "9")
            {
                textBox3.Focus();
            }
            else {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 2)
            {
                if (textBox3.Text == "18")
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox3.Text = "";
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength == 2)
            {
                if (textBox4.Text == "30")
                {
                    textBox5.Focus();
                }
                else
                {
                    textBox4.Text = "";
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength == 2)
            {
                if (textBox5.Text == "25")
                {
                    MessageBox.Show("Parabens!!");
                }
                else
                {
                    textBox5.Text = "";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}
