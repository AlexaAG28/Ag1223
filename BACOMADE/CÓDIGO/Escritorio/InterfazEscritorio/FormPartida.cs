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
    public partial class FormPartida : Form
    {
        public FormPartida()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBusP_Click(object sender, EventArgs e)
        {
            string dato = txtBusP.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Partida> lista = new List<Partida>();
            ControladorPartida _controladorPartida = new ControladorPartida();
            dgvPartida.DataSource = _controladorPartida.consulta(dato);
        }

        private void btnGuarP_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Partida _partida = new Partida();
            _partida.TIPO1 = txtTipo.Text;
            _partida.FECHA_CREADA1 = DateTime.Parse(txtFechaCreada.Text);
            _partida.COSTO1 = double.Parse(txtCostoP.Text);

            ControladorPartida ctrl = new ControladorPartida();

            if (txtIdP.Text != "")
            {
                _partida.ID_PARTIDA1 = int.Parse(txtIdP.Text);
                bandera = ctrl.actualizar(_partida);
            }
            else
            {
                bandera = ctrl.insertar(_partida);
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
            txtTipo.Text = "";
            txtFechaCreada.Text = "";
            txtCostoP.Text = "";
        }

        private void btnModiP_Click(object sender, EventArgs e)
        {
            txtIdP.Text = dgvPartida.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = dgvPartida.CurrentRow.Cells[1].Value.ToString();
            txtFechaCreada.Text = dgvPartida.CurrentRow.Cells[2].Value.ToString();
            txtCostoP.Text = dgvPartida.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnElimP_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int ID_PARTIDA = int.Parse(dgvPartida.CurrentRow.Cells[0].Value.ToString());
                ControladorPartida _ctrl = new ControladorPartida();
                bandera = _ctrl.eliminar(ID_PARTIDA);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiarPantalla();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpP_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }
    }
}
