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
using System.Windows.Threading;

namespace TKG_Inventario.Vista
{
    public partial class ContenedorAplicacion : Form
    {
        Login login = new Login();
        MainWindow mainWindows = new MainWindow();
        DispatcherTimer timer = new DispatcherTimer();

        public ContenedorAplicacion()
        {
            InitializeComponent();
            this.login.botonIniciarSesionPresionado += LoginbotonIniciarSesionPresionado;
            this.mainWindows.botonCerrarSesionPresionado += MainWindows_botonCerrarSesionPresionado;
            this.AbrirFormEnPanel(login);
        }

        private void LoginbotonIniciarSesionPresionado(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(mainWindows);
        }
        private void MainWindows_botonCerrarSesionPresionado(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(login);
       
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormEnPanel(Form formularioHijo)
        {
            this.panelContenedorFormularios.Controls.Clear();
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelContenedorFormularios.Controls.Add(formularioHijo);
            this.panelContenedorFormularios.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconoMaximizarApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconoCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMiniminizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
