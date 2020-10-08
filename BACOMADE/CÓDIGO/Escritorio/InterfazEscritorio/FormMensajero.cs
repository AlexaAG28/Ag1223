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
    public partial class FormMensajero : Form
    {
        public FormMensajero()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusM_Click(object sender, EventArgs e)
        {
            string dato = txtBusM.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Mensajero> lista = new List<Mensajero>();
            ControladorMensajero _controladorMensajero = new ControladorMensajero();
            dgvMensajero.DataSource = _controladorMensajero.consulta(dato);

        }

        private void btnGuarM_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Mensajero _mensajero = new Mensajero();
            _mensajero.NOMBRE_M1 = txtNombreM.Text;
            _mensajero.TELEFONO1 = txtTelefono.Text;
            _mensajero.DOCUMENTO_M1 = txtDocumentoM.Text;

            ControladorMensajero ctrl = new ControladorMensajero();

            if (txtIdM.Text != "")
            {
                _mensajero.ID_MENSAJERO1 = int.Parse(txtIdM.Text);
                bandera = ctrl.actualizar(_mensajero);
            }
            else
            {
                bandera = ctrl.insertar(_mensajero);
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
            txtNombreM.Text = "";
            txtTelefono.Text = "";
            txtDocumentoM.Text = "";
        }

        private void btnModiM_Click(object sender, EventArgs e)
        {
            txtIdM.Text = dgvMensajero.CurrentRow.Cells[0].Value.ToString();
            txtNombreM.Text = dgvMensajero.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dgvMensajero.CurrentRow.Cells[2].Value.ToString();
            txtDocumentoM.Text = dgvMensajero.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnElimM_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_MENSAJERO = int.Parse(dgvMensajero.CurrentRow.Cells[0].Value.ToString());
                ControladorMensajero _ctrl = new ControladorMensajero();
                bandera = _ctrl.eliminar(ID_MENSAJERO);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpM_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }
    }
}
