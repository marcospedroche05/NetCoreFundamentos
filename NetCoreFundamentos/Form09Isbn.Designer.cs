namespace NetCoreFundamentos
{
    partial class Form09Isbn
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
            txtIsbn = new TextBox();
            btnValidar = new Button();
            lblValido = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce el ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(48, 79);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(223, 23);
            txtIsbn.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(48, 130);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(139, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValido
            // 
            lblValido.AutoSize = true;
            lblValido.Location = new Point(48, 177);
            lblValido.Name = "lblValido";
            lblValido.Size = new Size(16, 15);
            lblValido.TabIndex = 3;
            lblValido.Text = "...";
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 259);
            Controls.Add(lblValido);
            Controls.Add(btnValidar);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnValidar;
        private Label lblValido;
    }
}