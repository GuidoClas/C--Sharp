using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Props
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor que inicializa la lista de alumnos.
        /// </summary>
        public Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor que reutiliza su sobrecarga, e inicializa el atributo clase e instructor.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) :this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Se encarga de guardar en formato .txt los datos del objeto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns>Retorna true o false dependiendo del retorno del metodo que serializa, y de si se lanzo una excepcion o no</returns>
        public static bool Guardar(Jornada jornada)
        {
            bool retorno;
            Texto guardar = new Texto();

            try
            {
                retorno = guardar.Guardar("Jornada.txt", jornada.ToString());
            }
            catch(Excepciones.ArchivosException)
            {
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Se encarga de leer el archivo .txt y devolver sus datos en formato string.
        /// </summary>
        /// <returns>Retornara dependiendo de si hubo una excepcion, los datos originales, o el mensaje de la excepcion</returns>
        public static string Leer()
        {
            Texto cargar = new Texto();
            string retorno;

            try
            {
                cargar.Leer("Jornada.txt", out retorno);
            }
            catch(Excepciones.ArchivosException ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }
        /// <summary>
        /// Metodo que se encarga de hacer visibles todos los datos de la clase, ademas de los datos incorporados en su lista.
        /// </summary>
        /// <returns>Retorna un string con todos los datos mencionados</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            sb.AppendFormat("CLASE DE {0} POR: {1}\n", this.Clase, this.Instructor.ToString());
            sb.AppendLine("Alumnos:\n");

            foreach(Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }

            sb.AppendLine("< ----------------------------------------------------------->");

            return sb.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(Jornada j, Alumno a)
        {
            if(j is null || a is null)
            {
                return false;
            }

            return a == j.Clase;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(a == j.Clase);
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
        }
        #endregion
    }
}
