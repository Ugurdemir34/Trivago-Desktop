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
using System.Drawing.Drawing2D;

namespace Tatil_Firsati_v1._00
{
    public partial class Bilgiler : UserControl
    {
        public Bilgiler()
        {
            InitializeComponent();
        }      
        int i = 0;
        MyOtel my=new MyOtel();
        private Bitmap OriginalImage;

        // The currently cropped image.
        private Bitmap CroppedImage;

        // The cropped image with the selection rectangle.
        private Bitmap DisplayImage;
        private Graphics DisplayGraphics;
        int width = 25;
        int height = 25;
        void Yorum_Yap(int otel_id)
        { 
            try
            {
              
                FırsatBul.bag.Open();
                FırsatBul.cmd = new OleDbCommand();
                FırsatBul.cmd.Connection = FırsatBul.bag;
                FırsatBul.cmd.CommandText = "INSERT INTO YORUM(Otel_ID,Ad_Soyad,Yorum,Oy,Tarih) VALUES(@Otel_ID,@Ad_Soyad,@Yorum,@Oy,@Tarih)";
                FırsatBul.cmd.Parameters.AddWithValue("@Otel_ID",otel_id);
                FırsatBul.cmd.Parameters.AddWithValue("@Ad_Soyad", txtad.Text);
                FırsatBul.cmd.Parameters.AddWithValue("@Yorum", rcyorum.Text);
                FırsatBul.cmd.Parameters.AddWithValue("@Oy", bunifuRating1.Value);
                FırsatBul.cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                FırsatBul.cmd.ExecuteNonQuery();
                MessageBox.Show("Yorum Yapıldı. Teşekkür Ederiz");
                my.yorumgetir(this,otel_id);
                FırsatBul.cmd.Dispose();
                FırsatBul.cmd = null;
                FırsatBul.bag.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata : " +hata.Message);
            }
        }                  
        public int oy_hesapla(int otelid)
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT Sum(OY)/ COUNT(OY) as Ort FROM YORUM WHERE Otel_ID ="+otelid,FırsatBul.bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            DataRow dr = tablo.Rows[0];
            int oy = Convert.ToInt16(dr["Ort"]);      
            return oy;
        }
        private void btngonder_Click(object sender, EventArgs e)
        {
            try
            {
                Yorum_Yap(MyOtel.otel_id);
                int oy_ort = oy_hesapla(MyOtel.otel_id);
                FırsatBul.bag.Open();
                OleDbCommand kmt = new OleDbCommand("UPDATE OTEL SET Oy = @Oy WHERE Otel_ID =@Otel_ID ",FırsatBul.bag);
                kmt.Parameters.AddWithValue("@Oy",oy_ort);
                kmt.Parameters.AddWithValue("@Otel_ID", MyOtel.otel_id);
                kmt.ExecuteNonQuery();
                FırsatBul.bag.Close();              
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message);
            }
            finally
            {
                FırsatBul.bag.Close();
            }
        }     
        private void Bilgiler_Load(object sender, EventArgs e)
        {
            gm2.MapProvider = GMapProviders.GoogleMap;
            gm2.DragButton = MouseButtons.Left;
            gm2.AutoScroll = true;
            pbzoom.Size = new Size(150, 150);
            pbzoom.SizeMode = PictureBoxSizeMode.Zoom;
            pbzoom.Paint += paint;  
            pictureBox1.Controls.Add(pbzoom);
           // bunifuElipse2.TargetControl = pbzoom;
                   
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();        
            bunifuTransition1.ShowSync(pictureBox1);
            if (i >=2)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            my.ResimGetir(pictureBox1, button2.Parent.Name, i);
            buyutulenResim();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();          
            bunifuTransition1.ShowSync(pictureBox1);
            if (i <= 0)
            {
                i = 2;
            }
            else
            {
                i--;
            }           
            my.ResimGetir(pictureBox1, button2.Parent.Name, i);
            buyutulenResim();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bt = new Bitmap(pictureBox1.Image);
                Buyut p = new Buyut();
                p.BackgroundImage = pictureBox1.Image;
                if (pictureBox1.Image == pictureBox1.ErrorImage)
                {
                }
                else
                {
                    if (bt.Width > 1366)
                    {
                        p.Width = 800;
                    }
                    if (bt.Height > 768)
                    {
                        p.Height = 600;
                    }
                    p.Show();                  
                }               
            }
            catch
            {                              
            }
        }
        private void lnksite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(MyOtel.site);
            }
            catch (Exception hata)
            {

                MessageBox.Show("Web sitesi bulunamadı ","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }
        PictureBox pbzoom = new PictureBox();
        int x, y;
        public void buyutulenResim()
        {
            OriginalImage = LoadBitmapUnlocked(pictureBox1.ImageLocation);
            CroppedImage = OriginalImage.Clone() as Bitmap;
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pbzoom.Image = DisplayImage;
            pbzoom.Visible = true;        
        }
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            int w, h;
            using (Bitmap bm = new Bitmap(file_name))
            {
                Bitmap yeni = null;
                Bitmap new_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics gr = Graphics.FromImage(new_bitmap))
                {
                    gr.DrawImage(bm, 0, 0);
                }
                w = pictureBox1.Width;
                h = pictureBox1.Height;
                if (w > 1000)
                {
                    w = 1500;
                    h = 1500;
                }
                yeni = new Bitmap(bm, w, h);
                pictureBox1.Size = new Size(w, h);
                return yeni;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null||DisplayImage != null || DisplayGraphics!=null||CroppedImage!=null)
            {                          
                Rectangle source_rect = new Rectangle(e.Location.X, e.Location.Y, 100, 100);
                Rectangle dest_rect = new Rectangle(0, 0, 100, 100);
                DisplayImage = new Bitmap(100, 100);
                DisplayGraphics = Graphics.FromImage(DisplayImage);
                DisplayGraphics.DrawImage(CroppedImage,
                dest_rect, source_rect, GraphicsUnit.Pixel);                
                pbzoom.Image = DisplayImage;
                pbzoom.Location = new Point(e.X, e.Y - 15);
                GC.Collect();
                GC.SuppressFinalize(this);
                GC.WaitForPendingFinalizers();
                x = e.Location.X;
                y = e.Location.Y;
            }
        }
        private void paint(object sender, PaintEventArgs e)
        {
            Rectangle cerceve = pbzoom.ClientRectangle;
            GraphicsPath gr = new GraphicsPath(FillMode.Alternate);
            gr.AddEllipse(0, 0, pbzoom.Width, pbzoom.Height);       
            Region r = new Region(gr);
            pbzoom.Region = r;
            cerceve.Inflate(4, 4);
            SolidBrush br = new SolidBrush(Color.FromArgb(55, 255, 255, 255));
            Pen eee = new Pen(br, 20);
            //e.Graphics.DrawRectangle(eee, cerceve);
            e.Graphics.DrawEllipse(eee, cerceve);
            cerceve.Inflate(-5, -5);
            Size a = new Size(10, 10);
            //  ControlPaint.DrawGrid(e.Graphics, cerceve, a, Color.White);                                 
            //  Pen pen = new Pen(Color.FromArgb(45,45,45),1.99f);
            //  pen.Alignment = PenAlignment.Inset; //<-- this
            //  e.Graphics.DrawEllipse(pen, cerceve);                  
            SolidBrush MyBrush = new SolidBrush(Color.FromArgb(45, 255, 255, 255));
            // e.Graphics.DrawRectangle(eee, cerceve);        
            e.Graphics.DrawEllipse(eee, cerceve);

        }
    }
}
