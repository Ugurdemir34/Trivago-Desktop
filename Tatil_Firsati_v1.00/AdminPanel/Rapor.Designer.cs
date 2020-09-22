namespace Tatil_Firsati_v1._00
{
    partial class Rapor
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
            this.OTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrivagoDataSet = new Tatil_Firsati_v1._00.TrivagoDataSet();
            this.pnlust = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OTELTableAdapter = new Tatil_Firsati_v1._00.TrivagoDataSetTableAdapters.OTELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrivagoDataSet)).BeginInit();
            this.pnlust.SuspendLayout();
            this.SuspendLayout();
            // 
            // OTELBindingSource
            // 
            this.OTELBindingSource.DataMember = "OTEL";
            this.OTELBindingSource.DataSource = this.TrivagoDataSet;
            // 
            // TrivagoDataSet
            // 
            this.TrivagoDataSet.DataSetName = "TrivagoDataSet";
            this.TrivagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlust
            // 
            this.pnlust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlust.Controls.Add(this.label6);
            this.pnlust.Controls.Add(this.button1);
            this.pnlust.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlust.Location = new System.Drawing.Point(0, 0);
            this.pnlust.Margin = new System.Windows.Forms.Padding(2);
            this.pnlust.Name = "pnlust";
            this.pnlust.Size = new System.Drawing.Size(765, 28);
            this.pnlust.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rapor";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OTELBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tatil_Firsati_v1._00.AdminPanel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 560);
            this.reportViewer1.TabIndex = 4;
            // 
            // OTELTableAdapter
            // 
            this.OTELTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 588);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrivagoDataSet)).EndInit();
            this.pnlust.ResumeLayout(false);
            this.pnlust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OTELBindingSource;
        private TrivagoDataSet TrivagoDataSet;
        private TrivagoDataSetTableAdapters.OTELTableAdapter OTELTableAdapter;
    }
}