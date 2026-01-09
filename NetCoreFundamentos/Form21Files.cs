using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            //CUANDO HABLAMOS DE RUTAS O CARACTERES ESPECIALES
            //DENTRO DE STRING, TENEMOS DOS FORMAS DE ESCRIBIR DICHOS CARACTERES
            //1) C:\\carpeta\\1.txt DOBLE BARRA
            //2) UTILIZAR @ ANTES Y FUERA DEL STRING
            //this.Path = @"C:\carpeta\1.txt"
            this.Path = "file1.txt";
            this.helper = new HelperFiles();

        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
        }

        private async void btnEscribir_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
