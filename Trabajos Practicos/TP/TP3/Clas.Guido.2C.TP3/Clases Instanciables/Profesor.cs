using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        #region Constructors
        /// <summary>
        /// Constructor estatico que se encarga de inicializar el atributo estatico random.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }
        /// <summary>
        /// Constructor que permite la serialización.
        /// </summary>
        public Profesor() : base()
        {
        }
        /// <summary>
        /// Constructor que inicializa los atributos reutilizando el constructor base, e inicializa los atributos clasesDelDia y random (con un valor random).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base (id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._RandomClases();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que se encarga de inicializar la Queue con dos clases aleatorias a traves del atributo estatico random.
        /// </summary>
        private void _RandomClases()
        {
            int cantidadEnum = Enum.GetNames(typeof(Universidad.EClases)).Length;
            int numRandom = Profesor.random.Next(1, cantidadEnum);

            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom);

            numRandom = Profesor.random.Next(1, cantidadEnum);

            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom);
        }

        /// <summary>
        /// Metodo que devuelve todos los datos de la clase base, ademas de las clases en las que participa.
        /// </summary>
        /// <returns>Retorna un string con todos los datos antes mencionado</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que retorna todas las clases del dia en la Queue.
        /// </summary>
        /// <returns>Retorna toda la información en formato string</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA:");
            
            foreach(Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Se encarga de hacer publicos todos los datos de la clase.
        /// </summary>
        /// <returns>Retorna un string con lo que retorna el metodo MostrarDatos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operators
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            if(i is null)
            {
                return false;
            }

            foreach(Universidad.EClases c in i.clasesDelDia)
            {
                if(c == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
