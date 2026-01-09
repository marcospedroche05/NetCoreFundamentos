using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFile : Form
    {
        HelperMascotas helper;
        public Form22MascotasFile()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre + ", " + mascota.Raza);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string raza = this.txtRaza.Text;
            Mascota mascota = new Mascota(nombre, raza);
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();
        }
    }
}
