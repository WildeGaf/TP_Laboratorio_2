using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get { return this.nombre;}
        }

        public Satelite(int duraOrbita,int duraRotacion,string nombre) : base(duraOrbita,duraRotacion,nombre)
        {
        }


        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Oribar el satelite: " + this.Nombre);
            return sb.ToString();
        }

        public  override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Satelite:");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        } 

    }
}
