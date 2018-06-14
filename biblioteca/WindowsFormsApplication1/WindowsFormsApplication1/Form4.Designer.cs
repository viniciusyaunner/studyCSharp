namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label controleLabel;
            System.Windows.Forms.Label codusLabel;
            System.Windows.Forms.Label dataemprestLabel;
            this.bibliotecaDataSet = new WindowsFormsApplication1.bibliotecaDataSet();
            this.emprestimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimoTableAdapter = new WindowsFormsApplication1.bibliotecaDataSetTableAdapters.EmprestimoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.emprestimoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.emprestimoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.controleTextBox = new System.Windows.Forms.TextBox();
            this.codusListBox = new System.Windows.Forms.ListBox();
            this.dataemprestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empreliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empreliTableAdapter = new WindowsFormsApplication1.bibliotecaDataSetTableAdapters.empreliTableAdapter();
            this.empreliDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication1.bibliotecaDataSetTableAdapters.UsuarioTableAdapter();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new WindowsFormsApplication1.bibliotecaDataSetTableAdapters.LivrosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            controleLabel = new System.Windows.Forms.Label();
            codusLabel = new System.Windows.Forms.Label();
            dataemprestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoBindingNavigator)).BeginInit();
            this.emprestimoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empreliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empreliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimoBindingSource
            // 
            this.emprestimoBindingSource.DataMember = "Emprestimo";
            this.emprestimoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // emprestimoTableAdapter
            // 
            this.emprestimoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.devolverliTableAdapter = null;
            this.tableAdapterManager.empreliTableAdapter = this.empreliTableAdapter;
            this.tableAdapterManager.EmprestimoTableAdapter = this.emprestimoTableAdapter;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // emprestimoBindingNavigator
            // 
            this.emprestimoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emprestimoBindingNavigator.BindingSource = this.emprestimoBindingSource;
            this.emprestimoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emprestimoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emprestimoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.emprestimoBindingNavigatorSaveItem});
            this.emprestimoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emprestimoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emprestimoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emprestimoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emprestimoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emprestimoBindingNavigator.Name = "emprestimoBindingNavigator";
            this.emprestimoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emprestimoBindingNavigator.Size = new System.Drawing.Size(608, 25);
            this.emprestimoBindingNavigator.TabIndex = 0;
            this.emprestimoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // emprestimoBindingNavigatorSaveItem
            // 
            this.emprestimoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emprestimoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emprestimoBindingNavigatorSaveItem.Image")));
            this.emprestimoBindingNavigatorSaveItem.Name = "emprestimoBindingNavigatorSaveItem";
            this.emprestimoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.emprestimoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.emprestimoBindingNavigatorSaveItem.Click += new System.EventHandler(this.emprestimoBindingNavigatorSaveItem_Click);
            // 
            // controleLabel
            // 
            controleLabel.AutoSize = true;
            controleLabel.Location = new System.Drawing.Point(10, 44);
            controleLabel.Name = "controleLabel";
            controleLabel.Size = new System.Drawing.Size(48, 13);
            controleLabel.TabIndex = 1;
            controleLabel.Text = "controle:";
            // 
            // controleTextBox
            // 
            this.controleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoBindingSource, "controle", true));
            this.controleTextBox.Location = new System.Drawing.Point(84, 41);
            this.controleTextBox.Name = "controleTextBox";
            this.controleTextBox.Size = new System.Drawing.Size(121, 20);
            this.controleTextBox.TabIndex = 2;
            // 
            // codusLabel
            // 
            codusLabel.AutoSize = true;
            codusLabel.Location = new System.Drawing.Point(10, 67);
            codusLabel.Name = "codusLabel";
            codusLabel.Size = new System.Drawing.Size(39, 13);
            codusLabel.TabIndex = 3;
            codusLabel.Text = "codus:";
            // 
            // codusListBox
            // 
            this.codusListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emprestimoBindingSource, "codus", true));
            this.codusListBox.DataSource = this.usuarioBindingSource;
            this.codusListBox.DisplayMember = "codigo";
            this.codusListBox.FormattingEnabled = true;
            this.codusListBox.Location = new System.Drawing.Point(84, 67);
            this.codusListBox.Name = "codusListBox";
            this.codusListBox.Size = new System.Drawing.Size(121, 82);
            this.codusListBox.TabIndex = 4;
            this.codusListBox.ValueMember = "nome";
            // 
            // dataemprestLabel
            // 
            dataemprestLabel.AutoSize = true;
            dataemprestLabel.Location = new System.Drawing.Point(314, 40);
            dataemprestLabel.Name = "dataemprestLabel";
            dataemprestLabel.Size = new System.Drawing.Size(68, 13);
            dataemprestLabel.TabIndex = 5;
            dataemprestLabel.Text = "dataemprest:";
            // 
            // dataemprestDateTimePicker
            // 
            this.dataemprestDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emprestimoBindingSource, "dataemprest", true));
            this.dataemprestDateTimePicker.Location = new System.Drawing.Point(388, 36);
            this.dataemprestDateTimePicker.Name = "dataemprestDateTimePicker";
            this.dataemprestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataemprestDateTimePicker.TabIndex = 6;
            // 
            // empreliBindingSource
            // 
            this.empreliBindingSource.DataMember = "Emprestimoempreli";
            this.empreliBindingSource.DataSource = this.emprestimoBindingSource;
            // 
            // empreliTableAdapter
            // 
            this.empreliTableAdapter.ClearBeforeFill = true;
            // 
            // empreliDataGridView
            // 
            this.empreliDataGridView.AutoGenerateColumns = false;
            this.empreliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empreliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.empreliDataGridView.DataSource = this.empreliBindingSource;
            this.empreliDataGridView.Location = new System.Drawing.Point(22, 170);
            this.empreliDataGridView.Name = "empreliDataGridView";
            this.empreliDataGridView.Size = new System.Drawing.Size(338, 113);
            this.empreliDataGridView.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "controle";
            this.dataGridViewTextBoxColumn1.HeaderText = "controle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codli";
            this.dataGridViewTextBoxColumn2.DataSource = this.livrosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "codli";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "codlivro";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datadev";
            this.dataGridViewTextBoxColumn3.HeaderText = "datadev";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empreliDataGridView);
            this.Controls.Add(controleLabel);
            this.Controls.Add(this.controleTextBox);
            this.Controls.Add(codusLabel);
            this.Controls.Add(this.codusListBox);
            this.Controls.Add(dataemprestLabel);
            this.Controls.Add(this.dataemprestDateTimePicker);
            this.Controls.Add(this.emprestimoBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoBindingNavigator)).EndInit();
            this.emprestimoBindingNavigator.ResumeLayout(false);
            this.emprestimoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empreliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empreliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource emprestimoBindingSource;
        private bibliotecaDataSetTableAdapters.EmprestimoTableAdapter emprestimoTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emprestimoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton emprestimoBindingNavigatorSaveItem;
        private bibliotecaDataSetTableAdapters.empreliTableAdapter empreliTableAdapter;
        private System.Windows.Forms.TextBox controleTextBox;
        private System.Windows.Forms.ListBox codusListBox;
        private System.Windows.Forms.DateTimePicker dataemprestDateTimePicker;
        private System.Windows.Forms.BindingSource empreliBindingSource;
        private bibliotecaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridView empreliDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private bibliotecaDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}