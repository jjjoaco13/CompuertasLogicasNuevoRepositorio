using NUnit.Framework;
using Program;


namespace Tests
{
    public class GarageGateTests
    {
        [Test]
        public void Caso_A0_B0_C0()
        {
            GarageGate gate = new GarageGate(0, 0, 0);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A0_B0_C1()
        {
            GarageGate gate = new GarageGate(0, 0, 1);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        public void Caso_A0_B1_C0()
        {
            GarageGate gate = new GarageGate(0, 1, 0);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A0_B1_C1()
        {
            GarageGate gate = new GarageGate(0, 1, 1);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A1_B0_C0()
        {
            GarageGate gate = new GarageGate(1, 0, 0);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A1_B0_C1()
        {
            GarageGate gate = new GarageGate(1, 0, 1);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A1_B1_C0()
        {
            GarageGate gate = new GarageGate(1, 1, 0);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void Caso_A1_B1_C1()
        {
            GarageGate gate = new GarageGate(1, 1, 1);
            int resultado = gate.EstaAbierto();
            Assert.That(resultado, Is.EqualTo(1));
        }
    }
}