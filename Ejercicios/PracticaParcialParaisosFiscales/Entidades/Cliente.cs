using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente):this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre):this(tipoCliente)
        {
            this._nombre = nombre;
        }
        
        private void CrearAlias()
        {
            Random rnd = new Random();
            int numAzar = rnd.Next(1000, 9999);
            StringBuilder sb = new StringBuilder();

            sb.Append(numAzar.ToString());
            sb.Append(this._tipoDeCliente.ToString());

            this._aliasParaIncognito = sb.ToString();
        }

        public string GetAlias()
        {
            string alias = this._aliasParaIncognito;
            if(alias == "Sin alias")
            {
                CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("Nombre: {0}", this._nombre);
            sb.AppendLine();
            sb.AppendFormat("Alias: {0}", this.GetAlias());
            sb.AppendLine();
            sb.AppendFormat("Tipo: {0}", this._tipoDeCliente);
            sb.AppendLine();

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente uncliente)
        {
            return uncliente.RetornarDatos();
        }

    }
}
