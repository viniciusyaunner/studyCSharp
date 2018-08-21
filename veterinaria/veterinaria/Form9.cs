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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.loginDataSet.animal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                animalTableAdapter.pornomea(loginDataSet.animal, "%" + textBox1.Text + "%");
            }
            else
            {
                try
                {
                    animalTableAdapter.Fill(loginDataSet.animal);
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
