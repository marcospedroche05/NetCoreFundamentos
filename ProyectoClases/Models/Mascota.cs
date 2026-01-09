using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public byte[] imagen { get; set; }
        public Mascota() {}
        public Mascota(string nombre, string raza, int edad)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Edad = edad;
        }
        public Mascota(string nombre, string raza)
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }


    }
}
