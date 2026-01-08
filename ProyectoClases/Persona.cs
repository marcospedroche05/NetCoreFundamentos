using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public class Persona
    {
        public string Nombre;
        public string Apellidos;
        //CAMPO DE PROPIEDAD
        private int _Edad;
        public int Edad { 
            get { return this._Edad; }
            set {
                if(value >= 0)
                {
                    this._Edad = value;
                } else
                {
                    //NO NOS GUSTA. SILENCIO
                    //this._Edad = 0;

                    //NO NOS GUSTA. ERROR
                    throw new Exception("La edad no puede ser negativa");
                }
            }
        }
    }
}
