using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportnaApp.Modeli
{
    public class Zaposlenik
    {

        public int id { get; set; }

        public string ime { get; set; }

        public string prezime { get; set; }

        public string user { get; set; }

        public string pass { get; set; }

        public string oib { get; set; }

        public double datumRod { get; set; }

        public int tipFK { get; set; }

        public string puniNaziv
        {
            get
            {
                return this.ime + " " + this.prezime;
            }
        }
    }
}
