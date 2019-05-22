using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
  public class Snacks : Producto
  {
    public Snacks(string codigo, EMarca marca, ConsoleColor color) : base(codigo, marca, color)
    {
    }
    /// <summary>
    /// Los snacks tienen 104 calorías
    /// </summary>
    protected override short CantidadCalorias
    {
      get{return 104;}
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("SNACKS");
      sb.AppendLine((string)this);
      sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
      sb.AppendLine("");
      sb.AppendLine("---------------------");

      return sb.ToString();
    }
  }
}
