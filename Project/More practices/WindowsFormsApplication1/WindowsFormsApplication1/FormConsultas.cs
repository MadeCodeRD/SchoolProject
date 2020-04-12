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
    public partial class FormConsultas : Form
    {
        cls_datos datos = new cls_datos();

        public FormConsultas()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            textBuscar.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grvConsultas.DataSource = datos.sql_Consultas("Agenda", "Codigo as ID,Nombre as nombre,Apellido as apellido,Telefono as telefono ",
                 "Nombre = '" + textBuscar.Text +"' or Apellido = '" + textBuscar.Text +"'");
                
        }
    }
}
