
namespace ProyectoProgramacion.VISTA
{
    partial class FrmAgendarCita1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendarCita1));
            this.lblIngresarNombreCita = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtIngresarNombreCita = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalirCitas1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarNombreCita
            // 
            this.lblIngresarNombreCita.AutoSize = true;
            this.lblIngresarNombreCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblIngresarNombreCita.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombreCita.Location = new System.Drawing.Point(160, 63);
            this.lblIngresarNombreCita.Name = "lblIngresarNombreCita";
            this.lblIngresarNombreCita.Size = new System.Drawing.Size(140, 14);
            this.lblIngresarNombreCita.TabIndex = 0;
            this.lblIngresarNombreCita.Text = "INGRESE SU NOMBRE";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(96, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 40);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtIngresarNombreCita
            // 
            this.txtIngresarNombreCita.Location = new System.Drawing.Point(96, 116);
            this.txtIngresarNombreCita.Name = "txtIngresarNombreCita";
            this.txtIngresarNombreCita.Size = new System.Drawing.Size(290, 20);
            this.txtIngresarNombreCita.TabIndex = 3;
            this.txtIngresarNombreCita.TextChanged += new System.EventHandler(this.txtIngresarNombreCita_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalirCitas1
            // 
            this.btnSalirCitas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalirCitas1.FlatAppearance.BorderSize = 2;
            this.btnSalirCitas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCitas1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCitas1.Location = new System.Drawing.Point(252, 174);
            this.btnSalirCitas1.Name = "btnSalirCitas1";
            this.btnSalirCitas1.Size = new System.Drawing.Size(109, 40);
            this.btnSalirCitas1.TabIndex = 5;
            this.btnSalirCitas1.Text = "SALIR";
            this.btnSalirCitas1.UseVisualStyleBackColor = false;
            this.btnSalirCitas1.Click += new System.EventHandler(this.btnSalirCitas1_Click);
            // 
            // FrmAgendarCita1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(451, 318);
            this.Controls.Add(this.btnSalirCitas1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIngresarNombreCita);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblIngresarNombreCita);
            this.Name = "FrmAgendarCita1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita 1";
            this.Load += new System.EventHandler(this.FrmAgendarCita1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombreCita;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtIngresarNombreCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirCitas1;
    }
}