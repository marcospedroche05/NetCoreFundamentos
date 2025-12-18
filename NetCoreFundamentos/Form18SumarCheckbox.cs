using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> cheks;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.cheks = new List<CheckBox>();
            foreach(CheckBox check in this.grbChecks.Controls)
            {
                cheks.Add(check);
                check.CheckedChanged += Evaluar;
           
            }
        }

        private void Evaluar(object? sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            int numero = int.Parse(check.Text);
            int suma = int.Parse(this.txtSuma.Text);
            if (check.Checked)
            {
                suma = this.SumarNumero(numero);
            } else
            {
                suma = this.RestarNumero(numero);
            }
            this.txtSuma.Text = suma.ToString();

        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach(CheckBox check in cheks)
            {
                int num = rnd.Next(1, 50);
                check.Text = num.ToString();
            }
        }

        int SumarNumero(int num)
        {
            int suma = int.Parse(this.txtSuma.Text);
            suma += num;
            return suma;
        }
        int RestarNumero(int num)
        {
            int suma = int.Parse(this.txtSuma.Text);
            suma -= num;
            return suma;
        }
    }
}
