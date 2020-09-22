using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Tatil_Firsati_v1._00
{
    public partial class AciklamaEkle : Form
    {
        public AciklamaEkle()
        {
            InitializeComponent();
        }
        void guncelle()
        {
            try
            {
                FırsatBul.bag.Open();
                OleDbCommand cm = new OleDbCommand("UPDATE ACIKLAMA SET Aciklama=@Aciklama WHERE Otel_ID=@Otel_ID", FırsatBul.bag);
                cm.Parameters.AddWithValue("@Aciklama",richTextBox1.Text);
                cm.Parameters.AddWithValue("@Otel_ID", OtelGuncelle.otelid);
                cm.ExecuteNonQuery();
                MessageBox.Show("Güncellendi!");
                FırsatBul.bag.Close();             
                this.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.SuppressFinalize(this);
            }
            catch (Exception hata )
            {
                MessageBox.Show("Bir hata meydana geldi!"+Environment.NewLine + ""+hata.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
