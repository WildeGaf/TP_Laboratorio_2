using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planetas
        {
            get { return planetas;}
        }

        public SistemaSolar()
        {
            planetas = new List<Astro>();
        }

        public string MostrasInformacionAstros()
        {
            int i;
            StringBuilder sb = new StringBuilder();
            for (i=0; i < Planetas.Count;i++)
            {
                sb.AppendLine(planetas[i].ToString());
            }
            return sb.ToString();
        }
    }
}
