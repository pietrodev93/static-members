using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        class Punti
        {
            static int numeroPunti = 0;

            public static void SituazionePunti()
            {
                MessageBox.Show("Hai accumulato: " + numeroPunti.ToString());
            }

            public Punti()
            {
                ++numeroPunti;
            }

            public static void ResetContuer()
            {
                numeroPunti = 0;
                MessageBox.Show(numeroPunti.ToString());
            }
        }


       
        private void button1_Click(object sender, EventArgs e)
        {

            Punti p1, p2, p3;

            Punti.SituazionePunti();
            p1 = new Punti();
            Punti.SituazionePunti();

            p2 = new Punti();
            Punti.SituazionePunti();

            
            Punti.ResetContuer();

        }

 
    }
}
