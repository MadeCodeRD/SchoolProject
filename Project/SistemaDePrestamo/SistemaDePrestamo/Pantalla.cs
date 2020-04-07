using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePrestamo
{
    public partial class Pantalla3 : Form
    {
        public Pantalla3()
        {
            InitializeComponent();
        }

        public void setpantalla3_1 (string value)
        {

            textNombre.Text = value;

        }

        public void setpantalla3_2 (string value)
        {

            textApellido.Text = value;
        }


        public void setpantalla3_3 (string value)
        {

            textFecha.Text = value;
        }

        public void setpantalla3_4(string value)
        {
            textPrestamoNum.Text = value;
        }


        public void setpantalla3_5 (string value)
        {

            textMonto.Text = value;
        }

        public void setpantalla3_6(string value)
        {


            textMonto.Text = value;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textNumRecibo.Clear();
            textDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
