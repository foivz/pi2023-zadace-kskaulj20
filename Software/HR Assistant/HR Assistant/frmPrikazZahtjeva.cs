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

        private void btnObradeni_Click(object sender, EventArgs e)
        {
            FrmObradeniZahtjevi frmPrikazObradenih = new FrmObradeniZahtjevi();
            Hide();
            frmPrikazObradenih.ShowDialog();
            Close();
        }

        /**  private void dgvKor_Ime_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              List<Zaposlenik> zaposlenici = RepozitorijZaposlenik.DohvatiZaposlenika(string email, string lozinka);

              dgvKor_Ime.DataSource = zaposlenici;
              DataGridViewBand band = dgvKor_Ime.Rows[3];
              band.Visible = false;
          }**/
    }
}
