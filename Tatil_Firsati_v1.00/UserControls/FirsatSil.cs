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
namespace Tatil_Firsati_v1._00
{
    public partial class FirsatSil : UserControl
    {
        public FirsatSil()
        {
            InitializeComponent();
        }
        void getir()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM FirsatBilgileri",FırsatBul.bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void FirsatSil_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DialogResult a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    FırsatBul.bag.Open();
                    OleDbCommand kmd = new OleDbCommand("DELETE FROM FIRSAT WHERE Firsat_ID =@Otel_ID", FırsatBul.bag);
                    kmd.Parameters.AddWithValue("@Otel_ID", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    kmd.ExecuteNonQuery();
                    FırsatBul.bag.Close();
                    MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
                    getir();
                }
            }
           
            
        }
    }
}
