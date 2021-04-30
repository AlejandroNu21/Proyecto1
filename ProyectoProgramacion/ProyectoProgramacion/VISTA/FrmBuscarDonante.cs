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
                Cls1 user = new Cls1();
                user.deleteUser(Convert.ToInt32(Id));
                Carga();
                Clear();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Cls1 user = new Cls1();
            //user.deleteUser(Convert.ToInt32(Id));
            //Carga();
            //Clear();
        }

        private void dtgBuscarDonante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgBuscarDonante.CurrentRow.Cells[0].Value.ToString();
            String NombreDonante = dtgBuscarDonante.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgBuscarDonante.CurrentRow.Cells[2].Value.ToString();
            String Telefono = dtgBuscarDonante.CurrentRow.Cells[3].Value.ToString();
            String Edad = dtgBuscarDonante.CurrentRow.Cells[4].Value.ToString();
            String GrupoSanguineo = dtgBuscarDonante.CurrentRow.Cells[5].Value.ToString();


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
