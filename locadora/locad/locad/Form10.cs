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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 6)
            {
                if (textBox1.Text == "sonhei")
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
                if (textBox2.Text == "feira")
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
            if (textBox3.TextLength == 8)
            {
                if (textBox3.Text == "macarrão")
                {
                    MessageBox.Show("Parabens!!");
                }
                else
                {
                    textBox3.Text = "";
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
