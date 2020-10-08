using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEscritorio
{
    public partial class FormMenú : Form
    {
        public FormMenú()
        {
            InitializeComponent();
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComprador frmC = new FormComprador();
            frmC.Show();
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormaPago frmFP = new FormFormaPago();
            frmFP.Show();
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIglesia frmI = new FormIglesia();
            frmI.Show();
        }

        private void secretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecretaria frmS = new FormSecretaria();
            frmS.Show();
        }

        private void envíoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnvio frmE = new FormEnvio();
            frmE.Show();
        }

        private void mensajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensajero frmM = new FormMensajero();
            frmM.Show();
        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPartida frmP = new FormPartida();
            frmP.Show();
        }
    }
}
