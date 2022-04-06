using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErgebnis;
        private bool gesichert;
        Random rnd = new Random();

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;

            letztesErgebnis = -1;
            gesichert = false;
        }

        public int AnzahlSeiten
        {
            get 
            { 
                return anzahlSeiten; 
            }
        }

        public int LetztesErgebnis
        {
            get
            {
                return letztesErgebnis;
            }
        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }
        }

        public void SicherungUmschalten()
        {
            gesichert = !gesichert;
        }

        public int Wuerfeln()
        {
            letztesErgebnis = rnd.Next(1, AnzahlSeiten + 1);
            return letztesErgebnis;
        }
    }
}
