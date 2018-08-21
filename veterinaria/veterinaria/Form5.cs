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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.animaisdados'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisdadosTableAdapter.Fill(this.loginDataSet.animaisdados);
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.loginDataSet.consulta);
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.animaisdados'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisdadosTableAdapter.Fill(this.loginDataSet.animaisdados);
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.loginDataSet.animal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisdadosBindingSource.EndEdit();
            this.animaisdadosTableAdapter.Update(loginDataSet.animaisdados);


        }


    }
}
