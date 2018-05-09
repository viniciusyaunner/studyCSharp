namespace Locad
{
    partial class Form4
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
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label classicoLabel;
            System.Windows.Forms.Label distribuidorLabel;
            System.Windows.Forms.Label diretorLabel;
            System.Windows.Forms.Label resumoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codGenLabel;
            System.Windows.Forms.Label codigoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.fitasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.fitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocad = new Locad.dsLocad();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fitasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.classicoTextBox = new System.Windows.Forms.TextBox();
            this.distribuidorTextBox = new System.Windows.Forms.TextBox();
            this.diretorTextBox = new System.Windows.Forms.TextBox();
            this.resumoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.fitasTableAdapter = new Locad.dsLocadTableAdapters.FitasTableAdapter();
            this.tableAdapterManager = new Locad.dsLocadTableAdapters.TableAdapterManager();
            this.codGenListBox = new System.Windows.Forms.ListBox();
            this.codigoComboBox = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new Locad.dsLocadTableAdapters.GenerosTableAdapter();
            tituloLabel = new System.Windows.Forms.Label();
            classicoLabel = new System.Windows.Forms.Label();
            distribuidorLabel = new System.Windows.Forms.Label();
            diretorLabel = new System.Windows.Forms.Label();
            resumoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codGenLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingNavigator)).BeginInit();
            this.fitasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.BackColor = System.Drawing.Color.Transparent;
            tituloLabel.Location = new System.Drawing.Point(6, 168);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(54, 12);
            tituloLabel.TabIndex = 21;
            tituloLabel.Text = "Titulo:";
            // 
            // classicoLabel
            // 
            classicoLabel.AutoSize = true;
            classicoLabel.BackColor = System.Drawing.Color.Transparent;
            classicoLabel.Location = new System.Drawing.Point(6, 192);
            classicoLabel.Name = "classicoLabel";
            classicoLabel.Size = new System.Drawing.Size(68, 12);
            classicoLabel.TabIndex = 23;
            classicoLabel.Text = "Classico:";
            // 
            // distribuidorLabel
            // 
            distribuidorLabel.AutoSize = true;
            distribuidorLabel.BackColor = System.Drawing.Color.Transparent;
            distribuidorLabel.Location = new System.Drawing.Point(6, 216);
            distribuidorLabel.Name = "distribuidorLabel";
            distribuidorLabel.Size = new System.Drawing.Size(96, 12);
            distribuidorLabel.TabIndex = 25;
            distribuidorLabel.Text = "Distribuidor:";
            // 
            // diretorLabel
            // 
            diretorLabel.AutoSize = true;
            diretorLabel.BackColor = System.Drawing.Color.Transparent;
            diretorLabel.Location = new System.Drawing.Point(265, 36);
            diretorLabel.Name = "diretorLabel";
            diretorLabel.Size = new System.Drawing.Size(61, 12);
            diretorLabel.TabIndex = 27;
            diretorLabel.Text = "Diretor:";
            // 
            // resumoLabel
            // 
            resumoLabel.AutoSize = true;
            resumoLabel.BackColor = System.Drawing.Color.Transparent;
            resumoLabel.Location = new System.Drawing.Point(265, 60);
            resumoLabel.Name = "resumoLabel";
            resumoLabel.Size = new System.Drawing.Size(54, 12);
            resumoLabel.TabIndex = 29;
            resumoLabel.Text = "Resumo:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(265, 84);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(47, 12);
            valorLabel.TabIndex = 31;
            valorLabel.Text = "Valor:";
            // 
            // codGenLabel
            // 
            codGenLabel.AutoSize = true;
            codGenLabel.BackColor = System.Drawing.Color.Transparent;
            codGenLabel.Location = new System.Drawing.Point(17, 56);
            codGenLabel.Name = "codGenLabel";
            codGenLabel.Size = new System.Drawing.Size(61, 12);
            codGenLabel.TabIndex = 32;
            codGenLabel.Text = "Cod Gen:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(3, 35);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(54, 12);
            codigoLabel.TabIndex = 33;
            codigoLabel.Text = "Codigo:";
            // 
            // fitasBindingNavigator
            // 
            this.fitasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fitasBindingNavigator.BindingSource = this.fitasBindingSource;
            this.fitasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fitasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fitasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fitasBindingNavigatorSaveItem});
            this.fitasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fitasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fitasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fitasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fitasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fitasBindingNavigator.Name = "fitasBindingNavigator";
            this.fitasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fitasBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.fitasBindingNavigator.TabIndex = 0;
            this.fitasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // fitasBindingSource
            // 
            this.fitasBindingSource.DataMember = "Fitas";
            this.fitasBindingSource.DataSource = this.dsLocad;
            // 
            // dsLocad
            // 
            this.dsLocad.DataSetName = "dsLocad";
            this.dsLocad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fitasBindingNavigatorSaveItem
            // 
            this.fitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fitasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fitasBindingNavigatorSaveItem.Image")));
            this.fitasBindingNavigatorSaveItem.Name = "fitasBindingNavigatorSaveItem";
            this.fitasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fitasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fitasBindingNavigatorSaveItem.Click += new System.EventHandler(this.fitasBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(344, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(109, 166);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(116, 19);
            this.tituloTextBox.TabIndex = 22;
            // 
            // classicoTextBox
            // 
            this.classicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Classico", true));
            this.classicoTextBox.Location = new System.Drawing.Point(109, 190);
            this.classicoTextBox.Name = "classicoTextBox";
            this.classicoTextBox.Size = new System.Drawing.Size(116, 19);
            this.classicoTextBox.TabIndex = 24;
            // 
            // distribuidorTextBox
            // 
            this.distribuidorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Distribuidor", true));
            this.distribuidorTextBox.Location = new System.Drawing.Point(109, 214);
            this.distribuidorTextBox.Name = "distribuidorTextBox";
            this.distribuidorTextBox.Size = new System.Drawing.Size(116, 19);
            this.distribuidorTextBox.TabIndex = 26;
            // 
            // diretorTextBox
            // 
            this.diretorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Diretor", true));
            this.diretorTextBox.Location = new System.Drawing.Point(344, 33);
            this.diretorTextBox.Name = "diretorTextBox";
            this.diretorTextBox.Size = new System.Drawing.Size(116, 19);
            this.diretorTextBox.TabIndex = 28;
            // 
            // resumoTextBox
            // 
            this.resumoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Resumo", true));
            this.resumoTextBox.Location = new System.Drawing.Point(344, 57);
            this.resumoTextBox.Name = "resumoTextBox";
            this.resumoTextBox.Size = new System.Drawing.Size(116, 19);
            this.resumoTextBox.TabIndex = 30;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(344, 81);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(116, 19);
            this.valorTextBox.TabIndex = 32;
            this.valorTextBox.Text = "R$";
            // 
            // fitasTableAdapter
            // 
            this.fitasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FitasTableAdapter = this.fitasTableAdapter;
            this.tableAdapterManager.GenerosTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.LocafitasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locad.dsLocadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codGenListBox
            // 
            this.codGenListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fitasBindingSource, "CodGen", true));
            this.codGenListBox.DataSource = this.generosBindingSource;
            this.codGenListBox.DisplayMember = "Genero";
            this.codGenListBox.FormattingEnabled = true;
            this.codGenListBox.ItemHeight = 12;
            this.codGenListBox.Location = new System.Drawing.Point(109, 67);
            this.codGenListBox.Name = "codGenListBox";
            this.codGenListBox.Size = new System.Drawing.Size(116, 88);
            this.codGenListBox.TabIndex = 33;
            this.codGenListBox.ValueMember = "Codigo";
            // 
            // codigoComboBox
            // 
            this.codigoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fitasBindingSource, "Codigo", true));
            this.codigoComboBox.FormattingEnabled = true;
            this.codigoComboBox.Location = new System.Drawing.Point(85, 33);
            this.codigoComboBox.Name = "codigoComboBox";
            this.codigoComboBox.Size = new System.Drawing.Size(140, 20);
            this.codigoComboBox.TabIndex = 34;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.dsLocad;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locad.Properties.Resources.tools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 259);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoComboBox);
            this.Controls.Add(codGenLabel);
            this.Controls.Add(this.codGenListBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(classicoLabel);
            this.Controls.Add(this.classicoTextBox);
            this.Controls.Add(distribuidorLabel);
            this.Controls.Add(this.distribuidorTextBox);
            this.Controls.Add(diretorLabel);
            this.Controls.Add(this.diretorTextBox);
            this.Controls.Add(resumoLabel);
            this.Controls.Add(this.resumoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fitasBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingNavigator)).EndInit();
            this.fitasBindingNavigator.ResumeLayout(false);
            this.fitasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsLocad dsLocad;
        private System.Windows.Forms.BindingSource fitasBindingSource;
        private dsLocadTableAdapters.FitasTableAdapter fitasTableAdapter;
        private dsLocadTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fitasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fitasBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox classicoTextBox;
        private System.Windows.Forms.TextBox distribuidorTextBox;
        private System.Windows.Forms.TextBox diretorTextBox;
        private System.Windows.Forms.TextBox resumoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ListBox codGenListBox;
        private System.Windows.Forms.ComboBox codigoComboBox;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private dsLocadTableAdapters.GenerosTableAdapter generosTableAdapter;
    }
}