using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Radnik : OpstiDomenskiObjekat
    {
        int iDRadnik;
        string imePrezime;
        string lozinka;
        string korisnickoIme;

        public int IDRadnik { get => iDRadnik; set => iDRadnik = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }

        public override string ToString()
        {
            return ImePrezime;
        }

        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Radnik";
        [Browsable(false)]
        public string primarniKljuc => "IDRadnik";
        [Browsable(false)]
        public string uslovPrimarni => "IDRadnik = "+IDRadnik;
        [Browsable(false)]
        public string uslovOstalo => " Lozinka = '"+Lozinka+"' AND KorisnickoIme = '"+KorisnickoIme+"' ";
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => "";
        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Radnik r = new Radnik();
            r.IDRadnik = Convert.ToInt32(red["IDRadnik"]);
            r.ImePrezime = (red["ImePrezime"]).ToString();
            r.Lozinka = (red["Lozinka"]).ToString();
            r.KorisnickoIme = (red["KorisnickoIme"]).ToString();
            return r;
        }
        #endregion
    }
}
