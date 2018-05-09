using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locad
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void generosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.dsLocad.Generos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
            {
                generosTableAdapter.porgenero(dsLocad.Generos, "%" + textBox1.Text + "%");

            }
            else
            {
                try
                {
                    generosTableAdapter.Fill(dsLocad.Generos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
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

