using DBLayer;
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
    public partial class frmLogIn : Form
    {

        public static Zaposlenik UlogiranZaposlenik
        {
            get; set;
        }
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UlogiranZaposlenik = RepozitorijZaposlenik.DohvatiZaposlenika(txtEmail.Text, txtLozinka.Text);
                if (UlogiranZaposlenik != null && UlogiranZaposlenik.CheckPassword(txtLozinka.Text))


                {
                    if (UlogiranZaposlenik.Uloga == 1) {
                        frmPrikazZahtjeva frmPrikaz = new frmPrikazZahtjeva();
                        Hide();
                        frmPrikaz.ShowDialog();
                        Close();
                    }
                    else if (UlogiranZaposlenik.Uloga == 2)
                    {

                        FrmPrikazZahtjevaZaposlenik frmPrikazZaposlenik = new FrmPrikazZahtjevaZaposlenik();
                        Hide();
                        frmPrikazZaposlenik.ShowDialog();
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Uneseni su pogrešni podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }

        }

        private void txrLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
