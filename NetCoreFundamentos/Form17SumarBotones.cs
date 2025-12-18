using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            //RECORREMOS TODOS LOS BOTONES DEL PANEL,
            //COMO SOLO HE DIBUJADO BOTONES, HAGO LA ABSTRACCION A BUTTON
            foreach(Button btn in this.groupBox1.Controls)
            {
                this.botones.Add(btn);
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach(Button btn in botones)
            {
                int numAleatorio = rnd.Next(1, 50);
                btn.Text = numAleatorio.ToString();
            }
        }
    }
}
