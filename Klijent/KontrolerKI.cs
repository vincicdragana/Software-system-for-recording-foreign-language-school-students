using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Radnik radnik;
        public static Nivo nivo;
        public static Pohadjanje pohadjanje;
        public static Prisustvo prisustvo;
        public static DataGridView dgvTermini1;
        public static Termin termin;
        public static List<Ucenik> ucenici;
        public static List<Prisustvo> prisustva;

        internal static void vratiUcenikeZaTermin(DataGridView dgvTermini, DataGridView dgvprisustva)
        {
            dgvTermini1 = dgvTermini;
            List<Ucenik> uce = new List<Ucenik>();


            termin = dgvTermini.CurrentRow.DataBoundItem as Termin;

            prisustvo = new Prisustvo
            {
                Termin = termin,
                Kurs = kurs,
                USLOV = "IDTermin = " + termin.IdTermin + " AND IDKurs = " + kurs.IDKurs 
            };
            prisustva = komunikacija.VratiPrisustvaZaTermin(prisustvo) as List<Prisustvo>;
            if (prisustva != null)
            {
                foreach (Prisustvo pri in prisustva)
                {
                    pri.Ucenik = komunikacija.PrikaziIzabranogUcenika(pri.Ucenik) as Ucenik;
                    uce.Add(pri.Ucenik);
                }
                if (uce == null)
                {
                    dgvprisustva.DataSource = uce;
                    return;
                }
                else
                {
                    dgvprisustva.DataSource = uce;
                    return;
                }
            }
               

        }

        internal static bool DaLiPostojeTerminiZaKurs(DataGridView dgvKursevi)
        {
            Kurs k = dgvKursevi.CurrentRow.DataBoundItem as Kurs;
            k = komunikacija.PrikaziKurs(k) as Kurs;
            if(k.Termini.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static bool IzbrisiPrisustvo(DataGridView dgvPrisustva)
        {
            try
            {
                Prisustvo p = new Prisustvo();
                p.Ucenik = dgvPrisustva.CurrentRow.DataBoundItem as Ucenik;
                p.Termin = termin;
                p.USLOV = " IDTermin =" + p.Termin.IdTermin + " AND IDUcenik =" + p.Ucenik.IDUcenik;
                object o = komunikacija.IzbrisiPrisustvo(p);
                if (o == null)
                {
                    MessageBox.Show("Prisustvo nije izbrisano!");
                    return false;
                }
                vratiUcenikeZaTermin(dgvTermini1, dgvPrisustva);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        internal static void PopuniGridEvidencija(DataGridView dgv, DataGridView dgvTermini)
        {
            kurs = dgv.CurrentRow.DataBoundItem as Kurs;
            kurs = (Kurs)komunikacija.PrikaziKurs(kurs);
            if (kurs == null)
            {
                MessageBox.Show("Sistem ne moze da ucita termine!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je ucitao termine!");

            }
            if(kurs.Termini == null)
            {
                return;
            }
            dgvTermini.DataSource = kurs.Termini;
        }



        internal static void PopuniDetaljePrisustvo(DataGridView dgvprisustva, DataGridView dgvTermini, TextBox txtDatum, DataGridView dgvPretraga)
        {
            vratiUcenikeZaTermin(dgvTermini, dgvprisustva) ;
            prisustva = new List<Prisustvo>();
            try
            {
                termin = dgvTermini.CurrentRow.DataBoundItem as Termin;
            }
            catch (Exception)
            {

                return;
            }
            txtDatum.Text = termin.Datum.ToString("dd.MM.yyyy");
            pohadjanje = new Pohadjanje();
            ucenici = new List<Ucenik>();
            pohadjanje.USLOV = " IDKurs = " + termin.Kurs.IDKurs;
            List<Pohadjanje> pohadjanja = komunikacija.PretraziPohadjanjaZaKurs(pohadjanje) as List<Pohadjanje>;
            foreach(Pohadjanje p in pohadjanja)
            {
                p.Ucenik =komunikacija.PrikaziIzabranogUcenika(p.Ucenik) as Ucenik;
                ucenici.Add(p.Ucenik);
            }

            dgvPretraga.DataSource = ucenici;

        }


        internal static bool UnesiPrisustvo(DataGridView dgvPretraga,DataGridView dgvprisustva)
        {
            Prisustvo p = komunikacija.UnesiPrisustvo() as Prisustvo;
            if ( p != null)
            {
                p.Termin = termin;
                p.Ucenik = dgvPretraga.CurrentRow.DataBoundItem as Ucenik;
                p.Kurs = kurs;
                p.USLOV = "IDTermin = " + p.Termin.IdTermin + " AND IDKurs = " + p.Kurs.IDKurs + " AND IDUcenik = " + p.Ucenik.IDUcenik;
                if (komunikacija.DaLiPostojiPrisustvo(p) != null)
                {
                    MessageBox.Show("Vec je uneto prisustvo za izabranog ucenika!");
                    return false;
                }
                if (komunikacija.UnesiPrisustvo(p) != null)
                {
                    vratiUcenikeZaTermin(dgvTermini1, dgvprisustva);
                    return true;
                }
            }
            return false;
            
        }

        public static Kurs kurs;
        public static Ucenik ucenik;
        public static List<Termin> termini;

        internal static void PretraziKurseve(TextBox txtPretrazi, DataGridView dgvKursevi)
        {
            kurs = new Kurs();

            kurs.USLOV = " Naziv like '" + txtPretrazi.Text + "%' ";
            List<Kurs> lista = (List<Kurs>)komunikacija.PretraziKurseve(kurs);
            dgvKursevi.DataSource = lista;
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Nema kurseva za izabranu vrednost!");
                dgvKursevi.Enabled = false;
            }
            else dgvKursevi.Enabled = true;
        }

        internal static void popuniDetaljeKurs(object kur, TextBox txtDatumDo, TextBox txtDatumOd, TextBox txtNaziv, TextBox txtSifraKursa, RadioButton rbDA, RadioButton rbNE, DataGridView dgvTermini, ComboBox cmbNivo, ComboBox cmbProfesor)
        {
            kurs = kur as Kurs;
            kurs = (Kurs)komunikacija.PrikaziKurs(kurs);
            if (kurs == null)
            {
                MessageBox.Show("Sistem ne moze da ucita kurs!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je ucitao kurs!");

            }
            txtDatumDo.Text = kurs.DatumDO.ToString("dd.MM.yyyy");
            txtDatumOd.Text = kurs.DatumOd.ToString("dd.MM.yyyy");
            txtNaziv.Text = kurs.Naziv;
            txtSifraKursa.Text = kurs.IDKurs.ToString();
            if (kurs.Aktivan == 1)
            {
                rbDA.Checked = true;
                rbNE.Checked = false;
            }
            else
            {
                rbDA.Checked = false;
                rbNE.Checked = true;
            }
            
            PopuniKomboNivo(cmbNivo);
            cmbNivo.SelectedItem = kurs.Nivo;
            //PopuniKomboProfesor(cmbProfesor);
            cmbProfesor.SelectedItem = kurs.Profesor;
            dgvTermini.DataSource = kurs.Termini;
            

        }

        internal static void PopuniDatumZaKursPohadjanje(object ku, Label lblDatum)
        {
            Kurs k = ku as Kurs;
            lblDatum.Text = k.DatumOd.ToString("dd.MM.yyyy")+" - "+k.DatumDO.ToString("dd.MM.yyyy");
        }

        internal static bool UnesiKurs(TextBox txtSifraKursa, DataGridView dgvTermini)
        {
            kurs = (Kurs)komunikacija.UnesiKurs();

            if (kurs == null)
            {
                MessageBox.Show("Sistem ne moze da kreira kurs!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao kurs!");
                txtSifraKursa.Text = kurs.IDKurs.ToString();
                dgvTermini.DataSource = kurs.Termini;
                return true;
            }
        }

        internal static bool IzmeniKursNovo(ComboBox nivo, ComboBox profesor, TextBox txtDatumDo, TextBox txtDatumOd, TextBox txtNaziv, RadioButton rbDA, RadioButton rbNE)
        {
            bool pom = true;
            DateTime ddo = DateTime.MaxValue;
            DateTime dod = DateTime.MinValue;
            try
            {
                ddo = DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);

            }
            catch (Exception)
            {
                txtDatumDo.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Nije dobar datum do!");
            }
            try
            {
                dod = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);


            }
            catch (Exception)
            {
                txtDatumOd.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Nije dobar datum od!");
            }



            if (ddo != DateTime.MaxValue && dod != DateTime.MinValue)
            {
                if (dod < ddo)
                {
                    txtDatumDo.BackColor = Color.White;
                    txtDatumOd.BackColor = Color.White;
                }
                else
                {
                    txtDatumDo.BackColor = Color.LightCoral;
                    txtDatumOd.BackColor = Color.LightCoral;
                    pom = false;
                    MessageBox.Show("Datum od ne sme biti veci od datuma do!");
                }


            }

            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Niste uneli naziv!");
            }
            else
            {
                txtNaziv.BackColor = Color.White;
            }

            if (kurs.Termini.Count == 0)
            {
                pom = false;
                MessageBox.Show("Niste uneli nijedan termin");
            }

            if (!pom) return false;

            kurs.Naziv = txtNaziv.Text;
            kurs.DatumDO = ddo;
            kurs.DatumOd = dod;
            if (rbDA.Checked)
            {
                kurs.Aktivan = 1;
            }
            else
            {
                kurs.Aktivan = 0;
            }
            kurs.Nivo = nivo.SelectedItem as Nivo;
            Profesor prof= profesor.SelectedItem as Profesor;
            Sertifikat sert = new Sertifikat();
            sert.USLOV = "IDProfesor = " + prof.Id;
            Sertifikat s = komunikacija.VratiSertifikatZaProfesora(sert) as Sertifikat;
            if (s.Jezik.IDJezik != kurs.Nivo.Jezik.IDJezik)
            {
                MessageBox.Show("Izabrani profesor ne predaje na izabranom nivou!");
                return false;
            }
            kurs.Profesor = prof;
            kurs.IZMENA = " Naziv = '" + kurs.Naziv + "', DatumOd = '" + kurs.DatumOd.ToString("yyyy-MM-dd") + "', DatumDo= '" + kurs.DatumDO.ToString("yyyy-MM-dd") + "', Aktivan = " + kurs.Aktivan+ ", IDNivo = " + kurs.Nivo.IDNivo+", IDProfesor = "+kurs.Profesor.Id;
            object rez = komunikacija.ZapamtiKurs(kurs);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti kurs!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio kurs!");
                return true;
            }
        }


        internal static void ObrisiTermin(object termin)
        {
            try
            {
                kurs.Termini.Remove(termin as Termin);
                int i = 1;
                foreach (Termin t in kurs.Termini)
                {
                    t.IdTermin = i;
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali termin!");
                return;
            }
        }

        internal static bool SacuvajKurs(TextBox txtDatumDo, TextBox txtDatumOd, TextBox txtNaziv, RadioButton rbDA, RadioButton rbNE, object nivo, ComboBox cmbNivo, ComboBox cmbProfesor)
        {
            bool pom=true;
            
            try
            {
                DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);
                
            }
            catch (Exception)
            {
                txtDatumDo.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Nije dobar datum do!");
            }
            try
            {
                DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);
                if (DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null) != DateTime.MaxValue && DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null) != DateTime.MinValue)
                {
                    if (DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null) < DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null))
                    {
                        txtDatumDo.BackColor = Color.White;
                        txtDatumOd.BackColor = Color.White;
                    }
                    else
                    {
                        txtDatumDo.BackColor = Color.LightCoral;
                        txtDatumOd.BackColor = Color.LightCoral;
                        pom = false;
                        MessageBox.Show("Datum od ne sme biti veci od datuma do!");
                    }


                }

            }
            catch (Exception)
            {
                txtDatumOd.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Nije dobar datum od!");
            }

            

            

            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.LightCoral;
                pom = false;
                MessageBox.Show("Niste uneli naziv!");
            }
            else
            {
                txtNaziv.BackColor = Color.White;
            }
            
            if (nivo == null)
            {
                MessageBox.Show("Niste izabrali nivo!");
                cmbNivo.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                cmbNivo.BackColor = Color.White;
            }
            if (kurs.Termini.Count == 0)
            {
                pom = false;
                MessageBox.Show("Niste uneli nijedan termin");
            }
            if (!pom) return false;

            kurs.Naziv = txtNaziv.Text;
            kurs.DatumDO = DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);
            kurs.DatumOd = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);
            kurs.Nivo = nivo as Nivo;
            if (rbDA.Checked)
            {
                kurs.Aktivan = 1;
            }
            else
            {
                kurs.Aktivan = 0;
            }

            Profesor prof= cmbProfesor.SelectedItem as Profesor;
            Sertifikat sert = new Sertifikat();
            sert.USLOV = "IDProfesor = "+ prof.Id;
            Sertifikat s = komunikacija.VratiSertifikatZaProfesora(sert) as Sertifikat;
            if(s.Jezik.IDJezik != kurs.Nivo.Jezik.IDJezik)
            {
                MessageBox.Show("Izabrani profesor ne predaje na izabranom nivou!");
                return false;
            }
            kurs.Profesor = prof;
            kurs.IZMENA = " Naziv = '" + kurs.Naziv + "', DatumOd = '" + kurs.DatumOd.ToString("yyyy-MM-dd") + "', DatumDo= '" + kurs.DatumDO.ToString("yyyy-MM-dd") + "', Aktivan = " + kurs.Aktivan + ", IDNivo = " + kurs.Nivo.IDNivo + ", IDProfesor = " + kurs.Profesor.Id + "";
            object rez = komunikacija.ZapamtiKurs(kurs);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti kurs!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio kurs!");
                return true;
            }
            
        }


        internal static void DodajTermin(TextBox txtDatumTermin, TextBox txtDatumDo, TextBox txtDatumOd)
        {
            bool pom = true;
            DateTime ddo = DateTime.MaxValue;
            DateTime dod = DateTime.MinValue;
            try
            {
                ddo = DateTime.ParseExact(txtDatumDo.Text, "dd.MM.yyyy", null);
                dod = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);

            }
            catch (Exception)
            {
                txtDatumDo.BackColor = Color.LightCoral;
                txtDatumOd.BackColor = Color.LightCoral;
                MessageBox.Show("Morate prvo uneti datume za pocetak i kraj kursa!");
                pom = false;
            }
            if (ddo != DateTime.MaxValue && dod != DateTime.MinValue)
            {
                txtDatumDo.BackColor = Color.White;
                txtDatumOd.BackColor = Color.White;
            }
            if(ddo < dod)
            {
                MessageBox.Show("Datum do mora biti veci od datuma od!");
                txtDatumDo.BackColor = Color.LightCoral;
                txtDatumOd.BackColor = Color.LightCoral;
                pom = false;
            }
            

            try
            {
                DateTime dte = DateTime.ParseExact(txtDatumTermin.Text, "dd.MM.yyyy", null);
                if (dte < dod || dte > ddo)
                {
                    txtDatumTermin.BackColor = Color.LightCoral;
                    MessageBox.Show("Datum termina mora biti u periodu dok traje kurs!");
                    pom = false;
                }
                else
                {
                    txtDatumTermin.BackColor = Color.White;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Nije dobar datum!");
                pom = false;
            }

            if (!pom) return;

            Termin te = new Termin();
            te.IdTermin = kurs.Termini.Count + 1;
            te.Kurs = kurs;
            te.Datum = DateTime.ParseExact(txtDatumTermin.Text, "dd.MM.yyyy", null);

            kurs.Termini.Add(te);

            txtDatumTermin.Clear();
        }

        internal static void PopuniKomboProfesor(ComboBox cmbProfesor)
        {
            Profesor p = new Profesor();
            cmbProfesor.DataSource = komunikacija.PretraziSveProfesore(p) as List<Profesor>;
            cmbProfesor.Text = "Izaberite profesora!";
        }

        internal static void PopuniKomboNivo(ComboBox cmbNivo)
        {
            cmbNivo.Items.Clear();
            List<Nivo> lista = (List<Nivo>)komunikacija.PretraziSveNivoe();
            foreach (Nivo n in lista)
            {
                cmbNivo.Items.Add(n);
            }

            cmbNivo.Text = "Izaberite nivo!";
        }

        internal static void PopuniKombJezik(ComboBox cmbJezik)
        {
            cmbJezik.Items.Clear();
            List<Jezik> lista = (List<Jezik>)komunikacija.PretraziSveJezike();
            foreach (Jezik j in lista)
            {
                cmbJezik.Items.Add(j);
            }

            cmbJezik.Text = "Izaberite jezik!";
        }

        internal static bool SacuvajNivo(object jezik, TextBox txtNaziv, ComboBox cmbJezik)
        {
            bool pom = true;

            if (jezik == null)
            {
                pom = false;
                MessageBox.Show("Niste izabrali jezik!");
                cmbJezik.BackColor = Color.LightCoral;
            }

            if(string.IsNullOrEmpty(txtNaziv.Text))
            {
                pom = false;
                MessageBox.Show("Niste uneli naziv!");
                txtNaziv.BackColor = Color.LightCoral;
            }
            if (!pom)
            {
                return false;
            }

            nivo.Jezik = jezik as Jezik;
            nivo.Naziv = txtNaziv.Text;

            object o = komunikacija.ZapamtiNivo(nivo);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti nivo!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio nivo!");
                return true;
            }
        }

        internal static bool UnesiNivo(TextBox iDNivo)
        {
            nivo = (Nivo)komunikacija.UnesiNivo();

            if (nivo == null)
            {
                MessageBox.Show("Sistem ne moze da kreira nivo!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao nivo!");
                iDNivo.Text = nivo.IDNivo.ToString();
                return true;
            }
        }

        internal static void PopuniUcenika(DataGridView dgvPretraga, Label lblUcenik)
        {
            ucenik = dgvPretraga.CurrentRow.DataBoundItem as Ucenik;
            lblUcenik.Text = ucenik.Ime + " " + ucenik.Prezime;             
        }

        internal static void PopuniDetalje(DataGridView dgvPretraga, DataGridView dgvPohadjanja, Label lblUcenik)
        {
            pohadjanje = new Pohadjanje();
            ucenik = dgvPretraga.CurrentRow.DataBoundItem as Ucenik;
            ucenik = (Ucenik)komunikacija.PrikaziIzabranogUcenika(ucenik);
            pohadjanje.Ucenik = ucenik;
            lblUcenik.Text = ucenik.Ime + " " + ucenik.Prezime;
            pohadjanje.USLOV = "IDUcenik = " + pohadjanje.Ucenik.IDUcenik;
            dgvPohadjanja.DataSource = komunikacija.PrikaziPohadjanjaZaUcenika(pohadjanje);
        }

        internal static void ObrisiPohadjanje(DataGridView dgvPohadjanje)
        {
            try
            {

                Pohadjanje p = dgvPohadjanje.CurrentRow.DataBoundItem as Pohadjanje;
                object o = komunikacija.ObrisiPohadjanje(p);
                if (o == null)
                {
                    MessageBox.Show("Sistem ne moze da obrise pohadjanje!");
                    return;
                }
                else
                {
                    MessageBox.Show("Sistem je uspesno obrisao pohadjanje!");
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali pohadjanje!");
            }
        }

        internal static void popuniKomboKurs(ComboBox cmbKurs)
        {
            cmbKurs.Items.Clear();
            List<Kurs> lista = (List<Kurs>)komunikacija.PretraziSveKurseve();
            foreach (Kurs k in lista)
            {
                cmbKurs.Items.Add(k);
            }

            cmbKurs.Text = "Izaberite kurs!";
        }

        internal static bool UnesiPohadjanjaZaUcenika(Label IDPohadjanje)
        {
            
            pohadjanje = (Pohadjanje)komunikacija.UnesiPohadjanje();

            if (pohadjanje == null)
            {
                MessageBox.Show("Sistem ne moze da kreira pohadjanje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao pohadjanje!");
                pohadjanje.Ucenik = ucenik;
                IDPohadjanje.Text = pohadjanje.IDPohadjanje.ToString();
                return true;
            }
        }

        internal static bool SacuvajPohadjanje(TextBox txtDatumUpisa, object kurs, ComboBox cmbKurs)
        {
            bool pom = true;
                pohadjanje.Kurs = kurs as Kurs;
            if (pohadjanje.Kurs == null)
            {
                MessageBox.Show("Niste izabrali kurs!");
                cmbKurs.BackColor = Color.LightCoral;
                pom = false;
            }
                try
                {
                    pohadjanje.DatumUpisa = DateTime.ParseExact(txtDatumUpisa.Text, "dd.MM.yyyy", null);
                try
                {
                    if (pohadjanje.DatumUpisa > (pohadjanje.Kurs).DatumDO )
                    {
                        MessageBox.Show("Izabrani kurs se zavrsio!");
                        txtDatumUpisa.BackColor = Color.LightCoral;
                        pom = false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Nije dobar datum");
                    txtDatumUpisa.BackColor = Color.LightCoral;
                    return false;
                }
                pohadjanje.Ucenik = ucenik;
            try
            {
                List<Pohadjanje> pohadjanja = komunikacija.PrikaziPohadjanjaZaUcenika(pohadjanje) as List<Pohadjanje>;
                foreach (Pohadjanje po in pohadjanja)
                {
                    if (po.Kurs.IDKurs == pohadjanje.Kurs.IDKurs)
                    {
                        MessageBox.Show($"Ucenik {ucenik.Ime} {ucenik.Prezime} vec pohadja izabrani kurs!");
                        cmbKurs.BackColor = Color.LightCoral;
                        pom = false;
                    }
                }
            }
            catch (Exception)
            {

               
            }
            if (!pom)
            {
                return false;
            }
            object o = komunikacija.ZapamtiPohadjanje(pohadjanje);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti pohadjanje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio pohadjanje!");
                return true;
            }
        }

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();           
        }

        internal static void PopuniDetaljeUcenika(TextBox txtAdresa, TextBox txtBrojTelefona, TextBox txtDatumRodjenja, TextBox txtIDUcenik, TextBox txtIme, TextBox txtJMBG, TextBox txtPrezime)
        {
            txtAdresa.Text = ucenik.Adresa;
            txtBrojTelefona.Text = ucenik.BrojTelefona;
            txtDatumRodjenja.Text = ucenik.DatumRodjenja.ToString("dd.MM.yyyy");
            txtIDUcenik.Text = ucenik.IDUcenik.ToString();
            txtIme.Text = ucenik.Ime;
            txtJMBG.Text = ucenik.JMBG1;
            txtPrezime.Text = ucenik.Prezime;
        }

        internal static void PretraziUcenike(TextBox txtPretrazi, DataGridView dgvPretraga)
        {
            ucenik = new Ucenik();
            ucenik.USLOV = " Ime like '" + txtPretrazi.Text + "%' OR Prezime like '" + txtPretrazi.Text + "%'";
            List<Ucenik> lista = (List<Ucenik>)komunikacija.PretraziUcenike(ucenik);

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje ucenike!");
            }

            dgvPretraga.DataSource = lista;


        }

        internal static bool PrikaziIzabranogUcenika(DataGridView dgvPretraga)
        {
            try
            {
                ucenik = dgvPretraga.CurrentRow.DataBoundItem as Ucenik;
                ucenik = (Ucenik)komunikacija.PrikaziIzabranogUcenika(ucenik);
                if (ucenik == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita podatke o uceniku!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao podatke o uceniku!");
                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali ucenika!");
                return false;
            }
        }

        internal static bool ObrisiUcenika()
        {
            object o = komunikacija.ObrisiUcenika(ucenik);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da obrise ucenika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao ucenika!");
                return true;
            }
        }

        internal static bool UnesiUcenika(TextBox txtIDUcenik)
        {
            ucenik = (Ucenik)komunikacija.UnesiUcenika();

            if (ucenik == null)
            {
                MessageBox.Show("Sistem ne moze da kreira ucenika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao ucenika!");
                txtIDUcenik.Text = ucenik.IDUcenik.ToString();
                return true;
            }
        }

        internal static bool SacuvajUcenika(TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtDatumRodjenja, TextBox txtBrojTelefona, TextBox txtAdresa, bool prviPut)
        {

            ucenik.Ime = txtIme.Text;
            ucenik.Prezime = txtPrezime.Text;
            ucenik.JMBG1 = txtJMBG.Text;
            ucenik.BrojTelefona = txtBrojTelefona.Text;
            try
            {
                ucenik.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Nije dobar datum");
                return false;
            }
            ucenik.Adresa = txtAdresa.Text;
            Ucenik u = new Ucenik
            {
                JMBG1 = ucenik.JMBG1
            };
            if (prviPut || txtJMBG.ToString() != ucenik.JMBG1)
            {
                u.USLOV = "JMBG = '" + u.JMBG1 + "'";
                u = (Ucenik)komunikacija.DaLiPostojiUcenik(u);
                if (u != null)
                {
                    MessageBox.Show("Vec postoji ucenik sa istim JMBG-om!");
                    return false;
                } 
            }
            object o = komunikacija.ZapamtiUcenika(ucenik);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti ucenika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio ucenika!");
                return true;
            }
        }

        internal static void Kraj()
        {
            komunikacija.Kraj();
            komunikacija = null;
        }

        internal static bool PrijaviSe(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            bool pom = true;
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Niste uneli korisnicko ime!");
                txtKorisnickoIme.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtKorisnickoIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                MessageBox.Show("Niste uneli lozinku!");
                txtLozinka.BackColor = Color.LightCoral;
                pom = false;
            }
            else
            {
                txtLozinka.BackColor = Color.White;
            }
            if (!pom) return false;
            radnik = new Radnik();
            radnik.KorisnickoIme = txtKorisnickoIme.Text;
            radnik.Lozinka = txtLozinka.Text;

            radnik = (Radnik)komunikacija.PronadjiRadnika(radnik);

            if (radnik == null)
            {
                MessageBox.Show("Neuspela prijava! Radnik nije pronadjen!");
                return false;
            }
            else
            {


                MessageBox.Show("Uspesno ste se prijavili, " + radnik.ImePrezime + "!");

                return true;
            }
        }
        internal static string PrikaziUlogovanogRadnika()
        {
            return "Ulogovan je: " + radnik.ToString() + " , Vreme prijave: " + DateTime.Now.ToString("HH:mm");
        }
    }
}
