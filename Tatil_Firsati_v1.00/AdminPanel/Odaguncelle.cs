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
    public partial class Odaguncelle : Form
    {
        public Odaguncelle()
        {
            InitializeComponent();
        }
        DataTable tablo;
        OleDbDataAdapter adp;
        Fiyatlar f;
        int odaid;
        public void FiyatGetir(int hotel_id)
        {
            using (adp = new OleDbDataAdapter("SELECT * FROM OTELODALARI INNER JOIN ODA ON ODA.Oda_ID = OTELODALARI.Oda_ID WHERE OTELODALARI.Otel_ID =" + hotel_id, FırsatBul.bag))
            {
                tablo = new DataTable();
                adp.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    DataRow item = tablo.Rows[i];
                    f = new Fiyatlar();
                    f.Controls["lblodatur"].Text = item["Oda_Tip"].ToString();
                    f.Controls["lblodafiyat"].Text = item["Oda_Fiyat"] + " ₺";
                    f.Name = hotel_id+"";
                    PictureBox pb = (PictureBox)f.Controls["pbresim"];
                    odaid = Convert.ToInt32(item["ODA.Oda_ID"]);
                    f.btnkapat.Name = odaid+"";
                    pb.ImageLocation = "FiyatResim\\" + odaid + ".png";
                    f.btnkapat.Click += Btnkapat_Click;
                    flowLayoutPanel1.Controls.Add(f);                    
                }
            };
        }
        public void sil(int hotel_id, int oda_id)
        {
            try
            {
                FırsatBul.bag.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM OTELODALARI WHERE Otel_ID =" + hotel_id + "AND Oda_ID = " +oda_id, FırsatBul.bag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi!");
                FırsatBul.bag.Close();
            }
            catch (Exception hata )
            {
                MessageBox.Show("Bir hata meydana geldi !"  + Environment.NewLine +" "+hata.Message);
              
            }
        }
        public void kaydet(int hotel_id, int oda_id)
        {
            try
            {
                FırsatBul.bag.Open();
                OleDbCommand kmt = new OleDbCommand("INSERT INTO OTELODALARI(Otel_ID,Oda_ID,Oda_Fiyat) VALUES(@Otel_ID,@Oda_ID,@Oda_Fiyat)", FırsatBul.bag);
                kmt.Parameters.AddWithValue("@Otel_ID", hotel_id);
                kmt.Parameters.AddWithValue("@Oda_ID", oda_id);
                kmt.Parameters.AddWithValue("@Oda_Fiyat", Convert.ToInt32(textBox2.Text));
                kmt.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı !");
                FırsatBul.bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata meydana geldi !" + Environment.NewLine + " " + hata.Message);
            }           
        }
        private void Btnkapat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                sil(Convert.ToInt16(f.Name),Convert.ToInt16(((Button)sender).Name));            
                f = (Fiyatlar)((Button)sender).Parent;
                f.Dispose();
            }           
        }

        private void Odaguncelle_Load(object sender, EventArgs e)
        {
            FiyatGetir(OtelGuncelle.otelid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Fiyatlar();
           
            f.pbresim.ImageLocation = "FiyatResim\\" + (comboBox1.SelectedIndex+2) + ".png";
            f.lblodatur.Text = comboBox1.SelectedItem.ToString();
            f.lblodafiyat.Text = textBox2.Text+" ₺";
            f.btnkapat.Click += Btnkapat_Click;
            flowLayoutPanel1.Controls.Add(f);
            kaydet(OtelGuncelle.otelid,(comboBox1.SelectedIndex+2));
          

        }
    }
}
