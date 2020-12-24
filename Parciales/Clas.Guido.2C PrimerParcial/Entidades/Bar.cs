using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public List<Empleado> Empleados
        {
            get { return this.empleados; } 
        }

        public List<Gente> Gente
        {
            get { return this.gente; }
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            bool esta = false;
            bool seAgrego = false;

            foreach(Empleado e in bar.Empleados)
            {
                if(e == empleado)
                {
                    esta = true;
                }
            }

            if(!esta && empleado.Validar())
            {
                bar.empleados.Add(empleado);
                seAgrego = true;
            }

            return seAgrego;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            bool seAgrego = false;

            if(bar.Gente.Count < (bar.Empleados.Count*10))  
            { 
                if (gente.Validar())
                {
                     bar.gente.Add(gente);
                     seAgrego = true;
                }
            }

            return seAgrego;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(Empleado item in this.Empleados)
            {
                sb.AppendFormat("EMPLEADO\n");
                sb.AppendLine((string)item);
            }

            foreach (Gente item in this.Gente)
            {
                sb.AppendFormat("GENTE\n");
                sb.AppendLine((string)item);
            }

            return sb.ToString();
        }

        public static Bar GetBar()
        {
            if(object.ReferenceEquals(Bar.singleton, null))
            {
                Bar.singleton = new Bar();
            }    
            
            return Bar.singleton;
        }

    }
}
