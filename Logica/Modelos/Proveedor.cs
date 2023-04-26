using Logica.Models;
using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Modelos
{
    public class Proveedor
    {

        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorEmail { get; set; }
        public string ProveedorDireccion { get; set; }
        public string ProveedorNotas { get; set; }
        public bool Activo { get; set; }

        public TipoProveedor MiTipoProveedor { get; set; }


        public Proveedor()
        {

            MiTipoProveedor = new TipoProveedor();
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProveedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.ProveedorEmail));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProveedorDireccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.ProveedorNotas));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoProveedor", this.MiTipoProveedor.ProveedorTipoID));
    

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");

            if (resultado > 0)
            {
                R = true;

            }

            return R;
        }

        public Proveedor ConsultarPorIDRetornaProveedor()
        {
            Proveedor R = new Proveedor();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarId");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                R.ProveedorNombre = Convert.ToString(dr["ProveedorNombre"]);
                R.ProveedorCedula = Convert.ToString(dr["ProveedorCedula"]);
                R.ProveedorEmail = Convert.ToString(dr["ProveedorEmail"]);
                R.ProveedorDireccion = Convert.ToString(dr["ProveedorDireccion"]);
                R.ProveedorNotas = Convert.ToString(dr["ProveedorNotas"]);
                

               
                R.MiTipoProveedor.ProveedorTipoID = Convert.ToInt32(dr["ProveedorTipoID"]);
                R.MiTipoProveedor.ProveedorTipoDescripcion = Convert.ToString(dr["ProveedorTipoDescripcion"]);

            }

            return R;
        }


        public bool Editar()
        {

            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarId()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Id", this.ProveedorID));

            //NECESITO UN DATA TABLE PARA CAPTURAR LA INFO DEL USUSARIO
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;

            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

          
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));

            DataTable consulta = new DataTable();

        
            consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarPorCedula");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //paso 1.4.1 y 1.4.2
            Conexion MiCnn = new Conexion();

            //agregamos el parametro por correo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.ProveedorEmail));

            DataTable consulta = new DataTable();

            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarEmail");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }



        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
         

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }




    }
}
