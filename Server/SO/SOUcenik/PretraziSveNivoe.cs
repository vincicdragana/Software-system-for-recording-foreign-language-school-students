using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOUcenik
{
    public class PretraziSveNivoe : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Nivo n = new Nivo();
            
            Broker.ObrisiZaUslovOstalo(n);
            return Broker.VratiSve(odo).OfType<Nivo>().ToList<Nivo>();
        }
    }
}
