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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
            Carga();
        }
        void Carga()
        {
            dtgRegistroUsuario.Rows.Clear();
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgRegistroUsuario.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Direccion, iteracion.Telefono, iteracion.Edad, iteracion.GrupoSanguineo);
                }
            }

        }

        void Clear()
        {
            txtNombreDonante.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            //CmbGrupoSanguineo.Clear();
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            

        }


    

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgRegistroUsuario.CurrentRow.Cells[0].Value.ToString();
            String NombreDonante = dtgRegistroUsuario.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgRegistroUsuario.CurrentRow.Cells[2].Value.ToString();
            String Telefono = dtgRegistroUsuario.CurrentRow.Cells[3].Value.ToString();
            String Edad = dtgRegistroUsuario.CurrentRow.Cells[4].Value.ToString();
            String GrupoSanguineo = dtgRegistroUsuario.CurrentRow.Cells[5].Value.ToString();


            txtId.Text = Id;
            txtNombreDonante.Text = NombreDonante;
            txtDireccion.Text = Direccion;
            txtTelefono.Text = Telefono;
            txtEdad.Text = Edad;
            CmbGrupoSanguineo.Text = GrupoSanguineo;
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            try { 
            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                Tbl_UserList1 userList = new Tbl_UserList1();

                userList.NombreDonante = txtNombreDonante.Text;
                userList.Direccion = txtDireccion.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Telefono = Convert.ToInt32(txtTelefono.Text);
                userList.GrupoSanguineo = CmbGrupoSanguineo.Text;
                db.Tbl_UserList1.Add(userList);
                db.SaveChanges();

            }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Carga();
            Clear();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
