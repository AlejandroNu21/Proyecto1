using ProyectoProgramacion.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
