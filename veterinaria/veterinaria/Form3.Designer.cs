namespace veterinaria
{
    partial class Form3
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
            System.Windows.Forms.Label cRMVLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.loginDataSet = new veterinaria.loginDataSet();
            this.veterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioTableAdapter = new veterinaria.loginDataSetTableAdapters.veterinarioTableAdapter();
            this.tableAdapterManager = new veterinaria.loginDataSetTableAdapters.TableAdapterManager();
            this.veterinarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cRMVTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.veterinarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            cRMVLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingNavigator)).BeginInit();
            this.veterinarioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinarioBindingSource
            // 
            this.veterinarioBindingSource.DataMember = "veterinario";
            this.veterinarioBindingSource.DataSource = this.loginDataSet;
            // 
            // veterinarioTableAdapter
            // 
            this.veterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animaisdadosTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veterinaria.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veterinarioTableAdapter = this.veterinarioTableAdapter;
            // 
            // veterinarioBindingNavigator
            // 
            this.veterinarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.veterinarioBindingNavigator.BindingSource = this.veterinarioBindingSource;
            this.veterinarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.veterinarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.veterinarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.veterinarioBindingNavigatorSaveItem});
            this.veterinarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.veterinarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.veterinarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.veterinarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.veterinarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.veterinarioBindingNavigator.Name = "veterinarioBindingNavigator";
            this.veterinarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.veterinarioBindingNavigator.Size = new System.Drawing.Size(659, 25);
            this.veterinarioBindingNavigator.TabIndex = 0;
            this.veterinarioBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cRMVLabel
            // 
            cRMVLabel.AutoSize = true;
            cRMVLabel.Location = new System.Drawing.Point(39, 76);
            cRMVLabel.Name = "cRMVLabel";
            cRMVLabel.Size = new System.Drawing.Size(41, 13);
            cRMVLabel.TabIndex = 1;
            cRMVLabel.Text = "CRMV:";
            // 
            // cRMVTextBox
            // 
            this.cRMVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veterinarioBindingSource, "CRMV", true));
            this.cRMVTextBox.Location = new System.Drawing.Point(100, 73);
            this.cRMVTextBox.Name = "cRMVTextBox";
            this.cRMVTextBox.Size = new System.Drawing.Size(100, 20);
            this.cRMVTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(39, 102);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veterinarioBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(100, 99);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(39, 128);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veterinarioBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(100, 125);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(39, 154);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 7;
            telefoneLabel.Text = "telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veterinarioBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(100, 151);
            this.telefoneMaskedTextBox.Mask = "(99) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 8;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(39, 180);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 9;
            celularLabel.Text = "celular:";
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veterinarioBindingSource, "celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(100, 177);
            this.celularMaskedTextBox.Mask = "(99) 00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.celularMaskedTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // veterinarioBindingNavigatorSaveItem
            // 
            this.veterinarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.veterinarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("veterinarioBindingNavigatorSaveItem.Image")));
            this.veterinarioBindingNavigatorSaveItem.Name = "veterinarioBindingNavigatorSaveItem";
            this.veterinarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.veterinarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.veterinarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.veterinarioBindingNavigatorSaveItem_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veterinaria.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(659, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(cRMVLabel);
            this.Controls.Add(this.cRMVTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(this.veterinarioBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingNavigator)).EndInit();
            this.veterinarioBindingNavigator.ResumeLayout(false);
            this.veterinarioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource veterinarioBindingSource;
        private loginDataSetTableAdapters.veterinarioTableAdapter veterinarioTableAdapter;
        private loginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator veterinarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton veterinarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cRMVTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.Button button1;

    }
}