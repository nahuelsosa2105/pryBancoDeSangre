namespace pryBancoDeSangre
{
    partial class frmMenu
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
            this.tblPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.tbpCargar = new System.Windows.Forms.TabPage();
            this.tblPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.Controls.Add(this.tbpBuscar);
            this.tblPrincipal.Controls.Add(this.tbpCargar);
            this.tblPrincipal.Depth = 0;
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(3, 64);
            this.tblPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tblPrincipal.Multiline = true;
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.SelectedIndex = 0;
            this.tblPrincipal.Size = new System.Drawing.Size(794, 383);
            this.tblPrincipal.TabIndex = 0;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(786, 357);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar paciente";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // tbpCargar
            // 
            this.tbpCargar.Location = new System.Drawing.Point(4, 22);
            this.tbpCargar.Name = "tbpCargar";
            this.tbpCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCargar.Size = new System.Drawing.Size(786, 357);
            this.tbpCargar.TabIndex = 1;
            this.tbpCargar.Text = "Cargar Paciente";
            this.tbpCargar.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblPrincipal);
            this.DrawerTabControl = this.tblPrincipal;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tblPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tblPrincipal;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpCargar;
    }
}