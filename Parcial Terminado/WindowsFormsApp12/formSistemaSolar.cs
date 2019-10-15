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

namespace WindowsFormsApp12
{
    public partial class formSistemaSolar : Form
    {

        private static List<Astro> planetas = new List<Astro>();
        public Planeta p;
        public SistemaSolar Sistema = new SistemaSolar();

        public formSistemaSolar()
        {
            InitializeComponent();
            cmbTipo.DataSource = Enum.GetNames(typeof(Tipo));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            int orbitar, i, encontrado = 0;
            if (txtNombrePlaneta.Text != string.Empty &&
                txtOrbitaPlaneta.Text != string.Empty &&
                int.TryParse(txtOrbitaPlaneta.Text, out orbitar) &&
                numRotacion.Value > 0 &&
                numSatelite.Value > 0 &&
                cmbTipo.Text != string.Empty)
            {
                p = new Planeta(orbitar, (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numSatelite.Value, (Tipo)cmbTipo.SelectedIndex);
                if (planetas.Count == 0)
                {
                    planetas.Add(p);
                    Sistema.Planetas.Add(p);
                    cmbPlanetas.Items.Add(txtNombrePlaneta.Text);
                }
                else
                {
                    foreach (Planeta per in planetas)
                    {
                        if (per == p)
                        {
                            encontrado = 1;
                            break;           
                        }
                    }
                    if (encontrado == 0)
                    {
                        planetas.Add(p);
                        Sistema.Planetas.Add(p);
                        cmbPlanetas.Items.Add(txtNombrePlaneta.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("No paso las validaciones");
            }
        }


        private void BtnAgregarSatelite_Click(object sender, EventArgs e)
        {
            int i;
            bool resp;
            if (cmbPlanetas.Text != string.Empty &&
                txtNombreSatelite.Text != string.Empty &&
                numOrbitaSatelite.Value > 0 &&
                numRotacionSatelite.Value > 0)
            {
                Satelite satelite = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);

                for (i = 0; i < planetas.Count; i++)
                {
                    if ((Planeta)planetas[i] != satelite)
                    {
                        resp = satelite + p;
                    }
                }
            }

        }

        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta auxPlaneta in planetas)
            {
                RichTextBox1.AppendText(auxPlaneta.Orbitar());
                RichTextBox1.AppendText(auxPlaneta.Rotar());
                foreach (Satelite s in auxPlaneta.Satelites)
                {
                    RichTextBox1.AppendText(s.Orbitar());
                    RichTextBox1.AppendText(s.Rotar());
                }
            }

        }

        private void BtnMostrarInfo_Click(object sender, EventArgs e)
        {
            RichTextBox1.Clear();
            RichTextBox1.AppendText(Sistema.MostrasInformacionAstros());
        }
    }
}
