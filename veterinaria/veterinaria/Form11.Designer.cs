namespace veterinaria
{
    partial class Form11
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loginDataSet = new veterinaria.loginDataSet();
            this.veterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioTableAdapter = new veterinaria.loginDataSetTableAdapters.veterinarioTableAdapter();
            this.animaisdadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisdadosTableAdapter = new veterinaria.loginDataSetTableAdapters.animaisdadosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.animaisdadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "veterinaria.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 247);
            this.reportViewer1.TabIndex = 0;
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
            // animaisdadosBindingSource
            // 
            this.animaisdadosBindingSource.DataMember = "animaisdados";
            this.animaisdadosBindingSource.DataSource = this.loginDataSet;
            // 
            // animaisdadosTableAdapter
            // 
            this.animaisdadosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisdadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource veterinarioBindingSource;
        private loginDataSet loginDataSet;
        private loginDataSetTableAdapters.veterinarioTableAdapter veterinarioTableAdapter;
        private System.Windows.Forms.BindingSource animaisdadosBindingSource;
        private loginDataSetTableAdapters.animaisdadosTableAdapter animaisdadosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}