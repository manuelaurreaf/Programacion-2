using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TallerRepaso2._0
{
    class ProgramTallerRepasos 
    {
        static void Main(string[] args)
        {
            //2
            Console.WriteLine("suma del uno al: ");
            int g = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 1; i++)
            {
                
                for (int p = 1; p <= g; p++)
                {
                    Console.WriteLine("{0} + {1} = {2}", g, p, (g + p));
                }
            }
            //3
            Console.WriteLine("suma del uno al, solo con multiplos de 3: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 1; i++)
            {
               
                for (int p = 1; p <= n; p++)
                {
                    Console.WriteLine("{0} + {1} = {2}", n, p*3, (n + (p*3)));
                }
            }
            //4
            Console.WriteLine("tabla hasta doce de: ");
            for (int i = 1; i <= 1; i++)
            {
                int o = int.Parse(Console.ReadLine());
                for (int p = 1; p <= 12; p++)
                {
                    Console.WriteLine("{0} * {1} = {2}", o, p, (o * p));
                }
            }
            //5
            Console.WriteLine("Los 20 años biciestos que nos depara el futuro son: "); 
            int año = 2020;
            int bis;
            while (año < 2101)
            {
                bis = año;
                Console.Write(bis + " - ");
                año = bis + 4;
            }
            //6
            Console.WriteLine("Lista de numeros en orden... ");
            List<string> lista_numeros = new List<string>();
            string Linea;
            StreamReader LeerArchivo = new StreamReader("D:\\Manuela\\Documents\\_Cuarto Semestre\\Programacion\\juegos.txt");
            Linea = LeerArchivo.ReadLine();
            while (Linea != null)
            {
                lista_numeros.Add(Linea);
                Linea = LeerArchivo.ReadLine(); // esto es para que pase de linea 
            }
            Console.WriteLine("Lista de numeros:");
            lista_numeros.Sort();
            foreach (string elemento in lista_numeros)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();
            //7
            Random[] U = new Random [100];
            int max = 90;
            int min = 100;
            for (int i = 0; i < U.Length; i++)
            {
                
                if (i > max) 
                {
                    max = i;
                    Console.Write("max: " + i);
                }
                
                if (i < min) 
                {
                    min = i;
                    Console.Write("min: " + i);
                }
            }
            //8
            Console.WriteLine("Diga un numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija entre sumar o multiplicar hasta su numero, s o m ");
            string h = (Console.ReadLine());
            if (h == "s")
            {
                for (int i = 1; i <= 1; i++)
                {
                    for (int j=1; j<= a; j++)
                    {
                        Console.WriteLine("{0} + {1} = {2}", a, j, (a + j));
                    }
                }
            }
            else if (h == "m")
            {
                for (int i = 1; i <= 1; i++)
                {
                    for (int j = 1; j <= a; j++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", a, j, (a * j));
                    }
                }
            }
            //10
            Console.WriteLine("Diga un numero para potenciar por si mismo: ");
            int pot = int.Parse(Console.ReadLine());
            double res;
            for (int i = 1; i <= pot; i++)
            {
                res = Math.Pow(pot, pot); 
                Console.WriteLine(res + " , ");
            }
            //11
            Console.WriteLine("Cuanto cuesta tu compra? ");
            int comp = int.Parse(Console.ReadLine());
            if ( comp > 100)
            {
                Console.WriteLine("Tu descuento es del 10% ");
            }
            else if (comp <=100 && comp > 50)
            {
                Console.WriteLine("Tu descuento es del 20% ");
            }
            else Console.WriteLine("No tienes descuento");
            //15
            Console.WriteLine("Mostrar las 30 primeras potencias de 3 y la suma de ellos.");
            double result;
            double totes=0;
            for (int i = 1; i <= 30; i++)
            {
                result = Math.Pow(i, 3);
                Console.WriteLine(result + " , ");
                totes += result;
            }
            Console.WriteLine("total:" + totes);
            
            //serie de Fibonacci
            Console.WriteLine("Serie de Fibonacci");
            int primNumero = 0;
            int segNumero = 1;
            int limite = 10000;
            int x; //lugar donde guardo el "Primer numero" anterior para poder sumar y seguir con la serie
            while (primNumero + segNumero <= limite)
            {
                Console.Write((primNumero + segNumero) + " - ");
                x = primNumero;
                primNumero = segNumero;
                segNumero = x + primNumero;
            }
            do
            {
                Console.Write("entra al do while");
                Console.Write((primNumero + segNumero) + " - ");
                x = primNumero;
                primNumero = segNumero;
                segNumero = x + primNumero;

            } while (primNumero + segNumero <= limite);
            //Llamadas
            Console.WriteLine("\nllamadas");
            double precio;
            int minutos;
            Console.WriteLine("Cuanto tiempo duro la llamada en minutos: ");
            int m = int.Parse(Console.ReadLine());
            if (m <= 3) Console.WriteLine("la llamada aun no se cobra");
            else
            {
                minutos = m - 3;
                precio = (minutos * 0.50) + 0.5;
                Console.Write("El precio de su llamada es: " + precio + "$");
            }
            //ciclos
            for (int i = 1; i <= 9; i += 1)
            {
                for (int j = 1; j <= 3; j += 1)
                {
                    for (int l = 1; l <= 3; l++)
                    {
                        if (l > 3)
                        {
                            l = 1;
                        }
                        Console.WriteLine("{0} {1} {2}", i, j, l);
                        i++;
                        //console.WriteLine(Espacio1[i, j, l]);
                    }
                }
            }
            //algoritmo 25 y 205
            int numero25 = 25;
            int numero205 = 205;
            int total = 0;
            for (numero25 = 26; numero25 <= numero205; numero25 += 10)
            {
                Console.Write(numero25 + " - ");
                total += numero25;
            }
            Console.Write("total:" + total + " ");
            
            //Matrices
           //4)
                Int16[,] matriz1 = new Int16[4, 5];
                Int16[,] matriz2 = new Int16[4, 5];
                Random nAleatorio = new Random();
                Random nAleatorio2 = new Random();
                int resultado = 0;
                int resultado2 = 0;
                for (short i = 0; i < 4; i++)
                {
                    for (short j = 0; j < 4; j++)
                    {
                        matriz1[i, j] = (Int16)nAleatorio.Next(1, 9);
                        resultado = matriz1[i, j];
                    }
                }
                for (short i = 0; i < 4; i++)
                {
                    for (short j = 0; j < 4; j++)
                    {
                        matriz2[i, j] = (Int16)nAleatorio.Next(1, 9);
                        resultado2 = matriz2[i, j];
                    }
                }
                Console.WriteLine("Suma de las matricez: " + (resultado + resultado2));
                Console.WriteLine("Multiplicacion de las matricez: " + (resultado * resultado2));

            //5)
            Int16[,] matrizVentas = new Int16[3, 5];
            Random nCualquiera = new Random();
            int[] VentanoVendedor = new int[3];
            int[] Ventano = new int[5];
            int resultadoMatriz = 0;
            for (short i = 0; i < 3; i++)
            {
                for (short j = 0; j < 5; j++)
                {
                    matrizVentas[i, j] = (Int16)nCualquiera.Next(1, 9);
                }
            }
            for (short i = 0; i < 3; i++)
            {
                for (short j = 0; j < 5; j++)
                {
                    resultadoMatriz += matrizVentas[i, j];
                }
                VentanoVendedor[i] = resultadoMatriz;
                resultadoMatriz = 0;
                Console.WriteLine("las ventas del año del empleado: "+ i+ " son:" + VentanoVendedor[i]);
            }
            for (short i = 0; i < 5; i++)
            {
                for (short j = 0; j < 3; j++)
                {
                    resultadoMatriz += matrizVentas[j, i];
                }
                Ventano[i] = resultadoMatriz;
                resultadoMatriz = 0;
                Console.WriteLine("las ventas del año: " + i + " son:" + Ventano[i]);
            }


            //B)
            //Lista de canciones
            /*  List<string> lista_canciones = new List<string>();
              lista_canciones.Add("happy");
              lista_canciones.Add("happier");
              lista_canciones.Add("talk");
              lista_canciones.Add("easy");
              lista_canciones = Readline();
              foreach (string elemento in lista_canciones)
              {
                  Console.WriteLine(elemento);
              }
              lista_canciones.Sort();
              string cancion = string(Console.ReadLine());

              Console.WriteLine(lista_canciones.Contains("happy"));*/
            //7. Archivos
            /* try
             {
                 List<string> lista_juegos = new List<string>();
                 string Linea;
                 string[] Arreglo;
                 float nota = 0F;
                 StreamReader LeerArchivo = new StreamReader("E:\\Definitivas.txt");
                 Linea = LeerArchivo.ReadLine();
                 while (Linea != null)
                 {
                     Arreglo = Linea.Split('|');
                     nota = (int.Parse(Arreglo[1]) + int.Parse(Arreglo[2]) + int.Parse(Arreglo[3])) / 3;
                     Console.WriteLine("El niño: " + Arreglo[0] + " tiene un promedio de " + nota);
                     lista_juegos.Add(Linea);
                     Linea = LeerArchivo.ReadLine(); // esto es para que pase de linea 
                 }
                 Console.ReadKey();

             }
             catch (Exception error)
             {
                 Console.WriteLine("Ocurrió Error en " + error);
             }*/
        }
    }
}
