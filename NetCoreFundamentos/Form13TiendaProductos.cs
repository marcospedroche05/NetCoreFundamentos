using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.lstTienda.Items.Add(producto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                object itemTienda = this.lstTienda.Items[indice];
                this.lstAlmacen.Items.Add(itemTienda);
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string elemento in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(elemento);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.lstAlmacen.SelectedIndex;
            string elementoSeleccionado = this.lstAlmacen.SelectedItem.ToString();
            int indiceAnterior = indexSeleccionado - 1;

            if (indiceAnterior >= 0)
            {
                string auxElementoAnterior = this.lstAlmacen.Items[indiceAnterior].ToString();
                this.lstAlmacen.Items[indiceAnterior] = elementoSeleccionado;
                this.lstAlmacen.Items[indexSeleccionado] = auxElementoAnterior;
                this.lstAlmacen.SelectedIndex = indiceAnterior;

                if(this.lstAlmacen.SelectedIndex == 0)
                {
                    this.btnSubir.Enabled = false;
                }
                this.btnBajar.Enabled = true;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.lstAlmacen.SelectedIndex;
            string elementoSeleccionado = this.lstAlmacen.SelectedItem.ToString();
            int indiceSiguiente = indexSeleccionado + 1;

            if (indiceSiguiente <= this.lstAlmacen.Items.Count - 1)
            {
                string auxElementoSiguiente = this.lstAlmacen.Items[indiceSiguiente].ToString();
                this.lstAlmacen.Items[indiceSiguiente] = elementoSeleccionado;
                this.lstAlmacen.Items[indexSeleccionado] = auxElementoSiguiente;
                this.lstAlmacen.SelectedIndex = indiceSiguiente;
                if(this.lstAlmacen.SelectedIndex == this.lstAlmacen.Items.Count - 1)
                {
                    this.btnBajar.Enabled = false;
                }
                this.btnSubir.Enabled = true;
            }
        }
    }
}
