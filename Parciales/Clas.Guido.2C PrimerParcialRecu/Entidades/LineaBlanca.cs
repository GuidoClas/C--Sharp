using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class LineaBlanca : Producto
    {
        private bool aplicaDescuento;

        public int Descuento
        {
            get
            {
                if(this.aplicaDescuento)
                {
                    return 10;
                }
                else
                {
                    return 0;
                }
            }

        }

        public override int PorcentajeGanancia
        {
            get
            {
                return 10;
            }
        }

        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return 21;
            }
        }

        public override float ValorDeVenta
        {
            get
            {
                float total = base.ValorDeVenta;

                if(Descuento != 0)
                {
                    total += ((base.ValorDeVenta * this.Descuento) / 100);
                }

                total = total + ((total * this.PorcentajeImpuestoInterno) / 100);
                total = total + ((total * this.PorcentajeGanancia) / 100);

                return total;
            }
        }

        public LineaBlanca(string nombre, int valorDeCompra, Origen origen, bool aplicaDescuento)
            :this(nombre, valorDeCompra, origen)
        {
            this.aplicaDescuento = aplicaDescuento;
        }

        public LineaBlanca(string nombre, int valorDeCompra, Origen origen)
            :base(nombre, valorDeCompra, origen)
        {
        }

        public override string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Etiqueta());
            if(this.aplicaDescuento)
            {
                sb.AppendFormat(" Aplica descuento: SI");
            }
            else
            {
                sb.AppendFormat(" Aplica descuento: NO");
            }
            return sb.ToString();
        }

    }
}
