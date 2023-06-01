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
using DBLayer;

namespace HR_Assistant
{
    public partial class FrmNoviZahtjev : Form
    {
        List<Zahtjev> SviZahtjevi { get; set; }
        Zahtjev NoviZahtjev { get; set; }

        public FrmNoviZahtjev()
        {
            InitializeComponent();
        }

       

        private void FrmNoviZahtjev_Load(object sender, EventArgs e)
        {
            
            SviZahtjevi = RepozitorijZahtjeva.GetZahtjevi();
            NoviZahtjev = new Zahtjev();
            //NoviZahtjev.ID_zahtjev = SviZahtjevi.Last().ID_zahtjev + 1;
            NoviZahtjev.Kreirao = frmLogIn.UlogiranZaposlenik.Id.ToString();
            
            
            string sql = $"SELECT Id_vrsta FROM VrstaOdsustva";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                cboRazlog.Items.Add(reader["Id_vrsta"].ToString());
            }
            reader.Close();
            DB.CloseConnection();
            

        }

        private void btnPodnesiZahtjev_Click(object sender, EventArgs e)
        {
            Zahtjev NoviZahtjev = new Zahtjev();
            {
                NoviZahtjev.Pocetak_Odsustva = txtPocetak.Text;
                NoviZahtjev.ID_zahtjev = int.Parse(txtId.Text);
                NoviZahtjev.KrajOdsustva = txtKraj.Text;
                NoviZahtjev.RazlogOdsustva = cboRazlog.SelectedIndex;
                NoviZahtjev.Komentar = txtKomentar.Text;
                NoviZahtjev.Status = 1;

            }
            RepozitorijZahtjeva repozitorij = new RepozitorijZahtjeva();

            repozitorij.DodajZahtjev(NoviZahtjev, frmLogIn.UlogiranZaposlenik );

            Hide();
            Close();
            FrmPrikazZahtjevaZaposlenik frmPrikazZahtjevaZaposlenik = new FrmPrikazZahtjevaZaposlenik();
            frmPrikazZahtjevaZaposlenik.ShowDialog();

        }

       

        private void txtKomentar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            FrmPrikazZahtjevaZaposlenik frmPrikazZahtjevaZaposlenik = new FrmPrikazZahtjevaZaposlenik();
            frmPrikazZahtjevaZaposlenik.ShowDialog();
        }
    }
}