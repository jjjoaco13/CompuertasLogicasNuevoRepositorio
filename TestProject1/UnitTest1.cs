using NUnit.Framework;
using Program;

namespace UnitTests
{
    [TestFixture]
    public class GarageGateTests
    {
        [Test]
        public void Garage_Cerrado_Cuando_A0_B0_C0()
        {
            var garage = new GarageGate(0, 0, 0);
            int resultado = garage.EstaAbierto();
            Assert.AreEqual(0, resultado);
        }

        [Test]
        public void Garage_Abierto_Cuando_A0_B0_C1()
        {
            var garage = new GarageGate(0, 0, 1);
            int resultado = garage.EstaAbierto();
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void Garage_Cerrado_Cuando_A1_B0_C1()
        {
            var garage = new GarageGate(1, 0, 1);
            int resultado = garage.EstaAbierto();
            Assert.IsFalse(0, resultado);
        }
    }
}