namespace TKG_Inventario.Vista
{
    partial class VentanaUsuario
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
            FontAwesome.Sharp.IconButton btnRegistrarUsuario;
            this.txtRut = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelUusario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarFormUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnModificarUsuario = new FontAwesome.Sharp.IconButton();
            this.labelNombreVentana = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.combEstado = new System.Windows.Forms.ComboBox();
            this.combTipoUsu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClaveConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.txtBuscarNomUsu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtaGridUsuario = new System.Windows.Forms.DataGridView();
            btnRegistrarUsuario = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRut
            // 
            this.txtRut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRut.Location = new System.Drawing.Point(14, 98);
            this.txtRut.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtRut.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(258, 29);
            this.txtRut.TabIndex = 23;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            this.txtRut.Leave += new System.EventHandler(this.txtRut_Leave);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(10, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 20);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Rut:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Location = new System.Drawing.Point(14, 45);
            this.txtNombre.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtNombre.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 29);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.labelUusario.Size = new System.Drawing.Size(69, 20);
            this.labelUusario.TabIndex = 20;
            this.labelUusario.Text = "Nombre:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(btnRegistrarUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpiarFormUsuario, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminarUsuario, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarUsuario, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 48);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // btnLimpiarFormUsuario
            // 
            this.btnLimpiarFormUsuario.AutoSize = true;
            this.btnLimpiarFormUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarFormUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiarFormUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFormUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLimpiarFormUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFormUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarFormUsuario.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnLimpiarFormUsuario.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarFormUsuario.IconSize = 32;
            this.btnLimpiarFormUsuario.Location = new System.Drawing.Point(709, 3);
            this.btnLimpiarFormUsuario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnLimpiarFormUsuario.Name = "btnLimpiarFormUsuario";
            this.btnLimpiarFormUsuario.Rotation = 0D;
            this.btnLimpiarFormUsuario.Size = new System.Drawing.Size(215, 42);
            this.btnLimpiarFormUsuario.TabIndex = 28;
            this.btnLimpiarFormUsuario.Text = "Limpiar";
            this.btnLimpiarFormUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFormUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarFormUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarFormUsuario.Click += new System.EventHandler(this.btnLimpiarFormUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.AutoSize = true;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.IconSize = 32;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(476, 3);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Rotation = 0D;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(213, 42);
            this.btnEliminarUsuario.TabIndex = 27;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AutoSize = true;
            this.btnModificarUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.IconSize = 32;
            this.btnModificarUsuario.Location = new System.Drawing.Point(243, 3);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Rotation = 0D;
            this.btnModificarUsuario.Size = new System.Drawing.Size(213, 42);
            this.btnModificarUsuario.TabIndex = 26;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // labelNombreVentana
            // 
            this.labelNombreVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNombreVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreVentana.Location = new System.Drawing.Point(0, 0);
            this.labelNombreVentana.Name = "labelNombreVentana";
            this.labelNombreVentana.Size = new System.Drawing.Size(950, 27);
            this.labelNombreVentana.TabIndex = 28;
            this.labelNombreVentana.Text = "Gestión de usuarios";
            this.labelNombreVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.combEstado);
            this.groupBox1.Controls.Add(this.combTipoUsu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtClaveConf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomUsu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.labelUusario);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 187);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antecedentes del usuario:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(405, 0);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 29);
            this.txtIdUsuario.TabIndex = 38;
            this.txtIdUsuario.Visible = false;
            // 
            // combEstado
            // 
            this.combEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.combEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combEstado.ForeColor = System.Drawing.Color.White;
            this.combEstado.FormattingEnabled = true;
            this.combEstado.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.combEstado.Location = new System.Drawing.Point(640, 44);
            this.combEstado.Name = "combEstado";
            this.combEstado.Size = new System.Drawing.Size(259, 32);
            this.combEstado.TabIndex = 37;
            // 
            // combTipoUsu
            // 
            this.combTipoUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combTipoUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.combTipoUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combTipoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTipoUsu.ForeColor = System.Drawing.Color.White;
            this.combTipoUsu.FormattingEnabled = true;
            this.combTipoUsu.Items.AddRange(new object[] {
            "Seleccione",
            "Administrador",
            "Bodequero",
            "Usuario"});
            this.combTipoUsu.Location = new System.Drawing.Point(640, 97);
            this.combTipoUsu.Name = "combTipoUsu";
            this.combTipoUsu.Size = new System.Drawing.Size(259, 32);
            this.combTipoUsu.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(636, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tipo de usuario:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(636, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Estado:";
            // 
            // txtClaveConf
            // 
            this.txtClaveConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClaveConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtClaveConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveConf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClaveConf.Location = new System.Drawing.Point(327, 151);
            this.txtClaveConf.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtClaveConf.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtClaveConf.Name = "txtClaveConf";
            this.txtClaveConf.PasswordChar = '*';
            this.txtClaveConf.Size = new System.Drawing.Size(258, 29);
            this.txtClaveConf.TabIndex = 31;
            this.txtClaveConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveConf_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(323, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Repetir contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClave.Location = new System.Drawing.Point(327, 98);
            this.txtClave.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtClave.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(258, 29);
            this.txtClave.TabIndex = 29;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(323, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.Location = new System.Drawing.Point(327, 45);
            this.txtCorreo.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtCorreo.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(258, 29);
            this.txtCorreo.TabIndex = 27;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(323, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo:";
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtNomUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomUsu.Location = new System.Drawing.Point(14, 151);
            this.txtNomUsu.MaximumSize = new System.Drawing.Size(258, 30);
            this.txtNomUsu.MinimumSize = new System.Drawing.Size(258, 30);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(258, 29);
            this.txtNomUsu.TabIndex = 25;
            this.txtNomUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsu_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre de usuario:";
            // 
            // labelMensaje
            // 
            this.labelMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.Location = new System.Drawing.Point(0, 579);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(950, 41);
            this.labelMensaje.TabIndex = 30;
            this.labelMensaje.Text = "Usuario / Creado / Modificado / Eliminado";
            this.labelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarNomUsu
            // 
            this.txtBuscarNomUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(92)))), ((int)(((byte)(43)))));
            this.txtBuscarNomUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNomUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNomUsu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarNomUsu.Location = new System.Drawing.Point(223, 31);
            this.txtBuscarNomUsu.Name = "txtBuscarNomUsu";
            this.txtBuscarNomUsu.Size = new System.Drawing.Size(234, 26);
            this.txtBuscarNomUsu.TabIndex = 36;
            this.txtBuscarNomUsu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarNomUsu_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(5, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Buscar por Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtaGridUsuario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBuscarNomUsu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 299);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de usuarios:";
            // 
            // dtaGridUsuario
            // 
            this.dtaGridUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtaGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridUsuario.Location = new System.Drawing.Point(14, 74);
            this.dtaGridUsuario.Name = "dtaGridUsuario";
            this.dtaGridUsuario.ReadOnly = true;
            this.dtaGridUsuario.Size = new System.Drawing.Size(911, 201);
            this.dtaGridUsuario.TabIndex = 37;
            this.dtaGridUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtaGridUsuario_CellMouseClick);
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.AutoSize = true;
            btnRegistrarUsuario.BackColor = System.Drawing.Color.Lime;
            btnRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRegistrarUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnRegistrarUsuario.IconColor = System.Drawing.Color.Black;
            btnRegistrarUsuario.IconSize = 32;
            btnRegistrarUsuario.Location = new System.Drawing.Point(10, 3);
            btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Rotation = 0D;
            btnRegistrarUsuario.Size = new System.Drawing.Size(213, 42);
            btnRegistrarUsuario.TabIndex = 29;
            btnRegistrarUsuario.Text = "Ingresar";
            btnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRegistrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNombreVentana);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.VentanaUsuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtRut;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label labelUusario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnLimpiarFormUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnModificarUsuario;
        private System.Windows.Forms.Label labelNombreVentana;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtNomUsu;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtClaveConf;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtCorreo;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMensaje;
        internal System.Windows.Forms.TextBox txtBuscarNomUsu;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combEstado;
        private System.Windows.Forms.ComboBox combTipoUsu;
        private System.Windows.Forms.DataGridView dtaGridUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
    }
}