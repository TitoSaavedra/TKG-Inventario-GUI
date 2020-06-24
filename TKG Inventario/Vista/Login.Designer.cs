namespace TKG_Inventario.Vista
{
    partial class Login
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
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.iconoMiniminizarApp = new FontAwesome.Sharp.IconPictureBox();
            this.iconoMaximizarApp = new FontAwesome.Sharp.IconPictureBox();
            this.iconoCerrarApp = new FontAwesome.Sharp.IconPictureBox();
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMiniminizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.iconoMiniminizarApp);
            this.panelBarraTitulo.Controls.Add(this.iconoMaximizarApp);
            this.panelBarraTitulo.Controls.Add(this.iconoCerrarApp);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1184, 30);
            this.panelBarraTitulo.TabIndex = 2;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // iconoMiniminizarApp
            // 
            this.iconoMiniminizarApp.BackColor = System.Drawing.SystemColors.Control;
            this.iconoMiniminizarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoMiniminizarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoMiniminizarApp.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconoMiniminizarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoMiniminizarApp.IconSize = 30;
            this.iconoMiniminizarApp.Location = new System.Drawing.Point(1094, 0);
            this.iconoMiniminizarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoMiniminizarApp.Name = "iconoMiniminizarApp";
            this.iconoMiniminizarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoMiniminizarApp.TabIndex = 2;
            this.iconoMiniminizarApp.TabStop = false;
            this.iconoMiniminizarApp.Click += new System.EventHandler(this.iconoMiniminizarApp_Click);
            // 
            // iconoMaximizarApp
            // 
            this.iconoMaximizarApp.BackColor = System.Drawing.SystemColors.Control;
            this.iconoMaximizarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoMaximizarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoMaximizarApp.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.iconoMaximizarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoMaximizarApp.IconSize = 30;
            this.iconoMaximizarApp.Location = new System.Drawing.Point(1124, 0);
            this.iconoMaximizarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoMaximizarApp.Name = "iconoMaximizarApp";
            this.iconoMaximizarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoMaximizarApp.TabIndex = 1;
            this.iconoMaximizarApp.TabStop = false;
            this.iconoMaximizarApp.Click += new System.EventHandler(this.iconoMaximizarApp_Click_1);
            // 
            // iconoCerrarApp
            // 
            this.iconoCerrarApp.BackColor = System.Drawing.SystemColors.Control;
            this.iconoCerrarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoCerrarApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconoCerrarApp.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconoCerrarApp.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconoCerrarApp.IconSize = 30;
            this.iconoCerrarApp.Location = new System.Drawing.Point(1154, 0);
            this.iconoCerrarApp.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconoCerrarApp.Name = "iconoCerrarApp";
            this.iconoCerrarApp.Size = new System.Drawing.Size(30, 30);
            this.iconoCerrarApp.TabIndex = 0;
            this.iconoCerrarApp.TabStop = false;
            this.iconoCerrarApp.Click += new System.EventHandler(this.iconoCerrarApp_Click);
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 30);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1184, 581);
            this.panelContenedorPrincipal.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.Controls.Add(this.panelBarraTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMiniminizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconoMiniminizarApp;
        private FontAwesome.Sharp.IconPictureBox iconoMaximizarApp;
        private FontAwesome.Sharp.IconPictureBox iconoCerrarApp;
        private System.Windows.Forms.Panel panelContenedorPrincipal;
    }
}