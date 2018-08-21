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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.loginDataSet.consulta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                consultaTableAdapter.porcrmv(loginDataSet.consulta, int.Parse(textBox1.Text));
            }
            else
            {
                try
                {
                    consultaTableAdapter.Fill(loginDataSet.consulta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
