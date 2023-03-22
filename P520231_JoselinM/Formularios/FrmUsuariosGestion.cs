using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JoselinM.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuario { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuario = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //DEFINIMOS EL PADRE MDI

            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();

            CargarListaDeUsuarios();
        }

        private void CargarListaDeUsuarios()
        {
           // resetear la lista de ususarios
             ListaUsuario = new DataTable();  
            
            ListaUsuario = MiUsuarioLocal.ListarActivos();

            if (cboxVerActivos.Checked)
            {
                ListaUsuario = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuario = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuario;

        }


        private void CargarListaRoles()
        {

            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0 ) 
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(DgLista.SelectedRows.Count == 1) 
            {

                //de la colección de filas seleccionadas (que en este caso es solo una) 
                //seleccionamos la fila en indice 0, o sea la primera
                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                //lo que necesito es el valor del ID del usuario para realizaer la consulta 
                //y traer todos los datos para llenar el objeto de usuario local 
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);


                //para no asumir riesgos se reinstancia el usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();


                //ahora le agregarmos el valor obtenido por la fila al ID del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;


                //una vez que tengo el objeto local con el valor del id, puedo ir a consultar
                //el usuario por ese id y llenar el resto de atributos.
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();


                //validamos que el usuario local tenga datos 

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si cargamos correctamente el usuario local llenamos los controles 

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //combobox 
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                }



               
            }
        }
    }
}
