using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorMensajero : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_MENSAJERO, NOMBRE_M, TELEFONO, DOCUMENTO_M FROM TBL_MENSAJERO ORDER BY NOMBRE_M ASC";
            }
            else
            {
                sql = "SELECT ID_MENSAJERO, NOMBRE_M, TELEFONO, DOCUMENTO_M FROM TBL_MENSAJERO WHERE NOMBRE_M LIKE '%" + dato + "%' OR TELEFONO LIKE '%" + dato + "%' OR DOCUMENTO_M LIKE '%" + dato + "%' ORDER BY NOMBRE_M ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Mensajero _mensajero = new Mensajero();
                    _mensajero.ID_MENSAJERO1 = int.Parse(reader.GetString(0));
                    _mensajero.NOMBRE_M1 = reader.GetString(1);
                    _mensajero.TELEFONO1 = reader.GetString(2);
                    _mensajero.DOCUMENTO_M1 = reader.GetString(3);
                    lista.Add(_mensajero);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Mensajero datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_MENSAJERO (NOMBRE_M, TELEFONO, DOCUMENTO_M) VALUES ('" + datos.NOMBRE_M1 + "', '" + datos.TELEFONO1 + "', '" + datos.DOCUMENTO_M1 + "')";

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
        public bool actualizar(Mensajero datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_MENSAJERO SET NOMBRE_M='" + datos.NOMBRE_M1+ "', TELEFONO='" + datos.TELEFONO1 + "',  DOCUMENTO_M='" + datos.DOCUMENTO_M1 + "' WHERE ID_MENSAJERO='" + datos.ID_MENSAJERO1 + "' ";

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
        public bool eliminar(int ID_MENSAJERO)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_MENSAJERO WHERE ID_MENSAJERO='" + ID_MENSAJERO + "' ";

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
