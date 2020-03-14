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
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {

            string nombre, apellido, direccion, sector, telefono, celular, email, provincia, docID;


            nombre = textNombre.Text;
            apellido = textApellido.Text;
            direccion = textDireccion.Text;
            sector = textSector.Text;
            telefono = textTelefono.Text;
            celular = textCelular.Text;
            email = textEmail.Text;
            provincia = textProvincia.Text;
            docID = textDocID.Text;

            Pantalla2 pant2 = new Pantalla2();
            pant2.setpantalla2_1(textDocID.Text);
            pant2.setpantalla2_2(textNombre.Text);
            pant2.setpantalla2_3(textApellido.Text);
            pant2.Show();





        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textDocID.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textDireccion.Clear();
            textTelefono.Clear();
            textSector.Clear();
            textCelular.Clear();
            textEmail.Clear();
            textProvincia.Clear();
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
