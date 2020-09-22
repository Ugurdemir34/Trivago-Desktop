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
using System.Collections;
using System.Threading;

namespace Tatil_Firsati_v1._00
{
    public partial class OtelGuncelle : UserControl
    {
        public OtelGuncelle()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        double fiyat = 0;
        public static int otelid;
        List<string> cekilenyollar = new List<string>();
        List<int> silinen = new List<int>();
        List<string> yollar = new List<string>();
        PictureBox p;
        public string aciklamagetir( int otelid)
        {
            string deger = "";
            try
            {
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT Aciklama FROM ACIKLAMA WHERE Otel_ID=" + otelid, FırsatBul.bag);
                DataTable tablo = new DataTable();
                adp.Fill(tablo);
                DataRow dr = tablo.Rows[0];
              
                deger = dr["Aciklama"].ToString();
            }
            catch (Exception)
            {
                deger = "";
               
            }
            return deger;
        }
        void getir(string sehir)
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT Otel_Ad,Tel,Fiyat FROM SEHIR INNER JOIN OTEL ON SEHIR.Sehir_ID = OTEL.Sehir_ID WHERE SEHIR.Sehir_Ad ='" + sehir + "'", FırsatBul.bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }     
        void resimlericek()
        {
            yollar.Clear();           
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                p = new PictureBox() { Size = new Size(110, 110), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle,ErrorImage = null};
                p.ImageLocation = "Resimler\\" + txtoteladi.Text + "" + i + ".jpeg";
                p.Name = "" + i;
                flowLayoutPanel1.Controls.Add(p);               
                yollar.Add(p.ImageLocation);
                p.Click += P_Click;
            }           
        }
        void veriler(string otelad)
        {        
            OleDbDataAdapter adptr = new OleDbDataAdapter("SELECT * FROM SEHIR INNER JOIN OTEL ON SEHIR.Sehir_ID = OTEL.Sehir_ID WHERE OTEL.Otel_Ad ='" + otelad + "'", FırsatBul.bag);
            DataTable tablom = new DataTable();
            adptr.Fill(tablom);
            DataRow dr = tablom.Rows[0];
            txtoteladi.Text = dr["Otel_Ad"].ToString();
            txtsite.Text = dr["Web_Site"].ToString();
            txttel.Text = dr["Tel"].ToString();
            txtyildiz.Text = dr["Yildiz_Sayisi"].ToString();
            txtfiyat.Text = dr["Fiyat"].ToString();
            rchadres.Text = dr["Acik_Adres"].ToString();
            cbhavuz.SelectedItem = dr["Havuz"].ToString();
            cbmerkez.SelectedItem = dr["Merkez"].ToString();
            cbkahvalti.SelectedItem = dr["Kahvalti"].ToString();
            cbwifi.SelectedItem = dr["WiFi"].ToString();
            msX.Text = dr["Koordinat1"].ToString();
            msY.Text = dr["Koordinat2"].ToString();
            otelid = Convert.ToInt16(dr["Otel_ID"]);
            fiyat = Convert.ToDouble(dr["Fiyat"]);
            resimlericek();
        }
        private void OtelGuncelle_Load(object sender, EventArgs e)
        {
            this.oTELTableAdapter.Fill(this.trivagoDataSet.OTEL);            
        }
        public int kontrol(string otelad)
        {
            int verisayisi = 0;            
            OleDbCommand kmt = new OleDbCommand("SELECT * FROM FIRSAT INNER JOIN OTEL ON FIRSAT.Otel_ID = OTEL.Otel_ID WHERE Otel_Ad ='"+otelad+"'",FırsatBul.bag);
            verisayisi =Convert.ToInt32(kmt.ExecuteScalar());         
            return verisayisi;
        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            getir(comboBox1.SelectedItem + "");

        }      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = true;

            int secili = dataGridView1.SelectedCells[0].RowIndex;
            veriler(dataGridView1.Rows[secili].Cells[0].Value.ToString());
            if (e.ColumnIndex == 3)
            {
                AciklamaEkle a = new AciklamaEkle();
                a.textBox1.Text = txtoteladi.Text;
                a.richTextBox1.Text = aciklamagetir(otelid);
                a.ShowDialog();
            }
            if (e.ColumnIndex == 4)
            {
                Odaguncelle oda = new _00.Odaguncelle();
                oda.textBox1.Text = txtoteladi.Text;
                oda.ShowDialog();
            }
        }      
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            FırsatBul.bag.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = FırsatBul.bag;
            komut.CommandText = "UPDATE OTEL SET Tel = @Tel ,Web_Site=@Web_Site, Acik_Adres=@Acik_Adres, Yildiz_Sayisi=@Yildiz_Sayisi, Fiyat=@Fiyat, Merkez=@Merkez, WiFi=@WiFi, Havuz=@Havuz, Kahvalti=@Kahvalti, Koordinat1=@Koordinat1, Koordinat2=@Koordinat2 WHERE Otel_ID =" + otelid;
            komut.Parameters.AddWithValue("@Tel", txttel.Text);
            komut.Parameters.AddWithValue("@Web_Site", txtsite.Text);
            komut.Parameters.AddWithValue("@Acik_Adres", rchadres.Text);
            komut.Parameters.AddWithValue("@Yildiz_Sayisi", Convert.ToInt16(txtyildiz.Text));
            komut.Parameters.AddWithValue("@Fiyat", Convert.ToInt16(txtfiyat.Text));
            komut.Parameters.AddWithValue("@Merkez",Convert.ToBoolean( cbmerkez.SelectedItem));
            komut.Parameters.AddWithValue("@WiFi",Convert.ToBoolean(cbwifi.SelectedItem));
            komut.Parameters.AddWithValue("@Havuz", Convert.ToBoolean(cbhavuz.SelectedItem));
            komut.Parameters.AddWithValue("@Kahvalti", Convert.ToBoolean(cbkahvalti.SelectedItem));
            komut.Parameters.AddWithValue("@Koordinat1", msX.Text.Replace('.',','));
            komut.Parameters.AddWithValue("@Koordinat2", msY.Text.Replace('.', ','));
            komut.ExecuteNonQuery();
            if(Convert.ToDouble(txtfiyat.Text) < fiyat)
            {
                if(kontrol(txtoteladi.Text) <=0)
                {
                    komut = new OleDbCommand("INSERT INTO FIRSAT(Otel_ID,Eski_Fiyat,Yeni_Fiyat) VALUES(@Otel_ID,Eski_Fiyat,Yeni_Fiyat)", FırsatBul.bag);
                    komut.Parameters.AddWithValue("@Otel_ID", otelid);
                    komut.Parameters.AddWithValue("@Eski_Fiyat", fiyat);
                    komut.Parameters.AddWithValue("@Yeni_Fiyat", Convert.ToDouble(txtfiyat.Text));
                    komut.ExecuteNonQuery();
                }
                else
                {
                    komut = new OleDbCommand("UPDATE FIRSAT SET Otel_ID=@Otel_ID, Eski_Fiyat=@Eski_Fiyat, Yeni_Fiyat =@Yeni_Fiyat WHERE Otel_ID=@Otel_ID", FırsatBul.bag);
                    komut.Parameters.AddWithValue("@Otel_ID", otelid);
                    komut.Parameters.AddWithValue("@Eski_Fiyat", fiyat);
                    komut.Parameters.AddWithValue("@Yeni_Fiyat", Convert.ToDouble(txtfiyat.Text));
                    komut.ExecuteNonQuery();
                }            
            }
            else
            {
                komut = new OleDbCommand("DELETE FROM FIRSAT WHERE Otel_ID  = @Otel_ID", FırsatBul.bag);
                komut.Parameters.AddWithValue("@Otel_ID", otelid);
                komut.ExecuteNonQuery();
            }
            FırsatBul.bag.Close();
            for (int i = 0; i < silinen.Count; i++)
            {
                string yeniyol = "Resimler\\" + txtoteladi.Text + "" + silinen[i] + ".jpeg";      
                File.Copy(cekilenyollar[i], yeniyol);
            }
            silinen.Clear();
            cekilenyollar.Clear();
            MessageBox.Show("Güncellendi!");
            getir(comboBox1.SelectedItem+"");
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
                            silinen.Add(Convert.ToInt16(p.Name));
                            p.ImageLocation = deger;
                            break;
                        }
                    }
               }           
        }
        private void P_Click(object sender, EventArgs e)
        {          
            if (((PictureBox)sender).Image == null)
            {              
            }
            else
            {
                DialogResult a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {                                
                   ((PictureBox)sender).Image = null;
                   yollar.Remove(((PictureBox)sender).ImageLocation);
                   File.Delete(((PictureBox)sender).ImageLocation);                   
                }
            }
        }     
    }
}
