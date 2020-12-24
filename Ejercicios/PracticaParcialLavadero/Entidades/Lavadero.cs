using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        public string Lavaderoo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine();
                sb.AppendFormat("Precio Auto: {0}", this.precioAuto);
                sb.AppendLine();
                sb.AppendFormat("Precio Camion: {0}", this.precioCamion);
                sb.AppendLine();
                sb.AppendFormat("Precio Moto: {0}", this.precioMoto);
                sb.AppendLine();
                sb.Append(this.Vehiculos);

                return sb.ToString();
            }
        }

        public string Vehiculos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine();
                foreach (Vehiculo v in this.vehiculos)
                {
                    sb.AppendLine(v.Mostrar());
                }

                return sb.ToString();
            }
        }

        private Lavadero()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public double MostrarTotalFacturado()
        {
            double precioTotal = 0;

            foreach (Vehiculo item in this.vehiculos)
            {
                if (item is Auto)
                {
                    precioTotal += this.precioAuto;
                }

                if (item is Camion)
                {
                    precioTotal += this.precioCamion;
                }

                if (item is Moto)
                {
                    precioTotal += this.precioMoto;
                }
            }

            return precioTotal;
        }

        public double MostrarTotalFacturado(eVehiculos vehiculo)
        {
            double precioTotal = 0;

            switch (vehiculo)
            {
                case eVehiculos.Auto:
                    foreach (Vehiculo item in this.vehiculos)
                    {
                        if (item is Auto)
                        {
                            precioTotal += this.precioAuto;
                        }
                    }
                    break;
                case eVehiculos.Moto:
                    foreach (Vehiculo item in this.vehiculos)
                    {
                        if (item is Moto)
                        {
                            precioTotal += this.precioMoto;
                        }
                    }
                    break;
                case eVehiculos.Camion:
                    foreach (Vehiculo item in this.vehiculos)
                    {
                        if (item is Camion)
                        {
                            precioTotal += this.precioCamion;
                        }
                    }
                    break;
                default:
                    break;
            }

            return precioTotal;
        }

        public static bool operator ==(Lavadero lv, Vehiculo vl)
        {
            bool retorno = false;

            foreach (Vehiculo item in lv.vehiculos)
            {
                if (item == vl)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Lavadero lv, Vehiculo vl)
        {
            return !(lv == vl);
        }

        public static Lavadero operator +(Lavadero lv, Vehiculo vl)
        {
            if ((lv != vl))
            {
                lv.vehiculos.Add(vl);
                Console.Write("Se pudo agregar\n");
            }
            else
            {
                Console.Write("No se pudo agregar, ya existe\n");
            }


            return lv;
        }

        public static Lavadero operator -(Lavadero lv, Vehiculo vl)
        {
            if ((lv == vl))
            {
                lv.vehiculos.Remove(vl);
                Console.WriteLine("Se pudo eliminar del lavadero");
            }
            else
            {
                Console.WriteLine("No existe en el lavadero");
            }


            return lv;
        }

        public void OrdenarPorPatente()
        {
            this.vehiculos.Sort(OrdenarVehiculosPorPatente);
        }

        public void OrdenarPorMarca()
        {
            this.vehiculos.Sort(OrdenarVehiculosPorMarca);
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Patente, v2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(Enum.GetName(typeof(eMarca), v1.Marca), Enum.GetName(typeof(eMarca), v2.Marca));
        }

    }
}
