namespace NetCoreFundamentos
{
    partial class Form5Char
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
            txtLetras = new TextBox();
            txtSimbolos = new TextBox();
            label2 = new Label();
            txtNumeros = new TextBox();
            label3 = new Label();
            txtPuntuaciones = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(60, 63);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(152, 100);
            txtLetras.TabIndex = 1;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(60, 241);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(152, 100);
            txtSimbolos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 213);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Simbolos";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(307, 63);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(152, 100);
            txtNumeros.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 35);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Numeros";
            // 
            // txtPuntuaciones
            // 
            txtPuntuaciones.Location = new Point(307, 241);
            txtPuntuaciones.Multiline = true;
            txtPuntuaciones.Name = "txtPuntuaciones";
            txtPuntuaciones.Size = new Size(152, 100);
            txtPuntuaciones.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 213);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntuacion";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(197, 382);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(119, 36);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form5Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 457);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuaciones);
            Controls.Add(label4);
            Controls.Add(txtNumeros);
            Controls.Add(label3);
            Controls.Add(txtSimbolos);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Name = "Form5Char";
            Text = "Form5Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtSimbolos;
        private Label label2;
        private TextBox txtNumeros;
        private Label label3;
        private TextBox txtPuntuaciones;
        private Label label4;
        private Button btnRun;
    }
}