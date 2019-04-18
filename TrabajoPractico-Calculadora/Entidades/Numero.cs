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


        /// <summary>
        /// Contructor de la clase, inicializa en 0.
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// Contructor de la clase, inicializa por parametro double.
        /// </summary>
        /// <param name="num">numero a asignar </param>
        public Numero(double num) : this(num.ToString())
        {

        }

        /// <summary>
        /// Contructor de la clase, inicializa por parametro string.
        /// </summary>
        /// <param name="num">numero a asignar</param>
        public Numero(string num)
        {
            SetNumero(num);
        }

        /// <summary>
        /// Asigna el valor al atributo
        /// </summary>
        /// <param name="numeroAux">Numero a asignar</param>
        public void SetNumero(string numeroAux)
        {
            this.numero = this.ValidarNumero(numeroAux);
        }

        /// <summary>
        /// Recibe un string y lo convierte en double.
        /// </summary>
        /// <param name="numeroAux">Numero a convertir</param>
        /// <returns>Retorna el numero ingresado como double o 0 en caso de error</returns>
        private double ValidarNumero(string numeroAux)
        {
            double numero;
            if (double.TryParse(numeroAux, out numero))
            {
                return numero;
            }
            else
            {
                numero = 0;
                return numero;
            }
        }

        /// <summary>
        /// Convierte un numero binario en decimal.
        /// </summary>
        /// <param name="binarioAux">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en decimal</returns>
        public static string BinarioDecimal(string binarioAux)
        {
            int binario, cantidad, i, exponente = 0;
            string resultado;
            double suma = 0;
            cantidad = binarioAux.Length;
            int.TryParse(binarioAux, out binario);
            for (i = cantidad - 1; i >= 0; i--)
            {

                if (binarioAux[i] == '1')
                {
                    suma += Math.Pow(2, exponente);
                }
                exponente++;
            }
            resultado = suma.ToString();
            return resultado;
        }

        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numero">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en binario</returns>
        public static string DecimalBinario(double numero)
        {
            double resto;
            string auxString, resultado = "";
            int division = (int)numero;
            if (numero > 0)
            {
                while (division >= 2)
                {
                    resto = division % 2;
                    division = division / 2;

                    auxString = resto.ToString();
                    resultado = auxString + resultado;
                }
                resultado = "1" + resultado;
            }
            else
            {
                resultado = "0";
            }
            return resultado;
        }

        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numeroAux">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en binario</returns>
        public static string DecimalBinario(string numeroAux)
        {
            double numero;
            string resultado;
            double.TryParse(numeroAux, out numero);
            resultado = DecimalBinario(numero);
            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador "-" (atributo numero)
        /// </summary> 
        /// <param name="numeroUno">Primer objeto a restar</param>
        /// <param name="numeroDos">Segundo objeto a restar</param>
        /// <returns></returns>
        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            double resultado;
            resultado = numeroUno.numero - numeroDos.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador "+" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a sumar</param>
        /// <param name="numeroDos">Segundo objeto a sumar</param>
        /// <returns>Retorna la suma entre dos objetos</returns>
        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            double resultado;
            resultado = numeroUno.numero + numeroDos.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador "*" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a multiplicar</param>
        /// <param name="numeroDos">Segundo objeto a multiplicar</param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            double resultado;
            if (numeroDos.numero != 0)
            {
                resultado = numeroUno.numero * numeroDos.numero;
            }
            else
            {
                resultado = -1;
            }
            return resultado;
        }

        /// <summary>
        /// Sobrecarga el operador "/" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a dividir</param>
        /// <param name="numeroDos">Segundo objeto, como divisor</param>
        /// <returns>Retorna la division los objetos, o double.MinValue si no es valido </returns>
        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
            double retorno;
            if (numeroDos.numero != 0)
            {
                retorno = numeroUno.numero / numeroDos.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            return retorno;
        }


    }
}
