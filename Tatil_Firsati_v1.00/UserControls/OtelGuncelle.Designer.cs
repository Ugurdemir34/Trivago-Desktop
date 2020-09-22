namespace Tatil_Firsati_v1._00
{
    partial class OtelGuncelle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trivagoDataSet = new Tatil_Firsati_v1._00.TrivagoDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.msY = new System.Windows.Forms.MaskedTextBox();
            this.msX = new System.Windows.Forms.MaskedTextBox();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.cbkahvalti = new System.Windows.Forms.ComboBox();
            this.cbhavuz = new System.Windows.Forms.ComboBox();
            this.cbwifi = new System.Windows.Forms.ComboBox();
            this.cbmerkez = new System.Windows.Forms.ComboBox();
            this.txtyildiz = new System.Windows.Forms.TextBox();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtoteladi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oTELTableAdapter = new Tatil_Firsati_v1._00.TrivagoDataSetTableAdapters.OTELTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oda = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aciklamaGetirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCIKLAMATableAdapter = new Tatil_Firsati_v1._00.TrivagoDataSetTableAdapters.ACIKLAMATableAdapter();
            this.aciklamaGetirTableAdapter = new Tatil_Firsati_v1._00.TrivagoDataSetTableAdapters.AciklamaGetirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivagoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaGetirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir seç :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 75;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel(Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(74, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // oTELBindingSource
            // 
            this.oTELBindingSource.DataMember = "OTEL";
            this.oTELBindingSource.DataSource = this.trivagoDataSet;
            // 
            // trivagoDataSet
            // 
            this.trivagoDataSet.DataSetName = "TrivagoDataSet";
            this.trivagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnresimekle);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.msY);
            this.groupBox1.Controls.Add(this.msX);
            this.groupBox1.Controls.Add(this.rchadres);
            this.groupBox1.Controls.Add(this.txtfiyat);
            this.groupBox1.Controls.Add(this.cbkahvalti);
            this.groupBox1.Controls.Add(this.cbhavuz);
            this.groupBox1.Controls.Add(this.cbwifi);
            this.groupBox1.Controls.Add(this.cbmerkez);
            this.groupBox1.Controls.Add(this.txtyildiz);
            this.groupBox1.Controls.Add(this.txtsite);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtoteladi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(799, 448);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnresimekle
            // 
            this.btnresimekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresimekle.FlatAppearance.BorderSize = 0;
            this.btnresimekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresimekle.Image = global::Tatil_Firsati_v1._00.Properties.Resources.add_image1600;
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimekle.Location = new System.Drawing.Point(687, 256);
            this.btnresimekle.Margin = new System.Windows.Forms.Padding(2);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(101, 41);
            this.btnresimekle.TabIndex = 6;
            this.btnresimekle.Text = "Resim Ekle";
            this.btnresimekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresimekle.UseVisualStyleBackColor = true;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(436, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 215);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.FlatAppearance.BorderSize = 0;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Lime;
            this.btnguncelle.Image = global::Tatil_Firsati_v1._00.Properties.Resources.tik;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Location = new System.Drawing.Point(698, 407);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(96, 36);
            this.btnguncelle.TabIndex = 4;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // msY
            // 
            this.msY.Location = new System.Drawing.Point(291, 231);
            this.msY.Margin = new System.Windows.Forms.Padding(2);
            this.msY.Mask = "00,000000";
            this.msY.Name = "msY";
            this.msY.Size = new System.Drawing.Size(101, 20);
            this.msY.TabIndex = 3;
            // 
            // msX
            // 
            this.msX.Location = new System.Drawing.Point(291, 196);
            this.msX.Margin = new System.Windows.Forms.Padding(2);
            this.msX.Mask = "00,000000";
            this.msX.Name = "msX";
            this.msX.Size = new System.Drawing.Size(101, 20);
            this.msX.TabIndex = 3;
            // 
            // rchadres
            // 
            this.rchadres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchadres.Location = new System.Drawing.Point(81, 284);
            this.rchadres.Margin = new System.Windows.Forms.Padding(2);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(311, 136);
            this.rchadres.TabIndex = 2;
            this.rchadres.Text = "";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(81, 192);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(97, 20);
            this.txtfiyat.TabIndex = 1;
            this.txtfiyat.Text = " ";
            // 
            // cbkahvalti
            // 
            this.cbkahvalti.FormattingEnabled = true;
            this.cbkahvalti.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbkahvalti.Location = new System.Drawing.Point(291, 158);
            this.cbkahvalti.Margin = new System.Windows.Forms.Padding(2);
            this.cbkahvalti.Name = "cbkahvalti";
            this.cbkahvalti.Size = new System.Drawing.Size(101, 21);
            this.cbkahvalti.TabIndex = 1;
            // 
            // cbhavuz
            // 
            this.cbhavuz.FormattingEnabled = true;
            this.cbhavuz.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbhavuz.Location = new System.Drawing.Point(291, 117);
            this.cbhavuz.Margin = new System.Windows.Forms.Padding(2);
            this.cbhavuz.Name = "cbhavuz";
            this.cbhavuz.Size = new System.Drawing.Size(101, 21);
            this.cbhavuz.TabIndex = 1;
            // 
            // cbwifi
            // 
            this.cbwifi.FormattingEnabled = true;
            this.cbwifi.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbwifi.Location = new System.Drawing.Point(291, 75);
            this.cbwifi.Margin = new System.Windows.Forms.Padding(2);
            this.cbwifi.Name = "cbwifi";
            this.cbwifi.Size = new System.Drawing.Size(101, 21);
            this.cbwifi.TabIndex = 1;
            // 
            // cbmerkez
            // 
            this.cbmerkez.FormattingEnabled = true;
            this.cbmerkez.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbmerkez.Location = new System.Drawing.Point(291, 34);
            this.cbmerkez.Margin = new System.Windows.Forms.Padding(2);
            this.cbmerkez.Name = "cbmerkez";
            this.cbmerkez.Size = new System.Drawing.Size(101, 21);
            this.cbmerkez.TabIndex = 1;
            // 
            // txtyildiz
            // 
            this.txtyildiz.Location = new System.Drawing.Point(81, 156);
            this.txtyildiz.Margin = new System.Windows.Forms.Padding(2);
            this.txtyildiz.Name = "txtyildiz";
            this.txtyildiz.Size = new System.Drawing.Size(97, 20);
            this.txtyildiz.TabIndex = 1;
            this.txtyildiz.Text = " ";
            // 
            // txtsite
            // 
            this.txtsite.Location = new System.Drawing.Point(81, 117);
            this.txtsite.Margin = new System.Windows.Forms.Padding(2);
            this.txtsite.Name = "txtsite";
            this.txtsite.Size = new System.Drawing.Size(97, 20);
            this.txtsite.TabIndex = 1;
            this.txtsite.Text = " ";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(81, 75);
            this.txttel.Margin = new System.Windows.Forms.Padding(2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(97, 20);
            this.txttel.TabIndex = 1;
            this.txttel.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kahvaltı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Havuz :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "WiFi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Koordinat Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Koordinat X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Merkez : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiyat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yıldız Sayısı :";
            // 
            // txtoteladi
            // 
            this.txtoteladi.Enabled = false;
            this.txtoteladi.Location = new System.Drawing.Point(81, 34);
            this.txtoteladi.Margin = new System.Windows.Forms.Padding(2);
            this.txtoteladi.Name = "txtoteladi";
            this.txtoteladi.Size = new System.Drawing.Size(97, 20);
            this.txtoteladi.TabIndex = 1;
            this.txtoteladi.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Web Site :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Otel Adı :";
            // 
            // oTELTableAdapter
            // 
            this.oTELTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otelAdDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.Aciklama,
            this.oda});
            this.dataGridView1.DataSource = this.aciklamaGetirBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 137);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // otelAdDataGridViewTextBoxColumn
            // 
            this.otelAdDataGridViewTextBoxColumn.DataPropertyName = "Otel_Ad";
            this.otelAdDataGridViewTextBoxColumn.HeaderText = "Otel Adı";
            this.otelAdDataGridViewTextBoxColumn.Name = "otelAdDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // Aciklama
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Aciklama.DefaultCellStyle = dataGridViewCellStyle1;
            this.Aciklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Text = "Açıklama Ekle";
            this.Aciklama.UseColumnTextForButtonValue = true;
            // 
            // oda
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.oda.DefaultCellStyle = dataGridViewCellStyle2;
            this.oda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda.HeaderText = "Oda";
            this.oda.Name = "oda";
            this.oda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oda.Text = "Oda Ekle";
            this.oda.UseColumnTextForButtonValue = true;
            // 
            // aciklamaGetirBindingSource
            // 
            this.aciklamaGetirBindingSource.DataMember = "AciklamaGetir";
            this.aciklamaGetirBindingSource.DataSource = this.trivagoDataSet;
            // 
            // aCIKLAMATableAdapter
            // 
            this.aCIKLAMATableAdapter.ClearBeforeFill = true;
            // 
            // aciklamaGetirTableAdapter
            // 
            this.aciklamaGetirTableAdapter.ClearBeforeFill = true;
            // 
            // OtelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OtelGuncelle";
            this.Size = new System.Drawing.Size(831, 677);
            this.Load += new System.EventHandler(this.OtelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivagoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaGetirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;     
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtoteladi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource oTELBindingSource;
        private TrivagoDataSet trivagoDataSet;
        private TrivagoDataSetTableAdapters.OTELTableAdapter oTELTableAdapter;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.ComboBox cbkahvalti;
        private System.Windows.Forms.ComboBox cbhavuz;
        private System.Windows.Forms.ComboBox cbwifi;
        private System.Windows.Forms.ComboBox cbmerkez;
        private System.Windows.Forms.TextBox txtyildiz;
        private System.Windows.Forms.TextBox txtsite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox msY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrivagoDataSetTableAdapters.ACIKLAMATableAdapter aCIKLAMATableAdapter;
        private System.Windows.Forms.BindingSource aciklamaGetirBindingSource;
        private TrivagoDataSetTableAdapters.AciklamaGetirTableAdapter aciklamaGetirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Aciklama;
        private System.Windows.Forms.DataGridViewButtonColumn oda;
    }
}
