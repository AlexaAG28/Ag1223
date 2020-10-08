namespace InterfazEscritorio
{
    partial class FormPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartida));
            this.txtBusP = new System.Windows.Forms.TextBox();
            this.btnBusP = new System.Windows.Forms.Button();
            this.dgvPartida = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpP = new System.Windows.Forms.Button();
            this.btnGuarP = new System.Windows.Forms.Button();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.txtCostoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaCreada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimP = new System.Windows.Forms.Button();
            this.btnModiP = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.iDPARTIDA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREADA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartida)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusP
            // 
            this.txtBusP.Location = new System.Drawing.Point(59, 41);
            this.txtBusP.Name = "txtBusP";
            this.txtBusP.Size = new System.Drawing.Size(166, 20);
            this.txtBusP.TabIndex = 0;
            // 
            // btnBusP
            // 
            this.btnBusP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusP.Location = new System.Drawing.Point(256, 35);
            this.btnBusP.Name = "btnBusP";
            this.btnBusP.Size = new System.Drawing.Size(62, 30);
            this.btnBusP.TabIndex = 1;
            this.btnBusP.Text = "&Buscar";
            this.btnBusP.UseVisualStyleBackColor = false;
            this.btnBusP.Click += new System.EventHandler(this.btnBusP_Click);
            // 
            // dgvPartida
            // 
            this.dgvPartida.AllowUserToAddRows = false;
            this.dgvPartida.AllowUserToDeleteRows = false;
            this.dgvPartida.AutoGenerateColumns = false;
            this.dgvPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPARTIDA1DataGridViewTextBoxColumn,
            this.tIPO1DataGridViewTextBoxColumn,
            this.fECHACREADA1DataGridViewTextBoxColumn,
            this.cOSTO1DataGridViewTextBoxColumn});
            this.dgvPartida.DataSource = this.partidaBindingSource;
            this.dgvPartida.Location = new System.Drawing.Point(41, 78);
            this.dgvPartida.Name = "dgvPartida";
            this.dgvPartida.ReadOnly = true;
            this.dgvPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartida.Size = new System.Drawing.Size(348, 207);
            this.dgvPartida.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.btnLimpP);
            this.groupBox1.Controls.Add(this.btnGuarP);
            this.groupBox1.Controls.Add(this.txtIdP);
            this.groupBox1.Controls.Add(this.txtCostoP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFechaCreada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(416, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos sobre la partida";
            // 
            // btnLimpP
            // 
            this.btnLimpP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpP.Location = new System.Drawing.Point(161, 199);
            this.btnLimpP.Name = "btnLimpP";
            this.btnLimpP.Size = new System.Drawing.Size(76, 35);
            this.btnLimpP.TabIndex = 18;
            this.btnLimpP.Text = "&Limpiar";
            this.btnLimpP.UseVisualStyleBackColor = false;
            this.btnLimpP.Click += new System.EventHandler(this.btnLimpP_Click);
            // 
            // btnGuarP
            // 
            this.btnGuarP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarP.Location = new System.Drawing.Point(59, 199);
            this.btnGuarP.Name = "btnGuarP";
            this.btnGuarP.Size = new System.Drawing.Size(76, 35);
            this.btnGuarP.TabIndex = 17;
            this.btnGuarP.Text = "&Guardar";
            this.btnGuarP.UseVisualStyleBackColor = false;
            this.btnGuarP.Click += new System.EventHandler(this.btnGuarP_Click);
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(59, 171);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(75, 22);
            this.txtIdP.TabIndex = 16;
            this.txtIdP.Visible = false;
            // 
            // txtCostoP
            // 
            this.txtCostoP.Location = new System.Drawing.Point(118, 141);
            this.txtCostoP.Name = "txtCostoP";
            this.txtCostoP.Size = new System.Drawing.Size(150, 22);
            this.txtCostoP.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Costo";
            // 
            // txtFechaCreada
            // 
            this.txtFechaCreada.Location = new System.Drawing.Point(118, 104);
            this.txtFechaCreada.Name = "txtFechaCreada";
            this.txtFechaCreada.Size = new System.Drawing.Size(150, 22);
            this.txtFechaCreada.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha creada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo";
            // 
            // btnElimP
            // 
            this.btnElimP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimP.Location = new System.Drawing.Point(231, 291);
            this.btnElimP.Name = "btnElimP";
            this.btnElimP.Size = new System.Drawing.Size(76, 35);
            this.btnElimP.TabIndex = 13;
            this.btnElimP.Text = "&Eliminar";
            this.btnElimP.UseVisualStyleBackColor = false;
            this.btnElimP.Click += new System.EventHandler(this.btnElimP_Click);
            // 
            // btnModiP
            // 
            this.btnModiP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiP.Location = new System.Drawing.Point(129, 291);
            this.btnModiP.Name = "btnModiP";
            this.btnModiP.Size = new System.Drawing.Size(76, 35);
            this.btnModiP.TabIndex = 12;
            this.btnModiP.Text = "&Modificar";
            this.btnModiP.UseVisualStyleBackColor = false;
            this.btnModiP.Click += new System.EventHandler(this.btnModiP_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(118, 66);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(150, 22);
            this.txtTipo.TabIndex = 19;
            // 
            // iDPARTIDA1DataGridViewTextBoxColumn
            // 
            this.iDPARTIDA1DataGridViewTextBoxColumn.DataPropertyName = "ID_PARTIDA1";
            this.iDPARTIDA1DataGridViewTextBoxColumn.HeaderText = "ID_PARTIDA1";
            this.iDPARTIDA1DataGridViewTextBoxColumn.Name = "iDPARTIDA1DataGridViewTextBoxColumn";
            this.iDPARTIDA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPARTIDA1DataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPO1DataGridViewTextBoxColumn
            // 
            this.tIPO1DataGridViewTextBoxColumn.DataPropertyName = "TIPO1";
            this.tIPO1DataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPO1DataGridViewTextBoxColumn.Name = "tIPO1DataGridViewTextBoxColumn";
            this.tIPO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHACREADA1DataGridViewTextBoxColumn
            // 
            this.fECHACREADA1DataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREADA1";
            this.fECHACREADA1DataGridViewTextBoxColumn.HeaderText = "FECHA CREADA";
            this.fECHACREADA1DataGridViewTextBoxColumn.Name = "fECHACREADA1DataGridViewTextBoxColumn";
            this.fECHACREADA1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOSTO1DataGridViewTextBoxColumn
            // 
            this.cOSTO1DataGridViewTextBoxColumn.DataPropertyName = "COSTO1";
            this.cOSTO1DataGridViewTextBoxColumn.HeaderText = "COSTO";
            this.cOSTO1DataGridViewTextBoxColumn.Name = "cOSTO1DataGridViewTextBoxColumn";
            this.cOSTO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(InterfazEscritorio.Partida);
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 349);
            this.Controls.Add(this.btnElimP);
            this.Controls.Add(this.btnModiP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPartida);
            this.Controls.Add(this.btnBusP);
            this.Controls.Add(this.txtBusP);
            this.Name = "FormPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPartida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusP;
        private System.Windows.Forms.Button btnBusP;
        private System.Windows.Forms.DataGridView dgvPartida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpP;
        private System.Windows.Forms.Button btnGuarP;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.TextBox txtCostoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaCreada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimP;
        private System.Windows.Forms.Button btnModiP;
        private System.Windows.Forms.BindingSource partidaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPARTIDA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREADA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTipo;
    }
}