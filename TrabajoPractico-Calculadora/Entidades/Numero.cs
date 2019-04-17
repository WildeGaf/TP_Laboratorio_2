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

    public Numero() : this(0)
    {
     
    }

    public Numero(double num) : this(num.ToString())
    {
      
    }

    public Numero(string num) 
    {
      SetNumero(num);
    }

    public void SetNumero(string numeroAux)
    {
      this.numero = this.ValidarNumero(numeroAux);
    }

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

    public static string DecimalBinario(string numeroAux)
    {
      double numero;
      string resultado;
      double.TryParse(numeroAux, out numero);
      resultado = DecimalBinario(numero);
      return resultado;
    }

    public static double operator -(Numero numeroUno, Numero numeroDos)
    {
      double resultado;
      resultado = numeroUno.numero - numeroDos.numero;
      return resultado;
    }

    public static double operator +(Numero numeroUno, Numero numeroDos)
    {
      double resultado;
      resultado = numeroUno.numero + numeroDos.numero;
      return resultado;
    }

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
