using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using HR_Assistant.Models;

namespace HR_Assistant.Repositories
{
    public class RepozitorijZahtjeva
    {
        /// <summary>
        /// Metoda koja dohvaća sve neobrađene zahtjeve iz baze podataka.
        /// </summary>
        
            public static List<Zahtjev> GetZahtjevi()
            {
                var zahtjevi = new List<Zahtjev>();

                string sql = $"SELECT * FROM Zahtjev WHERE Id_status=1";
            
            DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Zahtjev zahtjev = CreateObject(reader);
                    zahtjevi.Add(zahtjev);
                }
                reader.Close();
                DB.CloseConnection();
                return zahtjevi;
            }

        /// <summary>
        /// Metoda koja dohvaća sve obrađene zahtjeve iz baze podataka tako da provjerava koji im je status.
        /// </summary>
        /// <returns></returns>
        
            public static List<Zahtjev> GetObradeniZahtjevi()
            {
                var obradeni_zahtjevi = new List<Zahtjev>();

                string sql = $"SELECT * FROM Zahtjev WHERE Id_status !=1 ";
                
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Zahtjev obradeni_zahtjev = CreateObject(reader);
                    obradeni_zahtjevi.Add(obradeni_zahtjev);
                }
                reader.Close();
                DB.CloseConnection();
                return obradeni_zahtjevi;
            }
        /// <summary>
        /// Metoda koja dohvaća zahtjeve kreirane od strane korisnika koji je ulogiran u sustav.
        /// </summary>
        /// <returns></returns>
        public static List<Zahtjev> GetPoslaniZahtjevi()
        {
            var poslani_zahtjevi = new List<Zahtjev>();

            string sql = $"SELECT * FROM Zahtjev WHERE Id_korisnik = 3";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev poslani_zahtjev = CreateObject(reader);
                poslani_zahtjevi.Add(poslani_zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return poslani_zahtjevi;
        }

        /// <summary>
        /// Dohvaća vrste odsustava kako bi se oni prikazali u comboboxu.
        /// </summary>
        
        public static List<Zahtjev> VrsteOdsustva()
        {
            var vrste = new List<Zahtjev>();
            string sql = $"SELECT * FROM VrstaOdsustva";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev vrsta = CreateObject(reader);
                vrste.Add(vrsta);
            }
            reader.Close();
            DB.CloseConnection();
            return vrste;

        }

        public static void OdobrenjeZahtjeva(Zahtjev odabraniZahtjev)
        {
            string sql = $"UPDATE Zahtjev " + $"SET Id_status = 3 WHERE Id_zahtjev = {odabraniZahtjev.ID_zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }

        public static void OdbijanjeZahtjeva(Zahtjev odabrani_zahtjev)
        {
            string sql = $"UPDATE Zahtjev SET Id_status = 2 WHERE Id_zahtjev = {odabrani_zahtjev.ID_zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }



        public static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_zahtjev"].ToString());
            string date1 = (reader["pocetak_odsustva"].ToString());
            string date2 = (reader["zavrsetak_odsustva"].ToString());
            int razlog = int.Parse(reader["Id_vrsta"].ToString());
            string kreirao = (reader["Id_korisnik"].ToString());
            int status = int.Parse(reader["Id_status"].ToString());
            string komentar = (reader["komentar"].ToString());

            var zahtjev = new Zahtjev
            {
                ID_zahtjev = id,
                Pocetak_Odsustva = date1,
                KrajOdsustva = date2,
                RazlogOdsustva = razlog,
                Kreirao = kreirao,
                Status = status,
                Komentar = komentar
        };
          return zahtjev;
            

          
        }

        /// <summary>
        /// Implementirana je kako bi se omogućilo pretraživanje zahtjeva po ID-u.
        /// </summary>
        /// <param name="Id_zahtjev"></param>
      
        public static List<Zahtjev> DohvatiTrazeniZahtjev (int Id_zahtjev){
            string sql = $"SELECT * FROM Zahtjev WHERE Id_zahtjev={Id_zahtjev}";
            List<Zahtjev> trazeniZahtjevi = new List<Zahtjev> ();
            DB.OpenConnection();
            var reader = DB.GetDataReader (sql);
            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject (reader);
                trazeniZahtjevi.Add (zahtjev);
            }

            reader.Close ();
            DB.CloseConnection();
            return trazeniZahtjevi; 
        }

        
        public void DodajZahtjev(Zahtjev zahtjev, Korisnik korisnik)
        {
            string sql = $"INSERT INTO Zahtjev (Id_zahtjev, pocetak_odsustva, zavrsetak_odsustva, komentar, Id_korisnik, Id_vrsta, Id_status) VALUES ('{zahtjev.ID_zahtjev}', '{ zahtjev.Pocetak_Odsustva}', '{ zahtjev.KrajOdsustva}', '{ zahtjev.Komentar}', '{ korisnik.Id}', '{ zahtjev.RazlogOdsustva}', '{ zahtjev.Status}')";
            //cmd.Parameters.AddWithValue("@value", dateTimeVariable);
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void ObrisiZahtjev(int id_zahtjev)
        {
            string sql = $"DELETE FROM Zahtjev WHERE Id_zahtjev = {id_zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            
        }
    }
}
