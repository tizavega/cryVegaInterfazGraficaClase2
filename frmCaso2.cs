using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cryVegaInterfazGrafica
{
    public partial class frmCaso2 : Form
    {



        //ZONA DE VARIABLES GLOBALES
        //contadores
        int vContadorCritico = 0;
        int vContadorAlto = 0;
        int vContadorMedio = 0;
        int vContadorBajo = 0;

        private object lblresultadoCritico;

        public frmCaso2()
        {
            InitializeComponent();
        }

        private void lblCritico_Click(object sender, EventArgs e)
        {
            vContadorCritico = vContadorCritico + 1;

            lblResultadoCritico.BackColor = Color.Red;
           
            lblResultadoCritico.Text = vContadorCritico.ToString() +"%";
        }

        private void lblAlto_Click(object sender, EventArgs e)
        {
            vContadorAlto = vContadorAlto + 1;
            lblResultadoAlto.BackColor = Color.Orange;
            lblResultadoAlto.Text =vContadorAlto.ToString() +"%";
        }

        private void lblMedio_Click(object sender, EventArgs e)
        {
            vContadorMedio = vContadorMedio + 1;
            lblResultadoMedio.BackColor = Color.Yellow;
            lblResultadoMedio.Text = vContadorMedio.ToString() +"%  ";
        }

        private void lblBajo_Click(object sender, EventArgs e)
        {
            vContadorBajo = vContadorBajo + 1;
            lblResultadoBajo.BackColor = Color.Green;
            lblResultadoBajo.Text = vContadorBajo.ToString() + "%";
        }

        private void frmCaso2_Load(object sender, EventArgs e)
        {

        }
    }
}
