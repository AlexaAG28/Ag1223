using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorPartida : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_PARTIDA, TIPO, FECHA_CREADA, COSTO FROM TBL_PARTIDA ORDER BY FECHA_CREADA ASC";
            }
            else
            {
                sql = "SELECT ID_PARTIDA, TIPO, FECHA_CREADA, COSTO FROM TBL_PARTIDA WHERE TIPO LIKE '%" + dato + "%' OR  FECHA_CREADA LIKE '%" + dato + "%' OR  COSTO LIKE '%" + dato + "%' ORDER BY FECHA_CREADA ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Partida _partida = new Partida();
                    _partida.ID_PARTIDA1 = int.Parse(reader.GetString(0));
                    _partida.TIPO1 = reader.GetString(1);
                    _partida.FECHA_CREADA1 = DateTime.Parse(reader.GetString(2));
                    _partida.COSTO1 = double.Parse(reader.GetString(3));
                    lista.Add(_partida);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Partida datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_PARTIDA (TIPO, FECHA_CREADA, COSTO) VALUES ('" + datos.TIPO1 + "', '" + datos.FECHA_CREADA1 + "', '" + datos.COSTO1 + "')";

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
        public bool actualizar(Partida datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_PARTIDA SET TIPO='" + datos.TIPO1 + "', FECHA_CREADA='" + datos.FECHA_CREADA1 + "',  COSTO='" + datos.COSTO1 + "' WHERE ID_PARTIDA='" + datos.ID_PARTIDA1 + "' ";

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
        public bool eliminar(int ID_PARTIDA)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_PARTIDA WHERE ID_PARTIDA='" + ID_PARTIDA + "' ";

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
