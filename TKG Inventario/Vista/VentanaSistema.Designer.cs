namespace TKG_Inventario.Vista
{
    partial class VentanaSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrincipalSistema = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelNombreVentana = new System.Windows.Forms.Label();
            this.labelBajoStock = new System.Windows.Forms.Label();
            this.dtaGridProductosBajoStock = new System.Windows.Forms.DataGridView();
            this.timerHoraFech = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipalSistema.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridProductosBajoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipalSistema
            // 
            this.panelPrincipalSistema.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrincipalSistema.Controls.Add(this.tableLayoutPanel1);
            this.panelPrincipalSistema.Controls.Add(this.labelNombreVentana);
            this.panelPrincipalSistema.Controls.Add(this.labelBajoStock);
            this.panelPrincipalSistema.Controls.Add(this.dtaGridProductosBajoStock);
            this.panelPrincipalSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipalSistema.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipalSistema.Name = "panelPrincipalSistema";
            this.panelPrincipalSistema.Size = new System.Drawing.Size(950, 620);
            this.panelPrincipalSistema.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelFecha, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHora, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(552, 457);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 151);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFecha.Location = new System.Drawing.Point(3, 75);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(380, 29);
            this.labelFecha.TabIndex = 17;
            this.labelFecha.Text = "fecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelHora.Location = new System.Drawing.Point(3, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(380, 75);
            this.labelHora.TabIndex = 16;
            this.labelHora.Text = "00:00:00";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreVentana
            // 
            this.labelNombreVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNombreVentana.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreVentana.Location = new System.Drawing.Point(0, 0);
            this.labelNombreVentana.Name = "labelNombreVentana";
            this.labelNombreVentana.Size = new System.Drawing.Size(950, 18);
            this.labelNombreVentana.TabIndex = 18;
            this.labelNombreVentana.Text = "Sistema de gestión y control de bodega e inventario";
            this.labelNombreVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBajoStock
            // 
            this.labelBajoStock.AutoSize = true;
            this.labelBajoStock.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBajoStock.Location = new System.Drawing.Point(12, 28);
            this.labelBajoStock.Name = "labelBajoStock";
            this.labelBajoStock.Size = new System.Drawing.Size(325, 29);
            this.labelBajoStock.TabIndex = 1;
            this.labelBajoStock.Text = "Productos con bajo Stock:";
            // 
            // dtaGridProductosBajoStock
            // 
            this.dtaGridProductosBajoStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridProductosBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridProductosBajoStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGridProductosBajoStock.BackgroundColor = System.Drawing.Color.White;
            this.dtaGridProductosBajoStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtaGridProductosBajoStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridProductosBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridProductosBajoStock.ColumnHeadersHeight = 30;
            this.dtaGridProductosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridProductosBajoStock.EnableHeadersVisualStyles = false;
            this.dtaGridProductosBajoStock.GridColor = System.Drawing.Color.Black;
            this.dtaGridProductosBajoStock.Location = new System.Drawing.Point(17, 60);
            this.dtaGridProductosBajoStock.Name = "dtaGridProductosBajoStock";
            this.dtaGridProductosBajoStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridProductosBajoStock.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtaGridProductosBajoStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaGridProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridProductosBajoStock.Size = new System.Drawing.Size(921, 273);
            this.dtaGridProductosBajoStock.TabIndex = 0;
            // 
            // timerHoraFech
            // 
            this.timerHoraFech.Enabled = true;
            this.timerHoraFech.Tick += new System.EventHandler(this.timerHoraFech_Tick);
            // 
            // VentanaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.panelPrincipalSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaSistema";
            this.Text = "Sistema";
            this.panelPrincipalSistema.ResumeLayout(false);
            this.panelPrincipalSistema.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridProductosBajoStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipalSistema;
        private System.Windows.Forms.Label labelBajoStock;
        private System.Windows.Forms.DataGridView dtaGridProductosBajoStock;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timerHoraFech;
        private System.Windows.Forms.Label labelNombreVentana;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}