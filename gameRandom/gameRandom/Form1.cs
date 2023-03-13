using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameRandom
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarPregunta_Click(object sender, EventArgs e)
        {
            Preguntas frmPreguntas = new Preguntas();

            //oculto el formulario principal
            this.Hide();

            //muestro el formulario preguntas
            frmPreguntas.ShowDialog();
        }
    }
}
