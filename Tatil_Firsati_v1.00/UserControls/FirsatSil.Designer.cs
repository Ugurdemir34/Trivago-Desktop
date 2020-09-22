namespace Tatil_Firsati_v1._00
{
    partial class FirsatSil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firsatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eskiFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acikAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yildizSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsil = new System.Windows.Forms.DataGridViewImageColumn();
            this.firsatBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trivagoDataSet = new Tatil_Firsati_v1._00.TrivagoDataSet();
            this.firsatBilgileriTableAdapter = new Tatil_Firsati_v1._00.TrivagoDataSetTableAdapters.FirsatBilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firsatBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivagoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firsatIDDataGridViewTextBoxColumn,
            this.otelAdDataGridViewTextBoxColumn,
            this.eskiFiyatDataGridViewTextBoxColumn,
            this.yeniFiyatDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.webSiteDataGridViewTextBoxColumn,
            this.acikAdresDataGridViewTextBoxColumn,
            this.yildizSayisiDataGridViewTextBoxColumn,
            this.btnsil});
            this.dataGridView1.DataSource = this.firsatBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 635);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firsatIDDataGridViewTextBoxColumn
            // 
            this.firsatIDDataGridViewTextBoxColumn.DataPropertyName = "Firsat_ID";
            this.firsatIDDataGridViewTextBoxColumn.HeaderText = "Fırsat ID";
            this.firsatIDDataGridViewTextBoxColumn.Name = "firsatIDDataGridViewTextBoxColumn";
            // 
            // otelAdDataGridViewTextBoxColumn
            // 
            this.otelAdDataGridViewTextBoxColumn.DataPropertyName = "Otel_Ad";
            this.otelAdDataGridViewTextBoxColumn.HeaderText = "Otel Ad";
            this.otelAdDataGridViewTextBoxColumn.Name = "otelAdDataGridViewTextBoxColumn";
            // 
            // eskiFiyatDataGridViewTextBoxColumn
            // 
            this.eskiFiyatDataGridViewTextBoxColumn.DataPropertyName = "Eski_Fiyat";
            this.eskiFiyatDataGridViewTextBoxColumn.HeaderText = "Eski Fiyat";
            this.eskiFiyatDataGridViewTextBoxColumn.Name = "eskiFiyatDataGridViewTextBoxColumn";
            // 
            // yeniFiyatDataGridViewTextBoxColumn
            // 
            this.yeniFiyatDataGridViewTextBoxColumn.DataPropertyName = "Yeni_Fiyat";
            this.yeniFiyatDataGridViewTextBoxColumn.HeaderText = "Yeni Fiyat";
            this.yeniFiyatDataGridViewTextBoxColumn.Name = "yeniFiyatDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // webSiteDataGridViewTextBoxColumn
            // 
            this.webSiteDataGridViewTextBoxColumn.DataPropertyName = "Web_Site";
            this.webSiteDataGridViewTextBoxColumn.HeaderText = "Web Adres";
            this.webSiteDataGridViewTextBoxColumn.Name = "webSiteDataGridViewTextBoxColumn";
            // 
            // acikAdresDataGridViewTextBoxColumn
            // 
            this.acikAdresDataGridViewTextBoxColumn.DataPropertyName = "Acik_Adres";
            this.acikAdresDataGridViewTextBoxColumn.HeaderText = "Açık Adres";
            this.acikAdresDataGridViewTextBoxColumn.Name = "acikAdresDataGridViewTextBoxColumn";
            // 
            // yildizSayisiDataGridViewTextBoxColumn
            // 
            this.yildizSayisiDataGridViewTextBoxColumn.DataPropertyName = "Yildiz_Sayisi";
            this.yildizSayisiDataGridViewTextBoxColumn.HeaderText = "Yıldız Sayısı";
            this.yildizSayisiDataGridViewTextBoxColumn.Name = "yildizSayisiDataGridViewTextBoxColumn";
            // 
            // btnsil
            // 
            this.btnsil.HeaderText = "";
            this.btnsil.Image = global::Tatil_Firsati_v1._00.Properties.Resources.Delete_Icon;
            this.btnsil.Name = "btnsil";
            this.btnsil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnsil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // firsatBilgileriBindingSource
            // 
            this.firsatBilgileriBindingSource.DataMember = "FirsatBilgileri";
            this.firsatBilgileriBindingSource.DataSource = this.trivagoDataSet;
            // 
            // trivagoDataSet
            // 
            this.trivagoDataSet.DataSetName = "TrivagoDataSet";
            this.trivagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firsatBilgileriTableAdapter
            // 
            this.firsatBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // FirsatSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Name = "FirsatSil";
            this.Size = new System.Drawing.Size(831, 677);
            this.Load += new System.EventHandler(this.FirsatSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firsatBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivagoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firsatBilgileriBindingSource;
        private TrivagoDataSet trivagoDataSet;
        private TrivagoDataSetTableAdapters.FirsatBilgileriTableAdapter firsatBilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firsatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eskiFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeniFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acikAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yildizSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn btnsil;
    }
}
