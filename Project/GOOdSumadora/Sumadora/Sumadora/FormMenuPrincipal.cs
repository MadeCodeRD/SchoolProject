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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nominaSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNominaSemanal nomina = new FormNominaSemanal();
            nomina.Show();
        }

        private void casaDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCasaDeCambio casa = new FormCasaDeCambio();
            casa.Show();
        }

        private void sumadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sumadora = new Form1();
            sumadora.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
