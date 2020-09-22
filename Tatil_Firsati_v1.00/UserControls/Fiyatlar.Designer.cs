namespace Tatil_Firsati_v1._00
{
    partial class Fiyatlar
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
            this.lblodatur = new System.Windows.Forms.Label();
            this.lblodafiyat = new System.Windows.Forms.Label();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.btnkapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblodatur
            // 
            this.lblodatur.AutoSize = true;
            this.lblodatur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodatur.Location = new System.Drawing.Point(76, 32);
            this.lblodatur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblodatur.Name = "lblodatur";
            this.lblodatur.Size = new System.Drawing.Size(58, 19);
            this.lblodatur.TabIndex = 0;
            this.lblodatur.Text = "label1";
            // 
            // lblodafiyat
            // 
            this.lblodafiyat.AutoSize = true;
            this.lblodafiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblodafiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblodafiyat.Location = new System.Drawing.Point(262, 35);
            this.lblodafiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblodafiyat.Name = "lblodafiyat";
            this.lblodafiyat.Size = new System.Drawing.Size(41, 13);
            this.lblodafiyat.TabIndex = 0;
            this.lblodafiyat.Text = "label1";
            // 
            // pbresim
            // 
            this.pbresim.Location = new System.Drawing.Point(10, 11);
            this.pbresim.Margin = new System.Windows.Forms.Padding(2);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(58, 58);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresim.TabIndex = 1;
            this.pbresim.TabStop = false;
            // 
            // btnkapat
            // 
            this.btnkapat.FlatAppearance.BorderSize = 0;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.Location = new System.Drawing.Point(292, 2);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(19, 19);
            this.btnkapat.TabIndex = 2;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = true;
            // 
            // Fiyatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.pbresim);
            this.Controls.Add(this.lblodafiyat);
            this.Controls.Add(this.lblodatur);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fiyatlar";
            this.Size = new System.Drawing.Size(313, 81);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnkapat;
        public System.Windows.Forms.Label lblodatur;
        public System.Windows.Forms.Label lblodafiyat;
        public System.Windows.Forms.PictureBox pbresim;
    }
}
