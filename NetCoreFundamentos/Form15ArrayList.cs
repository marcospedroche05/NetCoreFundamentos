using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            //CREAMOS UNA COLECCION GENERICA
            List<Control> botones = new List<Control>();
            //DETECTA AUTOMATICAMENTE LOS ELEMENTOS
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.textBox1);







            //VAMOS A CREAR UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //SI DESEAMOS ACCEDER A UN OBJETO Y MODIFICAR ALGUNA CARACTERISTICA
            //NECESITAMOS REALIZAR CASTING
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            //PODEMOS REALIZAR CASTING CON FOR EACH
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.LightCoral;
            }
            //Y SI AÑADIMOS OTRO CONTROL QUE NO SEA UN BUTTON???
            coleccion.Add(this.textBox1);
            //NOS ABSTRAEMOS PARA CASTING EN TODOS LOS OBJETOS
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightCoral;
                //CUANDO TENEMOS MULTIPLES OBJETOS DE DIFERENTES CLASES,
                //NOS PODEMOS ABSTRAER EN EL RECORRIDO, PERO A LO MEJOR 
                //NECESITAMOS ALGUNA CARACTERISTICA ESPECIAL DE CADA UNO.
                //UNA CAJA TIENE UN METODO LLAMADO Paste()
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
