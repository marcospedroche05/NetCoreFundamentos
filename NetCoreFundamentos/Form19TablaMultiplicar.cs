using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> cajas;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            Random rnd = new Random();
            this.botones = new List<Button>();
            this.cajas = new List<TextBox>();
            foreach(Control control in this.Controls)
            {
                if(control is Button)
                {
                    botones.Add((Button)control);
                } else
                {
                    cajas.Add((TextBox)control);
                }
            }
            foreach(Button btn in botones)
            {
                int numAleatorio = rnd.Next(1, 11);
                btn.Text = numAleatorio.ToString();
                btn.Click += GenerarTabla;
            }
            this.cajas.Reverse();
        }

        private void GenerarTabla(object? sender, EventArgs e)
        {
            int contador = 1;
            Button btn = (Button)sender;
            int numero = int.Parse(btn.Text);
            foreach(TextBox caja in cajas)
            {
                int mult = numero * contador;
                caja.Text = mult.ToString();
                contador++;
            }
        }
    }
}
