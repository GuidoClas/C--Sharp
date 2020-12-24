using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void TesteaSiSeGuardaYLeeCorrectamente()
        {
            //arrange
            Bombero bombero = new Bombero("Jorge");
            Bombero auxBombero;

            //act
            bombero.Guardar(bombero);
            auxBombero = bombero.Leer();

            //assert   
            Assert.IsTrue
            (auxBombero.Nombre == bombero.Nombre);
        }

        [TestMethod]
        public void TesteaElMetodoDeExtension()
        {
            //arrange
            DateTime inicio = DateTime.Now;
            DateTime fin = DateTime.Now;

            //act
            //assert 
            Assert.IsTrue(inicio.DiferenciaEnMinutos(fin) == 0);
        }
    }
}
