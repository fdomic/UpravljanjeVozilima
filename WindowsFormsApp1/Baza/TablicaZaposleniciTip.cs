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
    class TablicaZaposleniciTip : AbstraktnaTablica
    {

        public static List<ZaposlenikTip> Dohvati()
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<ZaposlenikTip>("SELECT * FROM ZaposleniciTip");
                return rezultati.ToList();
            }
        }

        public static ZaposlenikTip Dohvati(int pk)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<ZaposlenikTip>("SELECT * FROM ZaposleniciTip WHERE id=@pk", new { pk = pk });
                return rezultati.FirstOrDefault();
            }
        }

        public static void Spremi(ZaposlenikTip v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("INSERT INTO Vozila (naziv) VALUES (@naziv)", v);
            }

        }

        public static void Azuriraj(ZaposlenikTip v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("UPDATE ZaposleniciTip SET naziv=@naziv WHERE id=@id", v);
            }
        }

        public static void Obrisi(ZaposlenikTip v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("DELETE FROM ZaposleniciTip WHERE id=@id", v);
            }
        }

    }
}
