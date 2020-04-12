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
    public partial class FormActualizar : Form
    {
        cls_datos datos = new cls_datos();

        public FormActualizar()
        {
            InitializeComponent();
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            textCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textCodigo.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textTelefono.Clear();
           

            textCodigo.Enabled = true;
            linkLabel2.Enabled = true;
            textCodigo.Focus();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DataTable data = datos.sql_Consultas("Agenda", "*", "Codigo='" + textCodigo.Text +"'");

            if (data.Rows.Count != 0)
            {

                textNombre.Text = data.Rows[0]["Nombre"].ToString();
                textApellido.Text = data.Rows[0]["Apellido"].ToString();
                textTelefono.Text = data.Rows[0]["Telefono"].ToString();

                textCodigo.Enabled = false;
                linkLabel2.Enabled = false;




            }
        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            datos.sql_Actualizar("Agenda", "Nombre='"+ textNombre.Text +"', Apellido='"+textApellido.Text+"',telefono='"+textTelefono.Text + "'","Codigo='"+textCodigo.Text + "'");

            textCodigo.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textTelefono.Clear();
            textCodigo.Focus();

            textCodigo.Enabled = true;
            linkLabel2.Enabled = true;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}

