namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnValor = new Button();
            btnDobleReferencia = new Button();
            btnReferencia = new Button();
            lblRaton = new Label();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            label3 = new Label();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(49, 67);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(49, 123);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnValor
            // 
            btnValor.Location = new Point(23, 277);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(117, 61);
            btnValor.TabIndex = 3;
            btnValor.Text = "Doble Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(23, 353);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(117, 61);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnReferencia
            // 
            btnReferencia.Location = new Point(23, 431);
            btnReferencia.Name = "btnReferencia";
            btnReferencia.Size = new Size(117, 61);
            btnReferencia.TabIndex = 5;
            btnReferencia.Text = "Objeto referencia";
            btnReferencia.UseVisualStyleBackColor = true;
            btnReferencia.Click += btnReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.ActiveCaption;
            lblRaton.Location = new Point(233, 277);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(390, 215);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "label2";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(326, 47);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(142, 23);
            txtSoloNumeros.TabIndex = 8;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 100);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(326, 97);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(142, 23);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 517);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnValor;
        private Button btnDobleReferencia;
        private Button btnReferencia;
        private Label lblRaton;
        private Label label2;
        private TextBox txtSoloNumeros;
        private Label label3;
        private TextBox txtSoloLetras;
    }
}