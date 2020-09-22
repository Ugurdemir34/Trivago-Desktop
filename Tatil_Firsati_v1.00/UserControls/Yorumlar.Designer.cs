namespace Tatil_Firsati_v1._00
{
    partial class Yorumlar
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
            this.sp = new System.Windows.Forms.SplitContainer();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lbloy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp)).BeginInit();
            this.sp.Panel1.SuspendLayout();
            this.sp.Panel2.SuspendLayout();
            this.sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp
            // 
            this.sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp.Location = new System.Drawing.Point(0, 0);
            this.sp.Margin = new System.Windows.Forms.Padding(2);
            this.sp.Name = "sp";
            this.sp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp.Panel1
            // 
            this.sp.Panel1.Controls.Add(this.lbltarih);
            this.sp.Panel1.Controls.Add(this.lbloy);
            this.sp.Panel1.Controls.Add(this.label2);
            this.sp.Panel1.Controls.Add(this.lblkullanici);
            // 
            // sp.Panel2
            // 
            this.sp.Panel2.Controls.Add(this.label1);
            this.sp.Size = new System.Drawing.Size(311, 119);
            this.sp.SplitterDistance = 38;
            this.sp.SplitterWidth = 1;
            this.sp.TabIndex = 0;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(249, 21);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(27, 13);
            this.lbltarih.TabIndex = 8;
            this.lbltarih.Text = "tarih";
            // 
            // lbloy
            // 
            this.lbloy.AutoSize = true;
            this.lbloy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloy.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbloy.Location = new System.Drawing.Point(291, 5);
            this.lbloy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloy.Name = "lbloy";
            this.lbloy.Size = new System.Drawing.Size(17, 17);
            this.lbloy.TabIndex = 7;
            this.lbloy.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(176, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Değerlendirme : ";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.Location = new System.Drawing.Point(0, 4);
            this.lblkullanici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(69, 17);
            this.lblkullanici.TabIndex = 5;
            this.lblkullanici.Text = "Kullanıcı";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.label1.Size = new System.Drawing.Size(312, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yorum";
            // 
            // Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Yorumlar";
            this.Size = new System.Drawing.Size(311, 119);
            this.Load += new System.EventHandler(this.Yorumlar_Load);
            this.sp.Panel1.ResumeLayout(false);
            this.sp.Panel1.PerformLayout();
            this.sp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp)).EndInit();
            this.sp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sp;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblkullanici;
        public System.Windows.Forms.Label lbloy;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbltarih;
    }
}
