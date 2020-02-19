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
         public string TotalDineroCajilla()
        {
            int totalX = CantidadX * 10000;
            int totalXX = CantidadXX * 20000;
            int totalL = CantidadL * 50000;
            string totalCajilla="";
            totalCajilla = totalX + "|" + totalXX + "|" + totalL;
            return totalCajilla;
        }
        public int CalcularTotalDinero(int totalX, int totalXX, int totalL)
        {
            int totalDinero = totalX + totalXX + totalL;
            return totalDinero;
        }
        public string RecargarDinero() 
        {
            int recargaX = CantidadX + (CantidadMaxX - CantidadX);
            int recargaXX = CantidadXX +(CantidadMaxXX - CantidadXX);
            int recargaL = CantidadL + (CantidadMaxL - CantidadL);
            string plataRecargada = "";
            plataRecargada = "Recargado en 10: " + (CantidadMaxX - CantidadX) + "Recargado en 20: " + (CantidadMaxXX - CantidadXX) + "Recargado en 50: " + (CantidadMaxL - CantidadL);
            return plataRecargada;
        }
        public string EntregarDinero(int Cantidad, int totalDinero)
        {
            string billetesEntregados = "";
            short billetesX = 0, billetesXX = 0, billetesL = 0;
            if(Cantidad % 10000 == 0)
            {
                if(Cantidad >= 20000 && Cantidad <= 800000)
                {
                    if (Cantidad <= totalDinero)
                    {
                        while (Cantidad >= 50000 && CantidadL > 0)
                        {
                            Cantidad -= 50000;
                            billetesL++;
                        }
                        while (Cantidad >= 20000 && CantidadXX > 0)
                        {
                            Cantidad -= 20000;
                            billetesXX++;
                        }
                        while (Cantidad >= 10000 && CantidadL > 0)
                        {
                            Cantidad -= 10000;
                            billetesX++;
                        }
                    }
                    else throw new Exception("No hay suficiente dinero");
                }
                else throw new Exception("Esta fuera del rango permitido");
            }
            else throw new Exception("Es imposible entregar esa cantida");
            billetesEntregados = "Se entregaron: " + billetesX + " billetes de 10" + billetesXX + " billetes de 20" + billetesL + " billetes de 50";
            return billetesEntregados;
        }
        
    }
}
