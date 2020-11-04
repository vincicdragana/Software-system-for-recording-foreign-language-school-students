using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Profesor: OpstiDomenskiObjekat
    {
        int id;
        string imePrezime;
        string jmbg;


        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public int Id { get => id; set => id = value; }

        #region ODO
        public string nazivTabele => "Profesor";

        public string primarniKljuc => "IDProfesor";

        public string uslovPrimarni => "IDProfesor ="+ Id;

        public string uslovOstalo => "";

        public string izmena => "";

        public string unos => "";

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Profesor p = new Profesor();
            p.Id = Convert.ToInt32(red["IDProfesor"]);
            p.ImePrezime = (red["ImePrezime"]).ToString();
            p.Jmbg = (red["JMBG"]).ToString();
            return p;
        }
        #endregion

        public override string ToString()
        {
            return ImePrezime;
        }

    }
}
