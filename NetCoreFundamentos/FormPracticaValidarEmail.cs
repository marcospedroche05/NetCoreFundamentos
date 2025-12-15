using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class FormPracticaValidarEmail : Form
    {
        public FormPracticaValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtMail.Text;
            bool correcto = true;
            string dominio = "";
            int posicionPunto;
            if (!email.Contains('.'))
            {
                MessageBox.Show("El correo debe contener al menos un .");
                correcto = false;
            }
            else
            {
                posicionPunto = email.LastIndexOf('.');
                dominio = email.Substring(posicionPunto + 1);
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("El correo debe contener @");
                correcto = false;
            } else if(email.StartsWith('@') || email.EndsWith('@'))
            {
                MessageBox.Show("El correo no debe contener un @ al inicio ni al final");
                correcto = false;
            } else if(email.Split('@').Length > 2)
            {  
                MessageBox.Show("El correo debe contener un solo @");
                correcto = false;
            } else if(email.IndexOf('.') < email.IndexOf('@'))
            {
                MessageBox.Show("El correo debe tener el . después del @");
                correcto = false;
            } else if(dominio.Length < 2 || dominio.Length > 3)
            {
                MessageBox.Show("El dominio debe tener una longitud de 2 o 3 caracteres");
                correcto = false;
            }

            if (correcto)
            {
                this.lblResultado.Text = "Email correcto";
            }

        }
    }
}
