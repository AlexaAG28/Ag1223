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
    public partial class FormIglesia : Form
    {
        public FormIglesia()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusI_Click(object sender, EventArgs e)
        {
            string dato = txtBusI.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Iglesia> lista = new List<Iglesia>();
            ControladorIglesia _controladorIglesia = new ControladorIglesia();
            dgvIglesia.DataSource = _controladorIglesia.consulta(dato);

        }
        private void btnGuarI_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Iglesia _iglesia = new Iglesia();
            _iglesia.NOMBRE_I1 = txtNombreI.Text;
            _iglesia.MUNICIPIO1 = txtMunicipio.Text;
            _iglesia.DIRECCION_I1 = txtDireccionI.Text;

            ControladorIglesia ctrl = new ControladorIglesia();

            if (txtIdI.Text != "")
            {
                _iglesia.ID_IGLESIA1 = int.Parse(txtIdI.Text);
                bandera = ctrl.actualizar(_iglesia);
            }
            else
            {
                bandera = ctrl.insertar(_iglesia);
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
                txtNombreI.Text = "";
                txtMunicipio.Text = "";
                txtDireccionI.Text = "";
            }

        private void btnModiI_Click(object sender, EventArgs e)
        {
            txtIdI.Text = dgvIglesia.CurrentRow.Cells[0].Value.ToString();
            txtNombreI.Text = dgvIglesia.CurrentRow.Cells[1].Value.ToString();
            txtMunicipio.Text = dgvIglesia.CurrentRow.Cells[2].Value.ToString();
            txtDireccionI.Text = dgvIglesia.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnElimI_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_IGLESIA = int.Parse(dgvIglesia.CurrentRow.Cells[0].Value.ToString());
                ControladorIglesia _ctrl = new ControladorIglesia();
                bandera = _ctrl.eliminar(ID_IGLESIA);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpI_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

    }
    }

