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
using System.Threading;

namespace Tatil_Firsati_v1._00
{
    public partial class YorumDuzenle : UserControl
    {
        public YorumDuzenle()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        void yorumgetir()
        {
            try
            {
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM YORUM WHERE Otel_ID = " + comboBox2.SelectedValue, FırsatBul.bag);
                DataTable tablo = new DataTable();
                adp.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata : " + hata.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            button1.Enabled = false;
            label3.Text = "Yükleniyor";
            Thread.Sleep(500);
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM OTEL WHERE Sehir_ID =" + (comboBox1.SelectedIndex + 1), FırsatBul.bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            comboBox2.DataSource = tablo;
            comboBox2.DisplayMember = "Otel_Ad";
            comboBox2.ValueMember = "Otel_ID";
            comboBox2.Enabled = true;
         
         
         
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label3.Text = "Yüklendi";
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yorumgetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            if(e.ColumnIndex == 6)
            {
                DialogResult a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    FırsatBul.bag.Open();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM YORUM Where Yorum_ID = " + dataGridView1.Rows[secili].Cells[0].Value + " AND Otel_ID = "+comboBox2.SelectedValue,FırsatBul.bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Silindi !");
                    FırsatBul.bag.Close();
                    yorumgetir();
                }
              
            }
        }
    }
}
