namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            label2 = new Label();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbYears = new RadioButton();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(12, 44);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(323, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(12, 85);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 126);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(12, 110);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 4;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(12, 135);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 5;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbYears
            // 
            rdbYears.AutoSize = true;
            rdbYears.Location = new Point(12, 160);
            rdbYears.Name = "rdbYears";
            rdbYears.Size = new Size(52, 19);
            rdbYears.TabIndex = 6;
            rdbYears.TabStop = true;
            rdbYears.Text = "Años";
            rdbYears.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(218, 123);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(144, 156);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(174, 32);
            btnIncremento.TabIndex = 8;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(12, 243);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(319, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 288);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(btnIncremento);
            Controls.Add(txtIncremento);
            Controls.Add(rdbYears);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(label2);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private Label label2;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbYears;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}