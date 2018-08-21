namespace veterinaria
{
    partial class Form6
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
            System.Windows.Forms.Label codconsLabel;
            System.Windows.Forms.Label crmvLabel;
            System.Windows.Forms.Label codanimalLabel;
            System.Windows.Forms.Label dataconsultaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.loginDataSet = new veterinaria.loginDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new veterinaria.loginDataSetTableAdapters.consultaTableAdapter();
            this.tableAdapterManager = new veterinaria.loginDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codconsTextBox = new System.Windows.Forms.TextBox();
            this.crmvTextBox = new System.Windows.Forms.TextBox();
            this.codanimalTextBox = new System.Windows.Forms.TextBox();
            this.dataconsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            codconsLabel = new System.Windows.Forms.Label();
            crmvLabel = new System.Windows.Forms.Label();
            codanimalLabel = new System.Windows.Forms.Label();
            dataconsultaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codconsLabel
            // 
            codconsLabel.AutoSize = true;
            codconsLabel.Location = new System.Drawing.Point(48, 92);
            codconsLabel.Name = "codconsLabel";
            codconsLabel.Size = new System.Drawing.Size(51, 13);
            codconsLabel.TabIndex = 1;
            codconsLabel.Text = "codcons:";
            // 
            // crmvLabel
            // 
            crmvLabel.AutoSize = true;
            crmvLabel.Location = new System.Drawing.Point(48, 118);
            crmvLabel.Name = "crmvLabel";
            crmvLabel.Size = new System.Drawing.Size(33, 13);
            crmvLabel.TabIndex = 3;
            crmvLabel.Text = "crmv:";
            // 
            // codanimalLabel
            // 
            codanimalLabel.AutoSize = true;
            codanimalLabel.Location = new System.Drawing.Point(48, 144);
            codanimalLabel.Name = "codanimalLabel";
            codanimalLabel.Size = new System.Drawing.Size(58, 13);
            codanimalLabel.TabIndex = 5;
            codanimalLabel.Text = "codanimal:";
            // 
            // dataconsultaLabel
            // 
            dataconsultaLabel.AutoSize = true;
            dataconsultaLabel.Location = new System.Drawing.Point(48, 171);
            dataconsultaLabel.Name = "dataconsultaLabel";
            dataconsultaLabel.Size = new System.Drawing.Size(71, 13);
            dataconsultaLabel.TabIndex = 7;
            dataconsultaLabel.Text = "dataconsulta:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(48, 196);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(31, 13);
            horaLabel.TabIndex = 9;
            horaLabel.Text = "hora:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(48, 222);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 11;
            valorLabel.Text = "valor:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(48, 248);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(64, 13);
            diagnosticoLabel.TabIndex = 13;
            diagnosticoLabel.Text = "diagnostico:";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "consulta";
            this.consultaBindingSource.DataSource = this.loginDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animaisdadosTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veterinaria.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veterinarioTableAdapter = null;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(603, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // codconsTextBox
            // 
            this.codconsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "codcons", true));
            this.codconsTextBox.Location = new System.Drawing.Point(125, 89);
            this.codconsTextBox.Name = "codconsTextBox";
            this.codconsTextBox.Size = new System.Drawing.Size(200, 20);
            this.codconsTextBox.TabIndex = 2;
            // 
            // crmvTextBox
            // 
            this.crmvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "crmv", true));
            this.crmvTextBox.Location = new System.Drawing.Point(125, 115);
            this.crmvTextBox.Name = "crmvTextBox";
            this.crmvTextBox.Size = new System.Drawing.Size(200, 20);
            this.crmvTextBox.TabIndex = 4;
            // 
            // codanimalTextBox
            // 
            this.codanimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "codanimal", true));
            this.codanimalTextBox.Location = new System.Drawing.Point(125, 141);
            this.codanimalTextBox.Name = "codanimalTextBox";
            this.codanimalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codanimalTextBox.TabIndex = 6;
            // 
            // dataconsultaDateTimePicker
            // 
            this.dataconsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "dataconsulta", true));
            this.dataconsultaDateTimePicker.Location = new System.Drawing.Point(125, 167);
            this.dataconsultaDateTimePicker.Name = "dataconsultaDateTimePicker";
            this.dataconsultaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataconsultaDateTimePicker.TabIndex = 8;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(125, 193);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 10;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(125, 219);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorTextBox.TabIndex = 12;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(125, 245);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosticoTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veterinaria.Properties.Resources.hqdefault;
            this.ClientSize = new System.Drawing.Size(603, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(codconsLabel);
            this.Controls.Add(this.codconsTextBox);
            this.Controls.Add(crmvLabel);
            this.Controls.Add(this.crmvTextBox);
            this.Controls.Add(codanimalLabel);
            this.Controls.Add(this.codanimalTextBox);
            this.Controls.Add(dataconsultaLabel);
            this.Controls.Add(this.dataconsultaDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(diagnosticoLabel);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private loginDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private loginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codconsTextBox;
        private System.Windows.Forms.TextBox crmvTextBox;
        private System.Windows.Forms.TextBox codanimalTextBox;
        private System.Windows.Forms.DateTimePicker dataconsultaDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.Button button1;


    }
}