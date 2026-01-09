using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                using(MemoryStream memorystream = new MemoryStream(mascota.imagen))
                {
                    this.pictureBox1.Image = Image.FromStream(memorystream);
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.imagen = File.ReadAllBytes(this.openFileDialog1.FileName);

            //LAS CLASES QUE SE UTILIZAN SON DE TIPO STREAM
            //PARA ESCRIBIR NECESITAMOS LA CLASE StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.pictureBox1.Image = null;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //ABRIR EL OPENFILA PARA SELECCIONAR LA IMAGEN
            this.openFileDialog1.ShowDialog();
            //RECUPERAMOS LA RUTA DE LA IMAGEN
            string path = this.openFileDialog1.FileName;
            //DIBUJAMOS LA IMAGEN
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
