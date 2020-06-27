using Inventario;
using System;
using System.Windows.Forms;
using TKG_Inventario.DAL;
using TKG_Inventario.DTO;

namespace TKG_Inventario.Vista
{
    public partial class VentanaUsuario : Form
    {
        Utilidades utilidades = new Utilidades();
        GestorUsuario gestorUsuario = new GestorUsuario();

        public VentanaUsuario()
        {
            InitializeComponent();
        }

        //Metodos btnClicks

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (txtClave.Text.Equals(txtClaveConf.Text))
                {
                    GestorUsuario gestorUsuario = new GestorUsuario();
                    int tipo = 0;
                    switch (combTipoUsu.Text)
                    {
                        case "Administrador":
                            tipo = 2;
                            break;
                        case "Bodequero":
                            tipo = 3;
                            break;
                        case "Usuario":
                            tipo = 4;
                            break;
                    }
                    Usuario usuario = new Usuario(0, txtRut.Text, txtNombre.Text, txtCorreo.Text, txtNomUsu.Text, txtClave.Text, combEstado.Text, tipo);
                    gestorUsuario.Ingresar(usuario);
                    MessageBox.Show("Registro exitoso");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Usuario");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (op == DialogResult.Yes)
            {
                GestorUsuario gestorUsuario = new GestorUsuario();
                Usuario usuario = new Usuario(int.Parse(txtIdUsuario.Text));
                gestorUsuario.Eliminar(usuario);
                Limpiar();
            }
            else
            {
                Limpiar();
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int tipo = 0;
                switch (combTipoUsu.Text)
                {
                    case "Administrador":
                        tipo = 2;
                        break;
                    case "Bodequero":
                        tipo = 3;
                        break;
                    case "Usuario":
                        tipo = 4;
                        break;
                }
                int estado = 0;
                switch (combEstado.Text)
                {
                    case "Activo":
                        estado = 1;
                        break;
                    case "Inactivo":
                        estado = 2;
                        break;
                }
                Usuario usu = new Usuario(int.Parse(txtIdUsuario.Text), txtRut.Text, txtNombre.Text, txtCorreo.Text, txtNomUsu.Text, txtClave.Text, estado + "", tipo);
                gestorUsuario.Modificar(usu);
                MessageBox.Show("Usuario modificado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se modificar el usuario");
            }
        }

        private void btnLimpiarFormUsuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void dtaGridUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView ver = (DataGridView)sender;
                string estado = "", tipo = "";
                switch (dtaGridUsuario.Rows[e.RowIndex].Cells[6].Value)
                {
                    case 2:
                        tipo = "Administrador";
                        break;
                    case 3:
                        tipo = "Bodequero";
                        break;
                    case 4:
                        tipo = "Usuario";
                        break;
                }
                switch (dtaGridUsuario.Rows[e.RowIndex].Cells[5].Value)
                {
                    case 1:
                        estado = "Activo";
                        break;
                    case 2:
                        estado = "Inactivo";
                        break;
                }
                txtIdUsuario.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNombre.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtRut.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtCorreo.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtNomUsu.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[4].Value.ToString());
                combTipoUsu.SelectedItem = tipo;
                combEstado.SelectedItem = estado;
                btnModificarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        /*
         * Metodos txtKeys
         */
        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(3, txtRut.Text.Length, 10, e);
        }

        private void txtNomUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(3, txtNomUsu.Text.Length, 30, e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(3, txtCorreo.Text.Length, 30, e);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(3, txtClave.Text.Length, 30, e);
        }

        private void txtClaveConf_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(3, txtClaveConf.Text.Length, 30, e);
        }

        private void txtBuscarNomUsu_KeyUp(object sender, KeyEventArgs e)
        {
            dtaGridUsuario.DataSource = null;
            gestorUsuario.Filtrar(txtBuscarNomUsu.Text);
            dtaGridUsuario.DataSource = gestorUsuario.dt;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.LetterNumber(1, txtNombre.Text.Length, 30, e);
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {

            if (!utilidades.validarRut(txtRut.Text))
            {
                MessageBox.Show("Rut invalido, vuelva a ingresar");
                txtRut.Text = "";

            }
        }


        /*
         * Otros
         */

        private void VentanaUsuario_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        public Boolean ValidarCampos()
        {
            Boolean sw = true;
            if (txtNombre.Text == "")
            {
                sw = false;
            }
            if (txtRut.Text == "")
            {
                sw = false;
            }
            if (txtCorreo.Text == "")
            {
                sw = false;
            }
            if (txtClave.Text == "")
            {
                sw = false;
            }
            if(txtNomUsu.Text == "")
            {
                sw = false;
            }
            if (combEstado.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            if (combTipoUsu.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            return sw;
        }

        public void CargarTabla()
        {
            dtaGridUsuario.DataSource = null;
            gestorUsuario.Mostrar();
            dtaGridUsuario.DataSource = gestorUsuario.dt;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtRut.Text = "";
            txtCorreo.Text = "";
            txtNomUsu.Text = "";
            txtClave.Text = "";
            txtClaveConf.Text = "";
            btnEliminarUsuario.Enabled = false;
            btnModificarUsuario.Enabled = false;
            txtIdUsuario.Visible = false;
            combEstado.SelectedIndex = 0;
            combTipoUsu.SelectedIndex = 0;
            txtNombre.Focus();
            CargarTabla();
        }
        
    }
}
