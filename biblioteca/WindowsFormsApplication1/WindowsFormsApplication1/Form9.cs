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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.LivrosTableAdapter.Fill(this.bibliotecaDataSet.Livros);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.UsuarioTableAdapter.Fill(this.bibliotecaDataSet.Usuario);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Hide();
        }
    }
}
