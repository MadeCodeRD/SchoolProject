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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            cls_connection je = new cls_connection();

            if (je.Validar(textUsuario.Text,textPass.Text)== true)
            {

                MessageBox.Show("LOGGIN SUCCESSFULLY", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);

                Pantalla1 he = new Pantalla1();
                he.Show();




            }

            else
            {
                MessageBox.Show("ERROR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textUsuario.Clear();
                textPass.Clear();
                textUsuario.Focus();




            }


        }
    }
}
