using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Firsati_v1._00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool acikmi = false;
            Mutex mtex = new Mutex(true, "Programim", out acikmi);            
            if (acikmi)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }       
            else
            {
                MessageBox.Show("Program Zaten Açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            
        }
    }
}
