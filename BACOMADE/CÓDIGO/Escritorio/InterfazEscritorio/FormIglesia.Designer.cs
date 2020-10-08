namespace InterfazEscritorio
{
    partial class FormIglesia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIglesia));
            this.txtBusI = new System.Windows.Forms.TextBox();
            this.btnBusI = new System.Windows.Forms.Button();
            this.dgvIglesia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpI = new System.Windows.Forms.Button();
            this.btnGuarI = new System.Windows.Forms.Button();
            this.txtIdI = new System.Windows.Forms.TextBox();
            this.txtDireccionI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimI = new System.Windows.Forms.Button();
            this.btnModiI = new System.Windows.Forms.Button();
            this.iDIGLESIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREI1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUNICIPIO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONI1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iglesiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIglesia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iglesiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusI
            // 
            this.txtBusI.Location = new System.Drawing.Point(59, 39);
            this.txtBusI.Name = "txtBusI";
            this.txtBusI.Size = new System.Drawing.Size(166, 20);
            this.txtBusI.TabIndex = 0;
            // 
            // btnBusI
            // 
            this.btnBusI.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusI.Location = new System.Drawing.Point(252, 31);
            this.btnBusI.Name = "btnBusI";
            this.btnBusI.Size = new System.Drawing.Size(75, 34);
            this.btnBusI.TabIndex = 1;
            this.btnBusI.Text = "&Buscar";
            this.btnBusI.UseVisualStyleBackColor = false;
            this.btnBusI.Click += new System.EventHandler(this.btnBusI_Click);
            // 
            // dgvIglesia
            // 
            this.dgvIglesia.AllowUserToAddRows = false;
            this.dgvIglesia.AllowUserToDeleteRows = false;
            this.dgvIglesia.AutoGenerateColumns = false;
            this.dgvIglesia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIglesia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDIGLESIA1DataGridViewTextBoxColumn,
            this.nOMBREI1DataGridViewTextBoxColumn,
            this.mUNICIPIO1DataGridViewTextBoxColumn,
            this.dIRECCIONI1DataGridViewTextBoxColumn});
            this.dgvIglesia.DataSource = this.iglesiaBindingSource;
            this.dgvIglesia.Location = new System.Drawing.Point(38, 86);
            this.dgvIglesia.Name = "dgvIglesia";
            this.dgvIglesia.ReadOnly = true;
            this.dgvIglesia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIglesia.Size = new System.Drawing.Size(416, 214);
            this.dgvIglesia.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpI);
            this.groupBox1.Controls.Add(this.btnGuarI);
            this.groupBox1.Controls.Add(this.txtIdI);
            this.groupBox1.Controls.Add(this.txtDireccionI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(498, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la iglesia";
            // 
            // btnLimpI
            // 
            this.btnLimpI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpI.Location = new System.Drawing.Point(164, 206);
            this.btnLimpI.Name = "btnLimpI";
            this.btnLimpI.Size = new System.Drawing.Size(76, 35);
            this.btnLimpI.TabIndex = 9;
            this.btnLimpI.Text = "&Limpiar";
            this.btnLimpI.UseVisualStyleBackColor = false;
            this.btnLimpI.Click += new System.EventHandler(this.btnLimpI_Click);
            // 
            // btnGuarI
            // 
            this.btnGuarI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuarI.Location = new System.Drawing.Point(62, 206);
            this.btnGuarI.Name = "btnGuarI";
            this.btnGuarI.Size = new System.Drawing.Size(76, 35);
            this.btnGuarI.TabIndex = 8;
            this.btnGuarI.Text = "&Guardar";
            this.btnGuarI.UseVisualStyleBackColor = false;
            this.btnGuarI.Click += new System.EventHandler(this.btnGuarI_Click);
            // 
            // txtIdI
            // 
            this.txtIdI.Location = new System.Drawing.Point(31, 163);
            this.txtIdI.Name = "txtIdI";
            this.txtIdI.Size = new System.Drawing.Size(75, 22);
            this.txtIdI.TabIndex = 7;
            this.txtIdI.Visible = false;
            // 
            // txtDireccionI
            // 
            this.txtDireccionI.Location = new System.Drawing.Point(109, 122);
            this.txtDireccionI.Name = "txtDireccionI";
            this.txtDireccionI.Size = new System.Drawing.Size(150, 22);
            this.txtDireccionI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(109, 85);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(150, 22);
            this.txtMunicipio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Municipio";
            // 
            // txtNombreI
            // 
            this.txtNombreI.Location = new System.Drawing.Point(109, 47);
            this.txtNombreI.Name = "txtNombreI";
            this.txtNombreI.Size = new System.Drawing.Size(150, 22);
            this.txtNombreI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnElimI
            // 
            this.btnElimI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimI.Location = new System.Drawing.Point(252, 327);
            this.btnElimI.Name = "btnElimI";
            this.btnElimI.Size = new System.Drawing.Size(76, 35);
            this.btnElimI.TabIndex = 11;
            this.btnElimI.Text = "&Eliminar";
            this.btnElimI.UseVisualStyleBackColor = false;
            this.btnElimI.Click += new System.EventHandler(this.btnElimI_Click);
            // 
            // btnModiI
            // 
            this.btnModiI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiI.Location = new System.Drawing.Point(150, 327);
            this.btnModiI.Name = "btnModiI";
            this.btnModiI.Size = new System.Drawing.Size(76, 35);
            this.btnModiI.TabIndex = 10;
            this.btnModiI.Text = "&Modificar";
            this.btnModiI.UseVisualStyleBackColor = false;
            this.btnModiI.Click += new System.EventHandler(this.btnModiI_Click);
            // 
            // iDIGLESIA1DataGridViewTextBoxColumn
            // 
            this.iDIGLESIA1DataGridViewTextBoxColumn.DataPropertyName = "ID_IGLESIA1";
            this.iDIGLESIA1DataGridViewTextBoxColumn.HeaderText = "ID_IGLESIA1";
            this.iDIGLESIA1DataGridViewTextBoxColumn.Name = "iDIGLESIA1DataGridViewTextBoxColumn";
            this.iDIGLESIA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIGLESIA1DataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREI1DataGridViewTextBoxColumn
            // 
            this.nOMBREI1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREI1DataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_I1";
            this.nOMBREI1DataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREI1DataGridViewTextBoxColumn.Name = "nOMBREI1DataGridViewTextBoxColumn";
            this.nOMBREI1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mUNICIPIO1DataGridViewTextBoxColumn
            // 
            this.mUNICIPIO1DataGridViewTextBoxColumn.DataPropertyName = "MUNICIPIO1";
            this.mUNICIPIO1DataGridViewTextBoxColumn.HeaderText = "MUNICIPIO";
            this.mUNICIPIO1DataGridViewTextBoxColumn.Name = "mUNICIPIO1DataGridViewTextBoxColumn";
            this.mUNICIPIO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONI1DataGridViewTextBoxColumn
            // 
            this.dIRECCIONI1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECCIONI1DataGridViewTextBoxColumn.DataPropertyName = "DIRECCION_I1";
            this.dIRECCIONI1DataGridViewTextBoxColumn.HeaderText = "DIRECCIÓN";
            this.dIRECCIONI1DataGridViewTextBoxColumn.Name = "dIRECCIONI1DataGridViewTextBoxColumn";
            this.dIRECCIONI1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iglesiaBindingSource
            // 
            this.iglesiaBindingSource.DataSource = typeof(InterfazEscritorio.Iglesia);
            // 
            // FormIglesia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 383);
            this.Controls.Add(this.btnElimI);
            this.Controls.Add(this.btnModiI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIglesia);
            this.Controls.Add(this.btnBusI);
            this.Controls.Add(this.txtBusI);
            this.Name = "FormIglesia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIglesia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIglesia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iglesiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusI;
        private System.Windows.Forms.Button btnBusI;
        private System.Windows.Forms.DataGridView dgvIglesia;
        private System.Windows.Forms.BindingSource iglesiaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDIGLESIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREI1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUNICIPIO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONI1DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpI;
        private System.Windows.Forms.Button btnGuarI;
        private System.Windows.Forms.TextBox txtIdI;
        private System.Windows.Forms.TextBox txtDireccionI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElimI;
        private System.Windows.Forms.Button btnModiI;
    }
}