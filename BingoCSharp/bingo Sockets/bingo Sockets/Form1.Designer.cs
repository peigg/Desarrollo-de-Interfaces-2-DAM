namespace bingo_Sockets
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.conecta = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.elegir = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.numeros = new System.Windows.Forms.Label();
            this.continuar = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.mens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.f4 = new System.Windows.Forms.Button();
            this.f5 = new System.Windows.Forms.Button();
            this.f10 = new System.Windows.Forms.Button();
            this.f9 = new System.Windows.Forms.Button();
            this.f8 = new System.Windows.Forms.Button();
            this.f7 = new System.Windows.Forms.Button();
            this.f6 = new System.Windows.Forms.Button();
            this.f19 = new System.Windows.Forms.Button();
            this.f18 = new System.Windows.Forms.Button();
            this.f17 = new System.Windows.Forms.Button();
            this.f16 = new System.Windows.Forms.Button();
            this.f15 = new System.Windows.Forms.Button();
            this.f24 = new System.Windows.Forms.Button();
            this.f23 = new System.Windows.Forms.Button();
            this.f22 = new System.Windows.Forms.Button();
            this.f21 = new System.Windows.Forms.Button();
            this.f20 = new System.Windows.Forms.Button();
            this.f14 = new System.Windows.Forms.Button();
            this.f13 = new System.Windows.Forms.Button();
            this.f12 = new System.Windows.Forms.Button();
            this.f11 = new System.Windows.Forms.Button();
            this.tablero = new System.Windows.Forms.Panel();
            this.win = new System.Windows.Forms.Button();
            this.ventana = new System.Windows.Forms.ListBox();
            this.titulo = new System.Windows.Forms.Label();
            this.modo = new System.Windows.Forms.Label();
            this.numde = new System.Windows.Forms.Label();
            this.ultimos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // conecta
            // 
            this.conecta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.conecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conecta.ForeColor = System.Drawing.Color.White;
            this.conecta.Location = new System.Drawing.Point(675, 554);
            this.conecta.Name = "conecta";
            this.conecta.Size = new System.Drawing.Size(94, 27);
            this.conecta.TabIndex = 18;
            this.conecta.Text = "Conectar";
            this.conecta.UseVisualStyleBackColor = false;
            this.conecta.Click += new System.EventHandler(this.conecta_Click);
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(551, 482);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(172, 22);
            this.usuario.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(485, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jugador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(490, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Conexion al Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(485, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(551, 510);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(172, 22);
            this.ip.TabIndex = 20;
            this.ip.Text = "127.0.0.1";
            // 
            // elegir
            // 
            this.elegir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.elegir.Enabled = false;
            this.elegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegir.ForeColor = System.Drawing.Color.White;
            this.elegir.Location = new System.Drawing.Point(12, 13);
            this.elegir.Name = "elegir";
            this.elegir.Size = new System.Drawing.Size(138, 31);
            this.elegir.TabIndex = 25;
            this.elegir.Text = "Elegir  Carton";
            this.elegir.UseVisualStyleBackColor = false;
            this.elegir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Jugar
            // 
            this.Jugar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Jugar.Enabled = false;
            this.Jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar.ForeColor = System.Drawing.Color.White;
            this.Jugar.Location = new System.Drawing.Point(156, 12);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(138, 32);
            this.Jugar.TabIndex = 24;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = false;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // numeros
            // 
            this.numeros.AutoSize = true;
            this.numeros.BackColor = System.Drawing.Color.Transparent;
            this.numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros.ForeColor = System.Drawing.Color.White;
            this.numeros.Location = new System.Drawing.Point(660, 72);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(0, 63);
            this.numeros.TabIndex = 1;
            // 
            // continuar
            // 
            this.continuar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.ForeColor = System.Drawing.Color.White;
            this.continuar.Location = new System.Drawing.Point(5, 574);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(94, 33);
            this.continuar.TabIndex = 23;
            this.continuar.Text = "Salir";
            this.continuar.UseVisualStyleBackColor = false;
            this.continuar.Click += new System.EventHandler(this.continuar_Click_1);
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.enviar.Enabled = false;
            this.enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enviar.Location = new System.Drawing.Point(699, 397);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(64, 23);
            this.enviar.TabIndex = 29;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // mens
            // 
            this.mens.Enabled = false;
            this.mens.Location = new System.Drawing.Point(490, 399);
            this.mens.Name = "mens";
            this.mens.Size = new System.Drawing.Size(203, 20);
            this.mens.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(486, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Enviale un Mensaje a todos!!!";
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f1.Enabled = false;
            this.f1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.ForeColor = System.Drawing.Color.Maroon;
            this.f1.Location = new System.Drawing.Point(8, 7);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(49, 43);
            this.f1.TabIndex = 53;
            this.f1.Text = "0";
            this.f1.UseVisualStyleBackColor = false;
            this.f1.Click += new System.EventHandler(this.f1_Click);
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f2.Enabled = false;
            this.f2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2.ForeColor = System.Drawing.Color.Maroon;
            this.f2.Location = new System.Drawing.Point(65, 7);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(49, 43);
            this.f2.TabIndex = 54;
            this.f2.Text = "0";
            this.f2.UseVisualStyleBackColor = false;
            this.f2.Click += new System.EventHandler(this.f2_Click);
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f3.Enabled = false;
            this.f3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3.ForeColor = System.Drawing.Color.Maroon;
            this.f3.Location = new System.Drawing.Point(121, 7);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(49, 43);
            this.f3.TabIndex = 55;
            this.f3.Text = "0";
            this.f3.UseVisualStyleBackColor = false;
            this.f3.Click += new System.EventHandler(this.f3_Click);
            // 
            // f4
            // 
            this.f4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f4.Enabled = false;
            this.f4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4.ForeColor = System.Drawing.Color.Maroon;
            this.f4.Location = new System.Drawing.Point(180, 7);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(49, 43);
            this.f4.TabIndex = 56;
            this.f4.Text = "0";
            this.f4.UseVisualStyleBackColor = false;
            this.f4.Click += new System.EventHandler(this.f4_Click);
            // 
            // f5
            // 
            this.f5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f5.Enabled = false;
            this.f5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5.ForeColor = System.Drawing.Color.Maroon;
            this.f5.Location = new System.Drawing.Point(237, 7);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(49, 43);
            this.f5.TabIndex = 57;
            this.f5.Text = "0";
            this.f5.UseVisualStyleBackColor = false;
            this.f5.Click += new System.EventHandler(this.f5_Click);
            // 
            // f10
            // 
            this.f10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f10.Enabled = false;
            this.f10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f10.ForeColor = System.Drawing.Color.Maroon;
            this.f10.Location = new System.Drawing.Point(237, 63);
            this.f10.Name = "f10";
            this.f10.Size = new System.Drawing.Size(49, 43);
            this.f10.TabIndex = 62;
            this.f10.Text = "0";
            this.f10.UseVisualStyleBackColor = false;
            this.f10.Click += new System.EventHandler(this.f10_Click);
            // 
            // f9
            // 
            this.f9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f9.Enabled = false;
            this.f9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f9.ForeColor = System.Drawing.Color.Maroon;
            this.f9.Location = new System.Drawing.Point(180, 63);
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size(49, 43);
            this.f9.TabIndex = 61;
            this.f9.Text = "0";
            this.f9.UseVisualStyleBackColor = false;
            this.f9.Click += new System.EventHandler(this.f9_Click);
            // 
            // f8
            // 
            this.f8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f8.Enabled = false;
            this.f8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f8.ForeColor = System.Drawing.Color.Maroon;
            this.f8.Location = new System.Drawing.Point(122, 63);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(49, 43);
            this.f8.TabIndex = 60;
            this.f8.Text = "0";
            this.f8.UseVisualStyleBackColor = false;
            this.f8.Click += new System.EventHandler(this.f8_Click);
            // 
            // f7
            // 
            this.f7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f7.Enabled = false;
            this.f7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f7.ForeColor = System.Drawing.Color.Maroon;
            this.f7.Location = new System.Drawing.Point(65, 63);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(49, 43);
            this.f7.TabIndex = 59;
            this.f7.Text = "0";
            this.f7.UseVisualStyleBackColor = false;
            this.f7.Click += new System.EventHandler(this.f7_Click);
            // 
            // f6
            // 
            this.f6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f6.Enabled = false;
            this.f6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f6.ForeColor = System.Drawing.Color.Maroon;
            this.f6.Location = new System.Drawing.Point(8, 63);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(49, 43);
            this.f6.TabIndex = 58;
            this.f6.Text = "0";
            this.f6.UseVisualStyleBackColor = false;
            this.f6.Click += new System.EventHandler(this.f6_Click);
            // 
            // f19
            // 
            this.f19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f19.Enabled = false;
            this.f19.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f19.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f19.ForeColor = System.Drawing.Color.Maroon;
            this.f19.Location = new System.Drawing.Point(237, 179);
            this.f19.Name = "f19";
            this.f19.Size = new System.Drawing.Size(49, 43);
            this.f19.TabIndex = 67;
            this.f19.Text = "0";
            this.f19.UseVisualStyleBackColor = false;
            this.f19.Click += new System.EventHandler(this.f19_Click);
            // 
            // f18
            // 
            this.f18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f18.Enabled = false;
            this.f18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f18.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f18.ForeColor = System.Drawing.Color.Maroon;
            this.f18.Location = new System.Drawing.Point(180, 179);
            this.f18.Name = "f18";
            this.f18.Size = new System.Drawing.Size(49, 43);
            this.f18.TabIndex = 66;
            this.f18.Text = "0";
            this.f18.UseVisualStyleBackColor = false;
            this.f18.Click += new System.EventHandler(this.f18_Click);
            // 
            // f17
            // 
            this.f17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f17.Enabled = false;
            this.f17.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f17.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f17.ForeColor = System.Drawing.Color.Maroon;
            this.f17.Location = new System.Drawing.Point(122, 179);
            this.f17.Name = "f17";
            this.f17.Size = new System.Drawing.Size(49, 43);
            this.f17.TabIndex = 65;
            this.f17.Text = "0";
            this.f17.UseVisualStyleBackColor = false;
            this.f17.Click += new System.EventHandler(this.f17_Click);
            // 
            // f16
            // 
            this.f16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f16.Enabled = false;
            this.f16.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f16.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f16.ForeColor = System.Drawing.Color.Maroon;
            this.f16.Location = new System.Drawing.Point(65, 179);
            this.f16.Name = "f16";
            this.f16.Size = new System.Drawing.Size(49, 43);
            this.f16.TabIndex = 64;
            this.f16.Text = "0";
            this.f16.UseVisualStyleBackColor = false;
            this.f16.Click += new System.EventHandler(this.f16_Click);
            // 
            // f15
            // 
            this.f15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f15.Enabled = false;
            this.f15.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f15.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f15.ForeColor = System.Drawing.Color.Maroon;
            this.f15.Location = new System.Drawing.Point(8, 179);
            this.f15.Name = "f15";
            this.f15.Size = new System.Drawing.Size(49, 43);
            this.f15.TabIndex = 63;
            this.f15.Text = "0";
            this.f15.UseVisualStyleBackColor = false;
            this.f15.Click += new System.EventHandler(this.f15_Click);
            // 
            // f24
            // 
            this.f24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f24.Enabled = false;
            this.f24.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f24.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f24.ForeColor = System.Drawing.Color.Maroon;
            this.f24.Location = new System.Drawing.Point(237, 236);
            this.f24.Name = "f24";
            this.f24.Size = new System.Drawing.Size(49, 43);
            this.f24.TabIndex = 72;
            this.f24.Text = "0";
            this.f24.UseVisualStyleBackColor = false;
            this.f24.Click += new System.EventHandler(this.f24_Click);
            // 
            // f23
            // 
            this.f23.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f23.Enabled = false;
            this.f23.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f23.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f23.ForeColor = System.Drawing.Color.Maroon;
            this.f23.Location = new System.Drawing.Point(180, 237);
            this.f23.Name = "f23";
            this.f23.Size = new System.Drawing.Size(49, 43);
            this.f23.TabIndex = 71;
            this.f23.Text = "0";
            this.f23.UseVisualStyleBackColor = false;
            this.f23.Click += new System.EventHandler(this.f23_Click);
            // 
            // f22
            // 
            this.f22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f22.Enabled = false;
            this.f22.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f22.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f22.ForeColor = System.Drawing.Color.Maroon;
            this.f22.Location = new System.Drawing.Point(121, 237);
            this.f22.Name = "f22";
            this.f22.Size = new System.Drawing.Size(49, 43);
            this.f22.TabIndex = 70;
            this.f22.Text = "0";
            this.f22.UseVisualStyleBackColor = false;
            this.f22.Click += new System.EventHandler(this.f22_Click);
            // 
            // f21
            // 
            this.f21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f21.Enabled = false;
            this.f21.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f21.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f21.ForeColor = System.Drawing.Color.Maroon;
            this.f21.Location = new System.Drawing.Point(65, 236);
            this.f21.Name = "f21";
            this.f21.Size = new System.Drawing.Size(49, 43);
            this.f21.TabIndex = 69;
            this.f21.Text = "0";
            this.f21.UseVisualStyleBackColor = false;
            this.f21.Click += new System.EventHandler(this.f21_Click);
            // 
            // f20
            // 
            this.f20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f20.Enabled = false;
            this.f20.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f20.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f20.ForeColor = System.Drawing.Color.Maroon;
            this.f20.Location = new System.Drawing.Point(8, 236);
            this.f20.Name = "f20";
            this.f20.Size = new System.Drawing.Size(49, 43);
            this.f20.TabIndex = 68;
            this.f20.Text = "0";
            this.f20.UseVisualStyleBackColor = false;
            this.f20.Click += new System.EventHandler(this.f20_Click);
            // 
            // f14
            // 
            this.f14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f14.Enabled = false;
            this.f14.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f14.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f14.ForeColor = System.Drawing.Color.Maroon;
            this.f14.Location = new System.Drawing.Point(237, 123);
            this.f14.Name = "f14";
            this.f14.Size = new System.Drawing.Size(49, 43);
            this.f14.TabIndex = 77;
            this.f14.Text = "0";
            this.f14.UseVisualStyleBackColor = false;
            this.f14.Click += new System.EventHandler(this.f14_Click);
            // 
            // f13
            // 
            this.f13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f13.Enabled = false;
            this.f13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f13.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f13.ForeColor = System.Drawing.Color.Maroon;
            this.f13.Location = new System.Drawing.Point(180, 123);
            this.f13.Name = "f13";
            this.f13.Size = new System.Drawing.Size(49, 43);
            this.f13.TabIndex = 76;
            this.f13.Text = "0";
            this.f13.UseVisualStyleBackColor = false;
            this.f13.Click += new System.EventHandler(this.f13_Click);
            // 
            // f12
            // 
            this.f12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f12.Enabled = false;
            this.f12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f12.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f12.ForeColor = System.Drawing.Color.Maroon;
            this.f12.Location = new System.Drawing.Point(65, 123);
            this.f12.Name = "f12";
            this.f12.Size = new System.Drawing.Size(49, 43);
            this.f12.TabIndex = 74;
            this.f12.Text = "0";
            this.f12.UseVisualStyleBackColor = false;
            this.f12.Click += new System.EventHandler(this.f12_Click);
            // 
            // f11
            // 
            this.f11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f11.Enabled = false;
            this.f11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.f11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f11.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f11.ForeColor = System.Drawing.Color.Maroon;
            this.f11.Location = new System.Drawing.Point(8, 123);
            this.f11.Name = "f11";
            this.f11.Size = new System.Drawing.Size(49, 43);
            this.f11.TabIndex = 73;
            this.f11.Text = "0";
            this.f11.UseVisualStyleBackColor = false;
            this.f11.Click += new System.EventHandler(this.f11_Click);
            // 
            // tablero
            // 
            this.tablero.BackColor = System.Drawing.Color.Transparent;
            this.tablero.Controls.Add(this.f14);
            this.tablero.Controls.Add(this.f1);
            this.tablero.Controls.Add(this.f13);
            this.tablero.Controls.Add(this.f2);
            this.tablero.Controls.Add(this.f12);
            this.tablero.Controls.Add(this.f3);
            this.tablero.Controls.Add(this.f11);
            this.tablero.Controls.Add(this.f4);
            this.tablero.Controls.Add(this.f24);
            this.tablero.Controls.Add(this.f5);
            this.tablero.Controls.Add(this.f23);
            this.tablero.Controls.Add(this.f6);
            this.tablero.Controls.Add(this.f22);
            this.tablero.Controls.Add(this.f7);
            this.tablero.Controls.Add(this.f21);
            this.tablero.Controls.Add(this.f8);
            this.tablero.Controls.Add(this.f20);
            this.tablero.Controls.Add(this.f9);
            this.tablero.Controls.Add(this.f19);
            this.tablero.Controls.Add(this.f10);
            this.tablero.Controls.Add(this.f18);
            this.tablero.Controls.Add(this.f15);
            this.tablero.Controls.Add(this.f17);
            this.tablero.Controls.Add(this.f16);
            this.tablero.Enabled = false;
            this.tablero.Location = new System.Drawing.Point(79, 234);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(293, 287);
            this.tablero.TabIndex = 78;
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.OrangeRed;
            this.win.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.White;
            this.win.Location = new System.Drawing.Point(471, 91);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(145, 73);
            this.win.TabIndex = 82;
            this.win.Text = "  BINGO\r\nClick Aqui ";
            this.win.UseVisualStyleBackColor = false;
            this.win.Visible = false;
            this.win.Click += new System.EventHandler(this.win_Click);
            // 
            // ventana
            // 
            this.ventana.FormattingEnabled = true;
            this.ventana.Location = new System.Drawing.Point(490, 217);
            this.ventana.Name = "ventana";
            this.ventana.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ventana.Size = new System.Drawing.Size(273, 160);
            this.ventana.TabIndex = 84;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titulo.ForeColor = System.Drawing.Color.Orange;
            this.titulo.Location = new System.Drawing.Point(12, 62);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(102, 13);
            this.titulo.TabIndex = 85;
            this.titulo.Text = "Modo de Juego: ";
            // 
            // modo
            // 
            this.modo.AutoSize = true;
            this.modo.BackColor = System.Drawing.Color.Transparent;
            this.modo.ForeColor = System.Drawing.Color.Wheat;
            this.modo.Location = new System.Drawing.Point(120, 62);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(11, 13);
            this.modo.TabIndex = 86;
            this.modo.Text = "-";
            // 
            // numde
            // 
            this.numde.AutoSize = true;
            this.numde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numde.Location = new System.Drawing.Point(472, 22);
            this.numde.Name = "numde";
            this.numde.Size = new System.Drawing.Size(122, 20);
            this.numde.TabIndex = 89;
            this.numde.Text = "Numero  - / 74";
            // 
            // ultimos
            // 
            this.ultimos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ultimos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ultimos.ForeColor = System.Drawing.Color.OrangeRed;
            this.ultimos.FormattingEnabled = true;
            this.ultimos.Location = new System.Drawing.Point(781, 95);
            this.ultimos.Name = "ultimos";
            this.ultimos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ultimos.Size = new System.Drawing.Size(64, 67);
            this.ultimos.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(781, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 92;
            this.label4.Text = " Números \r\nAnteriores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bingo_Sockets.Properties.Resources.juego;
            this.ClientSize = new System.Drawing.Size(853, 611);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ultimos);
            this.Controls.Add(this.numde);
            this.Controls.Add(this.modo);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.ventana);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mens);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.elegir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.win);
            this.Controls.Add(this.conecta);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.tablero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablero.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conecta;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeros;
        private System.Windows.Forms.Button elegir;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox mens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button f1;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Button f3;
        private System.Windows.Forms.Button f4;
        private System.Windows.Forms.Button f5;
        private System.Windows.Forms.Button f10;
        private System.Windows.Forms.Button f9;
        private System.Windows.Forms.Button f8;
        private System.Windows.Forms.Button f7;
        private System.Windows.Forms.Button f6;
        private System.Windows.Forms.Button f19;
        private System.Windows.Forms.Button f18;
        private System.Windows.Forms.Button f17;
        private System.Windows.Forms.Button f16;
        private System.Windows.Forms.Button f15;
        private System.Windows.Forms.Button f24;
        private System.Windows.Forms.Button f23;
        private System.Windows.Forms.Button f22;
        private System.Windows.Forms.Button f21;
        private System.Windows.Forms.Button f20;
        private System.Windows.Forms.Button f14;
        private System.Windows.Forms.Button f13;
        private System.Windows.Forms.Button f12;
        private System.Windows.Forms.Button f11;
        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Button win;
        private System.Windows.Forms.ListBox ventana;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label modo;
        private System.Windows.Forms.Label numde;
        private System.Windows.Forms.ListBox ultimos;
        private System.Windows.Forms.Label label4;
    }
}

