using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string texto = this.txtTexto.Text;
            int longitud = texto.Length;
            Stopwatch kronozomber = new Stopwatch();
            //COMENZAMOS EL PROCESO
            kronozomber.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char ultimaletra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE QUE CORRESPONDA
                texto = texto.Insert(i, ultimaletra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            kronozomber.Stop();
            //EL OBJETO STOPWATCH CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + kronozomber.Elapsed.Seconds.ToString() + ", Milisegundos: " + kronozomber.Elapsed.Milliseconds;
            this.txtTexto.Text = texto;
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch kronozomber = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE StringBuilder
            StringBuilder texto = new StringBuilder();
            //PARA AÑADIR CONTENIDO TIENE UN METODO LLAMADO Append
            texto.Append(this.txtTexto.Text);
            int longitud = texto.Length;
            //COMENZAMOS EL PROCESO
            kronozomber.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char ultimaletra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE QUE CORRESPONDA
                texto = texto.Insert(i, ultimaletra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            kronozomber.Stop();
            //EL OBJETO STOPWATCH CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + kronozomber.Elapsed.Seconds.ToString() + ", Milisegundos: " + kronozomber.Elapsed.Milliseconds;
            this.txtTexto.Text = texto.ToString();

        }
    }
}
