using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTest
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void SommaPositivi()
        {
            int a = 3, b = 7;
            int sommaAspettata = 10;
            int sommaEffettiva = Gestione.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }
        [TestMethod]
        public void SommaNulli()
        {
            int a = 0, b = 0;
            int sommaAspettata = 0;
            int sommaEffettiva = Gestione.Somma(a, b);
            Assert.AreEqual(sommaAspettata, sommaEffettiva);
        }
    }
}
