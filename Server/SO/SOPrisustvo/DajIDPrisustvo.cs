using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOPrisustvo
{
    public class DajIDPrisustvo : OpstaSO
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
            Prisustvo p = new Prisustvo()
            {
                IdPrisustvo = ID
            };
            if (ID > -1)
            {
                Broker.Sacuvaj(p);
            }
            else
            {
                p = null;
                return p;
            }
            return p;
        }
    }
}
