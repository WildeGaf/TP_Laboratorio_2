using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Centralita
  {
    private List<Llamada> ListadeLLamada;
    protected string razonSocial;

    public int GananciaPorLocal
    {
      get { return myVar; }
    }

    public int GananciaPorProvincial
    {
      get { return myVar; }
    }

    public int GananciaPorTotal
    {
      get { return myVar; }
    }

    public int Llamadas
    {
      get { return myVar; }
    }

    private CalcularGanancia(TipoLlamada.Tipo)
    {

    }

    public Centralita()
    {
      ListadeLLamada = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      this.razonSocial = nombreEmpresa;
    }

  }
}
