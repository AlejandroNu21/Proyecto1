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
                    //Tbl_UserList1 userList = new Tbl_UserList1();
                    //int Eliminar = Convert.ToInt32(txtId.Text);
                    //Tbl_UserList1 userList = db.Tbl_UserList1.Where(x => x.Id == 24).Select(x => x).FirstOrDefault();
                    ////int Eliminar = Convert.ToInt32(txtid.Text);
                    ////userList = db.Tbl_UserList1.Find(Eliminar);
                    //db.Tbl_UserList1.Remove(userList);
                    //db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void dtgBuscarDonante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgBuscarDonante.CurrentRow.Cells[0].Value.ToString();
            String NombreDonante = dtgBuscarDonante.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgBuscarDonante.CurrentRow.Cells[2].Value.ToString();
            String Telefono = dtgBuscarDonante.CurrentRow.Cells[3].Value.ToString();
            String Edad = dtgBuscarDonante.CurrentRow.Cells[4].Value.ToString();
            String GrupoSanguineo = dtgBuscarDonante.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
