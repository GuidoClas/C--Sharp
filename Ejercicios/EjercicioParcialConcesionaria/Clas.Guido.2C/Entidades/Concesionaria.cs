using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public double PrecioDeAutos 
        {
            get
            {
                double total = 0;
                foreach(Vehiculo item in this.vehiculos)
                {
                    if(item is Auto)
                    {
                        total += (float)(Auto)item;
                    }
                }
                return total;
            }
        }
        public double PrecioDeMotos
        {
            get
            {
                double total = 0;
                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Moto)
                    {
                        total += (float)(Moto)item;
                    }
                }
                return total;
            }
        }
        public double PrecioTotal
        {
            get
            {
                double total = this.PrecioDeAutos + this.PrecioDeMotos;

                return total;
            }
        }

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: {0}\n", c.capacidad);
            sb.AppendFormat("Total por autos: {0}\n", c.ObtenerPrecio(EVehiculo.PrecioDeAutos));
            sb.AppendFormat("Total por motos: {0}\n", c.ObtenerPrecio(EVehiculo.PrecioDeMotos));
            sb.AppendFormat("Total: {0}\n", c.ObtenerPrecio(EVehiculo.PrecioTotal));
            sb.AppendLine("****************************************");
            sb.AppendLine("Listado de Vehiculos");
            sb.AppendLine("****************************************");
            foreach(Vehiculo v in c.vehiculos)
            {
                if(v is Auto)
                {
                    sb.AppendLine(v.ToString());
                }

                if(v is Moto)
                {
                    sb.AppendLine(v.ToString());
                }
            }
            return sb.ToString();
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool seEncuentra = false;

            foreach(Vehiculo item in c.vehiculos)
            {
                if(item is Auto && v is Auto)
                {
                    if (((Auto)v) == ((Auto)item))
                    {
                        seEncuentra = true;
                    }
                }

                if (item is Moto && v is Moto)
                {
                    if (((Moto)v) == ((Moto)item))
                    {
                        seEncuentra = true;
                    }
                }

            }
         
            return seEncuentra;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if (!(c == v) && c.vehiculos.Count < c.capacidad && c.capacidad > 0)
            {
                c.vehiculos.Add(v);
            }
            else
            {
                if((c == v))
                { 
                    Console.WriteLine("El vehiculo ya esta en la concesionaria!!!");
                }

                if(c.vehiculos.Count >= c.capacidad || c.capacidad <= 0)
                {
                    Console.WriteLine("No hay mas lugar en la concesionaria!!!");
                }
            }

            return c;
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double total = 0;

            switch(tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    total = this.PrecioDeAutos;
                    break;
                case EVehiculo.PrecioDeMotos:
                    total = this.PrecioDeMotos;
                    break;
                case EVehiculo.PrecioTotal:
                    total = this.PrecioTotal;
                    break;
                default:
                    break;
            }

            return total;
        }
    }
}
