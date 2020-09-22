using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data.OleDb;
using System.Threading;
using GMap.NET.WindowsForms.ToolTips;
using System.Diagnostics;

namespace Tatil_Firsati_v1._00.Fırsat
{
    public partial class YakinOtel : UserControl
    {
        public YakinOtel()
        {
            InitializeComponent();
        }
        GeoCoordinateWatcher wc;
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMarkerGoogle marker1;
        GeoCoordinate location;
        GMapMarker mrk;
        Bitmap homemrk = new Bitmap(Properties.Resources.homeee);
        Bitmap otelsmrk = new Bitmap(Properties.Resources.otelss);
        OleDbDataAdapter adp;
        DataTable tablo;
        DataRow dr;
        private void YakinOtel_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();                   
        }
        void getir(int deger)
        {
            gmyakin.Overlays.Clear();
            markersOverlay.Markers.Clear();           
            // location = wc.Position.Location;
            PointLatLng st = new PointLatLng(location.Latitude, location.Longitude);
            gmyakin.Position = st;
            gmyakin.Overlays.Add(markersOverlay);
            marker1 = new GMarkerGoogle(gmyakin.Position, homemrk);
            marker1.ToolTipText = "Mevcut Konumunuz ☻";
            marker1.ToolTipMode = MarkerTooltipMode.Always;
            marker1.ToolTip.Foreground = Brushes.Black;
            marker1.ToolTip.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            var brush = new SolidBrush(Color.FromArgb(253, 197, 0));
            marker1.ToolTip.Fill = brush;
            markersOverlay.Markers.Add(marker1);
            adp = new OleDbDataAdapter("SELECT * FROM OTEL LEFT JOIN YORUM ON OTEL.Otel_ID = YORUM.Otel_ID WHERE Sehir_ID = 34", FırsatBul.bag);
            tablo = new DataTable();
            adp.Fill(tablo);
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                dr = tablo.Rows[i];
                PointLatLng a = new PointLatLng(Convert.ToDouble(dr["Koordinat1"]), Convert.ToDouble(dr["Koordinat2"]));
                var yep = new GeoCoordinate(a.Lat, a.Lng);
                double sayı = Math.Ceiling(Convert.ToDouble(location.GetDistanceTo(yep)) / 1000);
                if (sayı <= deger)
                {
                    mrk = new GMarkerGoogle(a, otelsmrk);
                    mrk.ToolTipText = "\n" + dr["Otel_Ad"] + "\n\n" + dr["Tel"] + "\n\nOrtalama : " + sayı + "km" +" ("+ Math.Ceiling((0.621371192*sayı))+" mil)\n\n Daha Detaylı Bilgi için Tıklayınız...";                           
                    mrk.Tag = dr["Otel_Ad"];
                    mrk.ToolTip = new GMapBaloonToolTip(mrk);
                    mrk.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    Brush ToolTipBackColor = new SolidBrush(Color.FromArgb(253, 197, 0));
                    mrk.ToolTip.Fill = ToolTipBackColor;
                    mrk.ToolTip.Foreground = Brushes.Black;
                    mrk.ToolTip.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                    // marker1.ToolTip.Fill = brush;                   
                    markersOverlay.Markers.Add(mrk);
                }
            }
            tablo.Dispose();
            adp.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(this);

        }
        private void Wc_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            //Thread.Sleep(1000);
            if (e.Status == GeoPositionStatus.Ready)
            {
                button1.Visible = false;
                label4.Text = "Başlatılıyor...";
                Thread.Sleep(1000);
                label4.Text = "Konum Bulunuyor...";
                Thread.Sleep(1000);
                label4.Text = "Konum verilerine erişildi";
                Thread.Sleep(1000);
                label4.Text = null;
              
                // Display the latitude and longitude.
                if (wc.Position.Location.IsUnknown)
                {
                    MessageBox.Show("Konum Verilerine Erişilemedi ! Lütfen Konum Ayarlarınızı Yapılandırın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   location = wc.Position.Location;
                   trackBar1.Enabled = true;                   
                   wc.Dispose();                 
                }
            }
            else
            {
              label4.Text = "Konum Verilerine Erişilemedi !\nLütfen Konum Ayarlarınızı Yapılandırın";
              //  button1.Visible = true;            
            }
        }   
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value + " km";
            getir(trackBar1.Value);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            wc = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            wc.StatusChanged += Wc_StatusChanged;
            wc.Start();
            gmyakin.MapProvider = GMapProviders.GoogleMap;
            Thread.Sleep(1000);                  
        }
        private void gmyakin_OnMarkerEnter(GMapMarker item)
        {
            try
            {
                groupBox1.Visible = true;
                label3.Text = item.ToolTipText;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox1.ImageLocation = "Resimler\\" + item.Tag + "" + 0 + ".jpeg";
            }
            catch
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "control.exe /name Microsoft.LocationandOtherSensors";
                Process Process = new Process();
                ProcessStartInfo ProcessInfo;
                ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + a);
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = false;
                Process = Process.Start(ProcessInfo);
                Process.WaitForExit();
                Process.Close();
            }
            catch
            {
                MessageBox.Show("Sistem Belirtilen Yolu Bulamıyor...","Hata",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        MyOtel my;     
        public void gmyakin_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            try
            {
                OtelBilgi otl = new OtelBilgi();
                adp = new OleDbDataAdapter("SELECT * FROM SEHIR INNER JOIN OTEL ON SEHIR.Sehir_ID = OTEL.Sehir_ID WHERE Otel_Ad = '" + item.Tag + "'", FırsatBul.bag);
                tablo = new DataTable();
                adp.Fill(tablo);
                dr = tablo.Rows[0];
                my = new MyOtel();
                my.Name = dr["Otel_Ad"].ToString();
                my.Controls["btnGoster"].Name = dr["Otel_ID"].ToString();
                my.Controls["lblOtelAdi"].Text = dr["Otel_Ad"].ToString();
                my.Controls["pbresim"].BackgroundImage = Properties.Resources.mylogo;
                my.Controls["lbladres"].Text = dr["Acik_Adres"].ToString();
                my.Controls["lblfiyat"].Text = dr["Fiyat"].ToString() + " ₺";
              
                my.degerdurum(my.lbldeger, my.lbloy, Convert.ToInt16(dr["Oy"]));
                PictureBox yldzresim = (PictureBox)my.Controls["pbyildiz"];
                yldzresim.ImageLocation = "YildizResim\\" + dr["Yildiz_Sayisi"] + ".png";
                PictureBox otelresim = (PictureBox)my.Controls["pbresim"];
                otelresim.ImageLocation = "Resimler\\" + item.Tag + "" + 0 + ".jpeg";
                otl.flowLayoutPanel1.Controls.Add(my);
                otl.Show();
            }
            catch
            {             
            }
        }
    }
}
