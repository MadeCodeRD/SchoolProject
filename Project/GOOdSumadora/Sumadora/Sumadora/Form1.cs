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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nosepuede.Visible = false;

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_paint(object sender, PaintEventArgs e)
        {

            Font myfont = new Font("Calibri", 18);
            Brush mybursh = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("MadelsonProgramming!", myfont,mybursh,0,0); 



        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            float primerValor, segundoValor;
            float resultado;
            primerValor = Convert.ToSingle(textvalor1.Text);
            segundoValor = Convert.ToSingle(textvalor2.Text);
            resultado = primerValor + segundoValor;

            textresultado.Text = Convert.ToString(resultado);



        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            float primerValor, segundoValor;
            float resultado;
            primerValor = Convert.ToSingle(textvalor1.Text);
            segundoValor = Convert.ToSingle(textvalor2.Text);
            resultado = primerValor - segundoValor;

            textresultado.Text = Convert.ToString(resultado);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            float primerValor, segundoValor;
            float resultado;
            primerValor = Convert.ToSingle(textvalor1.Text);
            segundoValor = Convert.ToSingle(textvalor2.Text);
            resultado = primerValor * segundoValor;

            textresultado.Text = Convert.ToString(resultado);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            float primerValor, segundoValor;
            float resultado;
            primerValor = Convert.ToSingle(textvalor1.Text);
            segundoValor = Convert.ToSingle(textvalor2.Text);

            if (segundoValor == 0)
            {

                nosepuede.Visible = true;
            }
            else
            {


                nosepuede.Visible = false;
                resultado = primerValor / segundoValor;

                textresultado.Text = Convert.ToString(resultado);

            }
            }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            textvalor1.Clear();
            textvalor2.Clear();
            textresultado.Clear();
            nosepuede.Visible = false;
            textvalor1.Focus();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
