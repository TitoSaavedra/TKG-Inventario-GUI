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

namespace TKG_Inventario.Vista
{
    public partial class VentanaProducto : Form
    {
        public VentanaProducto()
        {
            InitializeComponent();
        }

        public void cargar_combo()
        {
            GestorProducto producto = new GestorProducto();
            //cbFamilia.Items.Clear();

            cbFamilia.DataSource = producto.seleccionar();
            cbFamilia.DisplayMember = "nombreFamiliaProducto";
            cbFamilia.ValueMember = "idFamiliaProducto";

            //cbFamilia.Items.Insert(0, "Seleccione");
            //cbFamilia.SelectedIndex = 0;
        }

        public void cargar_grilla() 
        { 
            GestorProducto producto = new GestorProducto();
            dgBuscar.DataSource = null; 
            producto.Mostrar();
            dgBuscar.DataSource = producto.dt; 
            totalregistros.Text = "Total de Registros (" + dgBuscar.RowCount.ToString() + ")"; 
            
            if (dgBuscar.RowCount > 0) 
            { 
                btnExportar.Enabled = true; 
            } 
            else 
            { 
                btnExportar.Enabled = false; 
            } 
        }

        public void limpiar()
        {
            tbNombre.Focus();
            tbNombre.Text = "";
            tbPrecio.Text = "";
            tbStock.Text = "";
            cbEstado.SelectedIndex = 0;
            cbFamilia.SelectedIndex = 0;
            tbId.Text = "";
            tbId.Visible = false;
            btnIngresar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnExportar.Enabled = false;
            tbBuscar.Text = "";
            cargar_grilla();
        }

        public Boolean validar() 
        { 
            Boolean sw = true; 
            if (tbNombre.Text == "") 
            { 
                sw = false; 
            } 
            if (tbPrecio.Text == "") 
            { 
                sw = false; 
            } 
            if (tbStock.Text == "") 
            { 
                sw = false; 
            } 
            if (cbEstado.SelectedIndex.Equals(0)) 
            { 
                sw = false; 
            }
            if (cbFamilia.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            return sw; 
        }

        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true); int IndiceColumna = 0;
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

        /*------------------------------ BGN BUTTON ------------------------------*/
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar()) 
            { 
                GestorProducto producto = new GestorProducto(); 

                Producto p = new Producto(0, tbNombre.Text, int.Parse(tbPrecio.Text), int.Parse(tbStock.Text), cbEstado.Text, Convert.ToInt32(cbFamilia.SelectedValue));
                //MessageBox.Show(cbFamilia.Text);
                producto.Ingresar(p); 
                limpiar(); 
            } 
            else 
            { 
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Producto"); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validar()) 
            {
                GestorProducto producto = new GestorProducto(); 
                Producto p = new Producto(int.Parse(tbId.Text), tbNombre.Text, int.Parse(tbPrecio.Text), int.Parse(tbStock.Text), cbEstado.Text, Convert.ToInt32(cbFamilia.SelectedValue)); 
                producto.Modificar(p); 
                limpiar(); 
            } 
            else 
            { 
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Producto"); 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (op == DialogResult.Yes)
            {
                GestorProducto producto = new GestorProducto();
                Producto p = new Producto(int.Parse(tbId.Text), tbNombre.Text, int.Parse(tbPrecio.Text), int.Parse(tbStock.Text), cbEstado.Text, Convert.ToInt32(cbFamilia.SelectedValue));
                producto.Eliminar(p);
                limpiar();
            }
            else
            {
                limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgBuscar);
        }
        /*------------------------------ END BUTTON ------------------------------*/

        private void dgBuscar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView ver = (DataGridView)sender; 
                tbId.Text = (dgBuscar.Rows[e.RowIndex].Cells[0].Value.ToString()); 
                tbNombre.Text = (dgBuscar.Rows[e.RowIndex].Cells[1].Value.ToString()); 
                tbPrecio.Text = (dgBuscar.Rows[e.RowIndex].Cells[2].Value.ToString()); 
                tbStock.Text = (dgBuscar.Rows[e.RowIndex].Cells[3].Value.ToString()); 
                cbEstado.SelectedItem = (dgBuscar.Rows[e.RowIndex].Cells[4].Value.ToString());
                cbFamilia.SelectedItem = (dgBuscar.Rows[e.RowIndex].Cells[5].Value.ToString());

                btnIngresar.Enabled = false; 
                btnModificar.Enabled = true; 
                btnEliminar.Enabled = true;
            }
            catch (Exception exc) { exc.ToString(); 
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) 
            { 
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                e.Handled = true; 
                return; 
            }
        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            GestorProducto producto = new GestorProducto(); 
            dgBuscar.DataSource = null; 
            producto.Filtrar(tbBuscar.Text); 
            dgBuscar.DataSource = producto.dt; 
            totalregistros.Text = "Total de Registros (" + dgBuscar.RowCount.ToString() + ")";
        }

        private void VentanaProducto_Load(object sender, EventArgs e)
        {
            limpiar();
            cargar_combo();
        }
    }
}
