using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Marcos";
            persona.Apellidos = "Pedroche Pérez";
            persona.Edad = -25;
            this.lstClases.Items.Add("Nombre: " + persona.Nombre + ", Apellidos: " + persona.Apellidos + ", Edad: " + persona.Edad);
        }
    }
}
