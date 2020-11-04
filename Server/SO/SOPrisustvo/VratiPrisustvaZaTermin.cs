using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOPrisustvo
{
    public class VratiPrisustvaZaTermin : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {

            return Broker.VratiSveZaUslovOstalo(odo).OfType<Prisustvo>().ToList<Prisustvo>();
        }
    }
}
