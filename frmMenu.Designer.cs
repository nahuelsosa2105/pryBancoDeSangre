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
            this.dgvGrupoSanguineo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarGrupo = new MaterialSkin.Controls.MaterialButton();
            this.lblBuscarGrupo = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGrupoSanguineo = new MaterialSkin.Controls.MaterialComboBox();
            this.tbpCargar = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUltDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPrincipal.SuspendLayout();
            this.tbpBuscarFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoSanguineo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
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
            this.tblPrincipal.Size = new System.Drawing.Size(1349, 646);
            this.tblPrincipal.TabIndex = 0;
            // 
            // tbpBuscarFactor
            // 
            this.tbpBuscarFactor.BackColor = System.Drawing.Color.White;
            this.tbpBuscarFactor.Controls.Add(this.dgvGrupoSanguineo);
            this.tbpBuscarFactor.Controls.Add(this.groupBox1);
            this.tbpBuscarFactor.Location = new System.Drawing.Point(4, 25);
            this.tbpBuscarFactor.Name = "tbpBuscarFactor";
            this.tbpBuscarFactor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscarFactor.Size = new System.Drawing.Size(1341, 617);
            this.tbpBuscarFactor.TabIndex = 0;
            this.tbpBuscarFactor.Text = "Buscar Grupo Sanguineo";
            // 
            // dgvGrupoSanguineo
            // 
            this.dgvGrupoSanguineo.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupoSanguineo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoSanguineo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnDni,
            this.ColumnFechaNac,
            this.ColumnEdad,
            this.ColumnHC,
            this.ColumnUltDon,
            this.ColumnCantDon,
            this.ColumnMail,
            this.ColumnTelefono,
            this.ColumnDireccion,
            this.ColumnLocalidad,
            this.ColumnProv});
            this.dgvGrupoSanguineo.Location = new System.Drawing.Point(105, 286);
            this.dgvGrupoSanguineo.Name = "dgvGrupoSanguineo";
            this.dgvGrupoSanguineo.Size = new System.Drawing.Size(1446, 293);
            this.dgvGrupoSanguineo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBuscarGrupo);
            this.groupBox1.Controls.Add(this.lblBuscarGrupo);
            this.groupBox1.Controls.Add(this.cmbGrupoSanguineo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(105, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscarGrupo
            // 
            this.btnBuscarGrupo.AutoSize = false;
            this.btnBuscarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarGrupo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarGrupo.Depth = 0;
            this.btnBuscarGrupo.HighEmphasis = true;
            this.btnBuscarGrupo.Icon = null;
            this.btnBuscarGrupo.Location = new System.Drawing.Point(998, 135);
            this.btnBuscarGrupo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarGrupo.Name = "btnBuscarGrupo";
            this.btnBuscarGrupo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarGrupo.Size = new System.Drawing.Size(172, 36);
            this.btnBuscarGrupo.TabIndex = 2;
            this.btnBuscarGrupo.Text = "Buscar";
            this.btnBuscarGrupo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarGrupo.UseAccentColor = false;
            this.btnBuscarGrupo.UseVisualStyleBackColor = true;
            // 
            // lblBuscarGrupo
            // 
            this.lblBuscarGrupo.AutoSize = true;
            this.lblBuscarGrupo.Depth = 0;
            this.lblBuscarGrupo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBuscarGrupo.Location = new System.Drawing.Point(6, 33);
            this.lblBuscarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuscarGrupo.Name = "lblBuscarGrupo";
            this.lblBuscarGrupo.Size = new System.Drawing.Size(210, 19);
            this.lblBuscarGrupo.TabIndex = 1;
            this.lblBuscarGrupo.Text = "Seleccionar grupo sanguineo:";
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.AutoResize = false;
            this.cmbGrupoSanguineo.BackColor = System.Drawing.Color.White;
            this.cmbGrupoSanguineo.Depth = 0;
            this.cmbGrupoSanguineo.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbGrupoSanguineo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGrupoSanguineo.DropDownHeight = 174;
            this.cmbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoSanguineo.DropDownWidth = 121;
            this.cmbGrupoSanguineo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGrupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(405, 16);
            this.cmbGrupoSanguineo.MaxDropDownItems = 4;
            this.cmbGrupoSanguineo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(780, 49);
            this.cmbGrupoSanguineo.StartIndex = 0;
            this.cmbGrupoSanguineo.TabIndex = 0;
            // 
            // tbpCargar
            // 
            this.tbpCargar.Location = new System.Drawing.Point(4, 25);
            this.tbpCargar.Name = "tbpCargar";
            this.tbpCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCargar.Size = new System.Drawing.Size(1341, 617);
            this.tbpCargar.TabIndex = 1;
            this.tbpCargar.Text = "Cargar Paciente";
            this.tbpCargar.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 617);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Grupo Sanguineo";
            this.Column1.Name = "Column1";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnDni
            // 
            this.ColumnDni.HeaderText = "DNI";
            this.ColumnDni.Name = "ColumnDni";
            // 
            // ColumnFechaNac
            // 
            this.ColumnFechaNac.HeaderText = "Fecha Nacimiento";
            this.ColumnFechaNac.Name = "ColumnFechaNac";
            // 
            // ColumnEdad
            // 
            this.ColumnEdad.HeaderText = "Edad";
            this.ColumnEdad.Name = "ColumnEdad";
            // 
            // ColumnHC
            // 
            this.ColumnHC.HeaderText = "Historia Clinica";
            this.ColumnHC.Name = "ColumnHC";
            // 
            // ColumnUltDon
            // 
            this.ColumnUltDon.HeaderText = "Ult Donacion";
            this.ColumnUltDon.Name = "ColumnUltDon";
            // 
            // ColumnCantDon
            // 
            this.ColumnCantDon.HeaderText = "Cant Donaciones";
            this.ColumnCantDon.Name = "ColumnCantDon";
            // 
            // ColumnMail
            // 
            this.ColumnMail.HeaderText = "Correo Electronico";
            this.ColumnMail.Name = "ColumnMail";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnLocalidad
            // 
            this.ColumnLocalidad.HeaderText = "Localidad";
            this.ColumnLocalidad.Name = "ColumnLocalidad";
            // 
            // ColumnProv
            // 
            this.ColumnProv.HeaderText = "Provincia";
            this.ColumnProv.Name = "ColumnProv";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 713);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoSanguineo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tblPrincipal;
        private System.Windows.Forms.TabPage tbpBuscarFactor;
        private System.Windows.Forms.TabPage tbpCargar;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialComboBox cmbGrupoSanguineo;
        private MaterialSkin.Controls.MaterialLabel lblBuscarGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnBuscarGrupo;
        private System.Windows.Forms.DataGridView dgvGrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUltDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProv;
    }
}