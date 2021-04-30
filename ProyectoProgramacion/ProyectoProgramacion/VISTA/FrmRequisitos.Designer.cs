
namespace ProyectoProgramacion.VISTA
{
    partial class FrmRequisitos
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
            this.btnSalirRequisitos = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSalirRequisitos
            // 
            this.btnSalirRequisitos.FlatAppearance.BorderSize = 2;
            this.btnSalirRequisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirRequisitos.Location = new System.Drawing.Point(663, 393);
            this.btnSalirRequisitos.Name = "btnSalirRequisitos";
            this.btnSalirRequisitos.Size = new System.Drawing.Size(114, 45);
            this.btnSalirRequisitos.TabIndex = 0;
            this.btnSalirRequisitos.Text = "SALIR";
            this.btnSalirRequisitos.UseVisualStyleBackColor = true;
            this.btnSalirRequisitos.Click += new System.EventHandler(this.btnSalirRequisitos_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(65, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 350);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(407, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(314, 350);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // FrmRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSalirRequisitos);
            this.Name = "FrmRequisitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisitos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirRequisitos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}