using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double inicialProject = 500;
            double saved = 100;
            double valoresperado = 600;
            Company person = new Company("Hola",inicialproject);

            //Actuar

            person.Save(saved);

            //Afirmar
            double valorresultado = person.SaveProject;
            Assert.AreEqual(valoresperado, valorresultado);
        }

    }
}
}
