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
    public class Jezik : OpstiDomenskiObjekat
    {
        int iDJezik;
        string naziv;

        public int IDJezik { get => iDJezik; set => iDJezik = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return Naziv;
        }
        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Jezik";
        [Browsable(false)]
        public string primarniKljuc => "IDJezik";
        [Browsable(false)]
        public string uslovPrimarni => "IDJezik = " + IDJezik;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => "(IDJezik) values ("+IDJezik+")";
        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Jezik j = new Jezik();
            j.IDJezik = Convert.ToInt32(red["IDJezik"]);
            j.Naziv = (red["Naziv"]).ToString();

            return j;
        }
        #endregion
    }
}