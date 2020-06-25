using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKG_Inventario.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            botonIniciarSesion_Clicked(e);
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
