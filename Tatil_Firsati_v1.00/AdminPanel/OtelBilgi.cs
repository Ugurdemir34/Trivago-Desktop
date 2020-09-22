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
    public partial class OtelBilgi : Form
    {
        public OtelBilgi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(this);
            this.Close();
        }
    }
}
