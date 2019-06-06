using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Universitario : Persona
  {
    private int legajo;

    public Universitario()
    {

    }

    public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
    {
      this.legajo = legajo;
    }

    protected abstract string ParticiparEnClase();


    protected virtual string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder(base.ToString());
      sb.Append("Legajo: " + this.legajo);
      return sb.ToString();
    }
    public static bool operator ==(Universitario pg1,Universitario pg2) //verificar el Tipo, que es el tipo ? 
    {
      if (pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni) //&& (pg1.Equals() == true && pg2.Equals() == true))
      {
        return true;
      }
      else
        return false;
    }

    public static bool operator !=(Universitario pg1, Universitario pg2)
    {
      return !(pg1 == pg2);
    }

    public override bool Equals(object obj)
    {
      if (obj is Universitario)
        return true;
      else
        return false;
    }

    }



}
