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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.GenerosTableAdapter.Fill(this.dsLocad.Generos);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Fitas'. Você pode movê-la ou removê-la conforme necessário.
            this.FitasTableAdapter.Fill(this.dsLocad.Fitas);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
            Dispose();
        }
    }
}
