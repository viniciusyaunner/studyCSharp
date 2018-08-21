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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.loginDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
