using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{

   

    //LAS ENUMERACIONES ESTÁN DENTRO DEL NAMESPACE

    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Francia, Alemania, Colombia }

    public class Persona
    {
        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
        }
        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parámetros");
        }
        #endregion

        #region PROPIEDADES
        public string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                //DEVOLVEMOS UNA DESCRIPCION ALEATORIA DE NUESTRO NUMERO
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, tester de mierda");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //CAMPO DE PROPIEDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                if (value >= 0)
                {
                    this._Edad = value;
                }
                else
                {
                    //NO NOS GUSTA. SILENCIO
                    //this._Edad = 0;

                    //NO NOS GUSTA. ERROR
                    throw new Exception("La edad no puede ser negativa");
                }
            }
        }
        #endregion


        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }
        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }
        public string GetNombreCompleto(int num1, int num2)
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }
        #endregion
    }
}
