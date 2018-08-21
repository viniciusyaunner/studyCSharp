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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.animaisdados'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisdadosTableAdapter.Fill(this.loginDataSet.animaisdados);
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.veterinario'. Você pode movê-la ou removê-la conforme necessário.
            this.veterinarioTableAdapter.Fill(this.loginDataSet.veterinario);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
