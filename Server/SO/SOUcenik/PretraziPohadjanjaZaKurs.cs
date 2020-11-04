using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOUcenik
{
    public class PretraziPohadjanjaZaKurs : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.VratiSveZaUslovOstalo(odo).OfType<Pohadjanje>().ToList<Pohadjanje>();
        }
    }
}
