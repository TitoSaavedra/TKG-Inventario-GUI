using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKG_Inventario.Vista
{
    public partial class MainWindow : Form
    {
        VentanaSistema ventaSistema = new VentanaSistema();
        VentanaUsuario ventanaUsuario = new VentanaUsuario();
        VentanaFamiliaProducto ventanaFamiliaProducto = new VentanaFamiliaProducto();
        VentanaProducto ventanaProducto = new VentanaProducto();
        VentanaCompraProducto ventanaCompraProducto = new VentanaCompraProducto();
        private struct PowerBI
        {
            public static Color color0 = Color.FromArgb(0, 122, 204);
            public static Color color1 = Color.FromArgb(1, 184, 170);
            public static Color color2 = Color.FromArgb(40, 56, 60);
            public static Color color3 = Color.FromArgb(253, 98, 94);
            public static Color color4 = Color.FromArgb(242, 200, 15);
            public static Color color5 = Color.FromArgb(95, 107, 109);
            public static Color color6 = Color.FromArgb(138, 212, 235);
        }

        public MainWindow()
        {
            InitializeComponent();
            this.AbrirFormEnPanel(this.ventaSistema);
        }

        public event EventHandler botonCerrarSesionPresionado;
        protected virtual void botonCerrarSesion_Clicked(EventArgs e)
        {
            var handler = botonCerrarSesionPresionado;
            if (handler != null)
                handler(this, e);
        }
        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventaSistema);
            botonCerrarSesion_Clicked(e);
        }

        private void AbrirFormEnPanel(Form formularioHijo)
        {
            this.panelContenedor.Controls.Clear();
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void iconoMenu_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width == 250)
            {
                this.panelMenu.Width = 55;
                this.QuitarTextoBotones();
            }
            else
            {
                this.ResetearTextoBotones();
                this.panelMenu.Width = 250;
            }
        }
        private void QuitarTextoBotones()
        {
            this.botonSistema.Text = "";
            this.botonCrudUsuarios.Text = "";
            this.botonCrudFamiliaProductos.Text = "";
            this.botonCrudProductos.Text = "";
            this.botonCrudCompraProductos.Text = "";
            this.botonCerrarSesion.Text = "";

        }
        private void ResetearTextoBotones()
        {
            this.botonSistema.Text = "Sistema";
            this.botonCrudUsuarios.Text = "Usuarios";
            this.botonCrudFamiliaProductos.Text = "Familia Productos";
            this.botonCrudProductos.Text = "Productos";
            this.botonCrudCompraProductos.Text = "Compra Productos";
            this.botonCerrarSesion.Text = "Cerrar Sesión";
        }
        private void botonSistema_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventaSistema);
        }

        private void botonCrudUsuarios_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventanaUsuario);
        }

        private void botonCrudFamiliaProductos_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventanaFamiliaProducto);
        }

        private void botonCrudProductos_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventanaProducto);
        }

        private void botonCrudCompraProductos_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(this.ventanaCompraProducto);
        }

    }
}
