namespace Locad
{
    partial class Form12
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
            this.dsLocad = new Locad.dsLocad();
            this.FitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FitasTableAdapter = new Locad.dsLocadTableAdapters.FitasTableAdapter();
            this.GenerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenerosTableAdapter = new Locad.dsLocadTableAdapters.GenerosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GenerosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Locad.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 227);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsLocad
            // 
            this.dsLocad.DataSetName = "dsLocad";
            this.dsLocad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FitasBindingSource
            // 
            this.FitasBindingSource.DataMember = "Fitas";
            this.FitasBindingSource.DataSource = this.dsLocad;
            // 
            // FitasTableAdapter
            // 
            this.FitasTableAdapter.ClearBeforeFill = true;
            // 
            // GenerosBindingSource
            // 
            this.GenerosBindingSource.DataMember = "Generos";
            this.GenerosBindingSource.DataSource = this.dsLocad;
            // 
            // GenerosTableAdapter
            // 
            this.GenerosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(573, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locad.Properties.Resources.tools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLocad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FitasBindingSource;
        private dsLocad dsLocad;
        private dsLocadTableAdapters.FitasTableAdapter FitasTableAdapter;
        private System.Windows.Forms.BindingSource GenerosBindingSource;
        private dsLocadTableAdapters.GenerosTableAdapter GenerosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}