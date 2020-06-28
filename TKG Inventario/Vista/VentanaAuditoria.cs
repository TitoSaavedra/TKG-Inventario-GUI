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
using TKG_Inventario.Modelo.DAL;
using TKG_Inventario.Modelo.DTO;
using TKG_Inventario.Utils;

namespace TKG_Inventario.Vista
{
    public partial class VentanaAuditoria : Form
    {
        GestorAuditoria gestorAuditoria = new GestorAuditoria();
        GestorUsuario gestorUsuario = new GestorUsuario();

        public VentanaAuditoria()
        {
            InitializeComponent();
        }

        private void btnIngresarAudit_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (txtUsuarioSeleccionado.Text!="")
                {
                    Auditoria auditoria = new Auditoria();
                    auditoria.UsuarioIdUsuario = int.Parse(txtIdUsuario.Text);
                    auditoria.Fecha = dateTimeFecha.Value;
                    auditoria.Hora = dateTimeHora.Value.ToString("hh:mm:ss");
                    auditoria.Accion = combTabla.Text + " " + combConsulta.Text;
                    gestorAuditoria.IngresarAuditoria(auditoria);
                    MessageBox.Show("Auditoria Registrada");
                }
                else
                {
                    MessageBox.Show("Usuario seleccionado invalido");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private Boolean ValidarCampos()
        {
            Boolean sw = true;
            if (txtUsuarioSeleccionado.Text == "")
            {
                sw = false;
            }
            if (combTabla.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            if (combConsulta.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            if (dateTimeFecha.Text == "")
            {
                sw = false;
            }
            if (dateTimeHora.Text == "")
            {
                sw = false;
            }
            return sw;
        }

        private void CargarTablaUsuario()
        {
            dtaGridUsuario.DataSource = null;
            gestorUsuario.Mostrar();
            dtaGridUsuario.DataSource = gestorUsuario.dt;
            dtaGridUsuario.Columns[0].Width = 40;
            dtaGridUsuario.Columns[1].Width = 100;
            dtaGridUsuario.Columns[2].Width = 200;
            dtaGridUsuario.Columns[3].Width = 120;
            dtaGridUsuario.Columns[4].Width = 150;
            dtaGridUsuario.Columns[5].Width = 80;
            dtaGridUsuario.Columns[6].Width = 80;
            dtaGridUsuario.Columns[0].HeaderText = "ID";
            dtaGridUsuario.Columns[1].HeaderText = "Nombre";
            dtaGridUsuario.Columns[2].HeaderText = "Correo";
            dtaGridUsuario.Columns[3].HeaderText = "Rut";
            dtaGridUsuario.Columns[4].HeaderText = "Usuario";
            dtaGridUsuario.Columns[5].HeaderText = "Estado";
            dtaGridUsuario.Columns[6].HeaderText = "Tipo";
        }

        private void CargarTablaAuditoria()
        {
            dtaGridAuditoria.DataSource = null;
            gestorAuditoria.MostrarAuditoria();
            dtaGridAuditoria.DataSource = gestorAuditoria.dt;
            dtaGridAuditoria.Columns[0].Width = 40;
            dtaGridAuditoria.Columns[1].Width = 100;
            dtaGridAuditoria.Columns[2].Width = 100;
            dtaGridAuditoria.Columns[3].Width = 120;
            dtaGridAuditoria.Columns[4].Width = 150;
            dtaGridAuditoria.Columns[5].Width = 150;
            dtaGridAuditoria.Columns[0].HeaderText = "ID";
            dtaGridAuditoria.Columns[1].HeaderText = "Fecha";
            dtaGridAuditoria.Columns[2].HeaderText = "Hora";
            dtaGridAuditoria.Columns[3].HeaderText = "Accion";
            dtaGridAuditoria.Columns[4].HeaderText = "Nombre Usuario";
            dtaGridAuditoria.Columns[5].HeaderText = "Rut Usuario";
            if (dtaGridAuditoria.Rows.Count>0)
            {
                btnExportarAudit.Enabled = true;
            }
            else
            {
                btnExportarAudit.Enabled = false;
            }
        }

        private void VentanaAuditoria_Load(object sender, EventArgs e)
        {
            CargarTablaUsuario();
            CargarTablaAuditoria();
            Limpiar();
        }

        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            dtaGridUsuario.DataSource = null;
            gestorUsuario.Filtrar(txtBuscarUsuario.Text);
            dtaGridUsuario.DataSource = gestorUsuario.dt;
            dtaGridUsuario.Columns[0].Width = 40;
            dtaGridUsuario.Columns[1].Width = 100;
            dtaGridUsuario.Columns[2].Width = 200;
            dtaGridUsuario.Columns[3].Width = 120;
            dtaGridUsuario.Columns[4].Width = 150;
            dtaGridUsuario.Columns[5].Width = 80;
            dtaGridUsuario.Columns[6].Width = 80;
            dtaGridUsuario.Columns[0].HeaderText = "ID";
            dtaGridUsuario.Columns[1].HeaderText = "Nombre";
            dtaGridUsuario.Columns[2].HeaderText = "Correo";
            dtaGridUsuario.Columns[3].HeaderText = "Rut";
            dtaGridUsuario.Columns[4].HeaderText = "Usuario";
            dtaGridUsuario.Columns[5].HeaderText = "Estado";
            dtaGridUsuario.Columns[6].HeaderText = "Tipo";
        }

        private void dtaGridUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtUsuarioSeleccionado.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtIdUsuario.Text = (dtaGridUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        private void btnLimpiarFormAudit_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void Limpiar()
        {
            combConsulta.SelectedItem = 0;
            combTabla.SelectedItem = 0;
            txtBuscarUsuario.Text = "";
            txtIdUsuario.Text = "";
            txtUsuarioSeleccionado.Text = "";
        }

        private void btnExportarAudit_Click(object sender, EventArgs e)
        {
                exportaraexcel(dtaGridAuditoria);
        }

        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new
           Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            dtaGridAuditoria.DataSource = null;
            gestorAuditoria.FiltrarFechaAudit(dateTimeFiltro.Value);
            dtaGridAuditoria.DataSource = gestorAuditoria.dt;
            dtaGridAuditoria.Columns[0].Width = 40;
            dtaGridAuditoria.Columns[1].Width = 100;
            dtaGridAuditoria.Columns[2].Width = 100;
            dtaGridAuditoria.Columns[3].Width = 120;
            dtaGridAuditoria.Columns[4].Width = 150;
            dtaGridAuditoria.Columns[5].Width = 150;
            dtaGridAuditoria.Columns[0].HeaderText = "ID";
            dtaGridAuditoria.Columns[1].HeaderText = "Fecha";
            dtaGridAuditoria.Columns[2].HeaderText = "Hora";
            dtaGridAuditoria.Columns[3].HeaderText = "Accion";
            dtaGridAuditoria.Columns[4].HeaderText = "Nombre Usuario";
            dtaGridAuditoria.Columns[5].HeaderText = "Rut Usuario";
        }
    }
}
