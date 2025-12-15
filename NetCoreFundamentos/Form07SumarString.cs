using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = this.txtString.Text;
            int resultado = 0;
            for(int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                if (char.IsNumber(caracter))
                {
                    int num = (int)Char.GetNumericValue(caracter);
                    resultado += num;
                }
            }
            this.lblResultado.Text += " " + resultado;
        }
    }
}
