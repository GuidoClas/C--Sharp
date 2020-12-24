using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Empresa
    {
        private int limiteProductos;
        private string nombre;
        private List<Producto> productos;

        public Empresa()
        {
            this.productos = new List<Producto>(); 
        }
        public Empresa(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Empresa(string nombre, int limite) : this(nombre)
        {
            this.limiteProductos = limite;
        }

        public static Empresa operator +(Empresa empresa, Producto producto)
        {
            if (empresa.productos.Count < empresa.limiteProductos)
            {
                empresa.productos.Add(producto);
            }

            return empresa;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Productos de la empresa {0}\n", this.nombre);

            foreach(Producto item in this.productos)
            {
                sb.AppendLine(item.Etiqueta());
                sb.AppendFormat("FACTURACION VENTA: {0}\n", item.ValorDeVenta);
            }
            return sb.ToString();
        }

    }
}
