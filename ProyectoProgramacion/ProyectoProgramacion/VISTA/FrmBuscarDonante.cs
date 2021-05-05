using ProyectoProgramacion.DAO;
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
    public partial class FrmBuscarDonante : Form
    {
        public string Id { get; private set; }

        public FrmBuscarDonante()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgBuscarDonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Direccion, iteracion.Telefono, iteracion.Edad, iteracion.GrupoSanguineo);
                }
            }
            Carga();
        }
        void Carga()
        {
            dtgBuscarDonante.Rows.Clear();
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgBuscarDonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Direccion, iteracion.Telefono, iteracion.Edad, iteracion.GrupoSanguineo);
                }
            }

        }
        void Clear()
        {

        }
        private void btnSalirBDonante_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void btnEliminarBDonante_Click(object sender, EventArgs e)
        {
            try
            {
                using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
                {
                    Tbl_UserList1 user = new Tbl_UserList1();
                    int eliminar = (Convert.ToInt32(txtId.Text));
                    user = db.Tbl_UserList1.Find(eliminar);
                    db.Tbl_UserList1.Remove(user);
                    db.SaveChanges();
                    Carga();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtgBuscarDonante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgBuscarDonante.CurrentRow.Cells[0].Value.ToString();
            


            txtId.Text = Id;

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
          
            
            txtId.Text = Id;
        }

        private void FrmBuscarDonante_Load(object sender, EventArgs e)
        {

        }
    }
}
