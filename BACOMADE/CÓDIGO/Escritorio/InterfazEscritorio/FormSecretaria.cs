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
    public partial class FormSecretaria : Form
    {
        public FormSecretaria()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusS_Click(object sender, EventArgs e)
        {
            string dato = txtBusS.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Secretaria> lista = new List<Secretaria>();
            ControladorSecretaria _controladorsecretaria = new ControladorSecretaria();
            dgvSecretaria.DataSource = _controladorsecretaria.consulta(dato);

        }

        private void btnGuarS_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Secretaria _secretaria = new Secretaria();
            _secretaria.CORREO_S1 = txtCorreoS.Text;
            _secretaria.CONTRASEÑA_S1 = txtContraseñaS.Text;
            _secretaria.NOMBRE_S1 = txtNombreS.Text;
            _secretaria.APELLIDOS_S1 = txtApellidosS.Text;
            _secretaria.DOCUMENTO_S1 = txtDocumentoS.Text;

            ControladorSecretaria ctrl = new ControladorSecretaria();

            if (txtIdS.Text != "")
            {
                _secretaria.ID_SECRETARIA1 = int.Parse(txtIdS.Text);
                bandera = ctrl.actualizar(_secretaria);
            }
            else
            {
                bandera = ctrl.insertar(_secretaria);
            }

            if (bandera)
            {
                MessageBox.Show("Registro guardado");
                limpiarPantalla();
                cargarTabla(null);
            }
        }
        private void limpiarPantalla()
        {
            txtCorreoS.Text = "";
            txtContraseñaS.Text = "";
            txtNombreS.Text = "";
            txtApellidosS.Text = "";
            txtDocumentoS.Text = "";
        }

        private void btnModiS_Click(object sender, EventArgs e)
        {
            txtIdS.Text = dgvSecretaria.CurrentRow.Cells[0].Value.ToString();
            txtCorreoS.Text = dgvSecretaria.CurrentRow.Cells[1].Value.ToString();
            txtContraseñaS.Text = dgvSecretaria.CurrentRow.Cells[2].Value.ToString();
            txtNombreS.Text = dgvSecretaria.CurrentRow.Cells[3].Value.ToString();
            txtApellidosS.Text = dgvSecretaria.CurrentRow.Cells[4].Value.ToString();
            txtDocumentoS.Text = dgvSecretaria.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnElimS_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_SECRETARIA = int.Parse(dgvSecretaria.CurrentRow.Cells[0].Value.ToString());
                ControladorSecretaria _ctrl = new ControladorSecretaria();
                bandera = _ctrl.eliminar(ID_SECRETARIA);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpS_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }
    }
}
