using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Busch;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUnitarioAHORRO()
        {
            //Organizar
            string Nombre = "TestUnitarioAHORRO";
            double Monto= 500;
            double Montoutilizado = 400;
            double valoresperado = 100;
            Company ObjetoPrueba = new Company("HOLA", Monto);

            //Actuar

             ObjetoPrueba.Save(Montoutilizado);

            //Afirmar
            double valorresultado = ObjetoPrueba.SaveProject;
            Assert.AreEqual(valoresperado, valorresultado);
        }
        public void TestUnitarioNombre()
        {
            //Organizar
            string NombreInicial = "Busch";
            string NombreNuevo = "Valeria";
            string valoresperado = "Valeria";
            Company person = new Company(NombreInicial, 100);

            //Actuar

            person.ChangeName(NombreNuevo);

            //Afirmar
            string valorresultado = person.Name;
            Assert.AreEqual(valoresperado, valorresultado);
        }
    }
}
}
