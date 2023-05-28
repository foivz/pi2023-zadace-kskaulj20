using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Assistant.Models
{
    public class Zahtjev
    {

       public int ID_zahtjev { get; set; }
      public  string Pocetak_Odsustva { get; set; }     

       public  string KrajOdsustva { get; set; }

        public int RazlogOdsustva { get; set;   }

       public  string Kreirao { get; set; }
        public int Status { get; set; } 
        public string Komentar { get; set; }

        public override string ToString()
        {
            return ID_zahtjev.ToString();
        }

        public bool Bolovanje(int razlogOdsustva)
        {
            if(razlogOdsustva != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
