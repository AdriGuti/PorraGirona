using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorraGirona;
using PorraGirona.BussinesLayer;

namespace ProvaIntegralCalculPuntuacionsEntity
{
    [TestClass]
    public class CalculPuntacionsEntity
    {
        [TestMethod]
        public void CalculPuntsEntity()
        {
            bool result = GestioEntity.CalculaPuntuacionsEntity();
            Assert.IsTrue(result, GestioEntity.ErrorMessage);
        }
    }
}
