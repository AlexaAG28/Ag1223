namespace InterfazEscritorio
{
    partial class FormFormaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormaPago));
            this.txtBusFP = new System.Windows.Forms.TextBox();
            this.btnBusFP = new System.Windows.Forms.Button();
            this.dgvFormaPago = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreFP = new System.Windows.Forms.TextBox();
            this.btnLimpFP = new System.Windows.Forms.Button();
            this.btnGuarFP = new System.Windows.Forms.Button();
            this.txtIdFP = new System.Windows.Forms.TextBox();
            this.btnElimFP = new System.Windows.Forms.Button();
            this.btnModiFP = new System.Windows.Forms.Button();
            this.iDFORMAP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREFP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALPAGAR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAPAGO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusFP
            // 
            this.txtBusFP.Location = new System.Drawing.Point(50, 31);
            this.txtBusFP.Name = "txtBusFP";
            this.txtBusFP.Size = new System.Drawing.Size(175, 20);
            this.txtBusFP.TabIndex = 0;
            // 
            // btnBusFP
            // 
            this.btnBusFP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBusFP.Location = new System.Drawing.Point(248, 31);
            this.btnBusFP.Name = "btnBusFP";
            this.btnBusFP.Size = new System.Drawing.Size(60, 26);
            this.btnBusFP.TabIndex = 1;
            this.btnBusFP.Text = "&Buscar";
            this.btnBusFP.UseVisualStyleBackColor = false;
            this.btnBusFP.Click += new System.EventHandler(this.btnBusFP_Click);
            // 
            // dgvFormaPago
            // 
            this.dgvFormaPago.AllowUserToAddRows = false;
            this.dgvFormaPago.AllowUserToDeleteRows = false;
            this.dgvFormaPago.AutoGenerateColumns = false;
            this.dgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFORMAP1DataGridViewTextBoxColumn,
            this.nOMBREFP1DataGridViewTextBoxColumn,
            this.tOTALPAGAR1DataGridViewTextBoxColumn,
            this.fECHAPAGO1DataGridViewTextBoxColumn});
            this.dgvFormaPago.DataSource = this.formaPagoBindingSource;
            this.dgvFormaPago.Location = new System.Drawing.Point(50, 82);
            this.dgvFormaPago.Name = "dgvFormaPago";
            this.dgvFormaPago.ReadOnly = true;
            this.dgvFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPago.Size = new System.Drawing.Size(346, 206);
            this.dgvFormaPago.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpFP);
            this.groupBox1.Controls.Add(this.btnGuarFP);
            this.groupBox1.Controls.Add(this.txtIdFP);
            this.groupBox1.Controls.Add(this.txtNombreFP);
            this.groupBox1.Controls.Add(this.txtTotalPagar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFechaPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(433, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos sobre la forma de pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(133, 117);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(105, 22);
            this.txtFechaPago.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha del pago";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(133, 80);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(105, 22);
            this.txtTotalPagar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total a pagar";
            // 
            // txtNombreFP
            // 
            this.txtNombreFP.Location = new System.Drawing.Point(133, 40);
            this.txtNombreFP.Name = "txtNombreFP";
            this.txtNombreFP.Size = new System.Drawing.Size(105, 22);
            this.txtNombreFP.TabIndex = 6;
            // 
            // btnLimpFP
            // 
            this.btnLimpFP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpFP.Location = new System.Drawing.Point(148, 186);
            this.btnLimpFP.Name = "btnLimpFP";
            this.btnLimpFP.Size = new System.Drawing.Size(76, 35);
            this.btnLimpFP.TabIndex = 14;
            this.btnLimpFP.Text = "&Limpiar";
            this.btnLimpFP.UseVisualStyleBackColor = false;
            this.btnLimpFP.Click += new System.EventHandler(this.btnLimpFP_Click);
            // 
            // btnGuarFP
            // 
            this.btnGuarFP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuarFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuarFP.Location = new System.Drawing.Point(46, 186);
            this.btnGuarFP.Name = "btnGuarFP";
            this.btnGuarFP.Size = new System.Drawing.Size(76, 35);
            this.btnGuarFP.TabIndex = 13;
            this.btnGuarFP.Text = "&Guardar";
            this.btnGuarFP.UseVisualStyleBackColor = false;
            this.btnGuarFP.Click += new System.EventHandler(this.btnGuarFP_Click);
            // 
            // txtIdFP
            // 
            this.txtIdFP.Location = new System.Drawing.Point(31, 154);
            this.txtIdFP.Name = "txtIdFP";
            this.txtIdFP.Size = new System.Drawing.Size(105, 22);
            this.txtIdFP.TabIndex = 12;
            this.txtIdFP.Visible = false;
            // 
            // btnElimFP
            // 
            this.btnElimFP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElimFP.Location = new System.Drawing.Point(283, 302);
            this.btnElimFP.Name = "btnElimFP";
            this.btnElimFP.Size = new System.Drawing.Size(76, 35);
            this.btnElimFP.TabIndex = 15;
            this.btnElimFP.Text = "&Eliminar";
            this.btnElimFP.UseVisualStyleBackColor = false;
            this.btnElimFP.Click += new System.EventHandler(this.btnElimFP_Click);
            // 
            // btnModiFP
            // 
            this.btnModiFP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModiFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModiFP.Location = new System.Drawing.Point(181, 302);
            this.btnModiFP.Name = "btnModiFP";
            this.btnModiFP.Size = new System.Drawing.Size(76, 35);
            this.btnModiFP.TabIndex = 14;
            this.btnModiFP.Text = "&Modificar";
            this.btnModiFP.UseVisualStyleBackColor = false;
            this.btnModiFP.Click += new System.EventHandler(this.btnModiFP_Click);
            // 
            // iDFORMAP1DataGridViewTextBoxColumn
            // 
            this.iDFORMAP1DataGridViewTextBoxColumn.DataPropertyName = "ID_FORMA_P1";
            this.iDFORMAP1DataGridViewTextBoxColumn.HeaderText = "ID_FORMA_P1";
            this.iDFORMAP1DataGridViewTextBoxColumn.Name = "iDFORMAP1DataGridViewTextBoxColumn";
            this.iDFORMAP1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFORMAP1DataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREFP1DataGridViewTextBoxColumn
            // 
            this.nOMBREFP1DataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_FP1";
            this.nOMBREFP1DataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREFP1DataGridViewTextBoxColumn.Name = "nOMBREFP1DataGridViewTextBoxColumn";
            this.nOMBREFP1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALPAGAR1DataGridViewTextBoxColumn
            // 
            this.tOTALPAGAR1DataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PAGAR1";
            this.tOTALPAGAR1DataGridViewTextBoxColumn.HeaderText = "TOTAL A PAGAR";
            this.tOTALPAGAR1DataGridViewTextBoxColumn.Name = "tOTALPAGAR1DataGridViewTextBoxColumn";
            this.tOTALPAGAR1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAPAGO1DataGridViewTextBoxColumn
            // 
            this.fECHAPAGO1DataGridViewTextBoxColumn.DataPropertyName = "FECHA_PAGO1";
            this.fECHAPAGO1DataGridViewTextBoxColumn.HeaderText = "FECHA DEL PAGO";
            this.fECHAPAGO1DataGridViewTextBoxColumn.Name = "fECHAPAGO1DataGridViewTextBoxColumn";
            this.fECHAPAGO1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataSource = typeof(InterfazEscritorio.FormaPago);
            // 
            // FormFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 354);
            this.Controls.Add(this.btnElimFP);
            this.Controls.Add(this.btnModiFP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFormaPago);
            this.Controls.Add(this.btnBusFP);
            this.Controls.Add(this.txtBusFP);
            this.Name = "FormFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFormaPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusFP;
        private System.Windows.Forms.Button btnBusFP;
        private System.Windows.Forms.DataGridView dgvFormaPago;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreFP;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpFP;
        private System.Windows.Forms.Button btnGuarFP;
        private System.Windows.Forms.TextBox txtIdFP;
        private System.Windows.Forms.Button btnElimFP;
        private System.Windows.Forms.Button btnModiFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFORMAP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREFP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALPAGAR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAPAGO1DataGridViewTextBoxColumn;
    }
}