namespace Locad
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoFitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fitasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoDeFitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.consultaClientesToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(574, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.generoToolStripMenuItem,
            this.fitasToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generoToolStripMenuItem.Text = "Genero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // fitasToolStripMenuItem
            // 
            this.fitasToolStripMenuItem.Name = "fitasToolStripMenuItem";
            this.fitasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fitasToolStripMenuItem.Text = "Fitas";
            this.fitasToolStripMenuItem.Click += new System.EventHandler(this.fitasToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoFitasToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // locaçãoFitasToolStripMenuItem
            // 
            this.locaçãoFitasToolStripMenuItem.BackgroundImage = global::Locad.Properties.Resources.tools;
            this.locaçãoFitasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locaçãoFitasToolStripMenuItem.Name = "locaçãoFitasToolStripMenuItem";
            this.locaçãoFitasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.locaçãoFitasToolStripMenuItem.Text = "Locação Fitas";
            this.locaçãoFitasToolStripMenuItem.Click += new System.EventHandler(this.locaçãoFitasToolStripMenuItem_Click);
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.generoToolStripMenuItem1,
            this.fitasToolStripMenuItem1,
            this.locaçãoToolStripMenuItem1});
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.consultaClientesToolStripMenuItem.Text = "Consulta";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // generoToolStripMenuItem1
            // 
            this.generoToolStripMenuItem1.Name = "generoToolStripMenuItem1";
            this.generoToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.generoToolStripMenuItem1.Text = "Genero";
            this.generoToolStripMenuItem1.Click += new System.EventHandler(this.generoToolStripMenuItem1_Click);
            // 
            // fitasToolStripMenuItem1
            // 
            this.fitasToolStripMenuItem1.Name = "fitasToolStripMenuItem1";
            this.fitasToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.fitasToolStripMenuItem1.Text = "Fitas";
            this.fitasToolStripMenuItem1.Click += new System.EventHandler(this.fitasToolStripMenuItem1_Click);
            // 
            // locaçãoToolStripMenuItem1
            // 
            this.locaçãoToolStripMenuItem1.Name = "locaçãoToolStripMenuItem1";
            this.locaçãoToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.locaçãoToolStripMenuItem1.Text = "Locação";
            this.locaçãoToolStripMenuItem1.Click += new System.EventHandler(this.locaçãoToolStripMenuItem1_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem2,
            this.fitasToolStripMenuItem2,
            this.generoToolStripMenuItem2,
            this.locaçãoToolStripMenuItem2,
            this.locaçãoDeFitasToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
            // 
            // fitasToolStripMenuItem2
            // 
            this.fitasToolStripMenuItem2.Name = "fitasToolStripMenuItem2";
            this.fitasToolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.fitasToolStripMenuItem2.Text = "fitas";
            this.fitasToolStripMenuItem2.Click += new System.EventHandler(this.fitasToolStripMenuItem2_Click);
            // 
            // generoToolStripMenuItem2
            // 
            this.generoToolStripMenuItem2.Name = "generoToolStripMenuItem2";
            this.generoToolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.generoToolStripMenuItem2.Text = "genero";
            this.generoToolStripMenuItem2.Click += new System.EventHandler(this.generoToolStripMenuItem2_Click);
            // 
            // locaçãoToolStripMenuItem2
            // 
            this.locaçãoToolStripMenuItem2.Name = "locaçãoToolStripMenuItem2";
            this.locaçãoToolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.locaçãoToolStripMenuItem2.Text = "locação";
            this.locaçãoToolStripMenuItem2.Click += new System.EventHandler(this.locaçãoToolStripMenuItem2_Click);
            // 
            // locaçãoDeFitasToolStripMenuItem
            // 
            this.locaçãoDeFitasToolStripMenuItem.Name = "locaçãoDeFitasToolStripMenuItem";
            this.locaçãoDeFitasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.locaçãoDeFitasToolStripMenuItem.Text = "locação de fitas";
            this.locaçãoDeFitasToolStripMenuItem.Click += new System.EventHandler(this.locaçãoDeFitasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locad.Properties.Resources.tools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 432);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoFitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fitasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fitasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem locaçãoDeFitasToolStripMenuItem;
    }
}

