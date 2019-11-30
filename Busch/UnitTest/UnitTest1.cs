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
            double Monto= 500;
            double Montoutilizado = 100;
            double valoresperado = 600;
            Company ObjetoPrueba = new Company("HOLA", Monto);

            //Actuar

             ObjetoPrueba.Save(Montoutilizado);

            //Afirmar
            double valorresultado = ObjetoPrueba.SaveProject;
            Assert.AreEqual(valoresperado, valorresultado);
        }
        [TestMethod]
        public void TestUnitarioNombre()
        {
            //Organizar
            string NombreInicial = "Busch";
            string NombreNuevo = "Valeria";
            string valoresperado = "Valeria";
            Company persona = new Company(NombreInicial, 100);

            //Actuar

            persona.ChangeName(NombreNuevo);

            //Afirmar
            string valorresultado = persona.Name;
            Assert.AreEqual(valoresperado, valorresultado);
        }
    }
}

