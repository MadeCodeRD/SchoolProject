﻿using System;
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
    public partial class Pantalla2 : Form
    {
        public Pantalla2()
        {
            InitializeComponent();
        }


        public void setpantalla2_1(string value)
        {

            textDocID.Text = value;


        }

        public void setpantalla2_2 (string value)
        {

            textNombre.Text = value;
        }

        public void setpantalla2_3 (string value)
        {

            textApellido.Text = value;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             textFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {


            Pantalla3 pant3 = new Pantalla3();
            pant3.setpantalla3_1(textNombre.Text);
            pant3.setpantalla3_2(textApellido.Text);
            pant3.setpantalla3_3(textFecha.Text);
            pant3.setpantalla3_4(textNumPrestamo.Text);
            pant3.setpantalla3_5(textMonto.Text);
            pant3.Show();






        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            textPrestamo.Clear();
            textMonto.Clear();
            textPeriodoPrestamo.Clear();
            textCouta.Clear();
            textMontoTotalPrestamo.Clear();
            textGarantia.Clear();
            textNumPrestamo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
