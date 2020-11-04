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
    public class Ucenik : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return Ime +" "+ Prezime;
        }
        int iDUcenik;
        string ime;
        string prezime;
        string JMBG;
        string brojTelefona;
        DateTime datumRodjenja;

        [Browsable(false)]
        public int IDUcenik { get => iDUcenik; set => iDUcenik = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        [Browsable(false)]
        public string JMBG1 { get => JMBG; set => JMBG = value; }
        [Browsable(false)]
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        [Browsable(false)]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [Browsable(false)]
        public string Adresa { get; set; }
        [Browsable(false)]


        public override bool Equals(object obj)
        {

            if (obj is Ucenik u)
            {
                return u.IDUcenik == IDUcenik;
            }
            return false;
        }

        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Ucenik";
        [Browsable(false)]
        public string primarniKljuc => "IDUcenik";
        [Browsable(false)]
        public string uslovPrimarni => "IDUcenik = " + IDUcenik;

        public string USLOV = "Ime='"+""+ "' OR Prezime='" + "" + "' ";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => " Ime = '" + Ime + "', Prezime = '" + Prezime + "', JMBG = '" + JMBG1 + "', BrojTelefona = '" + BrojTelefona + "', DatumRodjenja = '" + DatumRodjenja + "', Adresa = '" + Adresa + "' ";
        [Browsable(false)]
        public string unos => "values(" + IDUcenik + ", '" + Ime + "', '" + Prezime + "', '" + JMBG1 + "', '" + BrojTelefona + "', '" + DatumRodjenja + "', '" + Adresa + "')";
        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Ucenik u = new Ucenik();
            u.IDUcenik = Convert.ToInt32(red["IDUcenik"]);
            u.Ime = (red["Ime"]).ToString();
            u.Prezime = (red["Prezime"]).ToString();
            u.JMBG1 = (red["JMBG"]).ToString();
            u.BrojTelefona = (red["BrojTelefona"]).ToString();
            u.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            u.Adresa = (red["Adresa"]).ToString();
            return u;
        }
        #endregion
    }
}
