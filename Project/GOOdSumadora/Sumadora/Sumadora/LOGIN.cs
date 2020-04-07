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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {


            cls_conexion conexion = new cls_conexion();
            if (conexion.Validar(textUsuario.Text, textpassword.Text) == true)
            {
                this.Hide();
                FormMenuPrincipal principal = new FormMenuPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Clear();
                textpassword.Clear();
                textUsuario.Focus();
            }

        }
    }



}
    
