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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Fitas'. Você pode movê-la ou removê-la conforme necessário.
            this.fitasTableAdapter.Fill(this.dsLocad.Fitas);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dsLocad.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Locafitas'. Você pode movê-la ou removê-la conforme necessário.
            this.locafitasTableAdapter.Fill(this.dsLocad.Locafitas);
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.dsLocad.Locacao);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }


        private void locafitasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void locafitasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            locafitasDataGridView.Rows[locafitasDataGridView.RowCount - 1].Cells["valor"].Value = "0,00";
            locafitasDataGridView.Rows[locafitasDataGridView.RowCount - 1].Cells["quantidade"].Value = "0";
            locafitasDataGridView.Rows[locafitasDataGridView.RowCount - 1].Cells["valortotal"].Value = "0,00";
        }

        private void locafitasDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            for (int i = 0; i < locafitasDataGridView.RowCount - 1; i++)
            {
                DataGridViewRow row = locafitasDataGridView.Rows[i];
                string valueA = row.Cells["valor "].Value.ToString();
                string valueB = row.Cells["quantidade "].Value.ToString();
                decimal valorA, valorB;
                if (decimal.TryParse(valueA, out valorA) && decimal.TryParse(valueB, out valorB))
                {
                    row.Cells["valortotal"].Value = (valorA * valorB).ToString("0.00");
                    total += valorA * valorB;
                    totalTextBox.Text = total.ToString("0.00");
                }
            }
        }

        private void locacaoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}