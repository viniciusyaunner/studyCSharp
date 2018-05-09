namespace Locad
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
            System.Windows.Forms.Label controleLabel;
            System.Windows.Forms.Label datalocaLabel;
            System.Windows.Forms.Label datadevLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label emprestimoLabel;
            System.Windows.Forms.Label devolucaoLabel;
            System.Windows.Forms.Label codcliLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dsLocad = new Locad.dsLocad();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableAdapter = new Locad.dsLocadTableAdapters.LocacaoTableAdapter();
            this.tableAdapterManager = new Locad.dsLocadTableAdapters.TableAdapterManager();
            this.locafitasTableAdapter = new Locad.dsLocadTableAdapters.LocafitasTableAdapter();
            this.locacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.locacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.controleTextBox = new System.Windows.Forms.TextBox();
            this.datalocaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datadevDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.emprestimoCheckBox = new System.Windows.Forms.CheckBox();
            this.devolucaoCheckBox = new System.Windows.Forms.CheckBox();
            this.locafitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoLocafitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.codcliListBox = new System.Windows.Forms.ListBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientesTableAdapter = new Locad.dsLocadTableAdapters.ClientesTableAdapter();
            this.locafitasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fitasTableAdapter = new Locad.dsLocadTableAdapters.FitasTableAdapter();
            controleLabel = new System.Windows.Forms.Label();
            datalocaLabel = new System.Windows.Forms.Label();
            datadevLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            emprestimoLabel = new System.Windows.Forms.Label();
            devolucaoLabel = new System.Windows.Forms.Label();
            codcliLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).BeginInit();
            this.locacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locafitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoLocafitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locafitasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controleLabel
            // 
            controleLabel.AutoSize = true;
            controleLabel.BackColor = System.Drawing.Color.Transparent;
            controleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            controleLabel.Location = new System.Drawing.Point(41, 39);
            controleLabel.Name = "controleLabel";
            controleLabel.Size = new System.Drawing.Size(68, 12);
            controleLabel.TabIndex = 1;
            controleLabel.Text = "controle:";
            // 
            // datalocaLabel
            // 
            datalocaLabel.AutoSize = true;
            datalocaLabel.BackColor = System.Drawing.Color.Transparent;
            datalocaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            datalocaLabel.Location = new System.Drawing.Point(41, 88);
            datalocaLabel.Name = "datalocaLabel";
            datalocaLabel.Size = new System.Drawing.Size(68, 12);
            datalocaLabel.TabIndex = 5;
            datalocaLabel.Text = "dataloca:";
            // 
            // datadevLabel
            // 
            datadevLabel.AutoSize = true;
            datadevLabel.BackColor = System.Drawing.Color.Transparent;
            datadevLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            datadevLabel.Location = new System.Drawing.Point(454, 36);
            datadevLabel.Name = "datadevLabel";
            datadevLabel.Size = new System.Drawing.Size(61, 12);
            datadevLabel.TabIndex = 7;
            datadevLabel.Text = "datadev:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = System.Drawing.Color.Transparent;
            totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            totalLabel.Location = new System.Drawing.Point(454, 59);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(47, 12);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "total:";
            // 
            // emprestimoLabel
            // 
            emprestimoLabel.AutoSize = true;
            emprestimoLabel.BackColor = System.Drawing.Color.Transparent;
            emprestimoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            emprestimoLabel.Location = new System.Drawing.Point(454, 85);
            emprestimoLabel.Name = "emprestimoLabel";
            emprestimoLabel.Size = new System.Drawing.Size(82, 12);
            emprestimoLabel.TabIndex = 11;
            emprestimoLabel.Text = "emprestimo:";
            // 
            // devolucaoLabel
            // 
            devolucaoLabel.AutoSize = true;
            devolucaoLabel.BackColor = System.Drawing.Color.Transparent;
            devolucaoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            devolucaoLabel.Location = new System.Drawing.Point(454, 113);
            devolucaoLabel.Name = "devolucaoLabel";
            devolucaoLabel.Size = new System.Drawing.Size(75, 12);
            devolucaoLabel.TabIndex = 13;
            devolucaoLabel.Text = "devolucao:";
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.BackColor = System.Drawing.Color.Transparent;
            codcliLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            codcliLabel.Location = new System.Drawing.Point(746, 162);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(54, 12);
            codcliLabel.TabIndex = 16;
            codcliLabel.Text = "codcli:";
            // 
            // dsLocad
            // 
            this.dsLocad.DataSetName = "dsLocad";
            this.dsLocad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.dsLocad;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FitasTableAdapter = null;
            this.tableAdapterManager.GenerosTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.LocafitasTableAdapter = this.locafitasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Locad.dsLocadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locafitasTableAdapter
            // 
            this.locafitasTableAdapter.ClearBeforeFill = true;
            // 
            // locacaoBindingNavigator
            // 
            this.locacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoBindingNavigator.BindingSource = this.locacaoBindingSource;
            this.locacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locacaoBindingNavigatorSaveItem});
            this.locacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoBindingNavigator.Name = "locacaoBindingNavigator";
            this.locacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoBindingNavigator.Size = new System.Drawing.Size(987, 25);
            this.locacaoBindingNavigator.TabIndex = 0;
            this.locacaoBindingNavigator.Text = "bindingNavigator1";
            this.locacaoBindingNavigator.RefreshItems += new System.EventHandler(this.locacaoBindingNavigator_RefreshItems);
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
            // locacaoBindingNavigatorSaveItem
            // 
            this.locacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoBindingNavigatorSaveItem.Image")));
            this.locacaoBindingNavigatorSaveItem.Name = "locacaoBindingNavigatorSaveItem";
            this.locacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // controleTextBox
            // 
            this.controleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "controle", true));
            this.controleTextBox.Location = new System.Drawing.Point(121, 36);
            this.controleTextBox.Name = "controleTextBox";
            this.controleTextBox.Size = new System.Drawing.Size(233, 19);
            this.controleTextBox.TabIndex = 2;
            // 
            // datalocaDateTimePicker
            // 
            this.datalocaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "dataloca", true));
            this.datalocaDateTimePicker.Location = new System.Drawing.Point(121, 84);
            this.datalocaDateTimePicker.Name = "datalocaDateTimePicker";
            this.datalocaDateTimePicker.Size = new System.Drawing.Size(233, 19);
            this.datalocaDateTimePicker.TabIndex = 6;
            // 
            // datadevDateTimePicker
            // 
            this.datadevDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "datadev", true));
            this.datadevDateTimePicker.Location = new System.Drawing.Point(567, 35);
            this.datadevDateTimePicker.Name = "datadevDateTimePicker";
            this.datadevDateTimePicker.Size = new System.Drawing.Size(233, 19);
            this.datadevDateTimePicker.TabIndex = 8;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(567, 59);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(233, 19);
            this.totalTextBox.TabIndex = 10;
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // emprestimoCheckBox
            // 
            this.emprestimoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.emprestimoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.locacaoBindingSource, "emprestimo", true));
            this.emprestimoCheckBox.Location = new System.Drawing.Point(567, 83);
            this.emprestimoCheckBox.Name = "emprestimoCheckBox";
            this.emprestimoCheckBox.Size = new System.Drawing.Size(233, 22);
            this.emprestimoCheckBox.TabIndex = 12;
            this.emprestimoCheckBox.Text = "checkBox1";
            this.emprestimoCheckBox.UseVisualStyleBackColor = false;
            // 
            // devolucaoCheckBox
            // 
            this.devolucaoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.devolucaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.locacaoBindingSource, "devolucao", true));
            this.devolucaoCheckBox.Location = new System.Drawing.Point(567, 111);
            this.devolucaoCheckBox.Name = "devolucaoCheckBox";
            this.devolucaoCheckBox.Size = new System.Drawing.Size(233, 22);
            this.devolucaoCheckBox.TabIndex = 14;
            this.devolucaoCheckBox.Text = "checkBox1";
            this.devolucaoCheckBox.UseVisualStyleBackColor = false;
            // 
            // locafitasBindingSource
            // 
            this.locafitasBindingSource.DataMember = "Locafitas";
            this.locafitasBindingSource.DataSource = this.dsLocad;
            // 
            // locacaoLocafitasBindingSource
            // 
            this.locacaoLocafitasBindingSource.DataMember = "LocacaoLocafitas";
            this.locacaoLocafitasBindingSource.DataSource = this.locacaoBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codcliListBox
            // 
            this.codcliListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoBindingSource, "codcli", true));
            this.codcliListBox.DataSource = this.clientesBindingSource;
            this.codcliListBox.DisplayMember = "Nome";
            this.codcliListBox.FormattingEnabled = true;
            this.codcliListBox.ItemHeight = 12;
            this.codcliListBox.Location = new System.Drawing.Point(806, 162);
            this.codcliListBox.Name = "codcliListBox";
            this.codcliListBox.Size = new System.Drawing.Size(139, 88);
            this.codcliListBox.TabIndex = 17;
            this.codcliListBox.ValueMember = "Codigo";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsLocad;
            // 
            // dsLocadBindingSource
            // 
            this.dsLocadBindingSource.DataSource = this.dsLocad;
            this.dsLocadBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "controle";
            this.dataGridViewTextBoxColumn1.HeaderText = "controle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn2.HeaderText = "codcli";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataloca";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataloca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datadev";
            this.dataGridViewTextBoxColumn4.HeaderText = "datadev";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "emprestimo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "emprestimo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "devolucao";
            this.dataGridViewCheckBoxColumn2.HeaderText = "devolucao";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // locafitasDataGridView
            // 
            this.locafitasDataGridView.AutoGenerateColumns = false;
            this.locafitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locafitasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.valortotal});
            this.locafitasDataGridView.DataSource = this.locacaoLocafitasBindingSource;
            this.locafitasDataGridView.Location = new System.Drawing.Point(52, 162);
            this.locafitasDataGridView.Name = "locafitasDataGridView";
            this.locafitasDataGridView.Size = new System.Drawing.Size(644, 203);
            this.locafitasDataGridView.TabIndex = 17;
            this.locafitasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locafitasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "controle";
            this.dataGridViewTextBoxColumn6.HeaderText = "controle";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codfita";
            this.dataGridViewTextBoxColumn7.DataSource = this.fitasBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Titulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "codfita";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Codigo";
            // 
            // fitasBindingSource
            // 
            this.fitasBindingSource.DataMember = "Fitas";
            this.fitasBindingSource.DataSource = this.dsLocad;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn9.HeaderText = "valor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn10.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // valortotal
            // 
            this.valortotal.DataPropertyName = "valortotal";
            this.valortotal.HeaderText = "valortotal";
            this.valortotal.Name = "valortotal";
            // 
            // fitasTableAdapter
            // 
            this.fitasTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locad.Properties.Resources.tools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 431);
            this.Controls.Add(this.locafitasDataGridView);
            this.Controls.Add(codcliLabel);
            this.Controls.Add(this.codcliListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(controleLabel);
            this.Controls.Add(this.controleTextBox);
            this.Controls.Add(datalocaLabel);
            this.Controls.Add(this.datalocaDateTimePicker);
            this.Controls.Add(datadevLabel);
            this.Controls.Add(this.datadevDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(emprestimoLabel);
            this.Controls.Add(this.emprestimoCheckBox);
            this.Controls.Add(devolucaoLabel);
            this.Controls.Add(this.devolucaoCheckBox);
            this.Controls.Add(this.locacaoBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).EndInit();
            this.locacaoBindingNavigator.ResumeLayout(false);
            this.locacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locafitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoLocafitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locafitasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsLocad dsLocad;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private dsLocadTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private dsLocadTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox controleTextBox;
        private System.Windows.Forms.DateTimePicker datalocaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datadevDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.CheckBox emprestimoCheckBox;
        private System.Windows.Forms.CheckBox devolucaoCheckBox;
        private dsLocadTableAdapters.LocafitasTableAdapter locafitasTableAdapter;
        private System.Windows.Forms.BindingSource locafitasBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource locacaoLocafitasBindingSource;
        private System.Windows.Forms.ListBox codcliListBox;
        private System.Windows.Forms.BindingSource dsLocadBindingSource;
        private System.Windows.Forms.DataGridView locacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dsLocadTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView locafitasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource fitasBindingSource;
        private dsLocadTableAdapters.FitasTableAdapter fitasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
    }
}