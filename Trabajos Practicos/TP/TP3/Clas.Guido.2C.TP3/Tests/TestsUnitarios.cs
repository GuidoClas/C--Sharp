using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Clases_Instanciables;
using Excepciones;
using Archivos;

namespace Tests
{
    [TestClass]
    public class TestsUnitarios
    {
        [TestMethod]
        public void ValidaInstanciaDeColeccion()
        {
            //Arrange
            Universidad universidad;
            //Act
            universidad = new Universidad();
            //Assert
            Assert.IsNotNull(universidad.Alumnos);
            Assert.IsNotNull(universidad.Instructores);
            Assert.IsNotNull(universidad.Jornadas);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void LanzaExcepcionDniInvalido()
        {
            //Arrange
            string dni = "-1";
            Alumno alumno;
            //Act
            alumno = new Alumno(1, "Juan", "Lopez", dni, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void LanzaExcepcionNacionalidadInvalidaArgentino()
        {
            //Arrange
            string dni = "90000001";
            Alumno alumno;
            //Act
            alumno = new Alumno(3, "Federico", "Dávila", dni, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void LanzaExcepcionNacionalidadInvalidaExtranjero()
        {
            //Arrange
            string dni = "89999999";
            Alumno alumno;
            //Act
            alumno = new Alumno(3, "Mauricio", "Cerizza", dni, Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            //Assert
        }

    }
}
