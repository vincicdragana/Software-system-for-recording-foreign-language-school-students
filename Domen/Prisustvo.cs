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
    public class Prisustvo : OpstiDomenskiObjekat
    {
        int idPrisustvo;
        Termin termin;
        Ucenik ucenik;
        Kurs kurs;

        public Termin Termin { get => termin; set => termin = value; }
        public int IdPrisustvo { get => idPrisustvo; set => idPrisustvo = value; }
        public Ucenik Ucenik { get => ucenik; set => ucenik = value; }
        public Kurs Kurs { get => kurs; set => kurs = value; }

        #region ODO
        public string nazivTabele => "Prisustvo";

        public string primarniKljuc => "IDPrisustvo";

        public string uslovPrimarni => "IDPrisustvo ="+IdPrisustvo;

        public string USLOV = "";
        public string uslovOstalo => USLOV;

        public string izmena => " IDTermin = '" + Termin.IdTermin + "', IDUcenik = " + Ucenik.IDUcenik+", IDKurs = "+Kurs.IDKurs ;

        public string unos => "(IDPrisustvo)values("+IdPrisustvo+")";



        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Prisustvo p = new Prisustvo();
            p.IdPrisustvo = Convert.ToInt32(red["IDPrisustvo"]);
            p.Termin = new Termin
            {
                IdTermin = Convert.ToInt32(red["IDTermin"])
            };
            p.Ucenik = new Ucenik
            {
                IDUcenik = Convert.ToInt32(red["IDUcenik"])
            };
            p.Kurs = new Kurs
            {
                IDKurs = Convert.ToInt32(red["IDKurs"])
            };

            return p;
        }
        #endregion
    }
}
