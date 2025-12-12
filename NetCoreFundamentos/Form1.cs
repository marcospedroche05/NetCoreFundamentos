namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUÍ SI QUEREMOS EVENTO EN EL BOTÓN 
            this.txtNombre.Text = "Soy un texto completamente nuevo!!!";
            this.txtNombre.Width = 210;
            this.txtNombre.BackColor = Color.GreenYellow;
        }
    }
}
