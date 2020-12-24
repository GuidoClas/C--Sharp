using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Smartphone : Producto
    {
        public override int PorcentajeGanancia
        {
            get
            {
                return 21;
            }

        }

        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return 10;
            }

        }

        public override float ValorDeVenta
        {
            get
            {
                float total = base.ValorDeVenta;

                if((Origen)this == Origen.Nacional)
                {
                    total = total - ((total * 20) / 100);
                }

                total = total + ((total * this.PorcentajeImpuestoInterno) / 100);
                total = total + ((total * this.PorcentajeGanancia) / 100);

                return total;
            }

        }

        public Smartphone(string nombre, int valorDeCompra, Origen origen)
            :base(nombre, valorDeCompra, origen)
        {      
        }
    }
}
