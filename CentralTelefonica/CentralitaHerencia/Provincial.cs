using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Provincial : Llamada
  {
    protected Franja franjaHoraria;

    public enum Franja
    {
      franja_1,
      franja_2,
      franja_3
    }

    public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
    {

    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }

    public float CostoLlamada
    {
      get { return CalcularCosto(); }
    }

    private float CalcularCosto()
    {
      float respuesta = 0;
      if (this.franjaHoraria is Franja.franja_1)
      {
        respuesta = (float)0.99 * this.Duracion;
      }
      else if (this.franjaHoraria is Franja.franja_2)
      {
        respuesta = (float)1.25 * this.Duracion;
      }
      else if (this.franjaHoraria is Franja.franja_3)
      {
        respuesta = (float)0.66 * this.Duracion;
      }
      return respuesta;
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.Append("Costo Llamada: "+ CostoLlamada.ToString());
      sb.AppendLine("Franja Horaria: " + this.franjaHoraria.ToString());
      return sb.ToString();
    }


  }
}
