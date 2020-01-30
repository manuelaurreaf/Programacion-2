using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string opcion;
                Int16[,] matriz1 = new Int16[4, 5];
                List<int> listaprin = new List<int>(); 

                Random nAleatorio = new Random();
                for(short i=0; i < 4; i++)
                {
                    for (short j = 0; j < 4; j++)
                    {
                        matriz1[i, j] = (Int16)nAleatorio.Next(1, 9);
                    }
                }
                Console.WriteLine("el resultado es " + suma_elemento_matriz(matriz1));

                listaprin = sumfil_sumcol(matriz1, 4, 5);
                if (listaprin.Count == 0) Console.WriteLine("la lista esta vacia");
                else
                {
                    foreach(Int16 elemento in listaprin)
                    {
                        Console.WriteLine(elemento);
                    }
                }


                /*
                do
                {

                    opcion = menu();

                    switch (opcion)
                    {

                        case "1":
                            op1();
                            break;
                        case "2":
                            op2();
                            break;
                        case "3":
                            op3();
                            break;
                        case "S":
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            Console.WriteLine("Opción Inválida");
                            break;
                    }

                }

                while (!opcion.Equals ("S"));
                */

            }

            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ocurrió Error en " + error);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fin de Ejecución");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
        }
        public static int suma_elemento_matriz(Int16 [,] matriz)
        {
            int resultado = 0;
            for (short i = 0; i < 4; i++)
            {
                for (short j = 0; j < 4; j++)
                {
                    resultado += matriz[i,j];
                }
            }
            return resultado; 
        }
        public static List<int> sumfil_sumcol(Int16[,] matriz, short nrofil, short nrocol)
        {
            List<int> listaresultados = new List<int>(); //primero declaro lo que tengo que devolver y pongo el return
            int sumafil = 0, sumacol = 0;
            try
            {
               for(short i = 0; i < nrofil; i++)
                {
                    for (short j = 0; j < nrocol; j++)
                    {
                        sumafil += matriz[i, j];
                    }
                }
                for (short i = 0; i < nrocol; i++)
                {
                    for (short j = 0; j < nrofil; j++)
                    {
                        sumacol += matriz[j, i];
                    }
                }
                //añadirlos a la lista
                listaresultados.Add(sumafil);
                listaresultados.Add(sumacol); 
            
            }
           catch(Exception error)
            {
                Console.WriteLine("ocurrio un error en subrutina sumafilcol" + error);
            }
            return listaresultados;
        }
        public static string menu()
        {
            string opcion;

            Console.WriteLine("****** Digite su opción ******");
            Console.WriteLine("1. Opcion 1");
            Console.WriteLine("2. Opcion 2");
            Console.WriteLine("3. Opcion 3");
            Console.WriteLine("S. Salir");

            opcion = Console.ReadLine();

            return opcion;

        }
        public static void op1()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void op2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void op3()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
    
}
