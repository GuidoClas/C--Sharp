using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public abstract class Producto
    {
        private string nombre;
        private Origen origen;
        private int valorDeCompra;

        public enum Origen
        {
            Nacional,
            Importado
        }

        public abstract int PorcentajeGanancia { get;}
        public abstract int PorcentajeImpuestoInterno { get;}
        public int PorcentajeImpuestoImportacion
        {
            get 
            {
                int porcentaje = 0;
                switch (this.origen)
                {
                    case Origen.Nacional:
                        porcentaje = 0;
                        break;
                    case Origen.Importado:
                        porcentaje = 35;
                        break;
                    default:
                        break;
                }
                return porcentaje;
            }
        }
        public virtual float ValorDeVenta
        {
            get
            {
                float total = 0;

                total += ((this.PorcentajeImpuestoImportacion * this.valorDeCompra) / 100) + this.valorDeCompra;
                
                return total;
            }
        }

        protected Producto(string nombre, int valorDeCompra, Origen origen)
        {
            this.nombre = nombre;
            this.valorDeCompra = valorDeCompra;
            this.origen = origen;
        }

        public static explicit operator Origen(Producto p)
        {
            return p.origen;
        }

        public virtual string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Producto {0} comprado a {1} como {2} - ", this.nombre, this.valorDeCompra, this.origen);

            return sb.ToString();
        }
    }
}
