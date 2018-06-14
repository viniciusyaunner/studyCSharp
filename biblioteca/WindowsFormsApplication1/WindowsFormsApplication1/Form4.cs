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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void emprestimoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emprestimoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.Livros);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.bibliotecaDataSet.Usuario);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.empreli'. Você pode movê-la ou removê-la conforme necessário.
            this.empreliTableAdapter.Fill(this.bibliotecaDataSet.empreli);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Emprestimo'. Você pode movê-la ou removê-la conforme necessário.
            this.emprestimoTableAdapter.Fill(this.bibliotecaDataSet.Emprestimo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empreliBindingSource.EndEdit();
            this.emprestimoTableAdapter.Update(bibliotecaDataSet.Emprestimo);
           
            this.Validate();
            this.empreliBindingSource.EndEdit();
            this.empreliTableAdapter.Update(bibliotecaDataSet.empreli);

        }
    }
}
