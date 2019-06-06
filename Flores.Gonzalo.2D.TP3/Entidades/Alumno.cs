using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed class Alumno : Universitario
    {
    private Universidad.EClases claseQueToma;
    private EEstadoCuenta estadoCuenta; 

    public Alumno()
    {
      
    }

    public Alumno(int id,string nombre,string apellido,string dni, ENacionalidad nacionalidad,Universidad.EClases claseQueToma)
                : base(id, nombre, apellido, dni, nacionalidad)
    {
      this.claseQueToma = claseQueToma;
    }

    public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta)
                : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
    {
      this.estadoCuenta = estadoCuenta;
    }

      public enum EEstadoCuenta
    {
      Aldia,
      Deudor,
      Becado
    }
    public static bool operator == (Alumno a, Universidad.EClases clase)
    {
      if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
        return true;
      else
        return false;
    }

    public static bool operator !=(Alumno a, Universidad.EClases clase)
    {
      return !(a.claseQueToma == clase) ;
    }

    public override string ToString()
    {
      return this.MostrarDatos();
    }

    protected override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.ToString());
      sb.AppendLine("Estado de cuenta: " + this.estadoCuenta);
      sb.AppendLine("Clase que toma: " + this.claseQueToma);
      return sb.ToString();
    }

    protected override string ParticiparEnClase()
    {
      return "Toma clase de " + this.claseQueToma.ToString();
    }

  }
}
