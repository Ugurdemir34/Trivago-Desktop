using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace Tatil_Firsati_v1._00
{
    public partial class OtelEkle : UserControl
    {
        public OtelEkle()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
         
        }
        List<string> cekilenyollar = new List<string>();      
        List<string> yollar = new List<string>();
      

      
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                FırsatBul.bag.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = FırsatBul.bag;
                komut.CommandText = "INSERT INTO OTEL(Sehir_ID,Tel,Web_Site,Otel_Ad,Acik_Adres,Yildiz_Sayisi,Fiyat,Oy,Merkez,WiFi,Havuz,Kahvalti,Koordinat1,Koordinat2) VALUES(@Sehir_ID,@Tel,@Web_Site,@Otel_Ad,@Acik_Adres,@Yildiz_Sayisi,@Fiyat,@Oy,@Merkez,@WiFi,@Havuz,@Kahvalti,@Koordinat1,@Koordinat2)";
                komut.Parameters.AddWithValue("@Sehir_ID", (comboBox1.SelectedIndex + 1));
                komut.Parameters.AddWithValue("@Tel", txttel.Text);
                komut.Parameters.AddWithValue("@Web_Site", txtsite.Text);
                komut.Parameters.AddWithValue("@Otel_Ad", txtoteladi.Text);
                komut.Parameters.AddWithValue("@Acik_Adres", rchadres.Text);
                komut.Parameters.AddWithValue("@Yildiz_Sayisi", Convert.ToInt16(txtyildiz.Text));
                komut.Parameters.AddWithValue("@Fiyat", Convert.ToInt16(txtfiyat.Text));
                komut.Parameters.AddWithValue("@Oy", 0);
                komut.Parameters.AddWithValue("@Merkez", Convert.ToBoolean(cbmerkez.SelectedItem));
                komut.Parameters.AddWithValue("@WiFi", Convert.ToBoolean(cbwifi.SelectedItem));
                komut.Parameters.AddWithValue("@Havuz", Convert.ToBoolean(cbhavuz.SelectedItem));
                komut.Parameters.AddWithValue("@Kahvalti", Convert.ToBoolean(cbkahvalti.SelectedItem));
                komut.Parameters.AddWithValue("@Koordinat1", msX.Text.Replace('.', ','));
                komut.Parameters.AddWithValue("@Koordinat2", msY.Text.Replace('.', ','));
                komut.ExecuteNonQuery();
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT TOP 1 Otel_ID FROM OTEL ORDER BY Otel_ID DESC", FırsatBul.bag);
                DataTable tablo = new DataTable();
                adp.Fill(tablo);
                DataRow dr = tablo.Rows[0];
                int otelid = Convert.ToInt32(dr["Otel_ID"]);
                OleDbCommand komut2 = new OleDbCommand("INSERT INTO ACIKLAMA(Otel_ID,Aciklama)VALUES(@Otel_ID,@Aciklama)",FırsatBul.bag);
                komut2.Parameters.AddWithValue("@Otel_ID",otelid);
                komut2.Parameters.AddWithValue("@Aciklama", richTextBox1.Text);
                komut2.ExecuteNonQuery();            
                 FırsatBul.bag.Close();
                 for (int i = 0; i < 3; i++)
                 {
                     string yeniyol = "Resimler\\" + txtoteladi.Text + "" + i + ".jpeg";
                     File.Copy(cekilenyollar[i], yeniyol);
                 }
                 cekilenyollar.Clear();
                 MessageBox.Show("Kayıt Başarılı! Otel Bilgilerini Otel Güncelleme menüsünden değiştirebilirsiniz.");     
            }
            catch (Exception hata )
            {
                MessageBox.Show("Bir Hata Meydana Geldi : " + hata.Message);
            }
        }
        PictureBox p;
        void resimlericek()
        {
            yollar.Clear();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                p = new PictureBox() { Size = new Size(110, 110), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle, ErrorImage = null };
                p.ImageLocation = "Resimler\\" + txtoteladi.Text + "" + i + ".jpeg";
                p.Name = "" + i;
                flowLayoutPanel1.Controls.Add(p);                          
            }
        }
        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpeg ) |  *.jpeg; ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string deger;
                deger = openFileDialog1.FileName;
                cekilenyollar.Add(deger);
                for (int i = 0; i < 3; i++)
                {
                    PictureBox p = (PictureBox)flowLayoutPanel1.Controls[i];
                    if (p.Image == null)
                    {                    
                       p.ImageLocation = deger;
                        break;
                    }
                }
            }
        }
        private void OtelEkle_Load(object sender, EventArgs e)
        {
            resimlericek();          
        }
        void otelgetir()
        {
            try
            {
                      
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM OTEL WHERE Sehir_ID = " + (+comboBox2.SelectedIndex + 1), FırsatBul.bag);
                DataTable tablo = new DataTable();
                adp.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch 
            {             
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            otelgetir();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;            
            if(e.ColumnIndex == 6)
            {
                try
                {
                    DialogResult a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        FırsatBul.bag.Open();
                        OleDbCommand kmd = new OleDbCommand("DELETE FROM OTEL WHERE Otel_ID =@Otel_ID", FırsatBul.bag);
                        kmd.Parameters.AddWithValue("@Otel_ID",dataGridView1.Rows[secili].Cells[0].Value);
                        kmd.ExecuteNonQuery();
                        FırsatBul.bag.Close();
                        MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
                      
                        otelgetir();
                    }
                }
                catch(Exception hata)
                {

                    MessageBox.Show("Bir Hata Meydana Geldi!"+Environment.NewLine+"sHata : " + hata.Message);
                }
                finally
                {
                    FırsatBul.bag.Close();
                }
            }
        }
    }
}
