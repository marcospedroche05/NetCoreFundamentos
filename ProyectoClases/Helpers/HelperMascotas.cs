using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        //CONVERTIR EL STRING DEL READ A LIST
        private void ConvertirMascotasList(string data)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
            foreach (string stringmascota in datosMascota)
            {
                string[] propiedades = stringmascota.Split(',');
                Mascota mascota = new Mascota(propiedades[0], propiedades[1]);
                this.Mascotas.Add(mascota);
            }
        }
        //EL PROGRAMADOR ESCRIBA READ Y LEEMOS UN STRING Y RELLENAMOS LA COLECCIÓN
        public async Task ReadMascotasAsync()
        {
            //LEEMOS EL FICHERO DE MASCOTAS
            string data = await this.helper.ReadFileAsync(this.path);
            //CONVERTIMOS EL STRING EN LIST
            this.ConvertirMascotasList(data);
        }

        //CONVERTIR LA COLECCION A STRING
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas){
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        //EL PROGRAMADOR ESCRIBA WRITE Y GUARDAMOS LAS MASCOTAS

        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();
            await this.helper.WriteFileAsync(this.path, data);
        }

    }
}
