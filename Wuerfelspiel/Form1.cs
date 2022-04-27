using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wuerfelspiel;

namespace Wuerfelspiel
{
    public partial class Form1 : Form
    {
        int wZaehler = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wZaehler == 3)
            {
                int wert1 = uc_Wuerfel1.WuerfelWert();
                int wert2 = uc_Wuerfel2.WuerfelWert();
                int wert3 = uc_Wuerfel3.WuerfelWert();
                int wert4 = uc_Wuerfel4.WuerfelWert();
                int wert5 = uc_Wuerfel5.WuerfelWert();

                if (wert1 == wert2 && wert2 == wert3 && wert3 == wert4 && wert4 == wert5)
                {
                    MessageBox.Show("KNIWWEL!!!!!1111!!!!ONE");
                }
                else
                {
                    MessageBox.Show("NOTHING");
                }
                wZaehler = 0;
            }
            else
            {
                uc_Wuerfel1.Wuerfeln();
                Refresh();
                uc_Wuerfel2.Wuerfeln();
                Refresh();
                uc_Wuerfel3.Wuerfeln();
                Refresh();
                uc_Wuerfel4.Wuerfeln();
                Refresh();
                uc_Wuerfel5.Wuerfeln();
                Refresh();
                wZaehler++;
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int wert1 = uc_Wuerfel1.WuerfelWert();
            int wert2 = uc_Wuerfel2.WuerfelWert();
            int wert3 = uc_Wuerfel3.WuerfelWert();
            int wert4 = uc_Wuerfel4.WuerfelWert();
            int wert5 = uc_Wuerfel5.WuerfelWert();

            if (wert1 == wert2 && wert2 == wert3 && wert3 == wert4 && wert4 == wert5)
            {
                MessageBox.Show("KNIWWEL!!!!!1111!!!!ONE");
            }
            else
            {
                MessageBox.Show("WHO TF CARES");
            }
        }
    }
}
