namespace veterinaria
{
    partial class Form5
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
            System.Windows.Forms.Label codanimalLabel;
            System.Windows.Forms.Label codcliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label raçaLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label alergicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.loginDataSet = new veterinaria.loginDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new veterinaria.loginDataSetTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new veterinaria.loginDataSetTableAdapters.TableAdapterManager();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codanimalTextBox = new System.Windows.Forms.TextBox();
            this.codcliTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.raçaTextBox = new System.Windows.Forms.TextBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.alergicoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animalconsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new veterinaria.loginDataSetTableAdapters.consultaTableAdapter();
            this.animaisdadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisdadosTableAdapter = new veterinaria.loginDataSetTableAdapters.animaisdadosTableAdapter();
            this.animaisdadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            codanimalLabel = new System.Windows.Forms.Label();
            codcliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            raçaLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            alergicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalconsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codanimalLabel
            // 
            codanimalLabel.AutoSize = true;
            codanimalLabel.Location = new System.Drawing.Point(67, 95);
            codanimalLabel.Name = "codanimalLabel";
            codanimalLabel.Size = new System.Drawing.Size(58, 13);
            codanimalLabel.TabIndex = 1;
            codanimalLabel.Text = "codanimal:";
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.Location = new System.Drawing.Point(67, 121);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(38, 13);
            codcliLabel.TabIndex = 3;
            codcliLabel.Text = "codcli:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(67, 147);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "nome:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(67, 173);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 7;
            tipoLabel.Text = "tipo:";
            // 
            // raçaLabel
            // 
            raçaLabel.AutoSize = true;
            raçaLabel.Location = new System.Drawing.Point(67, 199);
            raçaLabel.Name = "raçaLabel";
            raçaLabel.Size = new System.Drawing.Size(31, 13);
            raçaLabel.TabIndex = 9;
            raçaLabel.Text = "raça:";
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(67, 225);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(36, 13);
            idadeLabel.TabIndex = 11;
            idadeLabel.Text = "idade:";
            // 
            // alergicoLabel
            // 
            alergicoLabel.AutoSize = true;
            alergicoLabel.Location = new System.Drawing.Point(67, 251);
            alergicoLabel.Name = "alergicoLabel";
            alergicoLabel.Size = new System.Drawing.Size(47, 13);
            alergicoLabel.TabIndex = 13;
            alergicoLabel.Text = "alergico:";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.loginDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animaisdadosTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veterinaria.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veterinarioTableAdapter = null;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalBindingNavigatorSaveItem});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(712, 25);
            this.animalBindingNavigator.TabIndex = 0;
            this.animalBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
            // 
            // codanimalTextBox
            // 
            this.codanimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "codanimal", true));
            this.codanimalTextBox.Location = new System.Drawing.Point(131, 92);
            this.codanimalTextBox.Name = "codanimalTextBox";
            this.codanimalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codanimalTextBox.TabIndex = 2;
            // 
            // codcliTextBox
            // 
            this.codcliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "codcli", true));
            this.codcliTextBox.Location = new System.Drawing.Point(131, 118);
            this.codcliTextBox.Name = "codcliTextBox";
            this.codcliTextBox.Size = new System.Drawing.Size(100, 20);
            this.codcliTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(131, 144);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 6;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(131, 170);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 8;
            // 
            // raçaTextBox
            // 
            this.raçaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "raça", true));
            this.raçaTextBox.Location = new System.Drawing.Point(131, 196);
            this.raçaTextBox.Name = "raçaTextBox";
            this.raçaTextBox.Size = new System.Drawing.Size(100, 20);
            this.raçaTextBox.TabIndex = 10;
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "idade", true));
            this.idadeTextBox.Location = new System.Drawing.Point(131, 222);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeTextBox.TabIndex = 12;
            // 
            // alergicoTextBox
            // 
            this.alergicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "alergico", true));
            this.alergicoTextBox.Location = new System.Drawing.Point(131, 248);
            this.alergicoTextBox.Name = "alergicoTextBox";
            this.alergicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.alergicoTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animalconsultaBindingSource
            // 
            this.animalconsultaBindingSource.DataMember = "animalconsulta";
            this.animalconsultaBindingSource.DataSource = this.animalBindingSource;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // animaisdadosBindingSource
            // 
            this.animaisdadosBindingSource.DataMember = "animaisdados";
            this.animaisdadosBindingSource.DataSource = this.loginDataSet;
            // 
            // animaisdadosTableAdapter
            // 
            this.animaisdadosTableAdapter.ClearBeforeFill = true;
            // 
            // animaisdadosDataGridView
            // 
            this.animaisdadosDataGridView.AutoGenerateColumns = false;
            this.animaisdadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisdadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.animaisdadosDataGridView.DataSource = this.animaisdadosBindingSource;
            this.animaisdadosDataGridView.Location = new System.Drawing.Point(308, 63);
            this.animaisdadosDataGridView.Name = "animaisdadosDataGridView";
            this.animaisdadosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.animaisdadosDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codanimal";
            this.dataGridViewTextBoxColumn1.DataSource = this.animalBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "codanimal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "codanimal";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "altura";
            this.dataGridViewTextBoxColumn2.HeaderText = "altura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "peso";
            this.dataGridViewTextBoxColumn3.HeaderText = "peso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veterinaria.Properties.Resources.pizza_box_laptop_;
            this.ClientSize = new System.Drawing.Size(712, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.animaisdadosDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(codanimalLabel);
            this.Controls.Add(this.codanimalTextBox);
            this.Controls.Add(codcliLabel);
            this.Controls.Add(this.codcliTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(raçaLabel);
            this.Controls.Add(this.raçaTextBox);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(alergicoLabel);
            this.Controls.Add(this.alergicoTextBox);
            this.Controls.Add(this.animalBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalconsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private loginDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private loginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codanimalTextBox;
        private System.Windows.Forms.TextBox codcliTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox raçaTextBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox alergicoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource animalconsultaBindingSource;
        private loginDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private System.Windows.Forms.BindingSource animaisdadosBindingSource;
        private loginDataSetTableAdapters.animaisdadosTableAdapter animaisdadosTableAdapter;
        private System.Windows.Forms.DataGridView animaisdadosDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
    }
}