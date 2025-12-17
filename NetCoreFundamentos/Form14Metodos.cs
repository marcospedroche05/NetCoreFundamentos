using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero *= 2;
        }
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Honeydew;
        }
        void GetDobleReferencia(ref int numero)
        {
            numero *= 2;
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(num);
            this.lblResultado.Text = num.ToString();
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnReferencia);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //CON REF, LAS DOS VARIABLES APUNTAN AL MISMO ESPACIO DE MEMORIA
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }
    }
}
