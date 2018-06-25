using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void emprestimoLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolverLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Hide();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            Hide();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emprestimoDeLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Hide();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            Hide();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            Hide();
        }

        private void emprestimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            Hide();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
            Hide();
        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
            Hide();
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
            Hide();
        }
    }
}
