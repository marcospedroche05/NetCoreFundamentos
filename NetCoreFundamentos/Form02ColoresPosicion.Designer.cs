namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtPositionX = new TextBox();
            txtPositionY = new TextBox();
            btnMover = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRed = new TextBox();
            txtGreen = new TextBox();
            txtBlue = new TextBox();
            btnColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 32);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Posicion Y";
            // 
            // txtPositionX
            // 
            txtPositionX.Location = new Point(47, 66);
            txtPositionX.Name = "txtPositionX";
            txtPositionX.Size = new Size(100, 23);
            txtPositionX.TabIndex = 2;
            // 
            // txtPositionY
            // 
            txtPositionY.Location = new Point(177, 66);
            txtPositionY.Name = "txtPositionY";
            txtPositionY.Size = new Size(100, 23);
            txtPositionY.TabIndex = 3;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(47, 125);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(114, 31);
            btnMover.TabIndex = 4;
            btnMover.Text = "Reposicionar";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 228);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 228);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 228);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // txtRed
            // 
            txtRed.Location = new Point(46, 258);
            txtRed.Name = "txtRed";
            txtRed.Size = new Size(100, 23);
            txtRed.TabIndex = 8;
            // 
            // txtGreen
            // 
            txtGreen.Location = new Point(177, 258);
            txtGreen.Name = "txtGreen";
            txtGreen.Size = new Size(100, 23);
            txtGreen.TabIndex = 9;
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(306, 258);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(100, 23);
            txtBlue.TabIndex = 10;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(48, 307);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(113, 38);
            btnColor.TabIndex = 11;
            btnColor.Text = "Cambiar fondo";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColor);
            Controls.Add(txtBlue);
            Controls.Add(txtGreen);
            Controls.Add(txtRed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnMover);
            Controls.Add(txtPositionY);
            Controls.Add(txtPositionX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPositionX;
        private TextBox txtPositionY;
        private Button btnMover;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRed;
        private TextBox txtGreen;
        private TextBox txtBlue;
        private Button btnColor;
    }
}