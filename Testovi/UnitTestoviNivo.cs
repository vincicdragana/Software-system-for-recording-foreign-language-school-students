using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SONivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviNivo
    {
        [TestMethod]
        public void UnesiNivoUspesno()
        {
            Nivo nivo = new Nivo();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(nivo)).Returns(1);
            mock.Setup(b => b.Sacuvaj(nivo));

            UnesiNivo un = new UnesiNivo();
            un.Broker = mock.Object;
            Nivo pov = (Nivo)un.IzvrsiKonkretnuSO(nivo);
            mock.Verify((b => b.VratiSifru(nivo)), Times.Once());
            Assert.IsTrue(pov != null);
            Assert.AreEqual(1, pov.IDNivo);
        }

        [TestMethod]
        public void UnesiNivoNeuspesno()
        {
            Nivo nivo = new Nivo();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(null)).Returns(1);
            mock.Setup(b => b.Sacuvaj(nivo));

            UnesiNivo un = new UnesiNivo();
            un.Broker = mock.Object;
            Nivo pov = (Nivo)un.IzvrsiKonkretnuSO(null);
            mock.Verify((b => b.Sacuvaj(nivo)), Times.Never());
        }

        [TestMethod]
        public void ZapamtiNivoUspesno()
        {
            Nivo nivo = new Nivo
            {
                Naziv = "Eng A1 sept-jan"
            };
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.IzmeniUslovPrimarni(nivo)).Returns(1);

            ZapamtiNivo zn = new ZapamtiNivo();
            zn.Broker = mock.Object;
            int pov = (int)zn.IzvrsiKonkretnuSO(nivo);
            mock.Verify((b => b.IzmeniUslovPrimarni(nivo)), Times.Once);
            Assert.AreEqual(1, pov);
        }

        [TestMethod]
        public void PretraziSveJezikeUspesno()
        {
            Jezik jezik = new Jezik();
            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> jezici = ListaJezika();
            mock.Setup(b => b.VratiSve(jezik))
                .Returns(jezici);

            PretraziSveJezike psj = new PretraziSveJezike();
            psj.Broker = mock.Object;
            List<Jezik> pov = (List<Jezik>)psj.IzvrsiKonkretnuSO(jezik);
            mock.Verify(b => b.VratiSve(jezik), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(jezici[i], pov[i]);
            }
        }

        private List<OpstiDomenskiObjekat> ListaJezika()
        {
            List<OpstiDomenskiObjekat> jezici = new List<OpstiDomenskiObjekat>
            {
                new Jezik
                {
                    IDJezik =1,
                    Naziv = "Engleski"
                },
                new Jezik
                {
                    IDJezik =2,
                    Naziv = "Nemacki"
                }
            };
            return jezici;
        }
    }
}
