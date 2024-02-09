namespace OrdenarArrayForm
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
            txtLength = new TextBox();
            llbLength = new Label();
            btnGuardar = new Button();
            lblSolicita = new Label();
            txtValor = new TextBox();
            btnValores = new Button();
            lblDesordenado = new Label();
            lblOrdenado = new Label();
            txtOrdenado = new TextBox();
            txtDesordenado = new TextBox();
            SuspendLayout();
            // 
            // txtLength
            // 
            txtLength.Location = new Point(468, 26);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(200, 39);
            txtLength.TabIndex = 0;
            // 
            // llbLength
            // 
            llbLength.AutoSize = true;
            llbLength.Location = new Point(64, 29);
            llbLength.Name = "llbLength";
            llbLength.Size = new Size(337, 32);
            llbLength.TabIndex = 1;
            llbLength.Text = "Introduce la longitud del array";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.Location = new Point(492, 71);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblSolicita
            // 
            lblSolicita.AutoSize = true;
            lblSolicita.Location = new Point(64, 136);
            lblSolicita.Name = "lblSolicita";
            lblSolicita.Size = new Size(208, 32);
            lblSolicita.TabIndex = 3;
            lblSolicita.Text = "Introduzca valores";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(468, 136);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 39);
            txtValor.TabIndex = 4;
            // 
            // btnValores
            // 
            btnValores.BackColor = SystemColors.MenuHighlight;
            btnValores.Location = new Point(492, 181);
            btnValores.Name = "btnValores";
            btnValores.Size = new Size(150, 46);
            btnValores.TabIndex = 5;
            btnValores.Text = "Enviar";
            btnValores.UseVisualStyleBackColor = false;
            btnValores.Click += btnValores_Click;
            // 
            // lblDesordenado
            // 
            lblDesordenado.AutoSize = true;
            lblDesordenado.Location = new Point(64, 228);
            lblDesordenado.Name = "lblDesordenado";
            lblDesordenado.Size = new Size(231, 32);
            lblDesordenado.TabIndex = 6;
            lblDesordenado.Text = "Vector Desordenado";
            // 
            // lblOrdenado
            // 
            lblOrdenado.AutoSize = true;
            lblOrdenado.Location = new Point(64, 333);
            lblOrdenado.Name = "lblOrdenado";
            lblOrdenado.Size = new Size(195, 32);
            lblOrdenado.TabIndex = 7;
            lblOrdenado.Text = "Vector Ordenado";
            // 
            // txtOrdenado
            // 
            txtOrdenado.Location = new Point(64, 368);
            txtOrdenado.Multiline = true;
            txtOrdenado.Name = "txtOrdenado";
            txtOrdenado.Size = new Size(699, 70);
            txtOrdenado.TabIndex = 8;
            // 
            // txtDesordenado
            // 
            txtDesordenado.Location = new Point(64, 263);
            txtDesordenado.Multiline = true;
            txtDesordenado.Name = "txtDesordenado";
            txtDesordenado.Size = new Size(699, 67);
            txtDesordenado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDesordenado);
            Controls.Add(txtOrdenado);
            Controls.Add(lblOrdenado);
            Controls.Add(lblDesordenado);
            Controls.Add(btnValores);
            Controls.Add(txtValor);
            Controls.Add(lblSolicita);
            Controls.Add(btnGuardar);
            Controls.Add(llbLength);
            Controls.Add(txtLength);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLength;
        private Label llbLength;
        private Button btnGuardar;
        private Label lblSolicita;
        private TextBox txtValor;
        private Button btnValores;
        private Label lblDesordenado;
        private Label lblOrdenado;
        private TextBox txtOrdenado;
        private TextBox txtDesordenado;
    }
}
