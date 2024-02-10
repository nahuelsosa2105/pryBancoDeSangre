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
            this.tbpBuscarFactor = new System.Windows.Forms.TabPage();
            this.tbpCargar = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbGrupoSanguineo = new MaterialSkin.Controls.MaterialComboBox();
            this.tblPrincipal.SuspendLayout();
            this.tbpBuscarFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.Controls.Add(this.tbpBuscarFactor);
            this.tblPrincipal.Controls.Add(this.tbpCargar);
            this.tblPrincipal.Controls.Add(this.tabPage1);
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
            // tbpBuscarFactor
            // 
            this.tbpBuscarFactor.Controls.Add(this.cmbGrupoSanguineo);
            this.tbpBuscarFactor.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscarFactor.Name = "tbpBuscarFactor";
            this.tbpBuscarFactor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscarFactor.Size = new System.Drawing.Size(786, 357);
            this.tbpBuscarFactor.TabIndex = 0;
            this.tbpBuscarFactor.Text = "Buscar Factor Sanguineo";
            this.tbpBuscarFactor.UseVisualStyleBackColor = true;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 357);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.AutoResize = false;
            this.cmbGrupoSanguineo.BackColor = System.Drawing.Color.White;
            this.cmbGrupoSanguineo.Depth = 0;
            this.cmbGrupoSanguineo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGrupoSanguineo.DropDownHeight = 174;
            this.cmbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoSanguineo.DropDownWidth = 121;
            this.cmbGrupoSanguineo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGrupoSanguineo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGrupoSanguineo.ForeColor = System.Drawing.Color.White;
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.IntegralHeight = false;
            this.cmbGrupoSanguineo.ItemHeight = 43;
            this.cmbGrupoSanguineo.Items.AddRange(new object[] {
            "A+ (grupo sanguíneo A con factor Rh positivo).",
            "B+ (grupo sanguíneo B con factor Rh positivo).",
            "AB+ (grupo sanguíneo AB con factor Rh positivo).",
            "0+ (grupo sanguíneo 0 con factor Rh positivo).",
            "A- (grupo sanguíneo A con factor Rh negativo).",
            "B- (grupo sanguíneo B con factor Rh negativo).",
            "AB- (grupo sanguíneo AB con factor Rh negativo).",
            "0- (grupo sanguíneo 0 con factor Rh negativo)."});
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(110, 49);
            this.cmbGrupoSanguineo.MaxDropDownItems = 4;
            this.cmbGrupoSanguineo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(559, 49);
            this.cmbGrupoSanguineo.StartIndex = 0;
            this.cmbGrupoSanguineo.TabIndex = 0;
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
            this.tbpBuscarFactor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tblPrincipal;
        private System.Windows.Forms.TabPage tbpBuscarFactor;
        private System.Windows.Forms.TabPage tbpCargar;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialComboBox cmbGrupoSanguineo;
    }
}