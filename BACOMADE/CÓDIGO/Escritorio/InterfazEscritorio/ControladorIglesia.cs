using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorIglesia : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_IGLESIA, NOMBRE_I, MUNICIPIO, DIRECCION_I FROM TBL_IGLESIA ORDER BY NOMBRE_I ASC";
            }
            else
            {
                sql = "SELECT ID_IGLESIA, NOMBRE_I, MUNICIPIO, DIRECCION_I FROM TBL_IGLESIA WHERE NOMBRE_I LIKE '%" + dato + "%' OR  MUNICIPIO LIKE '%" + dato + "%' OR  DIRECCION_I LIKE '%" + dato + "%' ORDER BY NOMBRE_I ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Iglesia _iglesia = new Iglesia();
                    _iglesia.ID_IGLESIA1 = int.Parse(reader.GetString(0));
                    _iglesia.NOMBRE_I1 = reader.GetString(1);
                    _iglesia.MUNICIPIO1 = reader.GetString(2);
                    _iglesia.DIRECCION_I1 = reader.GetString(3);
                    lista.Add(_iglesia);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Iglesia datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_IGLESIA (NOMBRE_I, MUNICIPIO, DIRECCION_I) VALUES ('" + datos.NOMBRE_I1 + "', '" + datos.MUNICIPIO1 + "', '" + datos.DIRECCION_I1 + "')";

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
        public bool actualizar(Iglesia datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_IGLESIA SET NOMBRE_I='" + datos.NOMBRE_I1 + "', MUNICIPIO='"+ datos.MUNICIPIO1 +"', DIRECCION_I='" + datos.DIRECCION_I1 + "' WHERE ID_IGLESIA='" + datos.ID_IGLESIA1 + "' ";

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
        public bool eliminar(int ID_IGLESIA)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_IGLESIA WHERE ID_IGLESIA='" + ID_IGLESIA + "' ";

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
