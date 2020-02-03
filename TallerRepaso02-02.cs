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
            //har[,,] Espacio1 = new char[9, 9, 9];

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
        }
    }
}
