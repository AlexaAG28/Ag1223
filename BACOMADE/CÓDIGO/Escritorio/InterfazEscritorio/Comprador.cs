using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class Comprador
    {
        private int ID_COMPRADOR;
        private string CORREO_C;
        private string CONTRASEÑA_C;
        private string NOMBRE_C;
        private string APELLIDOS_C;
        private string DOCUMENTO_C;
        private string TELEFONO_C;
        private string DIRECCION_C;

        public int ID_COMPRADOR1 { get => ID_COMPRADOR; set => ID_COMPRADOR = value; }
        public string CORREO_C1 { get => CORREO_C; set => CORREO_C = value; }
        public string CONTRASEÑA_C1 { get => CONTRASEÑA_C; set => CONTRASEÑA_C = value; }
        public string NOMBRE_C1 { get => NOMBRE_C; set => NOMBRE_C = value; }
        public string APELLIDOS_C1 { get => APELLIDOS_C; set => APELLIDOS_C = value; }
        public string DOCUMENTO_C1 { get => DOCUMENTO_C; set => DOCUMENTO_C = value; }
        public string TELEFONO_C1 { get => TELEFONO_C; set => TELEFONO_C = value; }
        public string DIRECCION_C1 { get => DIRECCION_C; set => DIRECCION_C = value; }
    }
}
