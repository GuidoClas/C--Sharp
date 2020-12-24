using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza 
        {
            get
            {
                return this.raza;
            }
        }

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();

            return sb.AppendFormat("{0} - {1},", this.nombre, this.raza).ToString();
        }
        protected abstract string Ficha();
        
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool output = false;

            if(((object)m1) == null && ((object)m2) == null)
            {
                output = true;
            }
            else
            {
                if(((object)m1) != null && ((object)m2) != null)
                {
                    if(m1.Nombre == m2.Nombre && m1.Raza == m2.Raza)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
    }
}
