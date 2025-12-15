namespace NetCoreFundamentos
{
    partial class FormPracticaValidarEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMail = new TextBox();
            lblResultado = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce una dirección de correo";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(45, 71);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(366, 23);
            txtMail.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(45, 145);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(22, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = ".....";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(45, 110);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(132, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // FormPracticaValidarEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 245);
            Controls.Add(btnValidar);
            Controls.Add(lblResultado);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "FormPracticaValidarEmail";
            Text = "FormPracticaValidarEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Label lblResultado;
        private Button btnValidar;
    }
}