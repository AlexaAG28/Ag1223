using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class Secretaria
    {
        private int ID_SECRETARIA;
        private string CORREO_S;
        private string CONTRASEÑA_S;
        private string NOMBRE_S;
        private string APELLIDOS_S;
        private string DOCUMENTO_S;

        public int ID_SECRETARIA1 { get => ID_SECRETARIA; set => ID_SECRETARIA = value; }
        public string CORREO_S1 { get => CORREO_S; set => CORREO_S = value; }
        public string CONTRASEÑA_S1 { get => CONTRASEÑA_S; set => CONTRASEÑA_S = value; }
        public string NOMBRE_S1 { get => NOMBRE_S; set => NOMBRE_S = value; }
        public string APELLIDOS_S1 { get => APELLIDOS_S; set => APELLIDOS_S = value; }
        public string DOCUMENTO_S1 { get => DOCUMENTO_S; set => DOCUMENTO_S = value; }
    }
}
