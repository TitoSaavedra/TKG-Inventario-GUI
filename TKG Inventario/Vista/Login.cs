using Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKG_Inventario.DAL;
using TKG_Inventario.DTO;
using TKG_Inventario.Utils;

namespace TKG_Inventario.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Text = "";
            txtPass.Text = "";
        }
        public event EventHandler botonIniciarSesionPresionado;
        protected virtual void botonIniciarSesion_Clicked(EventArgs e)
        {
            var handler = botonIniciarSesionPresionado;
            if (handler != null)
                handler(this, e);
        }
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                GestorUsuario gestorUsuario = new GestorUsuario();
                Utilidades utilidades = new Utilidades();
                Usuario usuario = new Usuario();
                usuario.NomUsuario = txtUser.Text;
                usuario.Contrasena = utilidades.GetMD5Hash(txtPass.Text);
                Usuario usuarioL = gestorUsuario.Login(usuario);
                if (usuarioL != null)
                {
                    LoginSesion.IdUsuario = usuarioL.IdUsuario;
                    botonIniciarSesion_Clicked(e);
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos: ");
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos: ");
            }
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
