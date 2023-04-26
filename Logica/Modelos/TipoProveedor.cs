using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoProveedor
    {
        public int ProveedorTipoID { get; set; }
        public string ProveedorTipoDescripcion { get; set; }

        public DataTable Listar()
        {
            // Create a new DataTable and add two columns to it
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPTipoProveedorListar");

            // Return the DataTable
            return R;
        }


    }
}