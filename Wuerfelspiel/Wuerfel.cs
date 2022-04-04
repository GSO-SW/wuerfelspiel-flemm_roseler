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
<<<<<<< HEAD
        private int letztesErgebnis;
        private bool gesichert;

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;

            letztesErgebnis = -1;
            gesichert = false;
=======
        private Random rdm;
        public Wuerfel(int anzahlSeiten, Random rdm)
        {
            this.anzahlSeiten = anzahlSeiten;
            this.rdm = rdm;
>>>>>>> a9ee767114b531e19f307c0c16099efc763592aa
        }

        public int AnzahlSeiten
        {
<<<<<<< HEAD
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
=======
            get
            {
                return anzahlSeiten;
            }
        }

        public Random Rdm
        {
            get
            {
                return rdm;
>>>>>>> a9ee767114b531e19f307c0c16099efc763592aa
            }
        }
    }
}
