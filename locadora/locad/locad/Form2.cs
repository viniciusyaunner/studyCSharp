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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dsLocad.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'dsLoja.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dsLocad.Clientes);
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }

        private void cEPMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cEPMaskedTextBox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
