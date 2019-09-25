using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }

    public float Duracion
    {
      get { return duracion; }
    }

    public string NroDestino
    {
      get { return nroDestino; }
    }

    public string NroOrigen
    {
      get { return nroOrigen; }
    }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Llamada:  ");
      sb.AppendLine("Duracion: " + this.duracion.ToString());
      sb.AppendLine("Numero de Origen: " + this.NroOrigen);
      sb.AppendLine("Numero de Destino" + this.NroDestino);
      return sb.ToString();
    }


    public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      if (llamada1.duracion > llamada2.duracion)
        return 0;
      else
        return 1;
    }
  }
}
