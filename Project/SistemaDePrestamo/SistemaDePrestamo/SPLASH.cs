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
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void SPLASH_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int N = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;

            label2.Text = N.ToString();
            progressBar1.Value = N;

            if (N == 100)
            {
                this.Hide();
                timer1.Stop();
                LOGIN hey = new LOGIN();
                hey.Show();


            }




        }
    }
}
