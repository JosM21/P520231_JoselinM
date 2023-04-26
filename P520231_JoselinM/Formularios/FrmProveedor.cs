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
    public partial class FrmProveedor : Form

    {

        public Logica.Modelos.Proveedor MiPoveedorLocal { get; set; }

        public DataTable ListarProveedor  { get; set; }

        public FrmProveedor()
        {
            InitializeComponent();
            MiPoveedorLocal = new Logica.Modelos.Proveedor();
            ListarProveedor = new DataTable();

        }

        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();
            TxtNotas.Clear();
            TxtProveedorID.Clear();
            CbTipoProveedor.SelectedIndex = -1;

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.MiFormPrincipal;

            CargarListaDeProveedores();

            CargarTiposProveedor();


        }


        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }


        private void CargarListaDeProveedores()
        {
            // resetear la lista de ususarios
            Logica.Modelos.Proveedor MiProveedor = new Logica.Modelos.Proveedor();

            DataTable dataTable = new DataTable();
            dataTable = MiProveedor.Listar();


            if (dataTable.Rows.Count > 0)
            {
                ListarProveedor = MiPoveedorLocal.Listar();

            }

            DgLista.DataSource = ListarProveedor;

        }


        private void CargarTiposProveedor()
        {

            Logica.Models.TipoProveedor MiRol = new Logica.Models.TipoProveedor();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoProveedor.ValueMember = "ID";
                CbTipoProveedor.DisplayMember = "Descrip";
                CbTipoProveedor.DataSource = dt;
                CbTipoProveedor.SelectedIndex = -1;
            }
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdProveedor = Convert.ToInt32(MiFila.Cells["CProveedorID"].Value);



                MiPoveedorLocal = new Logica.Modelos.Proveedor();



                MiPoveedorLocal.ProveedorID = IdProveedor;



                MiPoveedorLocal = MiPoveedorLocal.ConsultarPorIDRetornaProveedor();




                if (MiPoveedorLocal != null && MiPoveedorLocal.ProveedorID > 0)
                {


                    TxtProveedorID.Text = Convert.ToString(MiPoveedorLocal.ProveedorID);

                    TxtNombre.Text = MiPoveedorLocal.ProveedorNombre;

                    TxtCedula.Text = MiPoveedorLocal.ProveedorCedula;

                    TxtCorreo.Text = MiPoveedorLocal.ProveedorEmail;

                    TxtDireccion.Text = MiPoveedorLocal.ProveedorDireccion;

                    TxtNotas.Text = MiPoveedorLocal.ProveedorNotas;

                    CbTipoProveedor.SelectedValue = MiPoveedorLocal.MiTipoProveedor.ProveedorTipoID;

                   


                }

            }

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;



            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDireccion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNotas.Text.Trim()) &&
                 CbTipoProveedor.SelectedIndex > -1)



            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un fecha", "Error de validacion", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un proveedor ", "Error de validacion", MessageBoxButtons.OK);
                    TxtCorreo.Focus();
                    return false;
                }

                if (CbTipoProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar un tipo de proveedor valido", "Error de validacion", MessageBoxButtons.OK);
                    CbTipoProveedor.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un proveedor ", "Error de validacion", MessageBoxButtons.OK);
                    TxtDireccion.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtNotas.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un proveedor ", "Error de validacion", MessageBoxButtons.OK);
                    TxtNotas.Focus();
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

                MiPoveedorLocal = new Logica.Modelos.Proveedor();



                MiPoveedorLocal.ProveedorNombre = TxtNombre.Text.Trim();
                MiPoveedorLocal.ProveedorCedula = TxtCedula.Text.Trim();
                MiPoveedorLocal.ProveedorEmail = TxtCorreo.Text.Trim();
                MiPoveedorLocal.ProveedorDireccion = TxtDireccion.Text.Trim();
                MiPoveedorLocal.ProveedorNotas = TxtNotas.Text.Trim();

                MiPoveedorLocal.MiTipoProveedor.ProveedorTipoID = Convert.ToInt32(CbTipoProveedor.SelectedValue);
          
                CedulaOK = MiPoveedorLocal.ConsultarPorCedula();
                EmailOK = MiPoveedorLocal.ConsultarPorEmail();

                if (CedulaOK == false && EmailOK == false)
                {
                    string msg = string.Format("¿DESEA AGREGAR AL PROVEEDOR {0}?", MiPoveedorLocal.ProveedorNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiPoveedorLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Proveedor guadado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeProveedores();

                        }
                        else
                        {
                            MessageBox.Show("Proveedor no guadado correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (CedulaOK)
                    {
                        MessageBox.Show("El proveedor con esa cedula ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                    if (EmailOK)
                    {
                        MessageBox.Show("El proveedor con esa email ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                }

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgLista.ClearSelection();
        }
    }
}

