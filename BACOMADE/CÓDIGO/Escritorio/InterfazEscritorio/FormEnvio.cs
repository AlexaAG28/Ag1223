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
    public partial class FormEnvio : Form
    {
        public FormEnvio()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusE_Click(object sender, EventArgs e)
        {
            string dato = txtBusE.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Envio> lista = new List<Envio>();
            ControladorEnvio _controladorEnvio = new ControladorEnvio();
            dgvEnvio.DataSource = _controladorEnvio.consulta(dato);
        }

        private void btnGuarE_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Envio _envio = new Envio();
            _envio.FECHA_ENVIO1 = DateTime.Parse(txtFechaE.Text);

            ControladorEnvio ctrl = new ControladorEnvio();

            if (txtIdE.Text != "")
            {
                _envio.ID_ENVIO1 = int.Parse(txtIdE.Text);
                bandera = ctrl.actualizar(_envio);
            }
            else
            {
                bandera = ctrl.insertar(_envio);
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
            txtFechaE.Text = "";
        }

        private void btnModiE_Click(object sender, EventArgs e)
        {
            txtIdE.Text = dgvEnvio.CurrentRow.Cells[0].Value.ToString();
            txtFechaE.Text = dgvEnvio.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnElimE_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_ENVIO = int.Parse(dgvEnvio.CurrentRow.Cells[0].Value.ToString());
                ControladorEnvio _ctrl = new ControladorEnvio();
                bandera = _ctrl.eliminar(ID_ENVIO);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpE_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }
    }
}
