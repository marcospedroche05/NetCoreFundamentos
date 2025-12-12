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
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
