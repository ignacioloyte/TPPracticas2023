using SistemaVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using CapaPresentacion.Idioma;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            /* Llamamos el metodo listar. Utilizamos expresiones landas para poder retornar 
             * la busqueda de un usuario en nuestra lista
            */
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.NUsuario == txtUsuario.Text &&
                u.Clave == txtClave.Text).FirstOrDefault();

            /* Aca realizamos el check para validar si existe el usuario, si existe en la bd sigue,
             * de lo contrario lanza un mensaje
             * */
            if (ousuario != null)
            {

                // Le pasamos el usuario que usamos en la consulta de la linea 35
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += form_closing;
            }

            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Evento para que al cerrarse el form de inicio se abra el login
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            //Realizamos el blanqueo de los campos para que al regresar
            //no puedan ser copiados.

            txtUsuario.Text = "";
            txtClave.Text = "";
            this.Show();
        }

        public void CargarIdioma()
        {
            lblUsuario.Text = Textos.lblUsuario;
            lblContraseña.Text = Textos.lblContraseña;
            lbltitulo.Text = Textos.lbltitulo;
            lbltitulo2.Text = Textos.lbltitulo2;
            btnIngresar.Text = Textos.btnIngresar;
            btnCancelar.Text = Textos.btnCancelar;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
