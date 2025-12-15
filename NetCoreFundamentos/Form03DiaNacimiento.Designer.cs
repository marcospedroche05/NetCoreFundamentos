namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            btnMostrar = new Button();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtYear = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 59);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 100);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 139);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(64, 267);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label4";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(64, 196);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(107, 38);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar dia";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(123, 59);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(123, 100);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(123, 139);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtYear);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(btnMostrar);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private Button btnMostrar;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtYear;
    }
}