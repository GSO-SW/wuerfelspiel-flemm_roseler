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
        private Random rdm;
        public Wuerfel(int anzahlSeiten, Random rdm)
        {
            this.anzahlSeiten = anzahlSeiten;
            this.rdm = rdm;
        }

        public int AnzahlSeiten
        {
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
            }
        }
    }
}
