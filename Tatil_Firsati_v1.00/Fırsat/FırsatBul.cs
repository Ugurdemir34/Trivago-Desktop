using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Tulpep.NotificationWindow;
namespace Tatil_Firsati_v1._00
{
    public partial class FırsatBul : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private HashSet<Control> controlsToMove = new HashSet<Control>();
        public FırsatBul()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            controlsToMove.Clear();
            Application.AddMessageFilter(this);
            controlsToMove.Add(panel1);
            çıkışToolStripMenuItem.Click += btnkapat_Click;            
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN && controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }
        string yildiz;
        string otelsirala;
        static string sehir;
        string fiyat;
        string merkez;
        string wifi;
        string havuz;
        string kahvalti;
        public int otel_id;       
        string s;
        public static string sehiradi;
        OleDbDataAdapter adp;
        public static OleDbCommand cmd;        
        public string GENELSORGU(string sehir,string yildiz, string fiyat, string merkez, string wifi, string havuz, string kahvalti,string otelsirala)
        {        
            s = "SELECT * FROM SEHIR INNER JOIN OTEL ON SEHIR.Sehir_ID = OTEL.Sehir_ID WHERE " + sehir + yildiz + fiyat + merkez + wifi + havuz + kahvalti + otelsirala;
            return s.ToString();
        }
        public void ResimGetir(string hoteladi,PictureBox p)
        {            
                p.ImageLocation = "Resimler\\" + hoteladi + "0.jpeg";                    
        }
        DataRow dr;
        public void sorguyerleştir()
        {          
            adp = new OleDbDataAdapter(GENELSORGU(sehir, yildiz, fiyat, merkez, wifi, havuz,kahvalti,otelsirala),bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);           
            flowLayoutPanel1.Controls.Clear();        
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                dr = tablo.Rows[i];
                my = new MyOtel();
                my.Name  = dr["Otel_Ad"].ToString();
                my.Controls["btnGoster"].Name = dr["Otel_ID"].ToString();
                my.Controls["lblOtelAdi"].Text = dr["Otel_Ad"].ToString();
                my.Controls["pbresim"].BackgroundImage = Properties.Resources.mylogo;           
                my.Controls["lbladres"].Text = dr["Acik_Adres"].ToString();
                my.Controls["lblfiyat"].Text = dr["Fiyat"].ToString() + " ₺";
                my.Controls["lbloy"].Text = "Değerlendirme : " + dr["Oy"].ToString();
                PictureBox pb = (PictureBox)my.Controls["pbyildiz"];
                pb.ImageLocation = "YildizResim\\"+dr["Yildiz_Sayisi"]+".png";            
                otel_id = Convert.ToInt16(dr["Otel_ID"]);
                my.degerdurum(my.lbldeger, my.lbloy, Convert.ToInt16(dr["Oy"]));
                ResimGetir(dr["Otel_Ad"].ToString(), (PictureBox)my.Controls["pbresim"]);
                flowLayoutPanel1.Controls.Add(my);               
            }          
            GC.Collect();
            GC.WaitForPendingFinalizers();
            tablo.Dispose();
            tablo = null;         
            adp.Dispose();
            adp = null;
        }       
        MyOtel my;       
        public static OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Trivago.accdb");
        Random a = new Random();
        void firsatbul()
        {
            try
            {
                OleDbDataAdapter adptr = new OleDbDataAdapter("SELECT TOP 1 * FROM FIRSAT INNER JOIN OTEL ON FIRSAT.Otel_ID = OTEL.Otel_ID ORDER BY RND()", FırsatBul.bag);
                DataTable tb = new DataTable();
                adptr.Fill(tb);
                DataRow roww = tb.Rows[0];
                string yol = "Resimler\\" + roww["Otel_Ad"] + "0.jpeg";
                Bitmap bm = new Bitmap(yol);
                PopupNotifier p = new PopupNotifier();
                p.TitleFont = new Font("Century Gothic", 12, FontStyle.Bold);                
                p.Click += P_Click;
                p.ContentHoverColor = Color.Red;
                p.Delay = 10000;
                p.TitleColor = Color.FromArgb(36, 36, 36);
                p.TitleText = "\t       Tatil Fırsatı\n" + roww["Otel_Ad"].ToString() + "\n";
                p.BodyColor = Color.White;
                p.ContentText = "\n\n" + roww["Acik_Adres"].ToString();
                p.Image = bm;
                p.ImageSize = new Size(90, 90);
                p.Popup();
                ad = roww["Otel_Ad"].ToString();
                adptr.Dispose();
                tb.Dispose();
                
            }
            catch
            {           
            }
        }
        string ad;
        private void P_Click(object sender, EventArgs e)
        {
            ((PopupNotifier)sender).Hide();
            flowLayoutPanel1.Controls.Clear();
            adp = new OleDbDataAdapter("SELECT * FROM FIRSAT INNER JOIN OTEL ON FIRSAT.Otel_ID = OTEL.Otel_ID WHERE Otel_Ad ='" +ad + "'", FırsatBul.bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dr = tablo.Rows[0];
            my = new MyOtel();
            my.Name = dr["Otel_Ad"].ToString();
            my.Controls["lbleski"].Visible = true;
            my.Controls["lbleski"].Text = dr["Eski_Fiyat"].ToString() + " ₺";
            my.Controls["lblyuzde"].Visible = true;          
            int yuzde = 100-Convert.ToInt16(Convert.ToDouble(dr["Yeni_Fiyat"]) / ((Convert.ToDouble(dr["Eski_Fiyat"]) / 100)));
            my.Controls["lblyuzde"].Text ="- % "+ yuzde.ToString();
            my.Controls["btnGoster"].Name = dr["OTEL.Otel_ID"].ToString();
            my.Controls["lblOtelAdi"].Text = dr["Otel_Ad"].ToString();
            my.Controls["pbresim"].BackgroundImage = Properties.Resources.mylogo;
            my.Controls["lbladres"].Text = dr["Acik_Adres"].ToString();
            my.Controls["lblfiyat"].Text = dr["Yeni_Fiyat"].ToString() + " ₺";          
            PictureBox yldzresim = (PictureBox)my.Controls["pbyildiz"];
            yldzresim.ImageLocation = "YildizResim\\" + dr["Yildiz_Sayisi"] + ".png";
           // PictureBox otelresim = (PictureBox)my.Controls["pbresim"];            
            my.degerdurum(my.lbldeger, my.lbloy, Convert.ToInt16(dr["Oy"]));
            ResimGetir(dr["Otel_Ad"].ToString(), (PictureBox)my.Controls["pbresim"]);
            flowLayoutPanel1.Controls.Add(my);          
        }
        private void FırsatBul_Load(object sender, EventArgs e)
        {
            firsatbul();      
             txtSehir.AppendText("Şehir Giriniz...");
            this.ActiveControl = btnbul;                       
        }      
        private void txtSehir_MouseClick(object sender, MouseEventArgs e)
        {
            txtSehir.Text = null;
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.Show();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.SuppressFinalize(this);
                
                       
                this.Dispose();                                          
            }                   
        }
        private void btnkucuk_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }  
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Maks. " + tbfiyat.Value+" TL";          
        }  
        void clearlayout()
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.Dispose();            
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }        
        private void btnbul_Click(object sender, EventArgs e)
        {
            clearlayout();
            panel2.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            sehiradi = "" + txtSehir.Text;      
            sehir = " SEHIR.Sehir_Ad ='" + txtSehir.Text + "'";
            sorguyerleştir();
            groupBox1.Enabled = true;
            cbfiltre.Visible = true;                    
        }               
     
        private void chmerkez_CheckedChanged(object sender, EventArgs e)
        {
            if (chmerkez.Checked)
            {
               merkez = " AND Merkez  = true";              
            }  
            else
            {
                merkez = null;               
            }
            sorguyerleştir();
        }
        private void chwifi_CheckedChanged(object sender, EventArgs e)
        {
            if(chwifi.Checked)
            {
               wifi = " AND WiFi = true";              
            }
            else
            {
                wifi = null;              
            }
            sorguyerleştir();
        }
        private void chhavuz_CheckedChanged(object sender, EventArgs e)
        {
            if (chhavuz.Checked)
            {
                havuz = " AND Havuz = true";              
            }
            else
            {
                havuz = null;               
            }
            sorguyerleştir();
        }
        private void tbfiyat_MouseUp(object sender, MouseEventArgs e)
        {
            fiyat = " AND fiyat Between 50 AND " + tbfiyat.Value + "";
            sorguyerleştir();
        }                     
        private void btnbul_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Color.WhiteSmoke;
            ((Button)sender).ForeColor = Color.WhiteSmoke;
        }
        private void btnbul_MouseLeave(object sender, EventArgs e)
        {
           ((Button)sender).FlatAppearance.BorderColor = Color.FromArgb(36, 36, 36);
            ((Button)sender).ForeColor = Color.FromArgb(36,36,36) ;        
        }
        private void cbfiltre_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (cbfiltre.SelectedIndex == 0)
            {
              /*var panel = flowLayoutPanel1.Controls.OfType<MyOtel>().OrderBy(w => w.Name);
                foreach (var item in panel)
                {
                    var asd = item.Controls.OfType<Label>().Where(w => w.Name.Contains("lbloteladi")).OrderBy(w => w.Text);
                    foreach (var item2 in asd)
                    {
                        flowLayoutPanel1.Controls.SetChildIndex(item, asd.ToString().IndexOf(item2.ToString()));
                    }
                }*/
                otelsirala = " ORDER BY Otel_Ad";   
            }
            else if (cbfiltre.SelectedIndex == 1)
            {
                otelsirala = " ORDER BY Fiyat";              
            }
            else
            {
                otelsirala = " ORDER BY Oy DESC";             
            }
            sorguyerleştir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yildiz = null;
            merkez = null;
            havuz = null;
            wifi = null;
            sorguyerleştir();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(FontFamily.GenericSansSerif, 10);
            button1.Location = new Point(button1.Location.X+2,button1.Location.Y);
            button1.ForeColor = Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(FontFamily.GenericSansSerif, 9);
            button1.Location = new Point(button1.Location.X - 2, button1.Location.Y );
            button1.ForeColor = Color.Black;
        }
        private void chkahvalti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkahvalti.Checked)
            {
                kahvalti = " AND Kahvalti = true ";             
            }
            else
            {
                kahvalti = null;               
            }
            sorguyerleştir();
        }
        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            Fırsat.YakinOtel ykn = new Fırsat.YakinOtel();
           
            flowLayoutPanel1.Controls.Add(ykn);
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            yildiz = " AND Yildiz_Sayisi = " + bunifuRating1.Value + "";
            sorguyerleştir();
        }
    }
}
