using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            char op;

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                op = operador;
            }
            else
            {
                op = '+';
            }
            return Convert.ToString(op); ;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;
            char op;

            if(string.IsNullOrEmpty(operador))
            {
                return 0;
            }
            else
            {
                op = Convert.ToChar(ValidarOperador(Convert.ToChar(operador)));
            }

            switch (op)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }

            return resultado;
        }

    }
}
