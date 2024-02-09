namespace Cliente
{
    partial class formCliente
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
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.LblPuerto = new System.Windows.Forms.Label();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.RtxtPanelMensajes = new System.Windows.Forms.RichTextBox();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.AutoSize = true;
            this.Lbl_IP.Location = new System.Drawing.Point(895, 331);
            this.Lbl_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(127, 25);
            this.Lbl_IP.TabIndex = 0;
            this.Lbl_IP.Text = "Direccion IP";
            // 
            // LblPuerto
            // 
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Location = new System.Drawing.Point(865, 435);
            this.LblPuerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(198, 25);
            this.LblPuerto.TabIndex = 1;
            this.LblPuerto.Text = "Puerto de conexión";
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Location = new System.Drawing.Point(847, 482);
            this.TxtPuerto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(238, 31);
            this.TxtPuerto.TabIndex = 2;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(744, 385);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(428, 31);
            this.txtIP.TabIndex = 3;
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.Olive;
            this.BtnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConectar.Location = new System.Drawing.Point(786, 552);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(356, 90);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar al servidor";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // RtxtPanelMensajes
            // 
            this.RtxtPanelMensajes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RtxtPanelMensajes.Location = new System.Drawing.Point(13, 328);
            this.RtxtPanelMensajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RtxtPanelMensajes.Name = "RtxtPanelMensajes";
            this.RtxtPanelMensajes.ReadOnly = true;
            this.RtxtPanelMensajes.Size = new System.Drawing.Size(705, 331);
            this.RtxtPanelMensajes.TabIndex = 5;
            this.RtxtPanelMensajes.Text = "";
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Location = new System.Drawing.Point(13, 64);
            this.TxtMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMensaje.Multiline = true;
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(819, 172);
            this.TxtMensaje.TabIndex = 6;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEnviar.Location = new System.Drawing.Point(847, 108);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(325, 62);
            this.BtnEnviar.TabIndex = 7;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Feed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escribe tu mensaje:";
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.RtxtPanelMensajes);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.TxtPuerto);
            this.Controls.Add(this.LblPuerto);
            this.Controls.Add(this.Lbl_IP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formCliente";
            this.Text = "Cliente sin conexión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.Label LblPuerto;
        private System.Windows.Forms.TextBox TxtPuerto;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.RichTextBox RtxtPanelMensajes;
        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

