using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace veterinaria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            Hide();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Hide();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Hide();
        }

        private void veterinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            Hide();
        }

        private void veterinarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            Hide();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            Hide();
        }

        private void veterinarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            Hide();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            Hide();
        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            Hide();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            Hide();
        }
    }
}
