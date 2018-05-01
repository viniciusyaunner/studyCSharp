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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4)
            {
                if (textBox1.Text == "bola")
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
            if (textBox2.TextLength == 8){
                if (textBox2.Text == "golfinho")
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
                if (textBox3.Text == "cachorro")
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
            if (textBox4.TextLength == 5)
            {
                if (textBox4.Text == "carro")
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
            if (textBox5.TextLength == 10)
            {
                if (textBox5.Text == "computador")
                {
                    textBox6.Focus();
                }
                else
                {
                    textBox5.Text = "";
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.TextLength == 10)
            {
                if (textBox6.Text == "astronauta")
                {
                    MessageBox.Show("Parabens!!");
                }
                else
                {
                    textBox1.Text = "";
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