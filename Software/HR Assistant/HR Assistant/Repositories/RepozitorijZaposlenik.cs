using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HR_Assistant.Repositories
{
    public class RepozitorijZaposlenik
    {

        public static Zaposlenik DohvatiZaposlenika(string email)
        {
            string sql = $"SELECT * FROM Korisnici WHERE Id_Uloga = 1 && email = '{email}'";
            return FetchZaposlenik(sql);
        }

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

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
           
            string email = reader["email"].ToString();
            string lozinka = reader["lozinka"].ToString();
            string uloga = reader["uloga"].ToString();

            var zaposlenik = new Zaposlenik

            {
                
            };
            return zaposlenik;
        }
    }
}
