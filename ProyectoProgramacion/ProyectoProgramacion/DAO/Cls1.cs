using ProyectoProgramacion.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.DAO
{
    class Cls1
    {
        public List<Tbl_UserList1> cargarDatosUserlist()
        {
            List<Tbl_UserList1> Lista;


            using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
            {
                Lista = db.Tbl_UserList1.ToList();


            }
            return Lista;
        }

        public void deleteUser(int Id)
        {
            try
            {
                using (DATOSPROYECTOEntities db = new DATOSPROYECTOEntities())
                {
                    ////Tbl_UserList1 userList = new Tbl_UserList1();
                    ////int Eliminar = Convert.ToInt32(txtId.Text);
                    ////Tbl_UserList1 userList = db.Tbl_UserList1.Where(x => x.Id == 26).Select(x => x).FirstOrDefault();
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
    }
}
