using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void vendasDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas F5 = new Vendas();
            F5.Show();
            Hide();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            Hide();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            Hide();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            Hide();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
            Hide();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            F11.Show();
            Hide();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            F12.Show();
            Hide();
        }

        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 F13 = new Form13();
            F13.Show();
            Hide();
        }
    }
}
