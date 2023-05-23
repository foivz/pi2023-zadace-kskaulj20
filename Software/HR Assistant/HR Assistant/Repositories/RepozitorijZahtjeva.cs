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

                string sql = $"SELECT * FROM Zahtjev";
            //DB.SetConfiguration("31.147.204.119\\PISERVER,1433", "kskaulj20", "t&FRW]B1");
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

        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_zahtjev"].ToString());
            DateTime date1 = DateTime.Parse(reader["pocetak_odsustva"].ToString());
            DateTime date2 = DateTime.Parse(reader["zavrsetak_odsustva"].ToString());
            int razlog = int.Parse(reader["Id_vrsza"].ToString());
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
