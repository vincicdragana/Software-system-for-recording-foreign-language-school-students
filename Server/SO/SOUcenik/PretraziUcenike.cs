using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOUcenik
{
    public class PretraziUcenike : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Ucenik u = new Ucenik();
            Broker.ObrisiZaUslovOstalo(u);
            return Broker.VratiSveZaUslovOstalo(odo).OfType<Ucenik>().ToList<Ucenik>();
        }
    }
}
