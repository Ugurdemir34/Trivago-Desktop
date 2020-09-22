using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tatil_Firsati_v1._00.Fırsat;
using System.Data.OleDb;
namespace Tatil_Firsati_v1._00
{
    public partial class Benzer : UserControl
    {
        public Benzer()
        {
            InitializeComponent();
        }
        OleDbDataAdapter adp;
        DataTable tablo;
        MyOtel my;
        DataRow dr;
        OtelBilgi otl;
        Bilgiler bil;
        void getir(string ad)
        {
            bil = new _00.Bilgiler();
             otl = new OtelBilgi();
             adp = new OleDbDataAdapter("SELECT * FROM FIRSAT INNER JOIN OTEL ON FIRSAT.Otel_ID = OTEL.Otel_ID WHERE Otel_Ad = '" + ad + "'", FırsatBul.bag);
             tablo = new DataTable();
             adp.Fill(tablo);
             dr = tablo.Rows[0];
             my = new MyOtel();
             my.Name = dr["Otel_Ad"].ToString();
             my.Controls["lbleski"].Visible = true;
             my.Controls["lblyuzde"].Visible = true;
             my.Controls["btnGoster"].Name = dr["OTEL.Otel_ID"].ToString();            
             my.Controls["lbleski"].Text = dr["Eski_Fiyat"].ToString() + " ₺";
             int yuzde = 100 - Convert.ToInt16(Convert.ToDouble(dr["Yeni_Fiyat"]) / ((Convert.ToDouble(dr["Eski_Fiyat"]) / 100)));
             my.Controls["lblOtelAdi"].Text = ad;
             my.Controls["lblyuzde"].Text = "- % " + yuzde.ToString();
             my.Controls["pbresim"].BackgroundImage = Properties.Resources.mylogo;
             my.Controls["lbladres"].Text = dr["Acik_Adres"].ToString();
             my.Controls["lblfiyat"].Text = dr["Fiyat"].ToString() + " ₺";
             my.Controls["lbloy"].Text = "Değerlendirme : " + dr["Oy"].ToString();
             PictureBox yldzresim = (PictureBox)my.Controls["pbyildiz"];
             yldzresim.ImageLocation = "YildizResim\\" + dr["Yildiz_Sayisi"] + ".png";
             PictureBox otelresim = (PictureBox)my.Controls["pbresim"];
             otelresim.ImageLocation = "Resimler\\" + ad + "" + 0 + ".jpeg";
             otl.flowLayoutPanel1.Controls.Add(my);
             otl.Show();
          
        }
        private void Benzer_Load(object sender, EventArgs e)
        {
          
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            getir(btngoster.Name);
        }
    }
}
