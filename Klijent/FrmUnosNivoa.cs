using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmUnosNivoa : Form
    {
        public FrmUnosNivoa()
        {
            InitializeComponent();
            panel1.Enabled = false;
            KontrolerKI.PopuniKombJezik(cmbJezik);
        }

        private void FrmUnosNivoa_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.SacuvajNivo(cmbJezik.SelectedItem, txtNaziv,cmbJezik))
            {
                txtNaziv.Clear();
                cmbJezik.Text = "Izaberite jezik!";
            }
        }

        private void btnKreirajNivo_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UnesiNivo(IDNivo))
            {
                panel1.Enabled = true;
                btnKreirajNivo.Enabled = false;
            }
        }
    }
}
