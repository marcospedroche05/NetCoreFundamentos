using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.txtDia.Text);
            int month = int.Parse(this.txtMes.Text);
            int year = int.Parse(this.txtYear.Text);
            
            if(month == 1)
            {
                month = 13;
                year = year - 1;
            } else if (month == 2)
            {
                month = 14;
                year = year - 1; 
            }

            int operacion1 = ((month + 1) * 3) / 5;
            int operacion2 = year / 4;
            int operacion3 = year / 100;
            int operacion4 = year / 400;

            int operacion5 = day + (month * 2) + year + operacion1 + operacion2 - operacion3 + operacion4 + 2;
            int operacion6 = operacion5 / 7;
            int operacion7 = operacion5 - (operacion6 * 7);
            string diaSemana;

            switch (operacion7)
            {
                case 0:
                    diaSemana = "SABADO";
                    break;
                case 1:
                    diaSemana = "DOMINGO";
                    break;
                case 2:
                    diaSemana = "LUNES";
                    break;
                case 3:
                    diaSemana = "MARTES";
                    break;
                case 4:
                    diaSemana = "MIERCOLES";
                    break;
                case 5:
                    diaSemana = "JUEVES";
                    break;
                case 6:
                    diaSemana = "VIERNES";
                    break;
                default:
                    diaSemana = "ERROR";
                    break;
            }

            this.lblResultado.Text = "El día es " + diaSemana;
        }
    }
}
