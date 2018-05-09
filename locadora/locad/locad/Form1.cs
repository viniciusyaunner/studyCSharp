using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Hide();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Hide();
        }

        private void locaçãoFitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            Hide();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            Hide();
        }

        private void generoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            Hide();
        }

        private void fitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
            Hide();
        }

        private void locaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
            Hide();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
            Hide();
        }

        private void fitasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.Show();
            Hide();
            Dispose();

        }

        private void generoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            F12.Show();
            Hide();
            Dispose();
        }

        private void locaçãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 F13 = new Form13();
            F13.Show();
            Hide();
            Dispose();
        }

        private void locaçãoDeFitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 F14 = new Form14();
            F14.Show();
            Hide();
            Dispose();
        }
    }
}
