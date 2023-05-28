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
        private Zahtjev zahtjev;
        public Zahtjev OdabranZahtjev { get => zahtjev; set => zahtjev = value; }


        public frmPrikazZahtjeva()
        {
            InitializeComponent();
            //this.zahtjev = zahtjev;
            //OdabranZahtjev = odabranZahtjev;
        }

       /** private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmObradaZahtjeva frmObradaZahtjeva = new FrmObradaZahtjeva(OdabranZahtjev);
            Hide();
            frmObradaZahtjeva.ShowDialog();
            Close();

        }**/

        private void frmPrikazZahtjeva_Load(object sender, EventArgs e)
        {
            PrikazZahtjeva();
        }

        private void PrikazTrazenihZahtjeva(int Id_zahtjev)
        {
            var TrazeniZahtjevi = RepozitorijZahtjeva.DohvatiTrazeniZahtjev(Id_zahtjev);
            dgvZahtjevi.DataSource = TrazeniZahtjevi;
            dgvZahtjevi.Columns["ID_zahtjev"].HeaderCell.Value = "Šifra zahtjeva";
            dgvZahtjevi.Columns["pocetak_odsustva"].HeaderCell.Value = "Početak odsustva";
            dgvZahtjevi.Columns["KrajOdsustva"].HeaderCell.Value = "Završetak odsustva";
            dgvZahtjevi.Columns["Komentar"].HeaderCell.Value = "Komentar";
            dgvZahtjevi.Columns["Kreirao"].HeaderCell.Value = "Šifra zaposlenika";
            dgvZahtjevi.Columns["RazlogOdsustva"].HeaderCell.Value = "Vrsta odsustva";
            dgvZahtjevi.Columns["Status"].Visible = false;

        }

        private void PrikazZahtjeva()
        {
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.GetZahtjevi();
            
            
            
            dgvZahtjevi.DataSource = zahtjevi;

            dgvZahtjevi.Columns["ID_zahtjev"].HeaderCell.Value = "Šifra zahtjeva";
            dgvZahtjevi.Columns["pocetak_odsustva"].HeaderCell.Value = "Početak odsustva";
            dgvZahtjevi.Columns["KrajOdsustva"].HeaderCell.Value = "Završetak odsustva";
            dgvZahtjevi.Columns["Komentar"].HeaderCell.Value = "Komentar";
            dgvZahtjevi.Columns["Kreirao"].HeaderCell.Value = "Šifra zaposlenika";
            dgvZahtjevi.Columns["RazlogOdsustva"].HeaderCell.Value = "Vrsta odsustva";
            dgvZahtjevi.Columns["Status"].Visible = false;

        }

        

        private void btnObradeni_Click(object sender, EventArgs e)
        {
            FrmObradeniZahtjevi frmPrikazObradenih = new FrmObradeniZahtjevi();
            Hide();
            frmPrikazObradenih.ShowDialog();
            Close();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if(txtPretrazi.Text !="")
            {
                int Id_zahtjev = int.Parse(txtPretrazi.Text);
                PrikazTrazenihZahtjeva(Id_zahtjev);
            }
            else
            {
                PrikazZahtjeva();

            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {

        }

        public void OsvjeziPrikaz()
        {
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void BtnObrada_Click(object sender, EventArgs e)
        {

            Zahtjev odabraniZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            if( odabraniZahtjev != null)
            {
                FrmObradaZahtjeva frmObradaZahtjeva = new FrmObradaZahtjeva(odabraniZahtjev);
                frmObradaZahtjeva.ShowDialog();
            }
            this.OsvjeziPrikaz();
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            Hide();
            frmLog.ShowDialog();
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
