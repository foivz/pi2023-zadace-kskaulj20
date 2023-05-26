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
            int id = int.Parse(reader["ID_zahtjev"].ToString());
            DateTime date1 = DateTime.Parse(reader["pocetak_odsustva"].ToString());
            DateTime date2 = DateTime.Parse(reader["zavrsetak_odsustva"].ToString());
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
    }
}
