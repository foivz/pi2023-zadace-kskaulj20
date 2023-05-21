using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Assistant.Models
{
    public class Zahtjev
    {

        int ID_zahtjev { get; set; }
        DateTime Pocetak_Odsustva { get; set; }     

        DateTime KrajOdsustva { get; set; }

         string RazlogOdsustva { get; set;   }

         Zaposlenik Kreirao { get; set; }

    }
}
