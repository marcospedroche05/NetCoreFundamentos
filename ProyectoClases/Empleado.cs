using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region PROPIEDADES
        protected int SalarioMinimo { get; set; }
        #endregion
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1600;
        }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
        public Empleado(string nombre, string apellidos, int edad) :base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con dos parámetros");
        }

        
    }
}
