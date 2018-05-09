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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void fitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLocad);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsLocad.Fitas'. Você pode movê-la ou removê-la conforme necessário.
            this.fitasTableAdapter.Fill(this.dsLocad.Fitas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                fitasTableAdapter.portitulo(dsLocad.Fitas, "%" + textBox1.Text + "%");

            }
            else
            {
                try
                {
                    fitasTableAdapter.Fill(dsLocad.Fitas);
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
