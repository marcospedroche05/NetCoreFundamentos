using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public Mascota() {}
        public Mascota(string nombre, string raza)
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }


    }
}
