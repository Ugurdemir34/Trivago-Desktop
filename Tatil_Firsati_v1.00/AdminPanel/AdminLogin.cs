using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Firsati_v1._00
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
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
        private void btnalt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "ur" && textBox2.Text.Trim() == "ur")
            {
                AdminPanel admn = new AdminPanel();
                admn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
