using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using FontAwesome.Sharp;

using CapaEntidad;
using CapaNegocio;

namespace SistemaVentas
{
    public partial class Inicio : Form
    {
        //Seteamos una variable usuario a la cual le vamos a asignar el usuario, actua como una variable
        // global de todo lo que tengo en Formulario inicio
        private static Usuario usuarioActual;

        //Almacena el menu activo
        private static IconMenuItem MenuActivo = null;

        //Almacena el formulario activo actualmente en el panel
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }


        // Metodo de carga del formulario
        private void Inicio_Load(object sender, EventArgs e)
        { //Chequear que no me devuelve los permisos
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in Menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblUsuario.Text = usuarioActual.NUsuario;
        }

        // Este metodo recibe el menu que fue clickeado y muestra el formulario seleccionado
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            //S� hay un menu activo que se regrese a blanco
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            //El menu marcado se pondr� naranja
            menu.BackColor = Color.DarkOrange;
            MenuActivo = menu;

            // Para que se cierre el formulario que estaba activo anteriormente
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            //Lo que yo quiero que se muestre
            FormularioActivo = formulario;
            //Configuramos el formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; //Toma todo el espacio del contenedor
            formulario.BackColor = Color.DarkOrange;
            //Agregamos el formulario al contenedor
            Contenedor.Controls.Add(formulario);
            //Mostramos el formulario
            formulario.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());

        }

        private void subCategoria_Click(object sender, EventArgs e)

        {
            //Debo pasarle el nombre del menu que quiero que muestre el formulario
            AbrirFormulario(MenuConfiguracion, new frmCategoria());

        }



        //Venta, Submenu: Registrar venta, detalle de venta 
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmRegistrarVenta());
        }

        private void btnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVerDetalleVenta());
        }

        //Compra: submenu: Registrar compra, Ver Detalle compra
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmRegistrarCompra());
        }

        private void btnVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmVerDetalleCompra());
        }


        //Clientes: Submenu: Registrar clientes, modificar cliente, desactivar cliente, consultar cliente
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuClientes, new frmAgregarCliente());
        }


        private void btnDesactivarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuClientes, new frmDesactivarCliente());
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuClientes, new frmConsultarClientes());
        }

        //Menu proveedores
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProveedores, new frmAgregarProveedor());
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProveedores, new frmModificarProveedor());
        }

        private void btnDesactivarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProveedores, new frmDesactivarProveedor());
        }

        private void btnConsultarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProveedores, new frmConsultarProveedores());
        }

        private void MenuConfiguracion_Click(object sender, EventArgs e)
        {

        }
        // Menu reportes

        //Menu configuraci�n

        //Menu acerca de
        //private void btnAcercaDe_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(MenuAcercaDe, new frmAcercaDe());
        //}
    }
}