namespace TKG_Inventario.Vista
{
    partial class VentanaAuditoria
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
            FontAwesome.Sharp.IconButton btnIngresarAudit;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombreVentana = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.labelUusario = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarFormAudit = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtaGridAuditoria = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExportarAudit = new FontAwesome.Sharp.IconButton();
            this.dateTimeHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.combTabla = new System.Windows.Forms.ComboBox();
            this.combConsulta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtaGridUsuario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.dateTimeFiltro = new System.Windows.Forms.DateTimePicker();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            btnIngresarAudit = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridAuditoria)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreVentana
            // 
            this.labelNombreVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNombreVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreVentana.Location = new System.Drawing.Point(0, 0);
            this.labelNombreVentana.Name = "labelNombreVentana";
            this.labelNombreVentana.Size = new System.Drawing.Size(950, 27);
            this.labelNombreVentana.TabIndex = 40;
            this.labelNombreVentana.Text = "Auditoria";
            this.labelNombreVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combConsulta);
            this.groupBox1.Controls.Add(this.combTabla);
            this.groupBox1.Controls.Add(this.dateTimeFecha);
            this.groupBox1.Controls.Add(this.dateTimeHora);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.labelUusario);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 282);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auditoria  datos";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(193, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hora:";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(347, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 20);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Acción:";
            // 
            // labelUusario
            // 
            this.labelUusario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUusario.AutoSize = true;
            this.labelUusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUusario.ForeColor = System.Drawing.Color.Black;
            this.labelUusario.Location = new System.Drawing.Point(10, 24);
            this.labelUusario.Name = "labelUusario";
            this.labelUusario.Size = new System.Drawing.Size(58, 20);
            this.labelUusario.TabIndex = 20;
            this.labelUusario.Text = "Fecha:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.97535F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8574491F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.51125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.87031F));
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiarFormAudit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExportarAudit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(btnIngresarAudit, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 318);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 48);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // btnLimpiarFormAudit
            // 
            this.btnLimpiarFormAudit.AutoSize = true;
            this.btnLimpiarFormAudit.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarFormAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiarFormAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFormAudit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLimpiarFormAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFormAudit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarFormAudit.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnLimpiarFormAudit.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarFormAudit.IconSize = 32;
            this.btnLimpiarFormAudit.Location = new System.Drawing.Point(598, 3);
            this.btnLimpiarFormAudit.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnLimpiarFormAudit.Name = "btnLimpiarFormAudit";
            this.btnLimpiarFormAudit.Rotation = 0D;
            this.btnLimpiarFormAudit.Size = new System.Drawing.Size(325, 42);
            this.btnLimpiarFormAudit.TabIndex = 28;
            this.btnLimpiarFormAudit.Text = "Limpiar";
            this.btnLimpiarFormAudit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFormAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarFormAudit.UseVisualStyleBackColor = false;
            this.btnLimpiarFormAudit.Click += new System.EventHandler(this.btnLimpiarFormAudit_Click);
            // 
            // btnIngresarAudit
            // 
            btnIngresarAudit.AutoSize = true;
            btnIngresarAudit.BackColor = System.Drawing.Color.Lime;
            btnIngresarAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            btnIngresarAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresarAudit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnIngresarAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnIngresarAudit.ForeColor = System.Drawing.SystemColors.ControlText;
            btnIngresarAudit.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnIngresarAudit.IconColor = System.Drawing.Color.Black;
            btnIngresarAudit.IconSize = 32;
            btnIngresarAudit.Location = new System.Drawing.Point(10, 3);
            btnIngresarAudit.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            btnIngresarAudit.Name = "btnIngresarAudit";
            btnIngresarAudit.Rotation = 0D;
            btnIngresarAudit.Size = new System.Drawing.Size(268, 42);
            btnIngresarAudit.TabIndex = 25;
            btnIngresarAudit.Text = "Ingresar";
            btnIngresarAudit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnIngresarAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnIngresarAudit.UseVisualStyleBackColor = false;
            btnIngresarAudit.Click += new System.EventHandler(this.btnIngresarAudit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFiltrarFecha);
            this.groupBox2.Controls.Add(this.dateTimeFiltro);
            this.groupBox2.Controls.Add(this.dtaGridAuditoria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 236);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historia auditoria:";
            // 
            // dtaGridAuditoria
            // 
            this.dtaGridAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridAuditoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGridAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dtaGridAuditoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtaGridAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtaGridAuditoria.ColumnHeadersHeight = 30;
            this.dtaGridAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridAuditoria.EnableHeadersVisualStyles = false;
            this.dtaGridAuditoria.GridColor = System.Drawing.Color.Black;
            this.dtaGridAuditoria.Location = new System.Drawing.Point(10, 62);
            this.dtaGridAuditoria.Name = "dtaGridAuditoria";
            this.dtaGridAuditoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridAuditoria.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtaGridAuditoria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtaGridAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridAuditoria.Size = new System.Drawing.Size(915, 164);
            this.dtaGridAuditoria.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Filro desde fecha:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportarAudit
            // 
            this.btnExportarAudit.AutoSize = true;
            this.btnExportarAudit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExportarAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportarAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarAudit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExportarAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarAudit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportarAudit.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarAudit.IconColor = System.Drawing.Color.Black;
            this.btnExportarAudit.IconSize = 32;
            this.btnExportarAudit.Location = new System.Drawing.Point(305, 3);
            this.btnExportarAudit.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnExportarAudit.Name = "btnExportarAudit";
            this.btnExportarAudit.Rotation = 0D;
            this.btnExportarAudit.Size = new System.Drawing.Size(273, 42);
            this.btnExportarAudit.TabIndex = 27;
            this.btnExportarAudit.Text = "Exportar Execel";
            this.btnExportarAudit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarAudit.UseVisualStyleBackColor = false;
            this.btnExportarAudit.Click += new System.EventHandler(this.btnExportarAudit_Click);
            // 
            // dateTimeHora
            // 
            this.dateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHora.Location = new System.Drawing.Point(197, 48);
            this.dateTimeHora.Name = "dateTimeHora";
            this.dateTimeHora.ShowUpDown = true;
            this.dateTimeHora.Size = new System.Drawing.Size(127, 29);
            this.dateTimeHora.TabIndex = 39;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(14, 47);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(168, 29);
            this.dateTimeFecha.TabIndex = 40;
            // 
            // combTabla
            // 
            this.combTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.combTabla.FormattingEnabled = true;
            this.combTabla.Items.AddRange(new object[] {
            "Seleccionar",
            "Usuario",
            "Compra",
            "Producto_has_compra",
            "Producto",
            "FamiliaProducto"});
            this.combTabla.Location = new System.Drawing.Point(405, 49);
            this.combTabla.Name = "combTabla";
            this.combTabla.Size = new System.Drawing.Size(233, 32);
            this.combTabla.TabIndex = 41;
            // 
            // combConsulta
            // 
            this.combConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.combConsulta.FormattingEnabled = true;
            this.combConsulta.Items.AddRange(new object[] {
            "Insert",
            "Update",
            "Delete"});
            this.combConsulta.Location = new System.Drawing.Point(726, 49);
            this.combConsulta.Name = "combConsulta";
            this.combConsulta.Size = new System.Drawing.Size(121, 32);
            this.combConsulta.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tabla:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(644, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Consulta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtIdUsuario);
            this.groupBox3.Controls.Add(this.txtUsuarioSeleccionado);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtaGridUsuario);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBuscarUsuario);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(911, 189);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Usuario";
            // 
            // dtaGridUsuario
            // 
            this.dtaGridUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dtaGridUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtaGridUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridUsuario.ColumnHeadersHeight = 30;
            this.dtaGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridUsuario.EnableHeadersVisualStyles = false;
            this.dtaGridUsuario.GridColor = System.Drawing.Color.Black;
            this.dtaGridUsuario.Location = new System.Drawing.Point(10, 62);
            this.dtaGridUsuario.Name = "dtaGridUsuario";
            this.dtaGridUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGridUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtaGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaGridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridUsuario.Size = new System.Drawing.Size(891, 121);
            this.dtaGridUsuario.TabIndex = 1;
            this.dtaGridUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtaGridUsuario_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Buscar por usuario:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(210, 29);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(199, 26);
            this.txtBuscarUsuario.TabIndex = 36;
            this.txtBuscarUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(546, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Selección:";
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtUsuarioSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioSeleccionado.Enabled = false;
            this.txtUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSeleccionado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(634, 28);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(199, 26);
            this.txtUsuarioSeleccionado.TabIndex = 48;
            // 
            // dateTimeFiltro
            // 
            this.dateTimeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFiltro.Location = new System.Drawing.Point(195, 26);
            this.dateTimeFiltro.Name = "dateTimeFiltro";
            this.dateTimeFiltro.Size = new System.Drawing.Size(168, 29);
            this.dateTimeFiltro.TabIndex = 47;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdUsuario.Location = new System.Drawing.Point(852, 28);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(49, 26);
            this.txtIdUsuario.TabIndex = 49;
            this.txtIdUsuario.Visible = false;
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(369, 22);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(102, 32);
            this.btnFiltrarFecha.TabIndex = 48;
            this.btnFiltrarFecha.Text = "Filtrar";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // VentanaAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNombreVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaAuditoria";
            this.Text = "VentanaAuditoria";
            this.Load += new System.EventHandler(this.VentanaAuditoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridAuditoria)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombreVentana;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label labelUusario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnLimpiarFormAudit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtaGridAuditoria;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeHora;
        private FontAwesome.Sharp.IconButton btnExportarAudit;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtaGridUsuario;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtBuscarUsuario;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combConsulta;
        private System.Windows.Forms.ComboBox combTabla;
        private System.Windows.Forms.DateTimePicker dateTimeFiltro;
        internal System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnFiltrarFecha;
    }
}