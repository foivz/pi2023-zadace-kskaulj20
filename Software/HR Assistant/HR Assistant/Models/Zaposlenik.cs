﻿using HR_Assistant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Assistant
{
    public class Zaposlenik : Korisnik
    {
        public bool CheckPassword(string Lozinka)
        {
            return Lozinka == Lozinka;
        }

    }
}
