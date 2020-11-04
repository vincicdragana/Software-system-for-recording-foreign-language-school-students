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
    public partial class FrmUnosUcenika : Form
    {
        bool prviPut = true;

        public FrmUnosUcenika()
        {
            InitializeComponent();
            btnIzmeni.Visible = false;
            btnObrisi.Visible = false;
            gbUcenik.Enabled = false;
            btnSacuvaj.Enabled = false;
        }

        public FrmUnosUcenika(DataGridView dgvPretraga)
        {
            InitializeComponent();
            //btnIzmeni.Visible = true;
            //btnObrisi.Visible = true;
            //gbUcenik.Enabled = true;
            btnSacuvaj.Visible = false;
            btnKreirajUcenika.Visible = false;
            txtIDUcenik.Enabled = false;
            KontrolerKI.PopuniDetaljeUcenika(txtAdresa,txtBrojTelefona,txtDatumRodjenja,txtIDUcenik,txtIme,txtJMBG,txtPrezime);
        }

        private void btnKreirajUcenika_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UnesiUcenika(txtIDUcenik))
            {
                btnKreirajUcenika.Enabled = false;
                gbUcenik.Enabled = true;
                btnSacuvaj.Enabled = true;
                txtIDUcenik.Enabled = false;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            if (KontrolerKI.SacuvajUcenika(txtIme, txtPrezime, txtJMBG, txtDatumRodjenja, txtBrojTelefona, txtAdresa, prviPut))
            {
                txtAdresa.Clear();
                txtBrojTelefona.Clear();
                txtDatumRodjenja.Clear();
                txtIDUcenik.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                txtJMBG.Clear();
                btnKreirajUcenika.Enabled = true;
                gbUcenik.Enabled = false;
            }

        }

        private bool Validacija()
        {
            bool pom = true;
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                txtIme.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                txtPrezime.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txtJMBG.Text))
            {
                txtJMBG.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtJMBG.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txtDatumRodjenja.Text))
            {
                txtDatumRodjenja.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtDatumRodjenja.BackColor = Color.White;
            }
            try
            {
                DateTime datum = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy", null);
                if (datum >= DateTime.Now)
                {
                    txtDatumRodjenja.BackColor = Color.LightCoral;
                    pom = false;
                }
                else
                {
                    txtDatumRodjenja.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                if (!string.IsNullOrEmpty(txtDatumRodjenja.Text))
                {
                    MessageBox.Show("Nije dobar format datuma!");
                }
                txtDatumRodjenja.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(txtBrojTelefona.Text))
            {
                txtBrojTelefona.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtBrojTelefona.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                txtAdresa.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtAdresa.BackColor = Color.White;
            }

            return pom;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            prviPut = false;
            if (KontrolerKI.SacuvajUcenika(txtIme, txtPrezime, txtJMBG, txtDatumRodjenja, txtBrojTelefona, txtAdresa,prviPut))
            {
                this.Close();
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiUcenika())
            {
                this.Close();
            }
        }
    }
}
