using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            int longitud = isbn.Length;
            if(longitud != 10)
            {
                MessageBox.Show("El ISBN debe contener 10 caracteres");
            } else
            {
                int suma = 0;
                for(int i = 1; i <= longitud; i++)
                {
                    int num = (int)isbn[i-1];
                    suma += (num * i);
                }
                if (suma % 11 == 0)
                {
                    this.lblValido.Text = "ISBN correcto";
                } else
                {
                    this.lblValido.Text = "ISBN no es válido";
                }
            }
        }
    }
}
