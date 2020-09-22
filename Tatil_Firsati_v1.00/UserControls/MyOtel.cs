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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Tatil_Firsati_v1._00
{
    public partial class MyOtel : UserControl
    {
        public MyOtel()
        {
            InitializeComponent();
        }      
        int sayac = 0;
        int sayac2 = 0;
        //Bilgiler bil;
        public static int otel_id;
        public static string otel_adi;
        OleDbDataAdapter adp;
        DataTable tablo;
        Bilgiler bil;
        Yorumlar yrm;
        double x, y;
        GMapOverlay markersOverlay;
        GMarkerGoogle marker1;
        DataRow dr;
        public static string site;
        Fiyatlar f;
        Benzer b;
        
        public void  degerdurum(Label lbloy,Label sonuc,int oy)
        {
            string donecek = "";
            Color renk;
            if (oy == 0)
            {
                donecek = "Kötü";
                renk = Color.Red;
            }
            else if (oy > 0 && oy <= 2)
            {
                donecek = "Fena Değil";
                renk = Color.FromArgb(253, 197, 0);
            }
            else if (oy > 2 && oy <= 4)
            {
                donecek = "İyi";
                renk = Color.FromArgb(0, 172, 237); 


            }
            else
            {
                donecek = "Mükemmel";
                renk = Color.FromArgb(49, 99, 0);
            }
            sonuc.Text = donecek;
            lbloy.Text = oy.ToString();
            lbloy.BackColor = renk;
          
        }
        void benzergetir(int otel_id,string sehir)
        {
            try
            {
                bil.flowbenzer.Controls.Clear();
             
             
                adp = new OleDbDataAdapter("SELECT * FROM FIRSAT INNER JOIN OTEL ON FIRSAT.Otel_ID = OTEL.Otel_ID WHERE OTEL.Otel_ID <> " + otel_id + " AND OTEL.Sehir_ID = (SELECT Sehir_ID FROM SEHIR WHERE Sehir_Ad = '" + sehir + "')", FırsatBul.bag);
                tablo = new DataTable();
                adp.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    dr = tablo.Rows[i];
                    b = new Benzer() { Size = new Size(225, 270) };
                    b.pb.ImageLocation = "Resimler\\" + dr["Otel_Ad"] + "" + 0 + ".jpeg";
                    b.label1.Text = dr["Eski_Fiyat"] +" ₺";
                    b.label2.Text = dr["Yeni_Fiyat"] +" ₺";
                    b.pbyildiz.ImageLocation = "YildizResim\\" + dr["Yildiz_Sayisi"] + ".png";
                    b.lbloteladi.Text = "" + dr["Otel_Ad"];
                    bil.flowbenzer.Controls.Add(b);
                    b.btngoster.Name = dr["Otel_Ad"].ToString();
                    b.lbldeger.Text = "" + dr["Oy"];
                    degerdurum(b.lbldeger,b.lblsonuc, Convert.ToInt16(dr["Oy"]));

                }
                tablo.Dispose();
                tablo = null;
                adp.Dispose();
                adp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex.Message);
            }
        }
        void bilgicek(int otel)
        {
            using (adp = new OleDbDataAdapter("SELECT * FROM OTEL INNER JOIN ACIKLAMA ON ACIKLAMA.Otel_ID = OTEL.Otel_ID WHERE OTEL.Otel_ID = " + otel, FırsatBul.bag))
            {
                tablo = new DataTable();
                adp.Fill(tablo);
                dr = tablo.Rows[0];
                x = Convert.ToDouble(dr["Koordinat1"].ToString());
                y = Convert.ToDouble(dr["Koordinat2"].ToString());
                bil.tabPage2.Controls["lbloteladi"].Text = dr["Otel_Ad"].ToString();
                bil.tabPage2.Controls["lblbilgiler"].Text = dr["Aciklama"].ToString();               
                site = dr["Web_Site"].ToString();             
                bil.tabPage2.Controls["lbltel"].Text  = "İrtibat No : " + dr["Tel"].ToString();               
                bil.gm2.Position = new PointLatLng(x, y);
                bil.gm2.Overlays.Clear();               
                markersOverlay = new GMapOverlay("markers");
                bil.gm2.Overlays.Add(markersOverlay);
                var brush = new SolidBrush(Color.FromArgb(253, 197, 0));
                marker1 = new GMarkerGoogle(bil.gm2.Position, GMarkerGoogleType.red_pushpin);
                marker1.ToolTipMode = MarkerTooltipMode.Always;
                marker1.ToolTipText = dr["Otel_Ad"].ToString() +"\n"+dr["Tel"];        
                marker1.ToolTip.Foreground = Brushes.Black;
                marker1.ToolTip.Font = new Font("Century Gothic",12,FontStyle.Bold);                                        
                marker1.ToolTip.Fill = brush;
                markersOverlay.Markers.Add(marker1);
                marker1.ToolTip.TextPadding = new Size(25, 15);               
            }
            tablo.Dispose();
            tablo = null;
            adp.Dispose();
            adp = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public  void yorumgetir(Bilgiler b,int otel)
        {
            b.tabControl1.TabPages[2].Controls["fl1"].Controls.Clear();
            using (adp = new OleDbDataAdapter("SELECT * FROM OTEL INNER JOIN YORUM ON OTEL.Otel_ID = YORUM.Otel_ID WHERE OTEL.Otel_ID =" + otel, FırsatBul.bag))
            {
                tablo = new DataTable();
                adp.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    DataRow item = tablo.Rows[i];
                    yrm = new Yorumlar();
                    b.tabControl1.TabPages[2].Controls["fl1"].Controls.Add(yrm);
                    SplitContainer spl = (SplitContainer)yrm.Controls["sp"];
                    spl.Panel1.Controls["lblkullanici"].Text = item["Ad_Soyad"].ToString();
                    spl.Panel2.Controls["label1"].Text = item["Yorum"].ToString();
                    spl.Panel1.Controls["lbloy"].Text = item["YORUM.Oy"].ToString();
                    spl.Panel1.Controls["lbltarih"].Text = item["Tarih"].ToString().Replace("00:00:00", "");
                }
            }
            tablo.Dispose();
            tablo = null;
            GC.Collect();
            adp.Dispose();
            adp = null;
            GC.WaitForPendingFinalizers();
        }
        public  void ResimGetir(PictureBox p, string oteladi,int i)
        {
            p.Image = null;
            try
            {               
                p.ImageLocation = "Resimler\\" + oteladi + "" + i + ".jpeg";
                bil.buyutulenResim();
            }
            catch
            {
              
               
            }
        }
        public  void FiyatGetir(int hotel_id)
        {
            using (adp = new OleDbDataAdapter("SELECT * FROM OTELODALARI INNER JOIN ODA ON ODA.Oda_ID = OTELODALARI.Oda_ID WHERE OTELODALARI.Otel_ID =" + hotel_id, FırsatBul.bag))
            {
                tablo = new DataTable();
                adp.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    DataRow item = tablo.Rows[i];
                    f = new Fiyatlar();
                    //b.flpanel.Controls.Add(f);                 
                    f.lblodatur.Text = item["Oda_Tip"].ToString();                           
                    f.lblodafiyat.Text = item["Oda_Fiyat"] + " ₺";
                    f.btnkapat.Visible = false;
                    PictureBox pb = (PictureBox)f.Controls["pbresim"];                 
                    int odaid = Convert.ToInt32(item["ODA.Oda_ID"]);
                    f.pbresim.ImageLocation = "FiyatResim\\" + odaid + ".png";                 
                    bil.flpanel.Controls.Add(f);

                }
            };
            tablo.Dispose();
            tablo = null;
            adp.Dispose();
            adp = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
        private void btnteklif_Click(object sender, EventArgs e)
        {
            Teklif t = new _00.Teklif();
            t.textBox1.Text =lbloteladi.Text;
            t.Show();
            t.adres = lbladres.Text;
        }
        private void btngoster_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                try
                {
                    if(bil==null)
                    {
                        bil = new Bilgiler();
                    }
                   if(bil!=null)
                    {
                        btngoster.Text = "        Gizle";
                        this.Height = 530;
                        sayac = 1;
                        panel1.Controls.Add(bil);
                        otel_id = Convert.ToInt16(btngoster.Name);
                        PictureBox pc = (PictureBox)bil.tabControl1.TabPages[0].Controls["pictureBox1"];
                        bil.tabControl1.TabPages[0].Name = lbloteladi.Text;
                        ResimGetir(pc, bil.tabControl1.TabPages[0].Name, 0);
                        yorumgetir(bil, otel_id);
                        bilgicek(otel_id);
                        FiyatGetir(otel_id);
                        benzergetir(otel_id, FırsatBul.sehiradi.ToString());
                        sayac2++;
                    }                                                   
                }
                catch
                {                 
                }
            }
            else
            {
                this.Height = 180;
                btngoster.Text = "         Göster";
              //  bil.Dispose();
             //   bil = null;
                sayac = 0;              
            }
        }              
    }
}
