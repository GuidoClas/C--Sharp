using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region Enum
        public enum ENacionalidad { Argentino, Extranjero }
        #endregion

        #region Props
        
        /// <summary>
        /// Validara que el apellido tenga formato correcto, sino no lo cargara
        /// </summary>
        public string Apellido
        {
            get 
            { 
                return this.apellido; 
            }
            set 
            { 
                if(ValidarNombreApellido(value) != "")
                {
                    this.apellido = value; 
                }
            }
        }
        /// <summary>
        /// Get devolverá el DNI. Set asignara el DNI previa validación.
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        /// <summary>
        /// Validara que el nombre tenga formato correcto, sino no lo cargara
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (ValidarNombreApellido(value) != "")
                {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Set asignara el DNI previa validación.
        /// </summary
        public string StringToDNI
        { 
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor que permitira la serialización.
        /// </summary
        public Persona()
        {
        }

        /// <summary>
        /// Constructor que recibe e inicializa nombre, apellido, nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, Persona.ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor que recibe e inicializa nombre, apellido, nacionalidad reutilizando codigo, y luego el dni.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, Persona.ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor que recibe e inicializa nombre, apellido, nacionalidad reutilizando codigo, y luego el dni en formato string.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Methods

        /// <summary>
        /// El metodo verificara que la nacionalidad se condice con el dni a settear y tenga formato correcto, de otra manera, lanzara una excepcion de formato o nacionalidad invalida.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Retorna el dato validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            bool lanzaExcepcion = false;
            
            switch (nacionalidad)    
            {
                case ENacionalidad.Argentino:
                    if(dato >= 1 && dato <= 89999999)
                    {
                        return dato;
                    }
                    lanzaExcepcion = true;
                    break;
                case ENacionalidad.Extranjero:
                    if(dato >= 90000000 && dato <= 99999999)
                    {
                        return dato;
                    }
                    lanzaExcepcion = true;
                    break;
                default:
                    break;
            }

            if(lanzaExcepcion)
            {
                if(dato < 1 || dato > 100000000)
                {
                    throw new DniInvalidoException();
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }    
            }

            return dato;
        }
        /// <summary>
        /// El metodo verificara que la nacionalidad se condice con el dni a settear y tenga formato correcto, de otra manera, lanzara una excepcion de formato o nacionalidad invalida.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Retorna el dato validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno;
            int dni;
            bool parseExitoso;

            parseExitoso = Int32.TryParse(dato, out dni);

            if(parseExitoso)
            {
                retorno = ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoException();
            }

            return retorno;
        }

        /// <summary>
        /// Validara que el nombre/apellido a settear contenga el formato adecuado
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Retorna el dato validado</returns>
        private string ValidarNombreApellido(string dato)
        { 
            for(int i = 0; i < dato.Length; i++)
            {
                if(!(char.IsLetter(dato, i)))
                {
                    return "";
                }
            }

            return dato;
        }

        /// <summary>
        /// ToString se encarga de hacer visibles todos los datos de la Persona.
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNACIONALIDAD: {2}\n", this.Apellido, this.Nombre, this.Nacionalidad);

            return sb.ToString();
        }
        #endregion

    }
}
