using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        public static EtipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        static Grupo()
        {
            Tipo = EtipoManada.Unica;
        }
        private Grupo() 
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Tipo = tipo;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Grupo: {0} - Tipo: {1}\n", g.nombre, Grupo.tipo);
            sb.AppendFormat("Integrantes({0}):\n", g.manada.Count);
           
            foreach(Mascota m in g.manada)
            {
                if(m is Perro)
                {
                    sb.AppendLine(m.ToString());
                }

                if(m is Gato)
                {
                    sb.AppendLine(m.ToString());
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool output = false;

            foreach(Mascota mascota in g.manada)
            {
                if(mascota == m)
                {
                    output = true;
                }
            }

            return output;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            bool esta = false;
            foreach(Mascota mascota in g.manada)
            {
                if(mascota == m)
                {
                    Console.WriteLine("Ya está '{0}", mascota.ToString());
                    esta = true;
                    break;
                }
                
            }
            if(!esta)
            {
                g.manada.Add(m);
            }

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            bool esta = false;
            foreach (Mascota mascota in g.manada)
            {
                if (mascota == m)
                {
                    esta = true;
                    break;
                }
                
            }

            if(esta)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No está el {0} en el grupo", m.ToString());
            }

            return g;
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Grupo)
            {
                output = this == (Grupo)obj;
            }

            return output;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
