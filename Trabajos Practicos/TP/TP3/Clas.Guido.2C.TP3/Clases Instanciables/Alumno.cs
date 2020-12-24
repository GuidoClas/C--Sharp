using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Enum
        public enum EEstadoCuenta { AlDia, Deudor, Becado }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor que permite la serialización.
        /// </summary>
        public Alumno() : base()
        {

        }

        /// <summary>
        /// Constructor que recibe los atributos de la clase, reutiliza el constructor base e inicializa el atributo claseQueToma.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base (id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor que recibe los atributos de la clase, reutiliza el constructor de esta clase e inicializa el atributo estadoCuenta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this (id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Methods
        /// <returns>Retorna un string indicando la clase que toma el objeto</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma;
        }
        /// <summary>
        /// Override de la clase base que permite mostrar los datos de la clase base y los de esta misma clase.
        /// </summary>
        /// <returns>Retorna un string con todos los datos mencionados.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Se encarga de hacer publicos los datos que devuelve el metodo MostrarDatos
        /// </summary>
        /// <returns>Retorna lo que retorna el metodo MostrarDatos en esta instancia</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operators
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if(a is null)
            {
                return false;
            }

            return a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase;
        }
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma != clase)
            {
                return true;
            }

            return false;
        }
        #endregion

    }
}
