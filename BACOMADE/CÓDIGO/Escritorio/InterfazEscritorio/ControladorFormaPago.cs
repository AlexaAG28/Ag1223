using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorFormaPago : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_FORMA_P, NOMBRE_FP, TOTAL_PAGAR, FECHA_PAGO FROM TBL_FORMA_PAGO ORDER BY NOMBRE_FP ASC";
            }
            else
            {
                sql = "SELECT ID_FORMA_P, NOMBRE_FP, TOTAL_PAGAR, FECHA_PAGO FROM TBL_FORMA_PAGO WHERE NOMBRE_FP LIKE '%" + dato + "%' OR  TOTAL_PAGAR LIKE '%" + dato + "%' OR  FECHA_PAGO LIKE '%" + dato + "%' ORDER BY NOMBRE_FP ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    FormaPago _formaPago = new FormaPago();
                    _formaPago.ID_FORMA_P1 = int.Parse(reader.GetString(0));
                    _formaPago.NOMBRE_FP1 = reader.GetString(1);
                    _formaPago.TOTAL_PAGAR1 = double.Parse(reader.GetString(2));
                    _formaPago.FECHA_PAGO1 = DateTime.Parse(reader.GetString(3));
                    lista.Add(_formaPago);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(FormaPago datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_FORMA_PAGO (NOMBRE_FP, TOTAL_PAGAR, FECHA_PAGO) VALUES ('" + datos.NOMBRE_FP1 + "', '" + datos.TOTAL_PAGAR1 + "', '" + datos.FECHA_PAGO1 + "')";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }
            return bandera;
        }
        public bool actualizar(FormaPago datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_FORMA_PAGO SET NOMBRE_FP='" + datos.NOMBRE_FP1 + "', TOTAL_PAGAR='" + datos.TOTAL_PAGAR1 + "',  FECHA_PAGO='" + datos.FECHA_PAGO1 + "' WHERE ID_FORMA_P='" + datos.ID_FORMA_P1 + "' ";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }
            return bandera;
        }
        public bool eliminar(int ID_FORMA_P)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_FORMA_PAGO WHERE ID_FORMA_P='" + ID_FORMA_P + "' ";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }
            return bandera;
        }
    }
}
