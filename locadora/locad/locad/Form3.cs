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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.dsLocad.Generos);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.dsLocad.Generos);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            //this.locacaoTableAdapter.Fill(this.dsLocad.Locacao);

        }

        private void emprestimoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void locacaoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void generosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }
    }
}
