using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructors
        /// <summary>
        /// Constructor que permite la serialización.
        /// </summary>
        public Universitario()
            : base()
        {
        }
        /// <summary>
        /// Constructor que inicializa el legajo, y reutiliza el constructor de clase base para inicializar los atributos.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Metodo virtual que permite mostrar todos los datos y re-implementar en clases derivadas.
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat("LEGAJO: {0}\n", this.legajo);

            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();
        #endregion

        #region Operators
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1 is null || pg2 is null)
            {
                return false;
            }

            return pg1.Equals(pg2) && pg1.DNI == pg2.DNI;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }
        #endregion
    }
}
