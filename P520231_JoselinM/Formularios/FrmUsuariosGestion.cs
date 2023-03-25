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

            if (dt != null && dt.Rows.Count > 0)
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

            if (DgLista.SelectedRows.Count == 1)
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();
        }


        private bool ValidarDatosDigitados()
        {
            bool R = false;


            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioDireccion.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)

            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre de usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una telefono valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo valid0", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;


                }

                if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una contraseña valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioContrasennia.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtUsuarioDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una direccion valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioDireccion.Focus();
                    return false;

                }

                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar una rol valido", "Error de validacion", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }








            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {



                bool CedulaOK;
                bool EmailOK;

                MiUsuarioLocal = new Logica.Models.Usuario();



                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                CedulaOK = MiUsuarioLocal.ConsultarPorCedula();
                EmailOK = MiUsuarioLocal.ConsultarPorEmail();

                if (CedulaOK == false && EmailOK == false)
                {
                    string msg = string.Format("¿DESEA AGREGAR AL USUARIO {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Usuario guadado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("Usuario no guadado correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (CedulaOK)
                    {
                        MessageBox.Show("El usuario con esa cedula ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                    if (EmailOK)
                    {
                        MessageBox.Show("El usuario con esa Email ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
        }
    }
}
