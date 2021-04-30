
namespace ProyectoProgramacion.VISTA
{
    partial class FrmBienvenida
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
            this.btnIngresarBienvenida = new System.Windows.Forms.Button();
            this.btnSalirBienvenida = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarBienvenida
            // 
            this.btnIngresarBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngresarBienvenida.FlatAppearance.BorderSize = 2;
            this.btnIngresarBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarBienvenida.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarBienvenida.Location = new System.Drawing.Point(124, 255);
            this.btnIngresarBienvenida.Name = "btnIngresarBienvenida";
            this.btnIngresarBienvenida.Size = new System.Drawing.Size(119, 43);
            this.btnIngresarBienvenida.TabIndex = 0;
            this.btnIngresarBienvenida.Text = "INGRESAR";
            this.btnIngresarBienvenida.UseVisualStyleBackColor = false;
            this.btnIngresarBienvenida.Click += new System.EventHandler(this.btnIngresarBienvenida_Click);
            // 
            // btnSalirBienvenida
            // 
            this.btnSalirBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalirBienvenida.FlatAppearance.BorderSize = 2;
            this.btnSalirBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirBienvenida.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirBienvenida.Location = new System.Drawing.Point(315, 255);
            this.btnSalirBienvenida.Name = "btnSalirBienvenida";
            this.btnSalirBienvenida.Size = new System.Drawing.Size(119, 43);
            this.btnSalirBienvenida.TabIndex = 1;
            this.btnSalirBienvenida.Text = "SALIR";
            this.btnSalirBienvenida.UseVisualStyleBackColor = false;
            this.btnSalirBienvenida.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBienvenida.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(181, 217);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(226, 14);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "BIENVENIDO A NUESTRO SISTEMA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::ProyectoProgramacion.Properties.Resources.sangre_gif;
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources.portadadonasangre;
            this.pictureBox1.Location = new System.Drawing.Point(114, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirBienvenida);
            this.Controls.Add(this.btnIngresarBienvenida);
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarBienvenida;
        private System.Windows.Forms.Button btnSalirBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenida;
    }
}