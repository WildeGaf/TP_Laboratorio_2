using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
  public class Dulce : Producto
  {
    #region Constructor
    public Dulce(EMarca marca, string codigo, ConsoleColor color) : base(codigo,marca,color)
    {       
    }
    #endregion

    #region Propiedades
    /// <summary>
    /// Los dulces tienen 80 calorías
    /// </summary>
    protected override short CantidadCalorias
    {
      get { return 80; }
    }
    #endregion

    #region Metodos
    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("DULCE");
      sb.AppendLine((string)this);
      sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
      sb.AppendLine("");
      sb.AppendLine("---------------------");

      return sb.ToString();
    }
    #endregion
  }
}
