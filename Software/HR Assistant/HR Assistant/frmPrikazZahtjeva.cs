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

namespace HR_Assistant
{
    public partial class frmPrikazZahtjeva : Form
    {
        public frmPrikazZahtjeva()
        {
            InitializeComponent();
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrikazZahtjeva_Load(object sender, EventArgs e)
        {
            PrikazZahtjeva();
        }

        private void PrikazZahtjeva()
        {
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void PrikazKorisnik()
        {
            //List<Zaposlenik> zaposlenici = RepozitorijZaposlenik.DohvatiZaposlenika();
            
            //dgvKor_Ime.DataSource = zaposlenik;
        }

        private void dgvKor_Ime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
