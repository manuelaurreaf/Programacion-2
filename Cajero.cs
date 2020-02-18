using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cajero
    {
        private string CodigoCajero;
        private short CantidadX = 0;
        private short CantidadXX = 0;
        private short CantidadL = 0;
        private short CantidadMaxX = 60;
        private short CantidadMaxXX = 60;
        private short CantidadMaxL = 60;

        public Cajero()
        {
            CantidadX1 = 60;
            CantidadXX1 = 60;
            CantidadL1 = 60;
        }

        public short CantidadX1 { get => CantidadX; set => CantidadX = value; }
        public short CantidadXX1 { get => CantidadXX; set => CantidadXX = value; }
        public short CantidadL1 { get => CantidadL; set => CantidadL = value; }

        public bool Leer_Tarjeta()
        {
            Random rnd = new Random();
            int v1 = rnd.Next(0, 2);
            if (v1 == 0)
            {
                return false;
            }
            else return true;
        }
        public int totalDineroCajilla()
        {
            
        }
    }
}
