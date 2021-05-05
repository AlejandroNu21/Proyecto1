using ProyectoProgramacion.MODEL;
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
    public partial class FrmAgendarCitas2 : Form
    {
        public FrmAgendarCitas2()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgAgendarCita.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Edad, iteracion.GrupoSanguineo);
                }
            }
            Carga();
        }
        void Carga()
        {


        }
        private void btnSalirAgendarCita2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dtgAgendarCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //String Id = dtgAgendarCita.CurrentRow.Cells[0].Value.ToString();
            //String NombreDonante = dtgAgendarCita.CurrentRow.Cells[1].Value.ToString();
            //String Edad = dtgAgendarCita.CurrentRow.Cells[4].Value.ToString();
            //String GrupoSanguineo = dtgAgendarCita.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {

        }

        private void lblNomUs_Click(object sender, EventArgs e)
        {

        }
    }
}
