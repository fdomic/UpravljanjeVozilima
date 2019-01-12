using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportnaApp.Baza;
using TransportnaApp.Modeli;
using System.Data.SQLite;
using Dapper;

namespace TransportnaApp.Baza
{
    class TablicaNalogZaSluzbenoPutovanje : AbstraktnaTablica
    {
        public static List<NalogZaSluzbenoPutovanje> Dohvati()
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<NalogZaSluzbenoPutovanje>("SELECT * FROM NalogZaSluzbenoPutovanje");
                return rezultati.ToList();
            }
        }

        public static NalogZaSluzbenoPutovanje Dohvati(int pk)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<NalogZaSluzbenoPutovanje>("SELECT * FROM NalogZaSluzbenoPutovanje WHERE id=@pk", new { pk = pk });
                return rezultati.FirstOrDefault();
            }
        }

        public static void Spremi(NalogZaSluzbenoPutovanje v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                string sql = "INSERT INTO NalogZaSluzbenoPutovanje (idNalog,teret,razlog) VALUES (@idNalog,@teret,@razlog)";
                cnn.Execute(sql, v);
            }

        }

        public static void Azuriraj(NalogZaSluzbenoPutovanje v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("UPDATE NalogZaSluzbenoPutovanje SET idNaglo=@idNalog, teret=@teret ,razlog=@razlog WHERE id=@id", v);
            }
        }

        public static void Obrisi(NalogZaSluzbenoPutovanje v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("DELETE FROM NalogZaSluzbenoPutovanje WHERE id=@id", v);
            }
        }
    }
}
