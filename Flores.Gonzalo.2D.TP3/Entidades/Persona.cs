using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        #endregion

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre,string apellido,ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringToDni = dni;
        }
        #endregion

        #region Enumerador
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { this.apellido = ValidaNombreApellido(value); }
        }

        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = ValidaNombreApellido(value); }
        }

        public int Dni
        {
            get { return dni; }
            set
            {this.dni = ValidarDni(this.Nacionalidad, value);}
        }

        public ENacionalidad Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public string StringToDni
        {
            set {
                
            }
        }

        #endregion

        #region Metodos

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno;
            if ((nacionalidad == ENacionalidad.Argentino) &&
                    (dato >= 1 && dato <= 89999999))
            {
                retorno = dato;
            }
            else if ((nacionalidad == ENacionalidad.Extranjero) &&
                (dni >= 90000000 && dni <= 99999999))
            {
                retorno = dato;
            }
            throw new NacionalidadInvalidaException();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int num;
            if (dato.Length <= 8 && dato.Length > 0) 
            {
                int.TryParse(dato, out num);
                return num;
            }
            else
            {
                throw new DniInvalidoException();
            }
        }

        private string ValidaNombreApellido(string dato)
        {
            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
            {
                return dato;
            }
            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+ this.Nombre);
            sb.AppendLine("Nombre: " + this.Apellido);
            sb.AppendLine("Nombre: " + this.Nacionalidad);
            sb.AppendLine("Nombre: " + this.Dni);
            return sb.ToString();
        }



        #endregion

    }
}
