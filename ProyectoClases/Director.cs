using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director() 
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo += 200;
        }

        public override int GetDiasVacaciones()
        {
            return base.GetDiasVacaciones() + 8;
        }
    }
}
