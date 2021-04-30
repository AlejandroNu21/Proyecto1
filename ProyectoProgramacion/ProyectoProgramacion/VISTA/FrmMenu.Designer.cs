
namespace ProyectoProgramacion.VISTA
{
    partial class FrmMenu
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
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.btnRUsuario = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnBuscarDonante = new System.Windows.Forms.Button();
            this.btnCompatibilidadSanguinea = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitosParaDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porqueDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalirMenu.FlatAppearance.BorderSize = 2;
            this.btnSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMenu.Location = new System.Drawing.Point(323, 411);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(110, 39);
            this.btnSalirMenu.TabIndex = 0;
            this.btnSalirMenu.Text = "SALIR";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // btnRUsuario
            // 
            this.btnRUsuario.BackColor = System.Drawing.Color.Firebrick;
            this.btnRUsuario.FlatAppearance.BorderSize = 2;
            this.btnRUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRUsuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUsuario.Location = new System.Drawing.Point(157, 57);
            this.btnRUsuario.Name = "btnRUsuario";
            this.btnRUsuario.Size = new System.Drawing.Size(125, 46);
            this.btnRUsuario.TabIndex = 4;
            this.btnRUsuario.Text = "Registrar Usuario";
            this.btnRUsuario.UseVisualStyleBackColor = false;
            this.btnRUsuario.Click += new System.EventHandler(this.btnRUsuario_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgendarCita.FlatAppearance.BorderSize = 2;
            this.btnAgendarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCita.Location = new System.Drawing.Point(157, 135);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(125, 41);
            this.btnAgendarCita.TabIndex = 5;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnBuscarDonante
            // 
            this.btnBuscarDonante.BackColor = System.Drawing.Color.Firebrick;
            this.btnBuscarDonante.FlatAppearance.BorderSize = 2;
            this.btnBuscarDonante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDonante.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDonante.Location = new System.Drawing.Point(157, 204);
            this.btnBuscarDonante.Name = "btnBuscarDonante";
            this.btnBuscarDonante.Size = new System.Drawing.Size(125, 41);
            this.btnBuscarDonante.TabIndex = 6;
            this.btnBuscarDonante.Text = "Buscar Donante";
            this.btnBuscarDonante.UseVisualStyleBackColor = false;
            this.btnBuscarDonante.Click += new System.EventHandler(this.btnBuscarDonante_Click);
            // 
            // btnCompatibilidadSanguinea
            // 
            this.btnCompatibilidadSanguinea.BackColor = System.Drawing.Color.Firebrick;
            this.btnCompatibilidadSanguinea.FlatAppearance.BorderSize = 2;
            this.btnCompatibilidadSanguinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCompatibilidadSanguinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompatibilidadSanguinea.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompatibilidadSanguinea.Location = new System.Drawing.Point(157, 274);
            this.btnCompatibilidadSanguinea.Name = "btnCompatibilidadSanguinea";
            this.btnCompatibilidadSanguinea.Size = new System.Drawing.Size(125, 53);
            this.btnCompatibilidadSanguinea.TabIndex = 7;
            this.btnCompatibilidadSanguinea.Text = "Compatibilidad Sanguinea";
            this.btnCompatibilidadSanguinea.UseVisualStyleBackColor = false;
            this.btnCompatibilidadSanguinea.Click += new System.EventHandler(this.btnCompatibilidadSanguinea_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNFORMACIONToolStripMenuItem
            // 
            this.iNFORMACIONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iNFORMACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requisitosParaDonacionesToolStripMenuItem,
            this.porqueDonarToolStripMenuItem});
            this.iNFORMACIONToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNFORMACIONToolStripMenuItem.Name = "iNFORMACIONToolStripMenuItem";
            this.iNFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.iNFORMACIONToolStripMenuItem.Text = "INFORMACION";
            // 
            // requisitosParaDonacionesToolStripMenuItem
            // 
            this.requisitosParaDonacionesToolStripMenuItem.Name = "requisitosParaDonacionesToolStripMenuItem";
            this.requisitosParaDonacionesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.requisitosParaDonacionesToolStripMenuItem.Text = "Requisitos Para Donaciones";
            this.requisitosParaDonacionesToolStripMenuItem.Click += new System.EventHandler(this.requisitosParaDonacionesToolStripMenuItem_Click);
            // 
            // porqueDonarToolStripMenuItem
            // 
            this.porqueDonarToolStripMenuItem.Name = "porqueDonarToolStripMenuItem";
            this.porqueDonarToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.porqueDonarToolStripMenuItem.Text = "Porque Donar?";
            this.porqueDonarToolStripMenuItem.Click += new System.EventHandler(this.porqueDonarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoProgramacion.Properties.Resources._gota_sangre;
            this.pictureBox1.Location = new System.Drawing.Point(12, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(445, 462);
            this.Controls.Add(this.btnCompatibilidadSanguinea);
            this.Controls.Add(this.btnBuscarDonante);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.btnRUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRUsuario;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnBuscarDonante;
        private System.Windows.Forms.Button btnCompatibilidadSanguinea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisitosParaDonacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porqueDonarToolStripMenuItem;
    }
}