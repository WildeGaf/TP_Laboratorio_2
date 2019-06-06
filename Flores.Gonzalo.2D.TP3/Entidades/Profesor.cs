using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
   Sobrescribir el método MostrarDatos con todos los datos del profesor.
   ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
   ToString hará públicos los datos del Profesor.
   Se inicializará a Random sólo en un constructor.
   En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
  mediante el método randomClases. Las dos clases pueden o no ser la misma.
   Un Profesor será igual a un EClase si da esa clase.*/

    sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private Random random;

        public void _randomClases()
        {

        }

        static Profesor()
        {

        }

        private Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this.random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {

        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Clase del Dia " + this.random);
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Clases del dia: ");
            foreach (Universidad.EClases auxClass in this.clasesDelDia)
            {
                sb.Append(this.clasesDelDia);
            }
            return sb.ToString();
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases j in i.clasesDelDia)
            {
                if (j == clase)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }



    }
}
