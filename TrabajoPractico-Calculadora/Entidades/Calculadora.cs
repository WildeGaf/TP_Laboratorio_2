using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado=0;
            string auxiliar;
            auxiliar = ValidarOperador(operador);
            if (auxiliar == "+")
            {
                resultado = num1 + num2;
            }
            if (auxiliar == "-")
            {
                resultado = num1 - num2;
            }
            if (auxiliar == "*")
            {
                resultado = num1 * num2;
            }
            if (auxiliar == "/" && num2.getNumeroDos() != 0)
            {
                resultado = num1 / num2;
            }
            if (auxiliar == "/" && num2.getNumeroDos() == 0)
            {
                resultado = double.MinValue;
            }
            return resultado;
        }


        private static string ValidarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }
            return operador;
        }


    }
}
