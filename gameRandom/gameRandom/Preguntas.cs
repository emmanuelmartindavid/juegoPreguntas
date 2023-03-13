using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace gameRandom
{
    public partial class Preguntas : Form
    {

        static Random random = new Random();
        string[] lines = File.ReadAllLines("C:\\Users\\cuerpos\\Desktop\\preguntas.txt");
        Dictionary<string, string> preguntas = new Dictionary<string, string>();


        public Preguntas()
        {
            InitializeComponent();
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {

            int indicePregunta = MostrarPregunta();
            MostrarOpciones(indicePregunta);




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmPrincipal = new Form1();

            frmPrincipal.Show();

        }


        private int MostrarPregunta()
        {
            // Lee las preguntas y respuestas desde un archivo de texto


            //itero para cargar preguntas y respuestas.
            for (int i = 0; i < lines.Length; i += 2)
            {
                // comprueba si hay una respuesta disponible
                if (i + 1 < lines.Length)
                {
                    //agrega la pregunta y su respuesta al diccionario
                    preguntas.Add(lines[i], lines[i + 1]);
                }
            }

            // Elige una pregunta al azar
            int index = random.Next(preguntas.Count);
            string preguntaActual = preguntas.ElementAt(index).Key;

            txbPregunta.Text = preguntaActual; // muestra la pregunta en el TextBox

            return index;
        }

        private Button[] arrayBotones;

        private void MostrarOpciones(int indice)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\cuerpos\\Desktop\\opciones.txt");
            string[] opcionesSeparadas = lines[indice].Split(' ');
            string[] respuesta = preguntas.Values.ToArray();

            arrayBotones = new Button[3];
            arrayBotones[0] = btnOpcion1;
            arrayBotones[1] = btnOpcion2;
            arrayBotones[2] = btnOpcion3;

            for (int i = 0; i < arrayBotones.Length; i++)
            {
                arrayBotones[i].Text = opcionesSeparadas[i];
                arrayBotones[i].Click += new EventHandler(btn_Click);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string[] respuesta = preguntas.Values.ToArray();

            for (int i = 0; i < respuesta.Length; i++)
            {
                if (boton.Text == respuesta[i])
                {
                    txbRespuesta.Text = "Respuesta Correcta";
                    return;
                }
            }

            txbRespuesta.Text = "Respuesta Incorrecta";
        }

        /*private void MostrarOpciones(int indice)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\cuerpos\\Desktop\\opciones.txt");
            string[] respuesta = preguntas.Values.ToArray();
            Button[] arrayBotones = new Button[3];

            for (int i = 0; i < arrayBotones.Length; i++)
            {
                arrayBotones[i] = btnOpcion1;
                arrayBotones[i] = btnOpcion2;
                arrayBotones[i] = btnOpcion3;

            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == indice)
                {
                    string[] opcionesSeparadas = lines[i].Split(' ');
                    btnOpcion1.Text = opcionesSeparadas[0];
                    btnOpcion2.Text = opcionesSeparadas[1];
                    btnOpcion3.Text = opcionesSeparadas[2];


                    for (int j = 0; j < respuesta.Length; j++)
                    {
                        for (int k = 0; k < arrayBotones.Length; k++)
                        {
                            if (respuesta[j] == arrayBotones[k].Text)
                            {
                                txbRespuesta.Text = "Respuesta Correcta";

                            }
                        }


                    }

                }

            }
        }*/

    }

}







