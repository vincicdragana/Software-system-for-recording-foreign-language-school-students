using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public abstract class OpstaSO
    {
        public Broker Broker { get; set; } = new Broker();
        public Object IzvrsiSO(OpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            try
            {
                Broker.otvoriKonekciju();
                Broker.zapocniTransakciju();
                rezultat = IzvrsiKonkretnuSO(odo);
                Broker.potvrdiTransakciju();                
            }
            catch (Exception)
            {
                Broker.ponistiTransakciju();               
            }
            finally
            {
                Broker.zatvoriKonekciju();
            }
            return rezultat;
        }

        public abstract Object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo);
    }
}
