using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
           
           
            this.Close();
        }

        private void btnRUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario Donante = new FrmRegistroUsuario();
            Donante.Show();
            this.Hide();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            FrmAgendarCita1 Citas = new FrmAgendarCita1();
            Citas.Show();
            this.Hide();
        }

        private void btnBuscarDonante_Click(object sender, EventArgs e)
        {
            FrmBuscarDonante Busqueda = new FrmBuscarDonante();
            Busqueda.Show();
            this.Hide();
        }

        private void btnCompatibilidadSanguinea_Click(object sender, EventArgs e)
        {
            FrmCompatibilidadSanguinea Compatibilidad = new FrmCompatibilidadSanguinea();
            Compatibilidad.Show();
            this.Hide();
        }

        private void porqueDonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPorqueDonar InfoDonacion = new FrmPorqueDonar();
            InfoDonacion.Show();
            this.Hide();
        }

        private void requisitosParaDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequisitos Requisitos = new FrmRequisitos();
            Requisitos.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
