using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SONivo
{
    public class UnesiNivo : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            int ID;
            try
            {
                ID = Broker.VratiSifru(odo);
            }
            catch (Exception)
            {

                ID = -1;
            }
            Nivo n = new Nivo()
            {
                IDNivo = ID
            };
            if (ID > -1)
            {
                Broker.Sacuvaj(n);
            }
            else
            {
                n = null;
                return n;
            }
            return n;
        }
    }
}
