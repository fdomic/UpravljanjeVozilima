using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportnaApp.Modeli;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace TransportnaApp.Baza
{
    class TablicaDodjeljenaVozila : AbstraktnaTablica
    {
        public static List<DodjelaVozila> Dohvati()
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<DodjelaVozila>("SELECT * FROM Nalozi");
                return rezultati.ToList();
            }
        }

        public static DodjelaVozila Dohvati(int pk)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<DodjelaVozila>("SELECT * FROM Nalozi WHERE id=@pk", new { pk = pk });
                return rezultati.FirstOrDefault();
            }
        }

        public static List<DodjelaVozila> DohvatiPoKorisniku(int zaposlenikId)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                var rezultati = cnn.Query<DodjelaVozila>("SELECT * FROM Nalozi WHERE idZaposlenik=@pk", new { pk = zaposlenikId });
                return rezultati.ToList();
            }
        }

        public static void Spremi(DodjelaVozila v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("INSERT INTO Nalozi ( idVozilo, idZaposlenik, naziv, mjestoPreuzimanja, datumPreuzimanja, mjestoDostave,  datumDostave ) VALUES (@idVozilo, @idZaposlenik, @naziv, @mjestoPreuzimanja, @datumPreuzimanja, @mjestoDostave,  @datumDostave)", v);
            }
        }

        public static void Azuriraj(DodjelaVozila v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("UPDATE Nalozi SET idVozilo=@idVozilo, idZaposlenik=@idZaposlenik, naziv=@naziv, mjestoPreuzimanja=@mjestoPreuzimanja, datumPreuzimanja=@datumPreuzimanja, mjestoDostave=@mjestoDostave,  datumDostave=@datumDostave WHERE id=@id", v);
            }
        }

        public static void Obrisi(DodjelaVozila v)
        {
            using (IDbConnection cnn = new SQLiteConnection(Konfiguracija()))
            {
                cnn.Execute("DELETE FROM Nalozi WHERE id=@id", v);
            }
        }
    }
}

