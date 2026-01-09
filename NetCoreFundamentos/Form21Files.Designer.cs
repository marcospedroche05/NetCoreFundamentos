namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnLeer = new Button();
            btnEscribir = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido file";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(35, 68);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(288, 350);
            txtContenido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(362, 68);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(137, 25);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(362, 112);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(137, 23);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(362, 150);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(137, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer file";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(362, 190);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(137, 23);
            btnEscribir.TabIndex = 6;
            btnEscribir.Text = "Write file";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 32);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(550, 68);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(205, 349);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnEscribir);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnLeer;
        private Button btnEscribir;
        private Label label3;
        private ListBox lstNombres;
    }
}