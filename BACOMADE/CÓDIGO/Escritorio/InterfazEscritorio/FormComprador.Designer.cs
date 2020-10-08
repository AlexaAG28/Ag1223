namespace InterfazEscritorio
{
    partial class FormComprador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprador));
            this.txtBuc_comp = new System.Windows.Forms.TextBox();
            this.btnBusC = new System.Windows.Forms.Button();
            this.dgvComprador = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.btnLimpC = new System.Windows.Forms.Button();
            this.btnGuarC = new System.Windows.Forms.Button();
            this.txtDireccionC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidosC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModiC = new System.Windows.Forms.Button();
            this.btnElimC = new System.Windows.Forms.Button();
            this.iDCOMPRADOR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREOC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASEÑAC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONOC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprador)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compradorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuc_comp
            // 
            this.txtBuc_comp.Location = new System.Drawing.Point(71, 41);
            this.txtBuc_comp.Name = "txtBuc_comp";
            this.txtBuc_comp.Size = new System.Drawing.Size(222, 20);
            this.txtBuc_comp.TabIndex = 0;
            // 
            // btnBusC
            // 
            this.btnBusC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusC.Location = new System.Drawing.Point(310, 32);
            this.btnBusC.Name = "btnBusC";
            this.btnBusC.Size = new System.Drawing.Size(75, 36);
            this.btnBusC.TabIndex = 1;
            this.btnBusC.Text = "&Buscar";
            this.btnBusC.UseVisualStyleBackColor = false;
            this.btnBusC.Click += new System.EventHandler(this.btnBusC_Click);
            // 
            // dgvComprador
            // 
            this.dgvComprador.AllowUserToAddRows = false;
            this.dgvComprador.AllowUserToDeleteRows = false;
            this.dgvComprador.AutoGenerateColumns = false;
            this.dgvComprador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCOMPRADOR1DataGridViewTextBoxColumn,
            this.cORREOC1DataGridViewTextBoxColumn,
            this.cONTRASEÑAC1DataGridViewTextBoxColumn,
            this.nOMBREC1DataGridViewTextBoxColumn,
            this.aPELLIDOSC1DataGridViewTextBoxColumn,
            this.dOCUMENTOC1DataGridViewTextBoxColumn,
            this.tELEFONOC1DataGridViewTextBoxColumn,
            this.dIRECCIONC1DataGridViewTextBoxColumn});
            this.dgvComprador.DataSource = this.compradorBindingSource;
            this.dgvComprador.Location = new System.Drawing.Point(23, 79);
            this.dgvComprador.Name = "dgvComprador";
            this.dgvComprador.ReadOnly = true;
            this.dgvComprador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprador.Size = new System.Drawing.Size(876, 244);
            this.dgvComprador.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtIdC);
            this.groupBox1.Controls.Add(this.btnLimpC);
            this.groupBox1.Controls.Add(this.btnGuarC);
            this.groupBox1.Controls.Add(this.txtDireccionC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefonoC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDocumentoC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidosC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContraseñaC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCorreoC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(932, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del comprador";
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(52, 334);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(95, 22);
            this.txtIdC.TabIndex = 17;
            this.txtIdC.Visible = false;
            // 
            // btnLimpC
            // 
            this.btnLimpC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpC.Location = new System.Drawing.Point(198, 362);
            this.btnLimpC.Name = "btnLimpC";
            this.btnLimpC.Size = new System.Drawing.Size(84, 42);
            this.btnLimpC.TabIndex = 15;
            this.btnLimpC.Text = "&Limpiar";
            this.btnLimpC.UseVisualStyleBackColor = false;
            this.btnLimpC.Click += new System.EventHandler(this.btnLimpC_Click);
            // 
            // btnGuarC
            // 
            this.btnGuarC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuarC.Location = new System.Drawing.Point(52, 362);
            this.btnGuarC.Name = "btnGuarC";
            this.btnGuarC.Size = new System.Drawing.Size(84, 42);
            this.btnGuarC.TabIndex = 14;
            this.btnGuarC.Text = "&Guardar";
            this.btnGuarC.UseVisualStyleBackColor = false;
            this.btnGuarC.Click += new System.EventHandler(this.btnGuarC_Click);
            // 
            // txtDireccionC
            // 
            this.txtDireccionC.Location = new System.Drawing.Point(124, 291);
            this.txtDireccionC.Name = "txtDireccionC";
            this.txtDireccionC.Size = new System.Drawing.Size(158, 22);
            this.txtDireccionC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(31, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dirección";
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.Location = new System.Drawing.Point(124, 252);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(158, 22);
            this.txtTelefonoC.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono";
            // 
            // txtDocumentoC
            // 
            this.txtDocumentoC.Location = new System.Drawing.Point(124, 208);
            this.txtDocumentoC.Name = "txtDocumentoC";
            this.txtDocumentoC.Size = new System.Drawing.Size(158, 22);
            this.txtDocumentoC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(31, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Documento";
            // 
            // txtApellidosC
            // 
            this.txtApellidosC.Location = new System.Drawing.Point(124, 168);
            this.txtApellidosC.Name = "txtApellidosC";
            this.txtApellidosC.Size = new System.Drawing.Size(158, 22);
            this.txtApellidosC.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Apellidos";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(124, 129);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(158, 22);
            this.txtNombreC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtContraseñaC
            // 
            this.txtContraseñaC.Location = new System.Drawing.Point(124, 85);
            this.txtContraseñaC.Name = "txtContraseñaC";
            this.txtContraseñaC.Size = new System.Drawing.Size(158, 22);
            this.txtContraseñaC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtCorreoC
            // 
            this.txtCorreoC.Location = new System.Drawing.Point(124, 45);
            this.txtCorreoC.Name = "txtCorreoC";
            this.txtCorreoC.Size = new System.Drawing.Size(158, 22);
            this.txtCorreoC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // btnModiC
            // 
            this.btnModiC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiC.Location = new System.Drawing.Point(383, 357);
            this.btnModiC.Name = "btnModiC";
            this.btnModiC.Size = new System.Drawing.Size(84, 42);
            this.btnModiC.TabIndex = 15;
            this.btnModiC.Text = "&Modificar";
            this.btnModiC.UseVisualStyleBackColor = false;
            this.btnModiC.Click += new System.EventHandler(this.btnModiC_Click);
            // 
            // btnElimC
            // 
            this.btnElimC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimC.Location = new System.Drawing.Point(531, 357);
            this.btnElimC.Name = "btnElimC";
            this.btnElimC.Size = new System.Drawing.Size(84, 42);
            this.btnElimC.TabIndex = 16;
            this.btnElimC.Text = "&Eliminar";
            this.btnElimC.UseVisualStyleBackColor = false;
            this.btnElimC.Click += new System.EventHandler(this.btnElimC_Click);
            // 
            // iDCOMPRADOR1DataGridViewTextBoxColumn
            // 
            this.iDCOMPRADOR1DataGridViewTextBoxColumn.DataPropertyName = "ID_COMPRADOR1";
            this.iDCOMPRADOR1DataGridViewTextBoxColumn.HeaderText = "ID_COMPRADOR1";
            this.iDCOMPRADOR1DataGridViewTextBoxColumn.Name = "iDCOMPRADOR1DataGridViewTextBoxColumn";
            this.iDCOMPRADOR1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCOMPRADOR1DataGridViewTextBoxColumn.Visible = false;
            // 
            // cORREOC1DataGridViewTextBoxColumn
            // 
            this.cORREOC1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cORREOC1DataGridViewTextBoxColumn.DataPropertyName = "CORREO_C1";
            this.cORREOC1DataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREOC1DataGridViewTextBoxColumn.Name = "cORREOC1DataGridViewTextBoxColumn";
            this.cORREOC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTRASEÑAC1DataGridViewTextBoxColumn
            // 
            this.cONTRASEÑAC1DataGridViewTextBoxColumn.DataPropertyName = "CONTRASEÑA_C1";
            this.cONTRASEÑAC1DataGridViewTextBoxColumn.HeaderText = "CONTRASEÑA";
            this.cONTRASEÑAC1DataGridViewTextBoxColumn.Name = "cONTRASEÑAC1DataGridViewTextBoxColumn";
            this.cONTRASEÑAC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREC1DataGridViewTextBoxColumn
            // 
            this.nOMBREC1DataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_C1";
            this.nOMBREC1DataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREC1DataGridViewTextBoxColumn.Name = "nOMBREC1DataGridViewTextBoxColumn";
            this.nOMBREC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDOSC1DataGridViewTextBoxColumn
            // 
            this.aPELLIDOSC1DataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS_C1";
            this.aPELLIDOSC1DataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSC1DataGridViewTextBoxColumn.Name = "aPELLIDOSC1DataGridViewTextBoxColumn";
            this.aPELLIDOSC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCUMENTOC1DataGridViewTextBoxColumn
            // 
            this.dOCUMENTOC1DataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_C1";
            this.dOCUMENTOC1DataGridViewTextBoxColumn.HeaderText = "DOCUMENTO";
            this.dOCUMENTOC1DataGridViewTextBoxColumn.Name = "dOCUMENTOC1DataGridViewTextBoxColumn";
            this.dOCUMENTOC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONOC1DataGridViewTextBoxColumn
            // 
            this.tELEFONOC1DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO_C1";
            this.tELEFONOC1DataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONOC1DataGridViewTextBoxColumn.Name = "tELEFONOC1DataGridViewTextBoxColumn";
            this.tELEFONOC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONC1DataGridViewTextBoxColumn
            // 
            this.dIRECCIONC1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECCIONC1DataGridViewTextBoxColumn.DataPropertyName = "DIRECCION_C1";
            this.dIRECCIONC1DataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONC1DataGridViewTextBoxColumn.Name = "dIRECCIONC1DataGridViewTextBoxColumn";
            this.dIRECCIONC1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compradorBindingSource
            // 
            this.compradorBindingSource.DataSource = typeof(InterfazEscritorio.Comprador);
            // 
            // FormComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 503);
            this.Controls.Add(this.btnElimC);
            this.Controls.Add(this.btnModiC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvComprador);
            this.Controls.Add(this.btnBusC);
            this.Controls.Add(this.txtBuc_comp);
            this.Name = "FormComprador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComprador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compradorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuc_comp;
        private System.Windows.Forms.Button btnBusC;
        private System.Windows.Forms.DataGridView dgvComprador;
        private System.Windows.Forms.BindingSource compradorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOMPRADOR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREOC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASEÑAC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONOC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpC;
        private System.Windows.Forms.Button btnGuarC;
        private System.Windows.Forms.TextBox txtDireccionC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefonoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidosC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModiC;
        private System.Windows.Forms.Button btnElimC;
        private System.Windows.Forms.TextBox txtIdC;
    }
}

