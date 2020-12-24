using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using SQL;
using Serializadores;

namespace TestsUnitarios
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TesteaQueSeSerialiceCorrectamente()
        {
            //Arrange
            Carrera c = new Carrera("Toretto", "Walker", 50);
            Carrera aux;
            XmlSerializer<Carrera> xml = new XmlSerializer<Carrera>();
            //Act
            xml.Guardar("pruebaCarrera.xml", c);
            xml.Leer("pruebaCarrera.xml", out aux);
            //Assert
            Assert.AreEqual(c.CorredorElegido, aux.CorredorElegido);
            Assert.AreEqual(c.Ganador, aux.Ganador);
            Assert.AreEqual(c.TotalApuestasPorPicada, aux.TotalApuestasPorPicada);

        }

        [TestMethod]
        public void TesteaMetodoDeExtensionDeString()
        {
            //Arrange
            string pathNecesitado = @"Server=localhost\SQLEXPRESS;Database=BaseCarreras;Trusted_Connection=True;";
            string baseRecibida = "Database=BaseCarreras;";
            string pathFinal;
            //Act
            pathFinal = baseRecibida.DevolverConnectionString();
            //Assert
            Assert.AreEqual(pathFinal, pathNecesitado);
        }
    }
}
