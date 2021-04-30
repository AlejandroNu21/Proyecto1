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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarBienvenida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<>--Bienvenido al sistema de Banco de Sangre--<>");
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
