using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorEnvio : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_ENVIO, FECHA_ENVIO FROM TBL_ENVIO ORDER BY FECHA_ENVIO ASC";
            }
            else
            {
                sql = "SELECT ID_ENVIO, FECHA_ENVIO FROM TBL_ENVIO WHERE FECHA_ENVIO LIKE '%" + dato + "%' ORDER BY FECHA_ENVIO ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Envio _envio = new Envio();
                    _envio.ID_ENVIO1 = int.Parse(reader.GetString(0));
                    _envio.FECHA_ENVIO1 = DateTime.Parse(reader.GetString(1));
                    lista.Add(_envio);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Envio datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_ENVIO (FECHA_ENVIO) VALUES ('" + datos.FECHA_ENVIO1 + "')";

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
        public bool actualizar(Envio datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_ENVIO SET FECHA_ENVIO'" + datos.FECHA_ENVIO1 + "' WHERE ID_ENVIO='" + datos.ID_ENVIO1 + "' ";

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
        public bool eliminar(int ID_ENVIO)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_ENVIO WHERE ID_ENVIO='" + ID_ENVIO + "' ";

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
