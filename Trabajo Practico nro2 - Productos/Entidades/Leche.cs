using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
  public class Leche : Producto
  {
    public enum ETipo { Entera, Descremada }
    ETipo tipo;

    /// <summary>
    /// Por defecto, TIPO será ENTERA
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="patente"></param>
    /// <param name="color"></param>


    public Leche(EMarca marca, string codigo, ConsoleColor color): this(codigo, marca, color, ETipo.Entera)
    {
    }

    public Leche(string codigo,EMarca marca, ConsoleColor color,ETipo tipo): base(codigo, marca,color)
    {
      this.tipo = ETipo.Entera;
    }

    /// <summary>
    /// Las leches tienen 20 calorías
    /// </summary>
    protected override short CantidadCalorias
    {
      get{return this.CantidadCalorias;}
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("LECHE");
      sb.AppendLine((string)this);
      sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
      sb.AppendLine("TIPO : " + this.tipo);
      sb.AppendLine("");
      sb.AppendLine("---------------------");

      return sb.ToString();
    }
  }
}
