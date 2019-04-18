using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora
{
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        /// <summary>
        /// Inicializa el form. 
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Convierte un valor en decimal y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            int aux;
            int.TryParse(lblResultado.Text, out aux);
            if (lblResultado.Text == string.Empty) // this.txtNumero1.Text = string.Empty;
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            else if ((lblResultado.Text != string.Empty && aux >= 0) && (btnConvertirADecimal.Enabled == true))
            {
                lblResultado.Text = Entidades.Numero.BinarioDecimal(lblResultado.Text);

                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }

        }

        /// <summary>
        /// Convierte un valor en binario y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            int auxint;
            if (lblResultado.Text == string.Empty)
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            if ((lblResultado.Text != string.Empty) && (btnConvertirABinario.Enabled = true))
            {
                int.TryParse(lblResultado.Text, out auxint);
                if (auxint >= 0)
                {
                    lblResultado.Text = Entidades.Numero.DecimalBinario(lblResultado.Text);
                    btnConvertirABinario.Enabled = false;
                    btnConvertirADecimal.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede transformar un numero negativo");
                }
            }
        }

        /// <summary>
        /// Valida, realiza una operacion y muestra el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string aux;
            double resultado;
            int auxVerificacion, auxVerificacionDos;
            if ((this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty) ||
                (!int.TryParse(txtNumero1.Text, out auxVerificacion) || !int.TryParse(txtNumero2.Text, out auxVerificacionDos)))
            {
                MessageBox.Show("Alguno de los numeros no esta ingresado o se ingresaron letras");
            }
            else
            {
                aux = cmbOperador.Text;
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, aux);
                aux = Convert.ToString(resultado);
                lblResp.Text = "Respuesta:";
                lblResultado.Text = aux;
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
        }

        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Establece los valores por defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Borra los valores del form.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
            this.lblResp.Text = string.Empty;
        }

        /// <summary>
        /// Ejecuta la operacion entre los valores ingresados.
        /// </summary>
        /// <param name="numeroUno">Primer numero a operar</param>
        /// <param name="numeroDos">Segundo numero a operar</param>
        /// <param name="Operador">Operacion que se desea realizar</param>
        /// <returns>Retorna el resultado</returns>
        private static double Operar(string numeroUno, string numeroDos, string Operador)
        {
            double resultado = 0;
            Numero numUno = new Numero(numeroUno);
            Numero numDos = new Numero(numeroDos);
            resultado = Entidades.Calculadora.Operar(numUno, numDos, Operador);
            return resultado;
        }

    }
}
