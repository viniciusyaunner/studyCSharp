using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\3º INFO\\D.S\\veterinaria\\login.accdb");
            OleDbCommand comandos = new OleDbCommand();
            conexao.Open();
            comandos.CommandText = ("select login, senha from login where login='" + textBox1.Text + "' and senha= '" + textBox2.Text + "'");
            comandos.Connection = conexao;
            OleDbDataReader consulta = comandos.ExecuteReader();
            if (consulta.HasRows)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else {
                MessageBox.Show("Login ou Senha inválido");
                conexao.Close();
            }

        }
    }
}
