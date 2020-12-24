using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño
        {
            get
            {
                return this._dueño;
            }
        }

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this._saldo = value;
            }
        }

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this.Saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial) : this(new Cliente(tipo, nombre), numero, saldoInicial)
        {
        }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;
            if (((object)cos1) == null && ((object)cos2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)cos1) != null && ((object)cos2) != null)
                {
                    if (cos1._numeroCuenta == cos2._numeroCuenta && cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias())
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
        public override bool Equals(object o)
        {  
            return true;  
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
