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
        private struct PowerBI
        {
            public static Color color0 = Color.FromArgb(0, 122, 204);
            public static Color color1 = Color.FromArgb(1, 184, 170);
            public static Color color2 = Color.FromArgb(40, 56, 60);
            public static Color color3 = Color.FromArgb(253, 98, 94);
            public static Color color4 = Color.FromArgb(242, 200, 15);
            public static Color color5 = Color.FromArgb(95,107, 109);
            public static Color color6 = Color.FromArgb(138,212, 235);
        }

        public MainWindow()
        {
            InitializeComponent();
        }



        private void MainWindow_Load(object sender, EventArgs e)
        {

        }



        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconoMenu_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width == 250)
            {
                this.panelMenu.Width = 55;
                this.quitarTextoBotones();
            }
            else
            {
                this.resetearTextoBotones();
                this.panelMenu.Width = 250;
            }
        }
        private void quitarTextoBotones()
        {
            this.botonSistema.Text = "";
            this.botonCrudUsuarios.Text = "";
            this.botonCrudFamiliaProductos.Text = "";
            this.botonCrudProductos.Text = "";
            this.botonCrudCompraProductos.Text = "";

        }
        private void resetearTextoBotones()
        {
            this.botonSistema.Text = "Sistema";
            this.botonCrudUsuarios.Text = "Usuarios";
            this.botonCrudFamiliaProductos.Text = "Familia Productos";
            this.botonCrudProductos.Text = "Productos";
            this.botonCrudCompraProductos.Text = "Compra Productos";

        }
        private void AbrirFormEnPanel(object formularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void botonCrudUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
