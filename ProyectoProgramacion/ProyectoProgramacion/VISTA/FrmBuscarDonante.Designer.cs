
namespace ProyectoProgramacion.VISTA
{
    partial class FrmBuscarDonante
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
            this.lblIngreseDonante = new System.Windows.Forms.Label();
            this.txtDonanteaBuscar = new System.Windows.Forms.TextBox();
            this.dtgBuscarDonante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarBDonante = new System.Windows.Forms.Button();
            this.btnSalirBDonante = new System.Windows.Forms.Button();
            this.btnBuscarDonante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarDonante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseDonante
            // 
            this.lblIngreseDonante.AutoSize = true;
            this.lblIngreseDonante.Location = new System.Drawing.Point(298, 47);
            this.lblIngreseDonante.Name = "lblIngreseDonante";
            this.lblIngreseDonante.Size = new System.Drawing.Size(131, 13);
            this.lblIngreseDonante.TabIndex = 0;
            this.lblIngreseDonante.Text = "Ingrese Donante a Buscar";
            // 
            // txtDonanteaBuscar
            // 
            this.txtDonanteaBuscar.Location = new System.Drawing.Point(242, 92);
            this.txtDonanteaBuscar.Name = "txtDonanteaBuscar";
            this.txtDonanteaBuscar.Size = new System.Drawing.Size(250, 20);
            this.txtDonanteaBuscar.TabIndex = 1;
            // 
            // dtgBuscarDonante
            // 
            this.dtgBuscarDonante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBuscarDonante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBuscarDonante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarDonante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgBuscarDonante.Location = new System.Drawing.Point(61, 137);
            this.dtgBuscarDonante.Name = "dtgBuscarDonante";
            this.dtgBuscarDonante.Size = new System.Drawing.Size(600, 150);
            this.dtgBuscarDonante.TabIndex = 2;
            this.dtgBuscarDonante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuscarDonante_CellContentClick);
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
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo Sanguineo";
            this.Column6.Name = "Column6";
            // 
            // btnEliminarBDonante
            // 
            this.btnEliminarBDonante.FlatAppearance.BorderSize = 2;
            this.btnEliminarBDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBDonante.Location = new System.Drawing.Point(221, 308);
            this.btnEliminarBDonante.Name = "btnEliminarBDonante";
            this.btnEliminarBDonante.Size = new System.Drawing.Size(117, 39);
            this.btnEliminarBDonante.TabIndex = 3;
            this.btnEliminarBDonante.Text = "ELIMINAR";
            this.btnEliminarBDonante.UseVisualStyleBackColor = true;
            this.btnEliminarBDonante.Click += new System.EventHandler(this.btnEliminarBDonante_Click);
            // 
            // btnSalirBDonante
            // 
            this.btnSalirBDonante.FlatAppearance.BorderSize = 2;
            this.btnSalirBDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirBDonante.Location = new System.Drawing.Point(375, 308);
            this.btnSalirBDonante.Name = "btnSalirBDonante";
            this.btnSalirBDonante.Size = new System.Drawing.Size(117, 39);
            this.btnSalirBDonante.TabIndex = 4;
            this.btnSalirBDonante.Text = "SALIR";
            this.btnSalirBDonante.UseVisualStyleBackColor = true;
            this.btnSalirBDonante.Click += new System.EventHandler(this.btnSalirBDonante_Click);
            // 
            // btnBuscarDonante
            // 
            this.btnBuscarDonante.FlatAppearance.BorderSize = 2;
            this.btnBuscarDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDonante.Location = new System.Drawing.Point(516, 83);
            this.btnBuscarDonante.Name = "btnBuscarDonante";
            this.btnBuscarDonante.Size = new System.Drawing.Size(104, 37);
            this.btnBuscarDonante.TabIndex = 5;
            this.btnBuscarDonante.Text = "BUSCAR";
            this.btnBuscarDonante.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 399);
            this.Controls.Add(this.btnBuscarDonante);
            this.Controls.Add(this.btnSalirBDonante);
            this.Controls.Add(this.btnEliminarBDonante);
            this.Controls.Add(this.dtgBuscarDonante);
            this.Controls.Add(this.txtDonanteaBuscar);
            this.Controls.Add(this.lblIngreseDonante);
            this.Name = "FrmBuscarDonante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Donante";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarDonante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseDonante;
        private System.Windows.Forms.TextBox txtDonanteaBuscar;
        private System.Windows.Forms.DataGridView dtgBuscarDonante;
        private System.Windows.Forms.Button btnEliminarBDonante;
        private System.Windows.Forms.Button btnSalirBDonante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnBuscarDonante;
    }
}