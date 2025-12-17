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
        int GetDobleValor(int numero)
        {
            return numero *= 2;
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
            int resultado = this.GetDobleValor(num);
            this.lblResultado.Text = resultado.ToString();
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

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA Keys QUE NOS PERMITE ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA BORRAR
            char teclaBorrar = (char)Keys.Back;
            //EXISTE ALGUNA MANERA DE SABER SI UN CHAR ES UN NUMERO????
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            char teclaEspacio = (char)Keys.Space;
            //EXISTE ALGUNA MANERA DE SABER SI UN CHAR ES UN NUMERO????
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar && e.KeyChar != teclaEspacio)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }
    }
}
