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
    public partial class Form : System.Windows.Forms.Form
    {
        int banderaBin = 0;
        int banderaDec = 0;
        public Form()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int aux;
            int.TryParse(lblResultado.Text, out aux);
            if (lblResultado.Text == string.Empty) // this.txtNumero1.Text = string.Empty;
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            else if ((lblResultado.Text != string.Empty && aux >= 0) && (banderaDec == 1))
            {
                lblResultado.Text = Entidades.Numero.BinarioDecimal(lblResultado.Text);
                banderaDec = 0;
                banderaBin = 1;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int auxint;
            if (lblResultado.Text == string.Empty) // this.txtNumero1.Text = string.Empty;
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            if (lblResultado.Text != string.Empty && this.banderaBin == 1)
            {
                int.TryParse(lblResultado.Text, out auxint);
                if (auxint >= 0)
                {
                    lblResultado.Text = Entidades.Numero.DecimalBinario(lblResultado.Text);
                    this.banderaBin = 0;
                    this.banderaDec = 1;
                }
                else
                {
                    MessageBox.Show("No se puede transformar un numero negativo");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aux;
            double resultado;
            int auxVerificacion,auxVerificacionDos;
            if ((this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty) ||
                (!int.TryParse(txtNumero1.Text,out auxVerificacion) || !int.TryParse(txtNumero2.Text, out auxVerificacionDos)))
            {
                MessageBox.Show("Alguno de los numeros no esta ingresado o se ingresaron letras");
            }
            else
            {
                aux = cmbOperador.Text;
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, aux);
                if (resultado == double.MinValue)
                {
                    MessageBox.Show("No se puede dividir por 0");
                }
                else
                {
                    
                    aux = Convert.ToString(resultado);
                    lblResp.Text = "Respuesta:";
                    lblResultado.Text = aux;
                    this.banderaBin = 1;
                    this.banderaDec = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
            this.lblResp.Text = string.Empty;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosedEventArgs e)
        {
            /* if (MessageBox.Show("¿Esta seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                 e.Cancel = true; */
        }

        private void FormCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private static double Operar(string numeroUno, string numeroDos, string Operador)
        {
            double resultado = 0;
            Numero numUno = new Numero(numeroUno);
            Numero numDos = new Numero(numeroDos);
            resultado = Entidades.Calculadora.Operar(numUno, numDos, Operador);
            return resultado;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
