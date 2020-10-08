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
    public partial class FormFormaPago : Form
    {
        public FormFormaPago()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusFP_Click(object sender, EventArgs e)
        {
            string dato = txtBusFP.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<FormaPago> lista = new List<FormaPago>();
            ControladorFormaPago _controladorFormaPago = new ControladorFormaPago();
            dgvFormaPago.DataSource = _controladorFormaPago.consulta(dato);
        }

        private void btnGuarFP_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            FormaPago _formaPago = new FormaPago();
            _formaPago.NOMBRE_FP1 = txtNombreFP.Text;
            _formaPago.TOTAL_PAGAR1 = double.Parse(txtTotalPagar.Text);
            _formaPago.FECHA_PAGO1 = DateTime.Parse(txtFechaPago.Text);

            ControladorFormaPago ctrl = new ControladorFormaPago();

            if (txtIdFP.Text != "")
            {
                _formaPago.ID_FORMA_P1 = int.Parse(txtIdFP.Text);
                bandera = ctrl.actualizar(_formaPago);
            }
            else
            {
                bandera = ctrl.insertar(_formaPago);
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
            txtNombreFP.Text = "";
            txtTotalPagar.Text = "";
            txtFechaPago.Text = "";
        }

        private void btnModiFP_Click(object sender, EventArgs e)
        {
            txtIdFP.Text = dgvFormaPago.CurrentRow.Cells[0].Value.ToString();
            txtNombreFP.Text = dgvFormaPago.CurrentRow.Cells[1].Value.ToString();
            txtTotalPagar.Text = dgvFormaPago.CurrentRow.Cells[2].Value.ToString();
            txtFechaPago.Text = dgvFormaPago.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnElimFP_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_FORMA_P = int.Parse(dgvFormaPago.CurrentRow.Cells[0].Value.ToString());
                ControladorFormaPago _ctrl = new ControladorFormaPago();
                bandera = _ctrl.eliminar(ID_FORMA_P);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpFP_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }
    }
}
