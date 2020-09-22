using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tatil_Firsati_v1;
namespace Tatil_Firsati_v1._00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnkullanici_Click(object sender, EventArgs e)
        {
            FırsatBul fırsatform = new FırsatBul();
            fırsatform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?","?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(message == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnkullanici_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Location = new Point(((Button)sender).Location.X, ((Button)sender).Location.Y+2);           
        }
        private void btnkullanici_MouseLeave(object sender, EventArgs e)
        {
           ((Button)sender).Location = new Point(((Button)sender).Location.X , (((Button)sender).Location.Y-2));
        }     
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Transparent;
        }
        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminLogin adm = new AdminLogin();
            adm.Show();
            this.Hide();
        }
    }
}
