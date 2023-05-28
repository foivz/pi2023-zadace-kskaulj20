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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_Assistant
{
    public partial class FrmObradaZahtjeva : Form
    {
        private Zahtjev zahtjev;
        private Zahtjev _odabranZahtjev;

        //public Zahtjev OdabranZahtjev { get => zahtjev; set => zahtjev = value; }
        public FrmObradaZahtjeva(Zahtjev odabranZahtjev)
        {
            InitializeComponent();
            _odabranZahtjev = odabranZahtjev;
            
        }

       /** public FrmObradaZahtjeva(int iD_zahtjev)
        {
            this.iD_zahtjev = iD_zahtjev;
        }**/

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmObradaZahtjeva_Load(object sender, EventArgs e)
        {

        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            RepozitorijZahtjeva.OdobrenjeZahtjeva(_odabranZahtjev);
            Close();
            Hide();
            
        }

        private void btnOdbij_Click(object sender, EventArgs e)
        {
            RepozitorijZahtjeva.OdbijanjeZahtjeva(_odabranZahtjev);
            Close();
            Hide();
        }
    }
}
