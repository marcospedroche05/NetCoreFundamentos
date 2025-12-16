using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            System.Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = rnd.Next(11);
                this.lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach(int numero in lstNumeros.Items)
            {   
                if(numero % 2 == 0)
                {
                    sumaPares += numero;
                } else
                {
                    sumaImpares += numero;
                }
                suma += numero;
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
