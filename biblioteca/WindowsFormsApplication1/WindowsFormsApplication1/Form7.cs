using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void emprestimoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emprestimoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Emprestimo'. Você pode movê-la ou removê-la conforme necessário.
            this.emprestimoTableAdapter.Fill(this.bibliotecaDataSet.Emprestimo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                emprestimoTableAdapter.porcont(bibliotecaDataSet.Emprestimo, int.Parse(textBox1.Text));
            }
            else
            {
                try
                {
                    emprestimoTableAdapter.Fill(bibliotecaDataSet.Emprestimo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }
    }
}