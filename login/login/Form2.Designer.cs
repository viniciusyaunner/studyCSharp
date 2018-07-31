namespace login
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label despesasLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDados = new login.dsDados();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.despesasTableAdapter = new login.dsDadosTableAdapters.despesasTableAdapter();
            this.tableAdapterManager = new login.dsDadosTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            despesasLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // despesasLabel
            // 
            despesasLabel.AutoSize = true;
            despesasLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            despesasLabel.Location = new System.Drawing.Point(12, 18);
            despesasLabel.Name = "despesasLabel";
            despesasLabel.Size = new System.Drawing.Size(55, 13);
            despesasLabel.TabIndex = 2;
            despesasLabel.Text = "despesas:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            valorLabel.Location = new System.Drawing.Point(12, 41);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "valor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataLabel.Location = new System.Drawing.Point(36, 70);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "data:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(dataLabel);
            this.panel1.Controls.Add(despesasLabel);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataMember = "despesas";
            this.despesasBindingSource.DataSource = this.dsDados;
            // 
            // dsDados
            // 
            this.dsDados.DataSetName = "dsDados";
            this.dsDados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(385, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 100);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // despesasTableAdapter
            // 
            this.despesasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.despesasTableAdapter = this.despesasTableAdapter;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = login.dsDadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 238);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(74, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(74, 70);
            this.maskedTextBox1.Mask = "99/99/9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.c69291de9d463b45c4366de9b0450557e1f3f45a_00;
            this.ClientSize = new System.Drawing.Size(583, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDados)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private dsDados dsDados;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private dsDadosTableAdapters.despesasTableAdapter despesasTableAdapter;
        private dsDadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
    }
}