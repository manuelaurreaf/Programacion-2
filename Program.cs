using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extracto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PuntosArticulo());
        }

        public static uint PuntosArticulo()
        {
            uint puntos = 0;
            short Opcion;
            try
            {
                do
                {
                    Console.WriteLine("Articulos que puede escoger:");
                    Console.WriteLine("1. Articulo de decoracion cuesta 5.000 puntos.");
                    Console.WriteLine("2. Articulo electronico menor cuesta 10.000 puntos.");
                    Console.WriteLine("3. Articulo electronico mediano cuesta 50.000 puntos.");
                    Console.WriteLine("4. Tiquete aereo nacional cuesta 90.000 puntos.");
                    Console.WriteLine("5. Articulo electronico grande cuesta 150.000 puntos.");
                    Console.WriteLine("6. Tiquete aereo round trip nacional cuesta 180.000 puntos.");
                    Console.WriteLine("Ingrese que opcion quiere: ");

                    try { Opcion = short.Parse(Console.ReadLine()); }
                    catch (Exception) { Opcion = 0; }
                } while (Opcion < 1 && Opcion > 6);
                return puntos;
            }
            catch (Exception)
            {
                throw new Exception("Porblema al crear el objeto");
            }
        }
    }
}
