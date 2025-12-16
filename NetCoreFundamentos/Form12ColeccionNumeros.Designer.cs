namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            label3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(42, 82);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(181, 304);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(249, 83);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(174, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar números";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(249, 125);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(174, 23);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 181);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma:";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(323, 181);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(323, 221);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 221);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Pares:";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(323, 264);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 264);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Impares:";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 412);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label label3;
        private TextBox txtImpares;
        private Label label4;
    }
}