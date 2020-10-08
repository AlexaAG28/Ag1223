namespace InterfazEscritorio
{
    partial class FormEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnvio));
            this.txtBusE = new System.Windows.Forms.TextBox();
            this.btnBusE = new System.Windows.Forms.Button();
            this.dgvEnvio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpE = new System.Windows.Forms.Button();
            this.btnGuarE = new System.Windows.Forms.Button();
            this.txtIdE = new System.Windows.Forms.TextBox();
            this.txtFechaE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimE = new System.Windows.Forms.Button();
            this.btnModiE = new System.Windows.Forms.Button();
            this.iDENVIO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAENVIO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.envioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusE
            // 
            this.txtBusE.Location = new System.Drawing.Point(55, 34);
            this.txtBusE.Name = "txtBusE";
            this.txtBusE.Size = new System.Drawing.Size(165, 20);
            this.txtBusE.TabIndex = 0;
            // 
            // btnBusE
            // 
            this.btnBusE.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusE.Location = new System.Drawing.Point(256, 29);
            this.btnBusE.Name = "btnBusE";
            this.btnBusE.Size = new System.Drawing.Size(65, 29);
            this.btnBusE.TabIndex = 1;
            this.btnBusE.Text = "&Buscar";
            this.btnBusE.UseVisualStyleBackColor = false;
            this.btnBusE.Click += new System.EventHandler(this.btnBusE_Click);
            // 
            // dgvEnvio
            // 
            this.dgvEnvio.AllowUserToAddRows = false;
            this.dgvEnvio.AllowUserToDeleteRows = false;
            this.dgvEnvio.AutoGenerateColumns = false;
            this.dgvEnvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDENVIO1DataGridViewTextBoxColumn,
            this.fECHAENVIO1DataGridViewTextBoxColumn});
            this.dgvEnvio.DataSource = this.envioBindingSource;
            this.dgvEnvio.Location = new System.Drawing.Point(72, 84);
            this.dgvEnvio.Name = "dgvEnvio";
            this.dgvEnvio.ReadOnly = true;
            this.dgvEnvio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnvio.Size = new System.Drawing.Size(144, 179);
            this.dgvEnvio.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpE);
            this.groupBox1.Controls.Add(this.btnGuarE);
            this.groupBox1.Controls.Add(this.txtIdE);
            this.groupBox1.Controls.Add(this.txtFechaE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(256, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del envío";
            // 
            // btnLimpE
            // 
            this.btnLimpE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpE.Location = new System.Drawing.Point(142, 118);
            this.btnLimpE.Name = "btnLimpE";
            this.btnLimpE.Size = new System.Drawing.Size(76, 35);
            this.btnLimpE.TabIndex = 11;
            this.btnLimpE.Text = "&Limpiar";
            this.btnLimpE.UseVisualStyleBackColor = false;
            this.btnLimpE.Click += new System.EventHandler(this.btnLimpE_Click);
            // 
            // btnGuarE
            // 
            this.btnGuarE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuarE.Location = new System.Drawing.Point(40, 118);
            this.btnGuarE.Name = "btnGuarE";
            this.btnGuarE.Size = new System.Drawing.Size(76, 35);
            this.btnGuarE.TabIndex = 10;
            this.btnGuarE.Text = "&Guardar";
            this.btnGuarE.UseVisualStyleBackColor = false;
            this.btnGuarE.Click += new System.EventHandler(this.btnGuarE_Click);
            // 
            // txtIdE
            // 
            this.txtIdE.Location = new System.Drawing.Point(25, 86);
            this.txtIdE.Name = "txtIdE";
            this.txtIdE.Size = new System.Drawing.Size(105, 22);
            this.txtIdE.TabIndex = 5;
            this.txtIdE.Visible = false;
            // 
            // txtFechaE
            // 
            this.txtFechaE.Location = new System.Drawing.Point(142, 49);
            this.txtFechaE.Name = "txtFechaE";
            this.txtFechaE.Size = new System.Drawing.Size(105, 22);
            this.txtFechaE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del envío";
            // 
            // btnElimE
            // 
            this.btnElimE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimE.Location = new System.Drawing.Point(156, 289);
            this.btnElimE.Name = "btnElimE";
            this.btnElimE.Size = new System.Drawing.Size(76, 35);
            this.btnElimE.TabIndex = 13;
            this.btnElimE.Text = "&Eliminar";
            this.btnElimE.UseVisualStyleBackColor = false;
            this.btnElimE.Click += new System.EventHandler(this.btnElimE_Click);
            // 
            // btnModiE
            // 
            this.btnModiE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiE.Location = new System.Drawing.Point(54, 289);
            this.btnModiE.Name = "btnModiE";
            this.btnModiE.Size = new System.Drawing.Size(76, 35);
            this.btnModiE.TabIndex = 12;
            this.btnModiE.Text = "&Modificar";
            this.btnModiE.UseVisualStyleBackColor = false;
            this.btnModiE.Click += new System.EventHandler(this.btnModiE_Click);
            // 
            // iDENVIO1DataGridViewTextBoxColumn
            // 
            this.iDENVIO1DataGridViewTextBoxColumn.DataPropertyName = "ID_ENVIO1";
            this.iDENVIO1DataGridViewTextBoxColumn.HeaderText = "ID_ENVIO1";
            this.iDENVIO1DataGridViewTextBoxColumn.Name = "iDENVIO1DataGridViewTextBoxColumn";
            this.iDENVIO1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDENVIO1DataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAENVIO1DataGridViewTextBoxColumn
            // 
            this.fECHAENVIO1DataGridViewTextBoxColumn.DataPropertyName = "FECHA_ENVIO1";
            this.fECHAENVIO1DataGridViewTextBoxColumn.HeaderText = "FECHA DEL ENVIO";
            this.fECHAENVIO1DataGridViewTextBoxColumn.Name = "fECHAENVIO1DataGridViewTextBoxColumn";
            this.fECHAENVIO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // envioBindingSource
            // 
            this.envioBindingSource.DataSource = typeof(InterfazEscritorio.Envio);
            // 
            // FormEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 336);
            this.Controls.Add(this.btnElimE);
            this.Controls.Add(this.btnModiE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEnvio);
            this.Controls.Add(this.btnBusE);
            this.Controls.Add(this.txtBusE);
            this.Name = "FormEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEnvio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.envioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusE;
        private System.Windows.Forms.Button btnBusE;
        private System.Windows.Forms.DataGridView dgvEnvio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdE;
        private System.Windows.Forms.TextBox txtFechaE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpE;
        private System.Windows.Forms.Button btnGuarE;
        private System.Windows.Forms.Button btnElimE;
        private System.Windows.Forms.Button btnModiE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENVIO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAENVIO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource envioBindingSource;
    }
}