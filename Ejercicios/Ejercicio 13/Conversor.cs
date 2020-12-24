using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string numero = "";
            int resultado = num;
         
           while(num > 1)
           {
                if(num % 2 == 1)
                {
                    resultado = num / 2;
                    numero += "1";
                }
                else
                {
                    resultado = num / 2;
                    numero += "0";
                }
                num = resultado;
           }

            numero += "1";
            numero = InvertirManualmente(numero);
            return numero;
        }

        public static int BinarioDecimal(string num)
        {
            int tam = num.Length;
            char caracter1;
            int caracter2;
            int total = 0;
            num = InvertirManualmente(num);
           

            for (int i = 0; i<tam; i++)
            {
                caracter1 = num[i];
                caracter2 = caracter1 - '0';
                total += Convert.ToInt32(caracter2 * Math.Pow(2, i));
            }

            return total;
        }

        public static string InvertirManualmente(string cadena)
        {
            string cadenaInvertida = "";

            foreach(char letra in cadena)
            {
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }
        
    }
}
