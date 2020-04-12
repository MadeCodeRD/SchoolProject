using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormInsertar : Form
    {
        cls_datos datos = new cls_datos();
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textApellido.Clear();
            textTelefono.Clear();
            textNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.sql_Insertar("Agenda", "Nombre,Apellido,Telefono", "'" + textNombre.Text + "','"
                + textApellido.Text + "','" + textTelefono.Text + "'");

            textNombre.Clear();
            textApellido.Clear();
            textTelefono.Clear();
            textNombre.Focus();


        }

        private void linklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
