
using System.Windows.Forms;

namespace P520231_JoselinM
{
    public static class Globales
    {

        //Estas propiedas al pertenecer a una clase static se auto instancian 
        //y se puede obtener acceso a ellas en la globalidad de la aplicación.

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompra MiFrmRegistroCompra = new Formularios.FrmRegistroCompra();

        public static Formularios.FrmProveedor MiFrmProveedor = new Formularios.FrmProveedor();


    }
}
