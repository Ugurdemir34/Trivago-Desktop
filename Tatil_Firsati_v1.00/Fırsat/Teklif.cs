using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography;
namespace Tatil_Firsati_v1._00
{
    public partial class Teklif : Form
    {
        public Teklif()
        {
            InitializeComponent();
        }
        public static string sifrele(string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();


            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public string adres;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Trim() == "" || textBox3.Text == "")
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Doldurunuz !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Match oku = regex.Match(textBox3.Text);
                if(!oku.Success)
                {
                    MessageBox.Show("Geçerli Bir Mail Adresi Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new NetworkCredential("yazilimisi@gmail.com", "Ue19982017");
                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        MailMessage ePosta = new MailMessage();
                        ePosta.From = new MailAddress("yazilimisi@gmail.com");
                        ePosta.To.Add(textBox3.Text);
                        ePosta.Subject = "Teklif";
                        ePosta.IsBodyHtml = true;
                        ePosta.Body = "Sayın " + textBox2.Text + ",<br>" + textBox1.Text + " adlı otelden <font color = 'blue' ><b>" + sifrele(textBox1.Text) + "</b></font> Referans kodu ile %5 lik indirim fırsatını kaçırmayın.<br>Otele aşağıdaki adresten ulaşabilirsiniz.<br>" +adres + "<br><br><a href = 'http://yazilimisi.com'>Sitemiz</a>";                       
                        object userState = ePosta;
                        smtp.SendAsync(ePosta, (object)ePosta);
                        MessageBox.Show("İndirim Kuponunuza Mail Adresinizden Ulaşabilirsiniz...", "Kupon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();            
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bir Hata Meydana Geldi : " + hata.Message);
                    }
                  
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
