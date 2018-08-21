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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.veterinario'. Você pode movê-la ou removê-la conforme necessário.
            this.veterinarioTableAdapter.Fill(this.loginDataSet.veterinario);


        }



        private void veterinarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.veterinarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void veterinarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                veterinarioTableAdapter.pornome(loginDataSet.veterinario, "%" + textBox1.Text + "%");
            }
            else {
                try
                {
                    veterinarioTableAdapter.Fill(loginDataSet.veterinario);
                }
                catch(Exception ex) {
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
