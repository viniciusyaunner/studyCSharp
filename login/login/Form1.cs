﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new
            OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;DataSource=E:\\3º INFO\\D.S\\login\\Dados.accdb");
            OleDbCommand comandos = new OleDbCommand();
            conexao.Open();
            comandos.CommandText = ("select login, senha from login where login'" + textBox2 + "'");
            comandos.Connection = conexao;
            OleDbDataReader consulta = comandos.ExecuteReader();
            if (consulta.HasRows)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else {
                MessageBox.Show("Login ou senha inválido");
            }
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}