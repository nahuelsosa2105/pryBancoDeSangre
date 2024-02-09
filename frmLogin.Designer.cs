namespace pryBancoDeSangre
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.btnOlvidar = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoUser = new MaterialSkin.Controls.MaterialButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoDeConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre de usuario:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(99, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(249, 126);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(358, 50);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(249, 197);
            this.txtPass.MaxLength = 50;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Password = true;
            this.txtPass.Size = new System.Drawing.Size(358, 50);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "";
            this.txtPass.TrailingIcon = null;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = false;
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.HighEmphasis = true;
            this.btnIniciarSesion.Icon = null;
            this.btnIniciarSesion.Location = new System.Drawing.Point(86, 284);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.Size = new System.Drawing.Size(511, 36);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciarSesion.UseAccentColor = false;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnOlvidar
            // 
            this.btnOlvidar.AutoSize = false;
            this.btnOlvidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOlvidar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOlvidar.Depth = 0;
            this.btnOlvidar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidar.HighEmphasis = true;
            this.btnOlvidar.Icon = null;
            this.btnOlvidar.Location = new System.Drawing.Point(86, 365);
            this.btnOlvidar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOlvidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOlvidar.Name = "btnOlvidar";
            this.btnOlvidar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOlvidar.Size = new System.Drawing.Size(511, 36);
            this.btnOlvidar.TabIndex = 5;
            this.btnOlvidar.Text = "Olvide mi contraseña";
            this.btnOlvidar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOlvidar.UseAccentColor = false;
            this.btnOlvidar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.AutoSize = false;
            this.btnNuevoUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoUser.Depth = 0;
            this.btnNuevoUser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUser.HighEmphasis = true;
            this.btnNuevoUser.Icon = null;
            this.btnNuevoUser.Location = new System.Drawing.Point(86, 442);
            this.btnNuevoUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoUser.Size = new System.Drawing.Size(511, 36);
            this.btnNuevoUser.TabIndex = 6;
            this.btnNuevoUser.Text = "Nuevo usuario";
            this.btnNuevoUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoUser.UseAccentColor = false;
            this.btnNuevoUser.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoDeConexion});
            this.statusStrip1.Location = new System.Drawing.Point(3, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(692, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "---";
            // 
            // lblEstadoDeConexion
            // 
            this.lblEstadoDeConexion.Name = "lblEstadoDeConexion";
            this.lblEstadoDeConexion.Size = new System.Drawing.Size(22, 17);
            this.lblEstadoDeConexion.Text = "---";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNuevoUser);
            this.Controls.Add(this.btnOlvidar);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio De Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialButton btnIniciarSesion;
        private MaterialSkin.Controls.MaterialButton btnOlvidar;
        private MaterialSkin.Controls.MaterialButton btnNuevoUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoDeConexion;
    }
}

