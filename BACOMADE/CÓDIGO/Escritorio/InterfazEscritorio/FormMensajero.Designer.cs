namespace InterfazEscritorio
{
    partial class FormMensajero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensajero));
            this.txtBusM = new System.Windows.Forms.TextBox();
            this.btnBusM = new System.Windows.Forms.Button();
            this.dgvMensajero = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentoM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.btnLimpM = new System.Windows.Forms.Button();
            this.btnGuarM = new System.Windows.Forms.Button();
            this.btnElimM = new System.Windows.Forms.Button();
            this.btnModiM = new System.Windows.Forms.Button();
            this.iDMENSAJERO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajero)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusM
            // 
            this.txtBusM.Location = new System.Drawing.Point(45, 35);
            this.txtBusM.Name = "txtBusM";
            this.txtBusM.Size = new System.Drawing.Size(187, 20);
            this.txtBusM.TabIndex = 0;
            // 
            // btnBusM
            // 
            this.btnBusM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusM.Location = new System.Drawing.Point(254, 27);
            this.btnBusM.Name = "btnBusM";
            this.btnBusM.Size = new System.Drawing.Size(75, 34);
            this.btnBusM.TabIndex = 1;
            this.btnBusM.Text = "&Buscar";
            this.btnBusM.UseVisualStyleBackColor = false;
            this.btnBusM.Click += new System.EventHandler(this.btnBusM_Click);
            // 
            // dgvMensajero
            // 
            this.dgvMensajero.AllowUserToAddRows = false;
            this.dgvMensajero.AllowUserToDeleteRows = false;
            this.dgvMensajero.AutoGenerateColumns = false;
            this.dgvMensajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMENSAJERO1DataGridViewTextBoxColumn,
            this.nOMBREM1DataGridViewTextBoxColumn,
            this.tELEFONO1DataGridViewTextBoxColumn,
            this.dOCUMENTOM1DataGridViewTextBoxColumn});
            this.dgvMensajero.DataSource = this.mensajeroBindingSource;
            this.dgvMensajero.Location = new System.Drawing.Point(29, 84);
            this.dgvMensajero.Name = "dgvMensajero";
            this.dgvMensajero.ReadOnly = true;
            this.dgvMensajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensajero.Size = new System.Drawing.Size(445, 207);
            this.dgvMensajero.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtIdM);
            this.groupBox1.Controls.Add(this.btnLimpM);
            this.groupBox1.Controls.Add(this.btnGuarM);
            this.groupBox1.Controls.Add(this.txtDocumentoM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(501, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del mensajero";
            // 
            // txtDocumentoM
            // 
            this.txtDocumentoM.Location = new System.Drawing.Point(111, 121);
            this.txtDocumentoM.Name = "txtDocumentoM";
            this.txtDocumentoM.Size = new System.Drawing.Size(158, 22);
            this.txtDocumentoM.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Documento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(111, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(158, 22);
            this.txtTelefono.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Teléfono";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(111, 42);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(158, 22);
            this.txtNombreM.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre";
            // 
            // txtIdM
            // 
            this.txtIdM.Location = new System.Drawing.Point(27, 151);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(95, 22);
            this.txtIdM.TabIndex = 28;
            this.txtIdM.Visible = false;
            // 
            // btnLimpM
            // 
            this.btnLimpM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpM.Location = new System.Drawing.Point(173, 179);
            this.btnLimpM.Name = "btnLimpM";
            this.btnLimpM.Size = new System.Drawing.Size(84, 42);
            this.btnLimpM.TabIndex = 27;
            this.btnLimpM.Text = "&Limpiar";
            this.btnLimpM.UseVisualStyleBackColor = false;
            this.btnLimpM.Click += new System.EventHandler(this.btnLimpM_Click);
            // 
            // btnGuarM
            // 
            this.btnGuarM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarM.Location = new System.Drawing.Point(27, 179);
            this.btnGuarM.Name = "btnGuarM";
            this.btnGuarM.Size = new System.Drawing.Size(84, 42);
            this.btnGuarM.TabIndex = 26;
            this.btnGuarM.Text = "&Guardar";
            this.btnGuarM.UseVisualStyleBackColor = false;
            this.btnGuarM.Click += new System.EventHandler(this.btnGuarM_Click);
            // 
            // btnElimM
            // 
            this.btnElimM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimM.Location = new System.Drawing.Point(278, 308);
            this.btnElimM.Name = "btnElimM";
            this.btnElimM.Size = new System.Drawing.Size(84, 42);
            this.btnElimM.TabIndex = 18;
            this.btnElimM.Text = "&Eliminar";
            this.btnElimM.UseVisualStyleBackColor = false;
            this.btnElimM.Click += new System.EventHandler(this.btnElimM_Click);
            // 
            // btnModiM
            // 
            this.btnModiM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiM.Location = new System.Drawing.Point(130, 308);
            this.btnModiM.Name = "btnModiM";
            this.btnModiM.Size = new System.Drawing.Size(84, 42);
            this.btnModiM.TabIndex = 17;
            this.btnModiM.Text = "&Modificar";
            this.btnModiM.UseVisualStyleBackColor = false;
            this.btnModiM.Click += new System.EventHandler(this.btnModiM_Click);
            // 
            // iDMENSAJERO1DataGridViewTextBoxColumn
            // 
            this.iDMENSAJERO1DataGridViewTextBoxColumn.DataPropertyName = "ID_MENSAJERO1";
            this.iDMENSAJERO1DataGridViewTextBoxColumn.HeaderText = "ID_MENSAJERO1";
            this.iDMENSAJERO1DataGridViewTextBoxColumn.Name = "iDMENSAJERO1DataGridViewTextBoxColumn";
            this.iDMENSAJERO1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMENSAJERO1DataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREM1DataGridViewTextBoxColumn
            // 
            this.nOMBREM1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREM1DataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_M1";
            this.nOMBREM1DataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREM1DataGridViewTextBoxColumn.Name = "nOMBREM1DataGridViewTextBoxColumn";
            this.nOMBREM1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONO1DataGridViewTextBoxColumn
            // 
            this.tELEFONO1DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO1";
            this.tELEFONO1DataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONO1DataGridViewTextBoxColumn.Name = "tELEFONO1DataGridViewTextBoxColumn";
            this.tELEFONO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCUMENTOM1DataGridViewTextBoxColumn
            // 
            this.dOCUMENTOM1DataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_M1";
            this.dOCUMENTOM1DataGridViewTextBoxColumn.HeaderText = "DOCUMENTO";
            this.dOCUMENTOM1DataGridViewTextBoxColumn.Name = "dOCUMENTOM1DataGridViewTextBoxColumn";
            this.dOCUMENTOM1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mensajeroBindingSource
            // 
            this.mensajeroBindingSource.DataSource = typeof(InterfazEscritorio.Mensajero);
            // 
            // FormMensajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.btnElimM);
            this.Controls.Add(this.btnModiM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMensajero);
            this.Controls.Add(this.btnBusM);
            this.Controls.Add(this.txtBusM);
            this.Name = "FormMensajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMensajero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusM;
        private System.Windows.Forms.Button btnBusM;
        private System.Windows.Forms.DataGridView dgvMensajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDocumentoM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.Button btnLimpM;
        private System.Windows.Forms.Button btnGuarM;
        private System.Windows.Forms.Button btnElimM;
        private System.Windows.Forms.Button btnModiM;
        private System.Windows.Forms.BindingSource mensajeroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMENSAJERO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOM1DataGridViewTextBoxColumn;
    }
}