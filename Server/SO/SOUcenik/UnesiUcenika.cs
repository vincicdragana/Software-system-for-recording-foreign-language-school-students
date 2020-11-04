using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOUcenik
{
    public class UnesiUcenika : OpstaSO
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
            Ucenik u = new Ucenik()
            {
                IDUcenik = ID
            };
            if(ID > -1)
            {
                Broker.Sacuvaj(u);
            }
            else
            {
                u = null;
                return u;
            }
            return u;
        }
    }
}
