namespace InterfazEscritorio
{
    partial class FormSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretaria));
            this.txtBusS = new System.Windows.Forms.TextBox();
            this.btnBusS = new System.Windows.Forms.Button();
            this.dgvSecretaria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentoS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidosS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdS = new System.Windows.Forms.TextBox();
            this.btnLimpS = new System.Windows.Forms.Button();
            this.btnGuarS = new System.Windows.Forms.Button();
            this.btnElimS = new System.Windows.Forms.Button();
            this.btnModiS = new System.Windows.Forms.Button();
            this.iDSECRETARIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREOS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASEÑAS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRES1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusS
            // 
            this.txtBusS.Location = new System.Drawing.Point(61, 34);
            this.txtBusS.Name = "txtBusS";
            this.txtBusS.Size = new System.Drawing.Size(187, 20);
            this.txtBusS.TabIndex = 0;
            // 
            // btnBusS
            // 
            this.btnBusS.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusS.Location = new System.Drawing.Point(278, 29);
            this.btnBusS.Name = "btnBusS";
            this.btnBusS.Size = new System.Drawing.Size(63, 28);
            this.btnBusS.TabIndex = 1;
            this.btnBusS.Text = "&Buscar";
            this.btnBusS.UseVisualStyleBackColor = false;
            this.btnBusS.Click += new System.EventHandler(this.btnBusS_Click);
            // 
            // dgvSecretaria
            // 
            this.dgvSecretaria.AllowUserToAddRows = false;
            this.dgvSecretaria.AllowUserToDeleteRows = false;
            this.dgvSecretaria.AutoGenerateColumns = false;
            this.dgvSecretaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecretaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSECRETARIA1DataGridViewTextBoxColumn,
            this.cORREOS1DataGridViewTextBoxColumn,
            this.cONTRASEÑAS1DataGridViewTextBoxColumn,
            this.nOMBRES1DataGridViewTextBoxColumn,
            this.aPELLIDOSS1DataGridViewTextBoxColumn,
            this.dOCUMENTOS1DataGridViewTextBoxColumn});
            this.dgvSecretaria.DataSource = this.secretariaBindingSource;
            this.dgvSecretaria.Location = new System.Drawing.Point(26, 82);
            this.dgvSecretaria.Name = "dgvSecretaria";
            this.dgvSecretaria.ReadOnly = true;
            this.dgvSecretaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecretaria.Size = new System.Drawing.Size(680, 264);
            this.dgvSecretaria.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtIdS);
            this.groupBox1.Controls.Add(this.btnLimpS);
            this.groupBox1.Controls.Add(this.btnGuarS);
            this.groupBox1.Controls.Add(this.txtDocumentoS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidosS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContraseñaS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCorreoS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(737, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la secretaria";
            // 
            // txtDocumentoS
            // 
            this.txtDocumentoS.Location = new System.Drawing.Point(123, 205);
            this.txtDocumentoS.Name = "txtDocumentoS";
            this.txtDocumentoS.Size = new System.Drawing.Size(158, 22);
            this.txtDocumentoS.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Documento";
            // 
            // txtApellidosS
            // 
            this.txtApellidosS.Location = new System.Drawing.Point(123, 165);
            this.txtApellidosS.Name = "txtApellidosS";
            this.txtApellidosS.Size = new System.Drawing.Size(158, 22);
            this.txtApellidosS.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Apellidos";
            // 
            // txtNombreS
            // 
            this.txtNombreS.Location = new System.Drawing.Point(123, 126);
            this.txtNombreS.Name = "txtNombreS";
            this.txtNombreS.Size = new System.Drawing.Size(158, 22);
            this.txtNombreS.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // txtContraseñaS
            // 
            this.txtContraseñaS.Location = new System.Drawing.Point(123, 82);
            this.txtContraseñaS.Name = "txtContraseñaS";
            this.txtContraseñaS.Size = new System.Drawing.Size(158, 22);
            this.txtContraseñaS.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // txtCorreoS
            // 
            this.txtCorreoS.Location = new System.Drawing.Point(123, 42);
            this.txtCorreoS.Name = "txtCorreoS";
            this.txtCorreoS.Size = new System.Drawing.Size(158, 22);
            this.txtCorreoS.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // txtIdS
            // 
            this.txtIdS.Location = new System.Drawing.Point(36, 236);
            this.txtIdS.Name = "txtIdS";
            this.txtIdS.Size = new System.Drawing.Size(95, 22);
            this.txtIdS.TabIndex = 22;
            this.txtIdS.Visible = false;
            // 
            // btnLimpS
            // 
            this.btnLimpS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpS.Location = new System.Drawing.Point(182, 264);
            this.btnLimpS.Name = "btnLimpS";
            this.btnLimpS.Size = new System.Drawing.Size(84, 42);
            this.btnLimpS.TabIndex = 21;
            this.btnLimpS.Text = "&Limpiar";
            this.btnLimpS.UseVisualStyleBackColor = false;
            this.btnLimpS.Click += new System.EventHandler(this.btnLimpS_Click);
            // 
            // btnGuarS
            // 
            this.btnGuarS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarS.Location = new System.Drawing.Point(36, 264);
            this.btnGuarS.Name = "btnGuarS";
            this.btnGuarS.Size = new System.Drawing.Size(84, 42);
            this.btnGuarS.TabIndex = 20;
            this.btnGuarS.Text = "&Guardar";
            this.btnGuarS.UseVisualStyleBackColor = false;
            this.btnGuarS.Click += new System.EventHandler(this.btnGuarS_Click);
            // 
            // btnElimS
            // 
            this.btnElimS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimS.Location = new System.Drawing.Point(405, 374);
            this.btnElimS.Name = "btnElimS";
            this.btnElimS.Size = new System.Drawing.Size(84, 42);
            this.btnElimS.TabIndex = 18;
            this.btnElimS.Text = "&Eliminar";
            this.btnElimS.UseVisualStyleBackColor = false;
            this.btnElimS.Click += new System.EventHandler(this.btnElimS_Click);
            // 
            // btnModiS
            // 
            this.btnModiS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiS.Location = new System.Drawing.Point(257, 374);
            this.btnModiS.Name = "btnModiS";
            this.btnModiS.Size = new System.Drawing.Size(84, 42);
            this.btnModiS.TabIndex = 17;
            this.btnModiS.Text = "&Modificar";
            this.btnModiS.UseVisualStyleBackColor = false;
            this.btnModiS.Click += new System.EventHandler(this.btnModiS_Click);
            // 
            // iDSECRETARIA1DataGridViewTextBoxColumn
            // 
            this.iDSECRETARIA1DataGridViewTextBoxColumn.DataPropertyName = "ID_SECRETARIA1";
            this.iDSECRETARIA1DataGridViewTextBoxColumn.HeaderText = "ID_SECRETARIA1";
            this.iDSECRETARIA1DataGridViewTextBoxColumn.Name = "iDSECRETARIA1DataGridViewTextBoxColumn";
            this.iDSECRETARIA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSECRETARIA1DataGridViewTextBoxColumn.Visible = false;
            // 
            // cORREOS1DataGridViewTextBoxColumn
            // 
            this.cORREOS1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cORREOS1DataGridViewTextBoxColumn.DataPropertyName = "CORREO_S1";
            this.cORREOS1DataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREOS1DataGridViewTextBoxColumn.Name = "cORREOS1DataGridViewTextBoxColumn";
            this.cORREOS1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTRASEÑAS1DataGridViewTextBoxColumn
            // 
            this.cONTRASEÑAS1DataGridViewTextBoxColumn.DataPropertyName = "CONTRASEÑA_S1";
            this.cONTRASEÑAS1DataGridViewTextBoxColumn.HeaderText = "CONTRASEÑA";
            this.cONTRASEÑAS1DataGridViewTextBoxColumn.Name = "cONTRASEÑAS1DataGridViewTextBoxColumn";
            this.cONTRASEÑAS1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRES1DataGridViewTextBoxColumn
            // 
            this.nOMBRES1DataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_S1";
            this.nOMBRES1DataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBRES1DataGridViewTextBoxColumn.Name = "nOMBRES1DataGridViewTextBoxColumn";
            this.nOMBRES1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDOSS1DataGridViewTextBoxColumn
            // 
            this.aPELLIDOSS1DataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS_S1";
            this.aPELLIDOSS1DataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSS1DataGridViewTextBoxColumn.Name = "aPELLIDOSS1DataGridViewTextBoxColumn";
            this.aPELLIDOSS1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCUMENTOS1DataGridViewTextBoxColumn
            // 
            this.dOCUMENTOS1DataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_S1";
            this.dOCUMENTOS1DataGridViewTextBoxColumn.HeaderText = "DOCUMENTO";
            this.dOCUMENTOS1DataGridViewTextBoxColumn.Name = "dOCUMENTOS1DataGridViewTextBoxColumn";
            this.dOCUMENTOS1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secretariaBindingSource
            // 
            this.secretariaBindingSource.DataSource = typeof(InterfazEscritorio.Secretaria);
            // 
            // FormSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.btnElimS);
            this.Controls.Add(this.btnModiS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSecretaria);
            this.Controls.Add(this.btnBusS);
            this.Controls.Add(this.txtBusS);
            this.Name = "FormSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSecretaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretariaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusS;
        private System.Windows.Forms.Button btnBusS;
        private System.Windows.Forms.DataGridView dgvSecretaria;
        private System.Windows.Forms.BindingSource secretariaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSECRETARIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREOS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASEÑAS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRES1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDocumentoS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidosS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdS;
        private System.Windows.Forms.Button btnLimpS;
        private System.Windows.Forms.Button btnGuarS;
        private System.Windows.Forms.Button btnElimS;
        private System.Windows.Forms.Button btnModiS;
    }
}