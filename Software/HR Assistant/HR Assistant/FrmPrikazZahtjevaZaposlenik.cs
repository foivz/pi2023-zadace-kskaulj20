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
    public partial class FrmPrikazZahtjevaZaposlenik : Form
    {
        public FrmPrikazZahtjevaZaposlenik()
        {
            InitializeComponent();
        }

        private void FrmPrikazZahtjevaZaposlenik_Load(object sender, EventArgs e)
        {
            PrikazZahtjeva();

        }

        private void PrikazZahtjeva()
        {
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.GetPoslaniZahtjevi();

            dgvZahtjeviZaposlenik.DataSource = zahtjevi;
        }

        private void dgvZahtjeviZaposlenik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void OsvjeziPrikaz()
        {
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.GetPoslaniZahtjevi();
            dgvZahtjeviZaposlenik.DataSource = zahtjevi;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Zahtjev odabraniZahtjev = dgvZahtjeviZaposlenik.CurrentRow.DataBoundItem as Zahtjev;
            RepozitorijZahtjeva repozitorij = new RepozitorijZahtjeva();
            repozitorij.ObrisiZahtjev(odabraniZahtjev.ID_zahtjev);
            MessageBox.Show("Uspješno obrisan zahtjev" );
            this.OsvjeziPrikaz();
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            FrmNoviZahtjev frmNoviZahtjev = new FrmNoviZahtjev();
            Hide();
            frmNoviZahtjev.ShowDialog();
            Close();
        }
    }
}
