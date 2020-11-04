using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SOPrisustvo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviPrisustvo
    {
        [TestMethod]
        public void VratiPrisustvaZaTerminUspesno()
        {
            Prisustvo prisustvo = new Prisustvo();
            List < OpstiDomenskiObjekat >  prisustva= ListaPrisustva();
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.VratiSveZaUslovOstalo(prisustvo)).Returns(prisustva);

            VratiPrisustvaZaTermin vpzt = new VratiPrisustvaZaTermin();
            vpzt.Broker = mock.Object;
            List<Prisustvo> pov = (List<Prisustvo>)vpzt.IzvrsiKonkretnuSO(prisustvo);
            mock.Verify(b => b.VratiSveZaUslovOstalo(prisustvo), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(prisustva[i], pov[i]);
            }
        }

        [TestMethod]
        public void UnesiPrisustvoUspesno()
        {
            Prisustvo prisustvo = ListaPrisustva()[0] as Prisustvo;
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(prisustvo)).Returns(1);
            mock.Setup(b => b.Sacuvaj(prisustvo));

            UnesiPrisustvo up = new UnesiPrisustvo();
            up.Broker = mock.Object;
            Prisustvo pov = (Prisustvo)up.IzvrsiKonkretnuSO(prisustvo);
            mock.Verify((b => b.VratiSifru(prisustvo)), Times.Once());
            Assert.IsTrue(pov != null);
            Assert.AreEqual(1, pov.IdPrisustvo);
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void UnesiPrisustvoaNeuspesno()
        {
            Prisustvo prisustvo = new Prisustvo();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(null)).Throws<Exception>();
            mock.Setup(b => b.Sacuvaj(prisustvo));

            UnesiPrisustvo up = new UnesiPrisustvo();
            up.Broker = mock.Object;
            Prisustvo pov = (Prisustvo)up.IzvrsiKonkretnuSO(null);
            mock.Verify((b => b.Sacuvaj(prisustvo)), Times.Never);
        }

        [TestMethod]
        public void SacuvajPrisustvoUspesno()
        {
            Prisustvo prisustvo= ListaPrisustva()[1] as Prisustvo;
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.IzmeniUslovPrimarni(prisustvo)).Returns(1);

            UnesiPrisustvo sp = new UnesiPrisustvo();
            sp.Broker = mock.Object;
            int pov = (int)sp.IzvrsiKonkretnuSO(prisustvo);
            mock.Verify((b => b.IzmeniUslovPrimarni(prisustvo)), Times.Once);
            Assert.AreEqual(1, pov);
        }

        [TestMethod]
        public void IzbrisiPrisustvoUspesno()
        {
            Prisustvo prisustvo = ListaPrisustva()[1] as Prisustvo;
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.ObrisiZaUslovOstalo(prisustvo)).Returns(1);

            IzbrisiPrisustvo ip = new IzbrisiPrisustvo();
            ip.Broker = mock.Object;
            int pov = (int)ip.IzvrsiKonkretnuSO(prisustvo);
            mock.Verify(b => b.ObrisiZaUslovOstalo(prisustvo), Times.Once());
            Assert.AreEqual(1, pov);
        }

        [TestMethod]
        public void DaLiPostojiPrisustvoUspesno()
        {
            Prisustvo p1 = ListaPrisustva()[1] as Prisustvo;
            Prisustvo p2 = new Prisustvo()
            {
                Termin = p1.Termin,
                Ucenik = p1.Ucenik,
                Kurs = p1.Kurs
            };
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.VratiZaUslovOstalo(p2)).Returns(p1);

            DaLiPostojiPrisustvo dlpp = new DaLiPostojiPrisustvo();
            dlpp.Broker = mock.Object;
            Prisustvo pov = (Prisustvo)dlpp.IzvrsiKonkretnuSO(p2);
            mock.Verify(b => b.VratiZaUslovOstalo(p2), Times.Once);
            Assert.IsTrue(pov != null);
            Assert.AreEqual(p1, pov);
        }

        private List<OpstiDomenskiObjekat> ListaPrisustva()
        {
            List<OpstiDomenskiObjekat> prisustva = new List<OpstiDomenskiObjekat>()
            {
                new Prisustvo
                {
                    IdPrisustvo =1,
                    Termin = new Termin
                    {
                        IdTermin=1,
                        
                    },
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    Ucenik = new Ucenik
                    {
                        IDUcenik =1
                    }
                },
                 new Prisustvo
                {
                    IdPrisustvo =2,
                    Termin = new Termin
                    {
                        IdTermin=1,

                    },
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    Ucenik = new Ucenik
                    {
                        IDUcenik =2
                    }

                },
                  new Prisustvo
                {
                    IdPrisustvo =3,
                    Termin = new Termin
                    {
                        IdTermin=1,

                    },
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    Ucenik = new Ucenik
                    {
                        IDUcenik =3
                    }

                },
            };
            return prisustva;
        }
    }
}
