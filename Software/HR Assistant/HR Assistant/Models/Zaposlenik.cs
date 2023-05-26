using HR_Assistant.Models;
using HR_Assistant.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HR_Assistant
{
    public class Zaposlenik : Korisnik
    {
        
       
        public override string ToString()
        {
            return Kor_ime;
        }

        public void OdobriZahtjev(Zahtjev odabranZahtjev)
        {
            RepozitorijZahtjeva.OdobrenjeZahtjeva(odabranZahtjev);
        }
    }
}

