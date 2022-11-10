using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorraGirona.BussinesLayer;
using PorraGirona.DataLayer;
namespace ProvesUnitaries
{
    [TestClass]
    public class ProvesUnitaries
    {
        [TestMethod]
        public void Test_Comprova_CalculaPuntsUnaProva()
        {
            Porres porra = new Porres();
            Partits partit = new Partits();

            porra.Golslocal = 2;            porra.Golsvisitant = 1;
            partit.Golslocal = 2;           partit.Golsvisitant = 1;

            int punts = GestioMisc.CalculaPuntsUnaPorra(porra, partit);

            Assert.AreEqual(5, punts, "Prova no passada no son iguals");
        }
    }
}
