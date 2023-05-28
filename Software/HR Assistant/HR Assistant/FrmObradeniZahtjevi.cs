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
    public partial class FrmObradeniZahtjevi : Form
    {
        public FrmObradeniZahtjevi()
        {
            InitializeComponent();
        }

        private void dgvObradeni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PrikazZahtjeva()
        {
            List<Zahtjev> obradenizahtjevi = RepozitorijZahtjeva.GetObradeniZahtjevi();

            dgvObradeni.DataSource = obradenizahtjevi;
        }

        private void FrmObradeniZahtjevi_Load(object sender, EventArgs e)
        {
            PrikazZahtjeva();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            frmPrikazZahtjeva frmPrikaz = new frmPrikazZahtjeva();
            frmPrikaz.ShowDialog(); 
        }
    }
}
