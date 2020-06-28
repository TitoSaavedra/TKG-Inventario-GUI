using FontAwesome.Sharp;
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
        VentanaAuditoria ventanaAuditoria = new VentanaAuditoria();

        public MainWindow()
        {
            InitializeComponent();
            this.cambiaColorBoton(this.botonSistema);
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
            this.cambiaColorBoton(this.botonSistema);
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
            this.botonAuditoria.Text = "";
            this.botonCerrarSesion.Text = "";

        }
        private void ResetearTextoBotones()
        {
            this.botonSistema.Text = "Sistema";
            this.botonCrudUsuarios.Text = "Usuarios";
            this.botonCrudFamiliaProductos.Text = "Familia Productos";
            this.botonCrudProductos.Text = "Productos";
            this.botonCrudCompraProductos.Text = "Compra Productos";
            this.botonAuditoria.Text = "Auditoria";
            this.botonCerrarSesion.Text = "Cerrar Sesión";
        }
        private void botonSistema_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventaSistema)))
            {
                this.cambiaColorBoton(this.botonSistema);
                this.AbrirFormEnPanel(this.ventaSistema);
            }
        }

        private void botonCrudUsuarios_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventanaUsuario)))
            {
                this.cambiaColorBoton(this.botonCrudUsuarios);
                this.AbrirFormEnPanel(this.ventanaUsuario);
            }
        }

        private void botonCrudFamiliaProductos_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventanaFamiliaProducto)))
            {
                this.cambiaColorBoton(this.botonCrudFamiliaProductos);
                this.AbrirFormEnPanel(this.ventanaFamiliaProducto);
            }
        }

        private void botonCrudProductos_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventanaProducto)))
            {
                this.cambiaColorBoton(this.botonCrudProductos);
                this.AbrirFormEnPanel(this.ventanaProducto);
            }
        }

        private void botonCrudCompraProductos_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventanaCompraProducto)))
            {
                this.cambiaColorBoton(this.botonCrudCompraProductos);
                this.AbrirFormEnPanel(this.ventanaCompraProducto);
            }
        }

        private void botonAuditoria_Click(object sender, EventArgs e)
        {
            if (!(this.panelContenedor.Contains(this.ventanaAuditoria)))
            {
                this.cambiaColorBoton(this.botonAuditoria);
                this.AbrirFormEnPanel(this.ventanaAuditoria);
            }
        }

        private void cambiaColorBoton(IconButton btn)
        {
            resetColorBotones();
            btn.ForeColor = Color.FromArgb(216, 92, 43);
            btn.IconColor = Color.FromArgb(216, 92, 43);
        }
        private void resetColorBotones()
        {
            //boton sistema
            this.botonSistema.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonSistema.IconColor = Color.FromArgb(255, 255, 255);
            //boton usuarios
            this.botonCrudUsuarios.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonCrudUsuarios.IconColor = Color.FromArgb(255, 255, 255);
            //boton familia productos
            this.botonCrudFamiliaProductos.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonCrudFamiliaProductos.IconColor = Color.FromArgb(255, 255, 255);
            //boton productos
            this.botonCrudProductos.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonCrudProductos.IconColor = Color.FromArgb(255, 255, 255);
            //boton compra productos
            this.botonCrudCompraProductos.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonCrudCompraProductos.IconColor = Color.FromArgb(255, 255, 255);
            //boton auditoria
            this.botonAuditoria.ForeColor = Color.FromArgb(255, 255, 255);
            this.botonAuditoria.IconColor = Color.FromArgb(255, 255, 255);
        }

   
    }
}
