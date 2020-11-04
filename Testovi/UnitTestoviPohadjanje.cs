using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SOPohadjanje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviPohadjanje
    {
        [TestMethod]
        public void ZapamtiPohadjanjeUspesno()
        {
            Pohadjanje pohadjanje = new Pohadjanje();
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.IzmeniUslovPrimarni(pohadjanje)).Returns(1);

            ZapamtiPohadjanje zp = new ZapamtiPohadjanje();
            zp.Broker = mock.Object;
            int pov = (int)zp.IzvrsiKonkretnuSO(pohadjanje);
            mock.Verify((b => b.IzmeniUslovPrimarni(pohadjanje)), Times.Once);
            Assert.AreEqual(1, pov);
        }

        [TestMethod]
        public void UnesiPohadjanjeUspesno()
        {
            Pohadjanje pohadjanje = new Pohadjanje();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(pohadjanje)).Returns(1);
            mock.Setup(b => b.Sacuvaj(pohadjanje));

            UnesiPohadjanje up = new UnesiPohadjanje();
            up.Broker = mock.Object;
            Pohadjanje pov = (Pohadjanje)up.IzvrsiKonkretnuSO(pohadjanje);
            mock.Verify((b => b.VratiSifru(pohadjanje)), Times.Once());
            Assert.IsTrue(pov != null);
            Assert.AreEqual(1, pov.IDPohadjanje);
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void UnesiPohadjanjeNeuspesno()
        {
            Pohadjanje pohadjanje = new Pohadjanje();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(null)).Throws<Exception>();
            mock.Setup(b => b.Sacuvaj(pohadjanje));

            UnesiPohadjanje up = new UnesiPohadjanje();
            up.Broker = mock.Object;
            Pohadjanje pov = (Pohadjanje)up.IzvrsiKonkretnuSO(null);
            mock.Verify((b => b.Sacuvaj(pohadjanje)), Times.Never);
        }

        [TestMethod]
        public void PrikaziPohadjanjaZaUcenikaUspesno()
        {
            Pohadjanje p = ListaPohadjanja()[0] as Pohadjanje;

            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> pohadjanja = ListaPohadjanja();
            mock.Setup(b => b.VratiSveZaUslovOstalo(p)).Returns(pohadjanja);
            mock.Setup(b => b.VratiZaUslovPrimarni(It.IsAny<Kurs>())).Returns(p.Kurs);

            PrikaziPohadjanjaZaUcenika ppzu = new PrikaziPohadjanjaZaUcenika();
            ppzu.Broker = mock.Object;
            List<Pohadjanje> pov = (List<Pohadjanje>)ppzu.IzvrsiKonkretnuSO(p);
            mock.Verify(b => b.VratiSveZaUslovOstalo(p), Times.Once());
            mock.Verify(b => b.VratiZaUslovPrimarni(It.IsAny<Kurs>()), Times.Exactly(pohadjanja.Count));
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(pohadjanja[i], pov[i]);
            }
        }

        [TestMethod]
        public void PretraziSveKurseveUspesno()
        {
            Kurs kurs = new Kurs();
            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> kursevi = ListaKurseva();
            mock.Setup(b => b.ObrisiZaUslovOstalo(It.IsAny<Kurs>()));
            mock.Setup(b => b.VratiSve(kurs))
                .Returns(kursevi);

            PretraziSveKurseve psk = new PretraziSveKurseve();
            psk.Broker = mock.Object;
            List<Kurs> pov = (List<Kurs>)psk.IzvrsiKonkretnuSO(kurs);
            mock.Verify(b => b.ObrisiZaUslovOstalo(It.IsAny<Kurs>()), Times.Once());
            mock.Verify(b => b.VratiSve(kurs), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(kursevi[i], pov[i]);
            }
        }

        [TestMethod]
        public void ObrisiPohadjanjeUspesno()
        {
            Pohadjanje pohadjanje = new Pohadjanje();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.ObrisiZaUslovPrimarni(pohadjanje)).Returns(1);

            ObrisiPohadjanje op = new ObrisiPohadjanje();
            op.Broker = mock.Object;
            int pov = (int)op.IzvrsiKonkretnuSO(pohadjanje);
            mock.Verify(b => b.ObrisiZaUslovPrimarni(pohadjanje), Times.Once());
            Assert.AreEqual(1, pov);
        }

        private List<OpstiDomenskiObjekat> ListaKurseva()
        {
            List<OpstiDomenskiObjekat> kursevi = new List<OpstiDomenskiObjekat>
            {
                new Kurs
                {
                    IDKurs =1,
                    Naziv = "Eng A1 okt-jan"
                },
                new Kurs
                {
                    IDKurs =2,
                    Naziv = "Nem A1 jun-jan"
                },
            };
            return kursevi;
        }

        private List<OpstiDomenskiObjekat> ListaPohadjanja()
        {
            List<OpstiDomenskiObjekat> pohadjanja = new List<OpstiDomenskiObjekat>
            {
                new Pohadjanje
                {
                    IDPohadjanje = 1,
                    Kurs = new Kurs
                    {
                        IDKurs=1
                    },
                    Ucenik = new Ucenik
                    {
                        IDUcenik =1
                    }
                },
                new Pohadjanje
                {
                    IDPohadjanje=2,
                     Kurs = new Kurs
                    {
                        IDKurs=1
                    },
                    Ucenik = new Ucenik
                    {
                        IDUcenik =2
                    }
                }
            };
            return pohadjanja;
        }
    }
}
