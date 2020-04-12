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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void aGENDAINSERTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNSERTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar insertar = new FormInsertar();
            insertar.Show();
        }

        private void aCTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizar actu = new FormActualizar();
            actu.Show();
        }

        private void nOMBRESOAPELLIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultas consul = new FormConsultas();
            consul.Show();
        }
    }
}
