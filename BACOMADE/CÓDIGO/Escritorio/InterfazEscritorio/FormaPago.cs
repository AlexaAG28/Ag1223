using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class FormaPago
    {
        private int ID_FORMA_P;
        private string NOMBRE_FP;
        private double TOTAL_PAGAR; 
        private DateTime FECHA_PAGO;

        public int ID_FORMA_P1 { get => ID_FORMA_P; set => ID_FORMA_P = value; }
        public string NOMBRE_FP1 { get => NOMBRE_FP; set => NOMBRE_FP = value; }
        public double TOTAL_PAGAR1 { get => TOTAL_PAGAR; set => TOTAL_PAGAR = value; }
        public DateTime FECHA_PAGO1 { get => FECHA_PAGO; set => FECHA_PAGO = value; }
    }
}
