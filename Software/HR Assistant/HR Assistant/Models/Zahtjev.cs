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
      public  DateTime Pocetak_Odsustva { get; set; }     

       public  DateTime KrajOdsustva { get; set; }

        public int RazlogOdsustva { get; set;   }

       public  string Kreirao { get; set; }
        public int Status { get; set; } 
        public string Komentar { get; set; }

        public override string ToString()
        {
            return ID_zahtjev.ToString();
        }

    }
}
