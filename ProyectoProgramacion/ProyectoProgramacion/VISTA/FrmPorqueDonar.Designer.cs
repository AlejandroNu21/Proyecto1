
namespace ProyectoProgramacion.VISTA
{
    partial class FrmPorqueDonar
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
            this.btnSalirPDonar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirPDonar
            // 
            this.btnSalirPDonar.FlatAppearance.BorderSize = 2;
            this.btnSalirPDonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPDonar.Location = new System.Drawing.Point(675, 367);
            this.btnSalirPDonar.Name = "btnSalirPDonar";
            this.btnSalirPDonar.Size = new System.Drawing.Size(113, 41);
            this.btnSalirPDonar.TabIndex = 1;
            this.btnSalirPDonar.Text = "SALIR";
            this.btnSalirPDonar.UseVisualStyleBackColor = true;
            this.btnSalirPDonar.Click += new System.EventHandler(this.btnSalirPDonar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(133, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(547, 257);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources._0sagree;
            this.pictureBox1.Location = new System.Drawing.Point(12, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPorqueDonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSalirPDonar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPorqueDonar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porque Donar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirPDonar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}