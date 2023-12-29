namespace pryBancoDeSangre
{
    partial class Logo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            this.pbrlogo = new System.Windows.Forms.ProgressBar();
            this.tmrBarra = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbrlogo
            // 
            this.pbrlogo.Location = new System.Drawing.Point(44, 463);
            this.pbrlogo.Name = "pbrlogo";
            this.pbrlogo.Size = new System.Drawing.Size(663, 35);
            this.pbrlogo.TabIndex = 0;
            // 
            // tmrBarra
            // 
            this.tmrBarra.Enabled = true;
            this.tmrBarra.Interval = 20;
            this.tmrBarra.Tick += new System.EventHandler(this.tmrBarra_Tick);
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryBancoDeSangre.Properties.Resources.LOGO_pryBancoDeSangre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(759, 607);
            this.Controls.Add(this.pbrlogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Logo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrlogo;
        private System.Windows.Forms.Timer tmrBarra;
    }
}

