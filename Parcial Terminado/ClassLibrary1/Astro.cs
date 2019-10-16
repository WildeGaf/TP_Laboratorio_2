using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Astro
  {
    private int duracionOrbita;
    private int duracionRotacion;
    protected string nombre;

    public Astro(int duraOrbita, int duraRotacion, string nombre)
    {
      this.duracionOrbita = duraOrbita;
      this.duracionRotacion = duraRotacion;
      this.nombre = nombre;

    }

    protected string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Nombre: " + this.nombre);
      sb.AppendLine("Duracion de Orbita: " + this.duracionOrbita);
      sb.AppendLine("Duracion de Rotacion: " + this.duracionRotacion);
      return sb.ToString();
    }

    public abstract string Orbitar();

    public virtual string Rotar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Rotando, Tiempo estimado: " + this.duracionRotacion);
      return sb.ToString();
    }

    public static explicit operator string (Astro astro)
    {
      return astro.nombre;
    }
    }
}
