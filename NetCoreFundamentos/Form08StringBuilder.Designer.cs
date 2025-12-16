namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnInvertir = new Button();
            btnBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Copie texto para trabajar:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(22, 54);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(507, 160);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(22, 244);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(123, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo en realizarse...";
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(91, 303);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(154, 32);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(286, 303);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(155, 32);
            btnBuilder.TabIndex = 4;
            btnBuilder.Text = "Invertir String Builder";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 358);
            Controls.Add(btnBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnInvertir;
        private Button btnBuilder;
    }
}