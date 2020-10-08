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
    public partial class FormComprador : Form
    {
        public FormComprador()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusC_Click(object sender, EventArgs e)
        {
            string dato= txtBuc_comp.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Comprador> lista = new List<Comprador>();
            ControladorComprador _controladorComprador = new ControladorComprador();
            dgvComprador.DataSource = _controladorComprador.consulta(dato);

        }
        private void btnGuarC_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Comprador _comprador = new Comprador();
            _comprador.CORREO_C1 = txtCorreoC.Text;
            _comprador.CONTRASEÑA_C1 = txtContraseñaC.Text;
            _comprador.NOMBRE_C1 = txtNombreC.Text;
            _comprador.APELLIDOS_C1 = txtApellidosC.Text;
            _comprador.DOCUMENTO_C1 = txtDocumentoC.Text;
            _comprador.TELEFONO_C1 = txtTelefonoC.Text;
            _comprador.DIRECCION_C1 = txtDireccionC.Text;

            ControladorComprador ctrl = new ControladorComprador();

            if(txtIdC.Text != "")
            {
                _comprador.ID_COMPRADOR1 = int.Parse(txtIdC.Text);
                bandera=ctrl.actualizar(_comprador);
            }
            else
            {
                bandera=ctrl.insertar(_comprador);
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
            txtCorreoC.Text = "";
            txtContraseñaC.Text = "";
            txtNombreC.Text = "";
            txtApellidosC.Text = "";
            txtDocumentoC.Text = "";
            txtTelefonoC.Text = "";
            txtDireccionC.Text = "";
        }

        private void btnModiC_Click(object sender, EventArgs e)
        {
            txtIdC.Text = dgvComprador.CurrentRow.Cells[0].Value.ToString();
            txtCorreoC.Text = dgvComprador.CurrentRow.Cells[1].Value.ToString();
            txtContraseñaC.Text = dgvComprador.CurrentRow.Cells[2].Value.ToString();
            txtNombreC.Text = dgvComprador.CurrentRow.Cells[3].Value.ToString();
            txtApellidosC.Text = dgvComprador.CurrentRow.Cells[4].Value.ToString();
            txtDocumentoC.Text = dgvComprador.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoC.Text = dgvComprador.CurrentRow.Cells[6].Value.ToString();
            txtDireccionC.Text = dgvComprador.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnElimC_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                int ID_COMPRADOR= int.Parse(dgvComprador.CurrentRow.Cells[0].Value.ToString());
                ControladorComprador _ctrl = new ControladorComprador();
                bandera= _ctrl.eliminar(ID_COMPRADOR);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpC_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

    }
}
