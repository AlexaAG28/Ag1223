namespace InterfazEscritorio
{
    partial class FormMenú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenú));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.envíoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compradorToolStripMenuItem,
            this.secretariaToolStripMenuItem,
            this.partidaToolStripMenuItem,
            this.partidaToolStripMenuItem1,
            this.envíoToolStripMenuItem,
            this.formaDePagoToolStripMenuItem,
            this.mensajeroToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.menúToolStripMenuItem.Text = "Información";
            // 
            // compradorToolStripMenuItem
            // 
            this.compradorToolStripMenuItem.Name = "compradorToolStripMenuItem";
            this.compradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compradorToolStripMenuItem.Text = "Comprador";
            this.compradorToolStripMenuItem.Click += new System.EventHandler(this.compradorToolStripMenuItem_Click);
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secretariaToolStripMenuItem.Text = "Secretaria";
            this.secretariaToolStripMenuItem.Click += new System.EventHandler(this.secretariaToolStripMenuItem_Click);
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partidaToolStripMenuItem.Text = "Iglesia";
            this.partidaToolStripMenuItem.Click += new System.EventHandler(this.partidaToolStripMenuItem_Click);
            // 
            // partidaToolStripMenuItem1
            // 
            this.partidaToolStripMenuItem1.Name = "partidaToolStripMenuItem1";
            this.partidaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.partidaToolStripMenuItem1.Text = "Partida";
            this.partidaToolStripMenuItem1.Click += new System.EventHandler(this.partidaToolStripMenuItem1_Click);
            // 
            // envíoToolStripMenuItem
            // 
            this.envíoToolStripMenuItem.Name = "envíoToolStripMenuItem";
            this.envíoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.envíoToolStripMenuItem.Text = "Envío";
            this.envíoToolStripMenuItem.Click += new System.EventHandler(this.envíoToolStripMenuItem_Click);
            // 
            // formaDePagoToolStripMenuItem
            // 
            this.formaDePagoToolStripMenuItem.Name = "formaDePagoToolStripMenuItem";
            this.formaDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formaDePagoToolStripMenuItem.Text = "Forma de pago";
            this.formaDePagoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagoToolStripMenuItem_Click);
            // 
            // mensajeroToolStripMenuItem
            // 
            this.mensajeroToolStripMenuItem.Name = "mensajeroToolStripMenuItem";
            this.mensajeroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensajeroToolStripMenuItem.Text = "Mensajero";
            this.mensajeroToolStripMenuItem.Click += new System.EventHandler(this.mensajeroToolStripMenuItem_Click);
            // 
            // FormMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1311, 547);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem envíoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeroToolStripMenuItem;
    }
}