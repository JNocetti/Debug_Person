using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        // [SetUp]
        // public void Setup()
        // {
        //     // Insertá tu código de inicialización aquí
        // }

        [Test]
        public void TestValidID() // Cambiá el nombre para indicar qué estás probando
        {
            Person person = new Person("Juan Nocetti","5.390.966-5");
            person.ID= "8.765.432-1";
            Assert.AreEquals("8.765.432-1",person.ID)
        }
    }
}