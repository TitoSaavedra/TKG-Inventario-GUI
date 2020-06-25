namespace TKG_Inventario.Vista
{
    partial class ContenedorAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenedorAplicacion));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedorFormularios = new System.Windows.Forms.Panel();
            this.panelApp = new System.Windows.Forms.Panel();
            this.iconoMiniminizarApp = new FontAwesome.Sharp.IconPictureBox();
            this.iconoCerrarApp = new FontAwesome.Sharp.IconPictureBox();
            this.iconoMaximizarApp = new FontAwesome.Sharp.IconPictureBox();
            this.panelBarraTitulo.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMiniminizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.DimGray;
            this.panelBarraTitulo.Controls.Add(this.iconoMiniminizarApp);
            this.panelBarraTitulo.Controls.Add(this.iconoMaximizarApp);
            this.panelBarraTitulo.Controls.Add(this.iconoCerrarApp);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1200, 30);
            this.panelBarraTitulo.TabIndex = 4;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // panelContenedorFormularios
            // 
            this.panelContenedorFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorFormularios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedorFormularios.Location = new System.Drawing.Point(0, 30);
            this.panelContenedorFormularios.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panelContenedorFormularios.Name = "panelContenedorFormularios";
            this.panelContenedorFormularios.Size = new System.Drawing.Size(1200, 620);
            this.panelContenedorFormularios.TabIndex = 5;
            // 
            // panelApp
            // 
            this.panelApp.Controls.Add(this.panelContenedorFormularios);
            this.panelApp.Controls.Add(this.panelBarraTitulo);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApp.Location = new System.Drawing.Point(0, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(1200, 650);
            this.panelApp.TabIndex = 0;
            // 
            // iconoMiniminizarApp
            // 
            this.iconoMiniminizarApp.BackColor = System.Drawing.Color.DimGray;
            this.iconoMiniminizarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoMiniminizarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoMiniminizarApp.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconoMiniminizarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoMiniminizarApp.IconSize = 30;
            this.iconoMiniminizarApp.Location = new System.Drawing.Point(1110, 0);
            this.iconoMiniminizarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoMiniminizarApp.Name = "iconoMiniminizarApp";
            this.iconoMiniminizarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoMiniminizarApp.TabIndex = 2;
            this.iconoMiniminizarApp.TabStop = false;
            this.iconoMiniminizarApp.Click += new System.EventHandler(this.iconoMiniminizarApp_Click);
            // 
            // iconoCerrarApp
            // 
            this.iconoCerrarApp.BackColor = System.Drawing.Color.DimGray;
            this.iconoCerrarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoCerrarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoCerrarApp.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconoCerrarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoCerrarApp.IconSize = 30;
            this.iconoCerrarApp.Location = new System.Drawing.Point(1170, 0);
            this.iconoCerrarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoCerrarApp.Name = "iconoCerrarApp";
            this.iconoCerrarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoCerrarApp.TabIndex = 0;
            this.iconoCerrarApp.TabStop = false;
            this.iconoCerrarApp.Click += new System.EventHandler(this.iconoCerrarApp_Click);
            // 
            // iconoMaximizarApp
            // 
            this.iconoMaximizarApp.BackColor = System.Drawing.Color.DimGray;
            this.iconoMaximizarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoMaximizarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoMaximizarApp.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.iconoMaximizarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoMaximizarApp.IconSize = 30;
            this.iconoMaximizarApp.Location = new System.Drawing.Point(1140, 0);
            this.iconoMaximizarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoMaximizarApp.Name = "iconoMaximizarApp";
            this.iconoMaximizarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoMaximizarApp.TabIndex = 1;
            this.iconoMaximizarApp.TabStop = false;
            this.iconoMaximizarApp.Visible = false;
            this.iconoMaximizarApp.Click += new System.EventHandler(this.iconoMaximizarApp_Click);
            // 
            // ContenedorAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContenedorAplicacion";
            this.Text = "TKG - Inventario";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMiniminizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizarApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconoMiniminizarApp;
        private FontAwesome.Sharp.IconPictureBox iconoCerrarApp;
        private System.Windows.Forms.Panel panelContenedorFormularios;
        private System.Windows.Forms.Panel panelApp;
        private FontAwesome.Sharp.IconPictureBox iconoMaximizarApp;
    }
}