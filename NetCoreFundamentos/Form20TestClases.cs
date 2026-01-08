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
            persona.Edad = 25;
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.España;
            //persona[0] = "Vamos 1";
            //persona.Domicilio.Calle = "Avenida Enero";
            //persona.Domicilio.Ciudad = "Madrid";
            //persona.Domicilio.CodigoPostal = 28019;
            this.lstClases.Items.Add("Nombre: " + persona.Nombre + ", Apellidos: " + persona.Apellidos + ", Edad: " + persona.Edad);
            this.lstClases.Items.Add(persona.GetNombreCompleto());
            //this.lstClases.Items.Add("Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad + ", " + persona.Domicilio.CodigoPostal);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            Director director = new Director();
            director.Nombre = "MarcosGODMODE";
            director.Apellidos = "PedrocheGODMODE";
            this.lstClases.Items.Add("Vacas Empleado: " + director.GetDiasVacaciones());
            this.lstClases.Items.Add("Director: " + director.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + director.GetSalarioMinimo() + "€");
        }
    }
}
