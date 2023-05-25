using System;
using DBLayer;
using HR_Assistant.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Assistant.Repositories
{
    public class RepozitorijZaposlenik
    {

        public static Zaposlenik DohvatiZaposlenika(string Email, string Lozinka)
        {
            string sql = $"SELECT * FROM Korisnici WHERE  email = '{Email}' AND lozinka = '{Lozinka}' ";
            return FetchZaposlenik(sql);
        }

      /**  public static Zaposlenik UserPrikaz(string Email, string Lozinka)
        {
            string sql = $"SELECT kor_ime FROM Korisnici WHERE email = '{Email}' AND lozinka = '{Lozinka}' ";
            return FetchZaposlenik(sql);
        }**/
       
        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }
        
        public static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
           
            string email = reader["email"].ToString();
            string lozinka = reader["lozinka"].ToString();
            int uloga = int.Parse(reader["uloga"].ToString());

            var zaposlenik = new Zaposlenik

            {
                Id = id, 
                Email = email,
                Lozinka = lozinka,
                Uloga = uloga
                
            };
            return zaposlenik;
        }
    }
}
