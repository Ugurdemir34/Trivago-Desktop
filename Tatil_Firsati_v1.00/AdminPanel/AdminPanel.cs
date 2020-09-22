using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Firsati_v1._00
{
    public partial class AdminPanel : Form
    { 
        public AdminPanel()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
          
        }    
        bool btndurum = true;
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font("Century Gothic", 12, FontStyle.Bold);                   
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font("Century Gothic", 11, FontStyle.Bold);                        
        }
        DialogResult a;
        private void button1_Click(object sender, EventArgs e)
        {
            a = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                frm1.Show();
                this.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.SuppressFinalize(this);              
            }
        }
        void menuoynat()
        {
            if (btndurum)
            {
                panel1.BackColor = Color.FromArgb(253, 197, 0);

                
                //panel1.Size = new Size(59, 485);
                bunifuTransition1.Hide(panel3);
                pictureBox3.Visible = true;

             
                foreach (Control item in pnlsol.Controls)
                {
                    foreach (Control a in item.Controls)
                    {
                        if (a is Label)
                        {
                            a.Visible = false;
                        }
                    }
                }
                btndurum = false;
                // panel1.Size = new Size(59, 485);
             
               
            }
            else
            {
                panel1.Size = new Size(196, 600);

                pictureBox3.Visible = false;
                panel1.BackColor = Color.FromArgb(253, 197, 0);
                foreach (Control item in pnlsol.Controls)
                {
                    foreach (Control a in item.Controls)
                    {
                        if (a is Label)
                        {
                            a.Visible = true;
                        }
                    }
                }
                btndurum = true;
                bunifuTransition1.Show(panel3);

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuoynat();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OtelGuncelle a = new OtelGuncelle();
            panel2.Controls.Add(a);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OtelEkle a = new OtelEkle();
            panel2.Controls.Add(a);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            YorumDuzenle a = new YorumDuzenle();
            panel2.Controls.Add(a);
        }    
        private void label4_Click(object sender, EventArgs e)
        {
            Rapor rp = new Rapor();
            rp.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FirsatSil fr = new _00.FirsatSil();
            panel2.Controls.Add(fr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.Show(panel1);
        }

        private void bunifuTransition1_AnimationCompleted(object sender, BunifuAnimatorNS.AnimationCompletedEventArg e)
        {
            if(!btndurum)
            {
                panel1.BackColor = Color.Transparent;
            }
           
        }
    }
}
