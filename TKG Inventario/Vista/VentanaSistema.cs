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
    public partial class VentanaSistema : Form
    {
        public VentanaSistema()
        {
            InitializeComponent();
            this.timerHoraFech.Enabled = true;
            this.dtaGridProductosBajoStock.Columns.Add("", "ID");
            this.dtaGridProductosBajoStock.Columns.Add("", "NOMBRE");
            this.dtaGridProductosBajoStock.Columns.Add("", "COSTO");
            this.dtaGridProductosBajoStock.Columns.Add("", "ESTOCK");
            this.dtaGridProductosBajoStock.Columns.Add("", "ESTADO");
            this.dtaGridProductosBajoStock.Columns.Add("", "FAMILIA");
            this.dtaGridProductosBajoStock.Rows.Add(new string[] { "1", "QQQQQQ QQQQQQ", "KKQWKK", "QWEJQW", "QWEOJQWE", "JADSJAJSD" });
        }

        private void timerHoraFech_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            this.labelFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
