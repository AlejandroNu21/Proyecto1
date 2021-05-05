
namespace ProyectoProgramacion.VISTA
{
    partial class FrmAgendarCitas2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtgAgendarCita = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnSalirAgendarCita2 = new System.Windows.Forms.Button();
            this.lblNomUs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dtgAgendarCita
            // 
            this.dtgAgendarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgendarCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgendarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendarCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgAgendarCita.Location = new System.Drawing.Point(241, 57);
            this.dtgAgendarCita.Name = "dtgAgendarCita";
            this.dtgAgendarCita.Size = new System.Drawing.Size(537, 150);
            this.dtgAgendarCita.TabIndex = 2;
            this.dtgAgendarCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendarCita_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Donante";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Grupo Sanguineo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Donacion";
            this.Column5.Name = "Column5";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(597, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.FlatAppearance.BorderSize = 2;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Location = new System.Drawing.Point(368, 257);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(130, 47);
            this.btnAgendarCita.TabIndex = 4;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnSalirAgendarCita2
            // 
            this.btnSalirAgendarCita2.FlatAppearance.BorderSize = 2;
            this.btnSalirAgendarCita2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgendarCita2.Location = new System.Drawing.Point(558, 257);
            this.btnSalirAgendarCita2.Name = "btnSalirAgendarCita2";
            this.btnSalirAgendarCita2.Size = new System.Drawing.Size(130, 47);
            this.btnSalirAgendarCita2.TabIndex = 5;
            this.btnSalirAgendarCita2.Text = "SALIR";
            this.btnSalirAgendarCita2.UseVisualStyleBackColor = true;
            this.btnSalirAgendarCita2.Click += new System.EventHandler(this.btnSalirAgendarCita2_Click);
            // 
            // lblNomUs
            // 
            this.lblNomUs.AutoSize = true;
            this.lblNomUs.Location = new System.Drawing.Point(655, 24);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(83, 13);
            this.lblNomUs.TabIndex = 6;
            this.lblNomUs.Text = "Nombre Usuario";
            this.lblNomUs.Click += new System.EventHandler(this.lblNomUs_Click);
            // 
            // FrmAgendarCitas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.btnSalirAgendarCita2);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dtgAgendarCita);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAgendarCitas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Citas 2";
            this.Load += new System.EventHandler(this.FrmAgendarCitas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dtgAgendarCita;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnSalirAgendarCita2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label lblNomUs;
    }
}