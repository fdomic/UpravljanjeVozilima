using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TransportnaApp.Modeli;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace TransportnaApp.Baza
{
    public class TablicaZaposlenika : AbstraktnaTablica
    {
        public static List<Zaposlenik> Dohvati()
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<Zaposlenik>("SELECT * FROM Zaposlenici");
                return rezultati.ToList();
            }
        }

        public static Zaposlenik Dohvati(int pk)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<Zaposlenik>("SELECT * FROM Zaposlenici WHERE id=@pk", new { pk = pk });
                return rezultati.FirstOrDefault();
            }
        }

        public static Zaposlenik Dohvati(string user ,string pass)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<Zaposlenik>("SELECT * FROM Zaposlenici WHERE user=@user AND pass=@pass ", new { user=user , pass=pass });
                return rezultati.FirstOrDefault();
            }
        }

        public static void Spremi(Zaposlenik v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("INSERT INTO Zaposlenici (ime,prezime,oib,datumRod,tipFK) VALUES (@ime,@prezime,@oib,@datumRod,@tipFK)", v);//KADA ZA OIB NAPISEMO NULL SRUSI SE!!!
            }

        }

        public static void Azuriraj(Zaposlenik v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("UPDATE Zaposlenici SET ime=@ime, prezime=@prezime, oib=@oib, datumRod=@datumRod, tipFK=@tipFK WHERE id=@id", v);//KADA ZA OIB NAPISEMO NULL SRUSI SE!!!
            }
        }

        public static void Obrisi(Zaposlenik v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("DELETE FROM Zaposlenici WHERE id=@id", v);
            }
        }
    }
}
