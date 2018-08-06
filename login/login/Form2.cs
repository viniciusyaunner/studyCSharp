using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }
        //funcao para buscar os dados no banco de dados
        private void mostrarDados() {
            string sql = "SELECT codigo,despesas,valor,data FROM despesas ORDER BY despesas";//comando SQL para buscar dados
        //cria uma conexao para buscar dados no Access
            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\3º INFO\\D.S\\login\\Dados.accdb");
            //execulta o comando SQL 
            OleDbCommand comando = new OleDbCommand(sql, conexao);

            conexao.Open();//abre Banco de dados

            DataTable dadosTabela = new DataTable();//criar um objeto de armazenar os dados em um formato de tabela
            dadosTabela.Load(comando.ExecuteReader());//adicionar automaticamente todos os dados em um DataTable
            conexao.Close();//fecha banco de dados
            dataGridView1.DataSource = dadosTabela;//a datagridview recebera os dados que estao no objeto dadosTabela

        }
        private void despesasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.despesasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDados);

        }

        private void despesasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.despesasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDados);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comando SQl para inserir um Access
            string sql = "INSERT INTO despesas(despesas,valor,data)VALUES('"+textBox1.Text+"','"+numericUpDown1.Text+"','"+maskedTextBox1.Text+"')";
            //cria um objeto de conexao
            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\3º INFO\\D.S\\login\\Dados.accdb");
            //o objeto execulta o sql
            OleDbCommand comando = new OleDbCommand(sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();//execulta o comando sql
                conexao.Close();
                MessageBox.Show("Registro inserido com sucesso");
                //limpar os dados e receber novos valores
                textBox1.Text = "";
                numericUpDown1.Text = "";
                maskedTextBox1.Text = "";
                mostrarDados();// mostrar dados


            }
            catch {
                MessageBox.Show("erro ao efetuar a operacao");

            }

 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //criar um objeto conexao com String de conexao que vao buyscar os dados em uma base 
            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\3º INFO\\D.S\\login\\Dados.accdb");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string pesquisa = "Delete from despesas where codigo =" + codigo;
                OleDbCommand comando = new OleDbCommand(pesquisa,conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Registro excliudo com sucesso");
                pesquisa = "select codigo,despesas,valor,data from despesas";
                DataTable despesas = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(pesquisa,conexao);
                adaptador.Fill(despesas);
                adaptador.Dispose();
                dataGridView1.DataSource = despesas.DefaultView;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
