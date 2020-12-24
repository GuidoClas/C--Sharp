using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int catidadDeCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            catidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();

            sb1.AppendLine();
            sb1.AppendFormat("Fecha de Inicio: {0}", fechaInicioActividades);
            sb1.AppendLine();
            sb1.AppendFormat("Locacion: {0}", this._lugar);
            sb1.AppendLine();
            sb1.AppendFormat("Cantidad de 'cuentitas': {0}", catidadDeCuentas);
            sb1.AppendLine();
            sb1.AppendFormat("***********Listado de cuentas offshores***********");
            sb1.AppendLine();
            Console.WriteLine(sb1.ToString());
            foreach (CuentaOffShore i in this._listadoCuentas)
            {
                if (i != null)
                {
                    sb.AppendFormat(Cliente.RetornarDatos(i.Dueño));
                    sb.AppendFormat("Numero de cuenta: {0}", (int)i);
                    sb.AppendLine();
                    sb.AppendFormat("Saldo: {0}", i.Saldo);
                    sb.AppendLine();
                }

               
            }
                Console.WriteLine(sb.ToString());
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            if((object)pf != null && (object)cos != null)
            {
                foreach(CuentaOffShore i in pf._listadoCuentas)
                {
                    if(cos == i)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf != cos)
            {
                pf._listadoCuentas.Add(cos);
                ParaisoFiscal.catidadDeCuentas++;
                Console.WriteLine("Se agregó la cuenta al paraiso . . .");
            }
            else
            {
                foreach(CuentaOffShore i in pf._listadoCuentas)
                {
                    if(i == cos)
                    {
                        i.Saldo += cos.Saldo;
                        Console.WriteLine("Saldo de la cuenta actualizado");
                    }
                }
            }

            return pf;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                ParaisoFiscal.catidadDeCuentas--;
                Console.WriteLine("Se quitó la cuenta del paraiso . . .");
            }
            else
            {
                Console.WriteLine("No exista esa cuenta en el paraiso");
            }

            return pf;
        }

    }
}
