using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class ControladorComprador : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            
            if(dato == null)
            {
                sql = "SELECT ID_COMPRADOR, CORREO_C, CONTRASEÑA_C, NOMBRE_C, APELLIDOS_C, DOCUMENTO_C, TELEFONO_C, DIRECCION_C FROM TBL_COMPRADOR ORDER BY NOMBRE_C ASC";
            }
            else
            {
                sql = "SELECT ID_COMPRADOR, CORREO_C, CONTRASEÑA_C, NOMBRE_C, APELLIDOS_C, DOCUMENTO_C, TELEFONO_C, DIRECCION_C FROM TBL_COMPRADOR WHERE CORREO_C LIKE '%"+dato+ "%' OR  CONTRASEÑA_C LIKE '%" + dato + "%' OR  NOMBRE_C LIKE '%" + dato + "%' OR  APELLIDOS_C LIKE '%" + dato + "%' OR  DOCUMENTO_C LIKE '%" + dato + "%' OR  TELEFONO_C LIKE '%" + dato + "%' OR  DIRECCION_C LIKE '%" + dato + "%' ORDER BY NOMBRE_C ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Comprador _comprador = new Comprador();
                    _comprador.ID_COMPRADOR1 = int.Parse(reader.GetString(0));
                    _comprador.CORREO_C1 = reader.GetString(1);
                    _comprador.CONTRASEÑA_C1 = reader.GetString(2);
                    _comprador.NOMBRE_C1 = reader.GetString(3);
                    _comprador.APELLIDOS_C1 = reader.GetString(4);
                    _comprador.DOCUMENTO_C1 = reader.GetString(5);
                    _comprador.TELEFONO_C1 = reader.GetString(6);
                    _comprador.DIRECCION_C1 = reader.GetString(7);
                    lista.Add(_comprador);
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Comprador datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO TBL_COMPRADOR (CORREO_C, CONTRASEÑA_C, NOMBRE_C, APELLIDOS_C, DOCUMENTO_C, TELEFONO_C, DIRECCION_C) VALUES ('" + datos.CORREO_C1 + "', '" + datos.CONTRASEÑA_C1 + "', '" + datos.NOMBRE_C1 + "', '" + datos.APELLIDOS_C1 + "', '" + datos.DOCUMENTO_C1 + "', '" + datos.TELEFONO_C1 + "', '" + datos.DIRECCION_C1 + "')";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }
            return bandera;
        }
        public bool actualizar(Comprador datos)
        {
            bool bandera = false;
            string sql = "UPDATE TBL_COMPRADOR SET CORREO_C='" + datos.CORREO_C1 + "', CONTRASEÑA_C='" + datos.CONTRASEÑA_C1 + "',  NOMBRE_C='" + datos.NOMBRE_C1 + "',  APELLIDOS_C='" + datos.APELLIDOS_C1 + "',  DOCUMENTO_C='" + datos.DOCUMENTO_C1 + "',  TELEFONO_C='" + datos.TELEFONO_C1 + "',  DIRECCION_C='" + datos.DIRECCION_C1 + "' WHERE ID_COMPRADOR='"+datos.ID_COMPRADOR1+"' ";

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
        public bool eliminar(int ID_COMPRADOR)
        {
            bool bandera = false;
            string sql = "DELETE FROM TBL_COMPRADOR WHERE ID_COMPRADOR='" + ID_COMPRADOR + "' ";

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
