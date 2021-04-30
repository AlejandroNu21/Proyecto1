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
    public partial class FrmAgendarCita1 : Form
    {
        public FrmAgendarCita1()
        {
            InitializeComponent();
        }

        private void FrmAgendarCita1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmAgendarCitas2 FechaCita = new FrmAgendarCitas2();

            MessageBox.Show("\nBIENVENIDO\n");
            FechaCita.Show();
            this.Hide();
        }

       

        private void btnSalirCitas1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }
    
    }
}
