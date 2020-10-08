using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEscritorio
{
    class Partida
    {
        private int ID_PARTIDA;
        private string TIPO;
        private DateTime FECHA_CREADA;
        private double COSTO;

        public int ID_PARTIDA1 { get => ID_PARTIDA; set => ID_PARTIDA = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public DateTime FECHA_CREADA1 { get => FECHA_CREADA; set => FECHA_CREADA = value; }
        public double COSTO1 { get => COSTO; set => COSTO = value; }
    }
}
