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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void fitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.dsLocad.Generos);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Fitas'. Você pode movê-la ou removê-la conforme necessário.
            this.fitasTableAdapter.Fill(this.dsLocad.Fitas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }
    }
}
