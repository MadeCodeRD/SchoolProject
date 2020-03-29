using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumadora
{
    public partial class FormCasaDeCambio : Form
    {
        public FormCasaDeCambio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textCantidadCambiar.Clear();
            textResultado.Clear();
            textResultado.Visible = false;
            labelResultado.Visible = false;
            textCantidadCambiar.Focus();




        }

        private void LinkUSaRD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double US = 54.15, RD, result;

            RD = double.Parse(textCantidadCambiar.Text);
            result = US * RD;
            labelResultado.Visible = true;
            textResultado.Visible = true;
            textResultado.Text = Convert.ToString(result);



        }

        private void LinkRDaUS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double US = 54.15, RD, result;

            RD = double.Parse(textCantidadCambiar.Text);
            result = RD/US;
            labelResultado.Visible = true;
            textResultado.Visible = true;

            textResultado.Text = Convert.ToString(result);



        }

        private void LinkEURaTD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double EUR = 60.48, RD, result;

            RD = double.Parse(textCantidadCambiar.Text);
            result = EUR * RD;

            labelResultado.Visible = true;
            textResultado.Visible = true;

            textResultado.Text = Convert.ToString(result);




        }
    }
}
