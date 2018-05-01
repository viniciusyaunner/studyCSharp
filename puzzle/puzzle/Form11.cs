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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 5)
            {
                if (textBox1.Text == "vapor")
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 5)
            {
                if (textBox2.Text == "panda")
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox2.Text = "";
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 5)
            {
                if (textBox3.Text == "carro")
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
            if (textBox4.TextLength == 4)
            {
                if (textBox4.Text == "maçã")
                {
                    MessageBox.Show("Parabens!!");
                }
                else
                {
                    textBox4.Text = "";
                }
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
