using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorSecretaria : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT ID_SECRETARIA, CORREO_S, CONTRASEÑA_S, NOMBRE_S, APELLIDOS_S, DOCUMENTO_S FROM TBL_SECRETARIA ORDER BY NOMBRE_S ASC";
            }
            else
            {
                sql = "SELECT ID_SECRETARIA, CORREO_S, CONTRASEÑA_S, NOMBRE_S, APELLIDOS_S, DOCUMENTO_S FROM TBL_SECRETARIA WHERE CORREO_S LIKE '%" + dato + "%' OR  CONTRASEÑA_S LIKE '%" + dato + "%' OR  NOMBRE_S LIKE '%" + dato + "%' OR  APELLIDOS_S LIKE '%" + dato + "%' OR  DOCUMENTO_S LIKE '%" + dato + "%' ORDER BY NOMBRE_S ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Secretaria _secretaria = new Secretaria();
                    _secretaria.ID_SECRETARIA1 = int.Parse(reader.GetString(0));
                    _secretaria.CORREO_S1 = reader.GetString(1);
                    _secretaria.CONTRASEÑA_S1 = reader.GetString(2);
                    _secretaria.NOMBRE_S1 = reader.GetString(3);
                    _secretaria.APELLIDOS_S1 = reader.GetString(4);
                    _secretaria.DOCUMENTO_S1 = reader.GetString(5);
                    lista.Add(_secretaria);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Secretaria datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_SECRETARIA (CORREO_S, CONTRASEÑA_S, NOMBRE_S, APELLIDOS_S, DOCUMENTO_S) VALUES ('" + datos.CORREO_S1 + "', '" + datos.CONTRASEÑA_S1 + "', '" + datos.NOMBRE_S1 + "', '" + datos.APELLIDOS_S1 + "', '" + datos.DOCUMENTO_S1 + "')";

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
        public bool actualizar(Secretaria datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_SECRETARIA SET CORREO_S='" + datos.CORREO_S1 + "', CONTRASEÑA_S='" + datos.CONTRASEÑA_S1 + "',  NOMBRE_S='" + datos.NOMBRE_S1 + "',  APELLIDOS_S='" + datos.APELLIDOS_S1 + "',  DOCUMENTO_S='" + datos.DOCUMENTO_S1 + "' WHERE ID_SECRETARIA='" + datos.ID_SECRETARIA1 + "' ";

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
        public bool eliminar(int ID_SECRETARIA)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_SECRETARIA WHERE ID_SECRETARIA='" + ID_SECRETARIA + "' ";

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
