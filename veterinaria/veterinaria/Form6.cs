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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }



        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.loginDataSet.consulta);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
