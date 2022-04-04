using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErgebnis;
        private bool gesichert;

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
    }
}
