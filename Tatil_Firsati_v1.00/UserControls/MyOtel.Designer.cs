namespace Tatil_Firsati_v1._00
{
    partial class MyOtel
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
            this.lbloteladi = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.btnteklif = new System.Windows.Forms.Button();
            this.btngoster = new System.Windows.Forms.Button();
            this.pbyildiz = new System.Windows.Forms.PictureBox();
            this.lbleski = new System.Windows.Forms.Label();
            this.lblyuzde = new System.Windows.Forms.Label();
            this.lbldeger = new System.Windows.Forms.Label();
            this.lbloy = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbyildiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloteladi
            // 
            this.lbloteladi.AutoSize = true;
            this.lbloteladi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloteladi.Location = new System.Drawing.Point(214, 9);
            this.lbloteladi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloteladi.Name = "lbloteladi";
            this.lbloteladi.Size = new System.Drawing.Size(76, 23);
            this.lbloteladi.TabIndex = 4;
            this.lbloteladi.Text = "Otel Adı";
            // 
            // lbladres
            // 
            this.lbladres.AllowDrop = true;
            this.lbladres.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladres.Location = new System.Drawing.Point(216, 73);
            this.lbladres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(394, 37);
            this.lbladres.TabIndex = 6;
            this.lbladres.Text = "Adres";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblfiyat.Location = new System.Drawing.Point(645, 73);
            this.lblfiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(49, 23);
            this.lblfiyat.TabIndex = 7;
            this.lblfiyat.Text = "Fiyat";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 366);
            this.panel1.TabIndex = 9;
            // 
            // pbresim
            // 
            this.pbresim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbresim.ErrorImage = null;
            this.pbresim.InitialImage = null;
            this.pbresim.Location = new System.Drawing.Point(0, 0);
            this.pbresim.Margin = new System.Windows.Forms.Padding(2);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(205, 179);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresim.TabIndex = 3;
            this.pbresim.TabStop = false;
            this.pbresim.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // btnteklif
            // 
            this.btnteklif.BackColor = System.Drawing.Color.Transparent;
            this.btnteklif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteklif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteklif.Image = global::Tatil_Firsati_v1._00.Properties.Resources.partner;
            this.btnteklif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteklif.Location = new System.Drawing.Point(623, 111);
            this.btnteklif.Name = "btnteklif";
            this.btnteklif.Size = new System.Drawing.Size(120, 39);
            this.btnteklif.TabIndex = 8;
            this.btnteklif.Text = "           Fırsat Yakala";
            this.btnteklif.UseVisualStyleBackColor = false;
            this.btnteklif.Click += new System.EventHandler(this.btnteklif_Click);
            // 
            // btngoster
            // 
            this.btngoster.BackColor = System.Drawing.Color.Transparent;
            this.btngoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoster.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoster.Image = global::Tatil_Firsati_v1._00.Properties.Resources.durbun;
            this.btngoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngoster.Location = new System.Drawing.Point(516, 111);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(101, 39);
            this.btngoster.TabIndex = 8;
            this.btngoster.Text = "         Göster";
            this.btngoster.UseVisualStyleBackColor = false;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // pbyildiz
            // 
            this.pbyildiz.Location = new System.Drawing.Point(217, 37);
            this.pbyildiz.Margin = new System.Windows.Forms.Padding(2);
            this.pbyildiz.Name = "pbyildiz";
            this.pbyildiz.Size = new System.Drawing.Size(88, 19);
            this.pbyildiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbyildiz.TabIndex = 5;
            this.pbyildiz.TabStop = false;
            // 
            // lbleski
            // 
            this.lbleski.AutoSize = true;
            this.lbleski.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleski.ForeColor = System.Drawing.Color.Red;
            this.lbleski.Location = new System.Drawing.Point(646, 38);
            this.lbleski.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbleski.Name = "lbleski";
            this.lbleski.Size = new System.Drawing.Size(38, 18);
            this.lbleski.TabIndex = 7;
            this.lbleski.Text = "Fiyat";
            this.lbleski.Visible = false;
            // 
            // lblyuzde
            // 
            this.lblyuzde.BackColor = System.Drawing.Color.Red;
            this.lblyuzde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblyuzde.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyuzde.ForeColor = System.Drawing.Color.White;
            this.lblyuzde.Location = new System.Drawing.Point(708, 7);
            this.lblyuzde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyuzde.Name = "lblyuzde";
            this.lblyuzde.Size = new System.Drawing.Size(56, 23);
            this.lblyuzde.TabIndex = 7;
            this.lblyuzde.Text = "Fiyat";
            this.lblyuzde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblyuzde.Visible = false;
            // 
            // lbldeger
            // 
            this.lbldeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.lbldeger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldeger.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldeger.ForeColor = System.Drawing.Color.Black;
            this.lbldeger.Location = new System.Drawing.Point(219, 109);
            this.lbldeger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeger.Name = "lbldeger";
            this.lbldeger.Size = new System.Drawing.Size(23, 23);
            this.lbldeger.TabIndex = 12;
            this.lbldeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbloy
            // 
            this.lbloy.AutoSize = true;
            this.lbloy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbloy.Location = new System.Drawing.Point(245, 111);
            this.lbloy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloy.Name = "lbloy";
            this.lbloy.Size = new System.Drawing.Size(101, 18);
            this.lbloy.TabIndex = 13;
            this.lbloy.Text = "değerlendirme";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MyOtel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbldeger);
            this.Controls.Add(this.lbloy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnteklif);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.lbleski);
            this.Controls.Add(this.lblyuzde);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.pbyildiz);
            this.Controls.Add(this.lbloteladi);
            this.Controls.Add(this.pbresim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.Name = "MyOtel";
            this.Size = new System.Drawing.Size(765, 179);
            this.Click += new System.EventHandler(this.btngoster_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbyildiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.PictureBox pbyildiz;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btngoster;
        public System.Windows.Forms.Label lbloteladi;
        public System.Windows.Forms.Button btnteklif;
        private System.Windows.Forms.Label lbleski;
        private System.Windows.Forms.Label lblyuzde;
        public System.Windows.Forms.Label lbldeger;
        public System.Windows.Forms.Label lbloy;
        private ns1.BunifuElipse bunifuElipse1;
    }
}
