using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPositionX.Text);
            int posY = int.Parse(this.txtPositionY.Text);
            this.btnMover.Location = new Point(posX, posY);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtRed.Text);
            int green = int.Parse(this.txtGreen.Text);
            int blue = int.Parse(this.txtBlue.Text);
            if (red < 0 || red > 255)
            {
                MessageBox.Show("El valor rojo debe estar comprendido entre 0 y 255");
            }
            else if (green < 0 || green > 255)
            {
                MessageBox.Show("El valor verde debe estar comprendido entre 0 y 255");
            }
            else if (blue < 0 || blue > 255)
            {
                MessageBox.Show("El valor azul debe estar comprendido entre 0 y 255");
            } else
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
        }
    }
}

