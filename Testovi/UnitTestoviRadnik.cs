using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SORadnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviRadnik
    {
        [TestMethod]

        public void UnesiUcenikaUspesno()
        {
            Radnik radnik = new Radnik
            {
                KorisnickoIme = "Pera",
                Lozinka = "Pera"
            };
            Radnik r = ListaRadnika()[0] as Radnik;
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiZaUslovOstalo(radnik)).Returns(r);

            PronadjiRadnika pr = new PronadjiRadnika();
            pr.Broker = mock.Object;
            Radnik pov = (Radnik)pr.IzvrsiKonkretnuSO(radnik);
            mock.Verify(b => b.VratiZaUslovOstalo(radnik), Times.Once());
            Assert.AreEqual(r, pov);
        }

        private List<OpstiDomenskiObjekat> ListaRadnika()
        {
            List<OpstiDomenskiObjekat> radnici = new List<OpstiDomenskiObjekat>
            {
                new Radnik
                {
                    ImePrezime = "Pera Peric",
                    KorisnickoIme = "Pera",
                    Lozinka = "Pera"
                },
                new Radnik
                {
                    ImePrezime = "Mika Mikic",
                    KorisnickoIme = "Mika",
                    Lozinka = "Mika"
                }
            };
            return radnici;
        }
    }
}
