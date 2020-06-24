namespace TKG_Inventario.Vista
{
    partial class MainWindow
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.botonCrudCompraProductos = new FontAwesome.Sharp.IconButton();
            this.botonCrudProductos = new FontAwesome.Sharp.IconButton();
            this.botonCrudFamiliaProductos = new FontAwesome.Sharp.IconButton();
            this.botonCrudUsuarios = new FontAwesome.Sharp.IconButton();
            this.botonSistema = new FontAwesome.Sharp.IconButton();
            this.panelContenedorNombre = new System.Windows.Forms.Panel();
            this.iconoMenu = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelContenedorNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(950, 650);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelMenu.Controls.Add(this.botonCrudCompraProductos);
            this.panelMenu.Controls.Add(this.botonCrudProductos);
            this.panelMenu.Controls.Add(this.botonCrudFamiliaProductos);
            this.panelMenu.Controls.Add(this.botonCrudUsuarios);
            this.panelMenu.Controls.Add(this.botonSistema);
            this.panelMenu.Controls.Add(this.panelContenedorNombre);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // botonCrudCompraProductos
            // 
            this.botonCrudCompraProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCrudCompraProductos.FlatAppearance.BorderSize = 0;
            this.botonCrudCompraProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrudCompraProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCrudCompraProductos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrudCompraProductos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.botonCrudCompraProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.botonCrudCompraProductos.IconSize = 30;
            this.botonCrudCompraProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudCompraProductos.Location = new System.Drawing.Point(0, 370);
            this.botonCrudCompraProductos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.botonCrudCompraProductos.Name = "botonCrudCompraProductos";
            this.botonCrudCompraProductos.Rotation = 0D;
            this.botonCrudCompraProductos.Size = new System.Drawing.Size(250, 60);
            this.botonCrudCompraProductos.TabIndex = 9;
            this.botonCrudCompraProductos.Text = "Compra Productos";
            this.botonCrudCompraProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudCompraProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCrudCompraProductos.UseVisualStyleBackColor = true;
            // 
            // botonCrudProductos
            // 
            this.botonCrudProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCrudProductos.FlatAppearance.BorderSize = 0;
            this.botonCrudProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrudProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCrudProductos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrudProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.botonCrudProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.botonCrudProductos.IconSize = 30;
            this.botonCrudProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudProductos.Location = new System.Drawing.Point(0, 310);
            this.botonCrudProductos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.botonCrudProductos.Name = "botonCrudProductos";
            this.botonCrudProductos.Rotation = 0D;
            this.botonCrudProductos.Size = new System.Drawing.Size(250, 60);
            this.botonCrudProductos.TabIndex = 8;
            this.botonCrudProductos.Text = "Productos";
            this.botonCrudProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCrudProductos.UseVisualStyleBackColor = true;
            // 
            // botonCrudFamiliaProductos
            // 
            this.botonCrudFamiliaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCrudFamiliaProductos.FlatAppearance.BorderSize = 0;
            this.botonCrudFamiliaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrudFamiliaProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCrudFamiliaProductos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrudFamiliaProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.botonCrudFamiliaProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.botonCrudFamiliaProductos.IconSize = 30;
            this.botonCrudFamiliaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudFamiliaProductos.Location = new System.Drawing.Point(0, 250);
            this.botonCrudFamiliaProductos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.botonCrudFamiliaProductos.Name = "botonCrudFamiliaProductos";
            this.botonCrudFamiliaProductos.Rotation = 0D;
            this.botonCrudFamiliaProductos.Size = new System.Drawing.Size(250, 60);
            this.botonCrudFamiliaProductos.TabIndex = 7;
            this.botonCrudFamiliaProductos.Text = "Familia Productos";
            this.botonCrudFamiliaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudFamiliaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCrudFamiliaProductos.UseVisualStyleBackColor = true;
            // 
            // botonCrudUsuarios
            // 
            this.botonCrudUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCrudUsuarios.FlatAppearance.BorderSize = 0;
            this.botonCrudUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrudUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCrudUsuarios.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrudUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.botonCrudUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.botonCrudUsuarios.IconSize = 30;
            this.botonCrudUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudUsuarios.Location = new System.Drawing.Point(0, 190);
            this.botonCrudUsuarios.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.botonCrudUsuarios.Name = "botonCrudUsuarios";
            this.botonCrudUsuarios.Rotation = 0D;
            this.botonCrudUsuarios.Size = new System.Drawing.Size(250, 60);
            this.botonCrudUsuarios.TabIndex = 6;
            this.botonCrudUsuarios.Text = "Usuarios";
            this.botonCrudUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCrudUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCrudUsuarios.UseVisualStyleBackColor = true;
            // 
            // botonSistema
            // 
            this.botonSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonSistema.FlatAppearance.BorderSize = 0;
            this.botonSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSistema.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonSistema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSistema.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.botonSistema.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.botonSistema.IconSize = 30;
            this.botonSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonSistema.Location = new System.Drawing.Point(0, 130);
            this.botonSistema.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.botonSistema.Name = "botonSistema";
            this.botonSistema.Rotation = 0D;
            this.botonSistema.Size = new System.Drawing.Size(250, 60);
            this.botonSistema.TabIndex = 5;
            this.botonSistema.Text = "Sistema";
            this.botonSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonSistema.UseVisualStyleBackColor = true;
            // 
            // panelContenedorNombre
            // 
            this.panelContenedorNombre.Controls.Add(this.iconoMenu);
            this.panelContenedorNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenedorNombre.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorNombre.Name = "panelContenedorNombre";
            this.panelContenedorNombre.Size = new System.Drawing.Size(250, 130);
            this.panelContenedorNombre.TabIndex = 0;
            // 
            // iconoMenu
            // 
            this.iconoMenu.BackColor = System.Drawing.Color.Transparent;
            this.iconoMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.iconoMenu.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.iconoMenu.IconColor = System.Drawing.SystemColors.Window;
            this.iconoMenu.IconSize = 35;
            this.iconoMenu.Location = new System.Drawing.Point(12, 30);
            this.iconoMenu.Name = "iconoMenu";
            this.iconoMenu.Size = new System.Drawing.Size(35, 35);
            this.iconoMenu.TabIndex = 0;
            this.iconoMenu.TabStop = false;
            this.iconoMenu.Click += new System.EventHandler(this.iconoMenu_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelContenedorNombre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedorNombre;
        private FontAwesome.Sharp.IconPictureBox iconoMenu;
        private FontAwesome.Sharp.IconButton botonCrudCompraProductos;
        private FontAwesome.Sharp.IconButton botonCrudProductos;
        private FontAwesome.Sharp.IconButton botonCrudFamiliaProductos;
        private FontAwesome.Sharp.IconButton botonCrudUsuarios;
        private FontAwesome.Sharp.IconButton botonSistema;
    }
}