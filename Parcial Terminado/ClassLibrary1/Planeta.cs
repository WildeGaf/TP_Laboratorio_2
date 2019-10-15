using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        List<Astro> satelites;

        public List<Astro> Satelites
        {
            get { return satelites; }
        }

        public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRot, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }


        public Planeta(int duraOrbita, int duraRot, string nombre) : base(duraOrbita, duraRot, nombre)
        {
            satelites = new  List<Astro>();
        }



        public static bool operator +(Astro astro, Planeta planeta)
        {
            if (astro is Satelite)
            {
                planeta.satelites.Add(astro);
                return true;
            }
            return false;
        }



        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite aux in planeta.Satelites)
            {
                if (aux.Nombre == satelite.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }


        public static bool operator ==(Planeta p1, Planeta p2)
        {
            if (p1.nombre == p2.nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }

        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Orbita el planeta" + this.nombre);
            return sb.ToString();
        }

        public new string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rota el planeta" + this.nombre);
            return sb.ToString();
        }

        public override string ToString()
        {
            int i;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Planeta: ");
            sb.Append(base.Mostrar());
            sb.AppendLine("Tipo de planeta: " + this.tipo);
            sb.AppendLine("Cantidad de Satelites: " + this.cantSatelites + "\n");
            for (i = 0; i < this.Satelites.Count();i++)
            {
                sb.Append(this.Satelites[i].ToString());
            }
           
            return sb.ToString();
        }
    }
}
