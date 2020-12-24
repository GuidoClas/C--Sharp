using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (!string.IsNullOrEmpty(strNumero) && double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }

            return retorno;
        }

        #region constructors
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion
        #region converters
        public string BinarioDecimal(string binario)
        {
            int auxNum;

            if (!EsBinario(binario) && !string.IsNullOrEmpty(binario))
            {
                auxNum = Convert.ToInt32(binario, 2);
            }
            else
            {
                return "Valor Invalido";
            }

            return auxNum.ToString();
        }

        public string DecimalBinario(double numero)
        {
            string num;
            if (numero < 0)
            {
                num = "Valor invalido";
            }
            else
            {
                num = Convert.ToString(Convert.ToInt32(numero), 2);
            }
            

            return num;
        }

        public string DecimalBinario(string numero)
        {
            if(string.IsNullOrEmpty(numero))
            {
                return DecimalBinario(Convert.ToDouble(0));
            }
            else
            {
                return DecimalBinario(Convert.ToDouble(numero));
            }
            
        }

        private bool EsBinario(string binario)
        {
            bool isBinary = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' || binario[i] != '1')
                {
                    isBinary = false;
                }
            }
            return isBinary;
        }
        #endregion
        #region OpOverloads
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            return num2.numero == 0 ? double.MinValue : num1.numero / num2.numero;
        }
        #endregion

    }
}
