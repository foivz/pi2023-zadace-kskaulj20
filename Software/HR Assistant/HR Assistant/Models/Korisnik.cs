using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Assistant.Models
{
    /// <summary>
    /// Klasa koja predstavlja korisnika ovog softvera. 
    /// </summary>
    public abstract class Korisnik
    { 
       public int Id { get; set; }    
       public string Kor_ime { get; set; }

        public string Email { get; set; }
        public string Lozinka { get; set; }

        public int Uloga { get; set; }   

        public bool CheckPassword(string pwd)
        {
            return Lozinka == pwd;
        }

        public override string ToString()
        {
            return Kor_ime;
        }
    }
}
