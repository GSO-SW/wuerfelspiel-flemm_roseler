using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class Uc_Wuerfel : UserControl
    {

        int wert = 0;
        Wuerfel w;

        public Uc_Wuerfel()
        {
            InitializeComponent();

            w = new Wuerfel(6);
            wert = w.Wuerfeln();
        }

        private void Uc_Wuerfel_Load(object sender, EventArgs e)
        {
            
        }

        private void Uc_Wuerfel_Paint(object sender, PaintEventArgs e)
        {
            //Hilfsvariablen
            Graphics g = e.Graphics;
            int h = this.Size.Height;
            int w = this.Size.Width;
            int zaehler = 0;
            Brush b = new SolidBrush(Color.HotPink);
            Pen p = new Pen(Color.Black);
            Size s = new Size(w - 1, h - 1);
            
            //Punkte für Würfel
            Point topLeft = new Point(0, 0);
            

            //Rectangles
            Rectangle wuerfel = new Rectangle(topLeft, s);
            Rectangle[] augen = new Rectangle[9];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    int aw = w / 3 * x;
                    int ah = h / 3 * y;
                    augen[zaehler] = new Rectangle(aw, ah, w / 3, h / 3);
                    zaehler++;
                }
            }

            if(wert == 1)
            {
                g.FillEllipse(b, augen[4]);
            }
            else if (wert == 2)
            {
                g.FillEllipse(b, augen[0]);
                g.FillEllipse(b, augen[8]);
            }
            else if (wert == 3)
            {
                g.FillEllipse(b, augen[0]);
                g.FillEllipse(b, augen[4]);
                g.FillEllipse(b, augen[8]);
            }
            else if (wert == 4)
            {
                g.FillEllipse(b, augen[0]);
                g.FillEllipse(b, augen[2]);
                g.FillEllipse(b, augen[6]);
                g.FillEllipse(b, augen[8]);
            }
            else if (wert == 5)
            {
                g.FillEllipse(b, augen[0]);
                g.FillEllipse(b, augen[2]);
                g.FillEllipse(b, augen[4]);
                g.FillEllipse(b, augen[6]);
                g.FillEllipse(b, augen[8]);
            }
            else if (wert == 6)
            {
                g.FillEllipse(b, augen[0]);
                g.FillEllipse(b, augen[1]);
                g.FillEllipse(b, augen[2]);
                g.FillEllipse(b, augen[6]);
                g.FillEllipse(b, augen[7]);
                g.FillEllipse(b, augen[8]);
            }
            //foreach (Rectangle r in augen)
            //{
            //    g.FillEllipse(b, r);
            //}

            g.DrawRectangle(p, wuerfel);
        }

        private void Uc_Wuerfel_Click(object sender, EventArgs e)
        {
            w.SicherungUmschalten();
        }

        private void Uc_Wuerfel_DoubleClick(object sender, EventArgs e)
        {
            wert = w.Wuerfeln();
            Refresh();
        }
    }
}
