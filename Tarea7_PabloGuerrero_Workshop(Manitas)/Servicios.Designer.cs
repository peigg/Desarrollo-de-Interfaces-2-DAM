namespace Workshop
{
    partial class Servicios
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
            this.btnMech = new System.Windows.Forms.Button();
            this.btnPlumb = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.btnWood = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pBoxServicios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMech
            // 
            this.btnMech.AccessibleDescription = "Closing app button";
            this.btnMech.AccessibleName = "Closing app button";
            this.btnMech.BackColor = System.Drawing.Color.Black;
            this.btnMech.BackgroundImage = global::Workshop.Properties.Resources.btnMechanic;
            this.btnMech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMech.Location = new System.Drawing.Point(159, 111);
            this.btnMech.Name = "btnMech";
            this.btnMech.Size = new System.Drawing.Size(145, 80);
            this.btnMech.TabIndex = 4;
            this.btnMech.UseVisualStyleBackColor = false;
            this.btnMech.Click += new System.EventHandler(this.btnMech_Click);
            // 
            // btnPlumb
            // 
            this.btnPlumb.AccessibleDescription = "Closing app button";
            this.btnPlumb.AccessibleName = "Closing app button";
            this.btnPlumb.BackColor = System.Drawing.Color.Black;
            this.btnPlumb.BackgroundImage = global::Workshop.Properties.Resources.btnPlumbing;
            this.btnPlumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlumb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlumb.Location = new System.Drawing.Point(398, 255);
            this.btnPlumb.Name = "btnPlumb";
            this.btnPlumb.Size = new System.Drawing.Size(145, 80);
            this.btnPlumb.TabIndex = 3;
            this.btnPlumb.UseVisualStyleBackColor = false;
            this.btnPlumb.Click += new System.EventHandler(this.btnPlumb_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.AccessibleDescription = "Closing app button";
            this.btnMetal.AccessibleName = "Closing app button";
            this.btnMetal.BackColor = System.Drawing.Color.Black;
            this.btnMetal.BackgroundImage = global::Workshop.Properties.Resources.btnMetal;
            this.btnMetal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetal.Location = new System.Drawing.Point(159, 255);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(145, 80);
            this.btnMetal.TabIndex = 2;
            this.btnMetal.UseVisualStyleBackColor = false;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // btnWood
            // 
            this.btnWood.AccessibleDescription = "Closing app button";
            this.btnWood.AccessibleName = "Closing app button";
            this.btnWood.BackColor = System.Drawing.Color.Black;
            this.btnWood.BackgroundImage = global::Workshop.Properties.Resources.btnWood;
            this.btnWood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWood.Location = new System.Drawing.Point(398, 111);
            this.btnWood.Name = "btnWood";
            this.btnWood.Size = new System.Drawing.Size(145, 80);
            this.btnWood.TabIndex = 1;
            this.btnWood.UseVisualStyleBackColor = false;
            this.btnWood.Click += new System.EventHandler(this.btnWood_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "Closing app button";
            this.btnClose.AccessibleName = "Closing app button";
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::Workshop.Properties.Resources.btnClose__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(583, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 80);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pBoxServicios
            // 
            this.pBoxServicios.BackgroundImage = global::Workshop.Properties.Resources.FondoRegistro;
            this.pBoxServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxServicios.Location = new System.Drawing.Point(0, 0);
            this.pBoxServicios.Name = "pBoxServicios";
            this.pBoxServicios.Size = new System.Drawing.Size(800, 450);
            this.pBoxServicios.TabIndex = 0;
            this.pBoxServicios.TabStop = false;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMech);
            this.Controls.Add(this.btnPlumb);
            this.Controls.Add(this.btnMetal);
            this.Controls.Add(this.btnWood);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pBoxServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxServicios;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWood;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.Button btnPlumb;
        private System.Windows.Forms.Button btnMech;
    }
}