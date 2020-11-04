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
    public class Termin:OpstiDomenskiObjekat
    {
        int idTermin;
        DateTime datum;
        Kurs kurs;
        
        [DisplayName("Rb")]
        public int IdTermin { get => idTermin; set => idTermin = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        [Browsable(false)]
        public Kurs Kurs { get => kurs; set => kurs = value; }

        #region  ODO
        [Browsable(false)]
        public string nazivTabele => "Termin";
        [Browsable(false)]
        public string primarniKljuc => "IDTermin";
        [Browsable(false)]
        public string uslovPrimarni => "IDTerimn = "+idTermin;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => "values ("+IdTermin+", "+Kurs.IDKurs+", '"+Datum.ToString("yyyy-MM-dd")+"')";



        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Termin t = new Termin();
            t.IdTermin = Convert.ToInt32(red["IDTermin"]);
            t.Datum = Convert.ToDateTime(red["Datum"]);

            t.kurs = new Kurs
            {
                IDKurs = Convert.ToInt32(red["IDKurs"])
            };
            return t;
        }
        #endregion
    }
}
