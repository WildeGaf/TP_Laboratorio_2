using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Hace una operacion entre el atributo numero de dos objetos
        /// </summary>
        /// <param name="num1">El primero objeto a operar </param>
        /// <param name="num2">El segundo objeto a operar </param>
        /// <param name="operador">La operacion que se quiere realizar</param>
        /// <returns>Retorna el resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            string auxiliar;
            auxiliar = ValidarOperador(operador);
            switch (auxiliar)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el operador sea valido.
        /// </summary>
        /// <param name="operador"> Recibe una operador como string </param>
        /// <returns>Retorna el operador ingresado, en caso de no ser valido retorna el operador suma </returns>
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
