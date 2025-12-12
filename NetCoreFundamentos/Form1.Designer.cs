namespace NetCoreFundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(36, 112);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(123, 37);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(123, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Introduzca su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(858, 546);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}
