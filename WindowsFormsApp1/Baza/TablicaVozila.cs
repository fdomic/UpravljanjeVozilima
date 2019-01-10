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
    public class TablicaVozila : AbstraktnaTablica
    {
        public static List<Vozilo> Dohvati()
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<Vozilo>("SELECT * FROM Vozila");
                return rezultati.ToList();
            }
        }

        public static Vozilo Dohvati(int pk)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<Vozilo>("SELECT * FROM Vozila WHERE id=@pk", new {pk = pk});
                return rezultati.FirstOrDefault();
            }
        }
        
        public static void Spremi(Vozilo v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("INSERT INTO Vozila (marka,tip,registracija) VALUES (@marka,@tip,@registracija)", v);
            }

        }

        public static void Azuriraj(Vozilo v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("UPDATE Vozila SET marka=@marka, tip=@tip ,registracija=@registracija WHERE id=@id", v);
            }
        }

        public static List<Vozilo> DohvatiSlobodnaVozila(double v1)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {


                string sql = "";
                sql += "SELECT * FROM Vozila LEFT JOIN Nalozi ON Vozila.id = Nalozi.idVozilo WHERE ";
                sql += "Nalozi.datumPreuzimanja IS NULL OR ";
                sql += "(" + v1 + " < Nalozi.datumPreuzimanja or " + v1 + " > Nalozi.datumDostave)";


                var rezultati = cnn.Query<Vozilo>(sql);
                return rezultati.ToList();
            }
        }

        public static List<Vozilo> DohvatiSlobodne(double v1 ,double v2)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                string sql = "";
                sql += "SELECT * FROM Vozila LEFT JOIN Nalozi ON Vozila.id = Nalozi.idVozilo WHERE ";
                sql += "Nalozi.datumPreuzimanja IS NULL OR ";
                sql += "((" + v1 + " < Nalozi.datumPreuzimanja or " + v1 + " > Nalozi.datumDostave) AND ";
                sql += "( " + v2 + " < Nalozi.datumPreuzimanja or " + v2 + " > Nalozi.datumDostave))";

                var rezultati = cnn.Query<Vozilo>(sql);
                return rezultati.ToList();
            }
        }

        public static void Obrisi(Vozilo v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("DELETE FROM Vozila WHERE id=@id", v);
            }
        }
    }
}
