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
    public partial class FormNominaSemanal : Form
    {
        public FormNominaSemanal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int L = 0, Ma = 0, Mi = 0, J = 0, V = 0, S = 0, D = 0, CANT = 0, HN = 0, HE = 0, Salario=0;

            L = int.Parse(textLunes.Text);
            Ma = int.Parse(textMartes.Text);
            Mi = int.Parse(textMiercoles.Text);
            J = int.Parse(textJueves.Text);
            V = int.Parse(textViernes.Text);
            S = int.Parse(textSabado.Text);
            D = int.Parse(textDomingo.Text);


            CANT = L + Ma + Mi + J + V + S + D;

           if (CANT > 40)
            {

                HN = 40 * 220;
                HE = (CANT - 40) * 300;


            } 
           else
            {

                HE = 0;
                HN = CANT * 220;
            }

            Salario = HN + HE;
            textSalario.Text = Convert.ToString(Salario);



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
