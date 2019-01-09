using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportnaApp.Baza;
using TransportnaApp.Utils;

namespace TransportnaApp.Modeli
{
    public class DodjelaVozila
    {
        public int id { get; set; }

        public int idVozilo { get; set; }

        public int idZaposlenik { get; set; }

        public string naziv { get; set; }

        public string mjestoPreuzimanja { get; set; }

        public double datumPreuzimanja { get; set; }

        public string mjestoDostave { get; set; }

        public double datumDostave { get; set; }

        public string nazivVozila
        {
            get
            {
                Vozilo v = TablicaVozila.Dohvati(this.idVozilo);
                return v.registracija;
            }
        }

        public string nazivZaposlenik
        {
            get
            {
                Zaposlenik v = TablicaZaposlenika.Dohvati(this.idZaposlenik);
                return v.puniNaziv;
            }
        }

        public string datumPreuzimanjaEkran
        {
            get
            {
                return Util.PretvoriTmestampUdatum(this.datumPreuzimanja).ToString("dd.MM.yyyy.");
            }
        }

        public string datumDostaveEkran
        {
            get
            {
                return Util.PretvoriTmestampUdatum(this.datumDostave).ToString("dd.MM.yyyy.");
            }
        }

    }
}
