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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        int N = 0;
        private void FormSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            labelprogressbar.Text = N.ToString();
            progressBar1.Value = N;
            if (N ==100)
            {

                this.Hide();
                timer1.Stop();
                FormMenuPrincipal menu = new FormMenuPrincipal();
                menu.Show();


            }





        }
    }
}
