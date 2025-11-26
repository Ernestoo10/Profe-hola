namespace WindowsFormsApp1
{
    partial class MENU
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.bttIngresar = new System.Windows.Forms.Button();
            this.bttsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.bttsalir);
            this.gbMenu.Controls.Add(this.bttIngresar);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.Location = new System.Drawing.Point(383, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(382, 416);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu AIEP";
            // 
            // bttIngresar
            // 
            this.bttIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttIngresar.Location = new System.Drawing.Point(26, 96);
            this.bttIngresar.Name = "bttIngresar";
            this.bttIngresar.Size = new System.Drawing.Size(324, 70);
            this.bttIngresar.TabIndex = 0;
            this.bttIngresar.Text = "Ingresar";
            this.bttIngresar.UseVisualStyleBackColor = true;
            // 
            // bttsalir
            // 
            this.bttsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttsalir.Location = new System.Drawing.Point(26, 254);
            this.bttsalir.Name = "bttsalir";
            this.bttsalir.Size = new System.Drawing.Size(324, 70);
            this.bttsalir.TabIndex = 2;
            this.bttsalir.Text = "Salir";
            this.bttsalir.UseVisualStyleBackColor = true;
            this.bttsalir.Click += new System.EventHandler(this.bttsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.AIEP_alt_azul_1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button bttsalir;
        private System.Windows.Forms.Button bttIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}