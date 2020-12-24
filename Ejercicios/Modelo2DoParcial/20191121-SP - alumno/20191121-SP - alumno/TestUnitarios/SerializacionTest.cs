using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class SerializacionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivosExcepcion))]
        public void CuandoSerializoDeberiaGuardarCorrectamente()
        {
        
                //arrange
                Planeta planeta = new Planeta(2, 1, 10, null);
                Planeta aux;
                Xml<Planeta> serializer = new Xml<Planeta>();

                //act
                serializer.Guardar("Planeta.xml", planeta);
                serializer.Leer("Planeta.xml", out aux);

                //assert   
                Assert.IsTrue
                (planeta.VelocidadTraslacion == aux.VelocidadTraslacion &&
                planeta.RadioRespectoSol == aux.RadioRespectoSol &&
                planeta.PosicionActual == aux.PosicionActual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosExcepcion))]
        public void CuandoSerializoConDirectorioInvalidoLanzaExcepcion()
        {
             //arrange
             Planeta aux;
             Xml<Planeta> serializer = new Xml<Planeta>();

             //act
             serializer.Leer("C:\\Planeta.xml", out aux);
        }
    }
}
