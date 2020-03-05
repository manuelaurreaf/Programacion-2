using MiBanco.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco
{
    class Program
    {
        private static bool esCliente = false;
        private static string nom = ""; 
        private static string numCuenta="";
        private static Cliente.listaTipoId tipoID;
        private static string numID;
        private static string tel= "";
        private static Cuenta.listaTipoCuenta tipoCuenta;
        private static long valorInicial=0;
        private static Cliente cliente;
        
        static void Main(string[] args)
        {
             try
             {
               short Opcion1 =-4;
                do
                {
                    Opcion1 = Menu();
                    try 
                    {
                        switch(Opcion1)
                        {
                            case 1: 
                                Console.WriteLine(CrearCuenta());
                                break;
                            case 2: 
                                 Console.WriteLine(VerCuenta());
                                break;
                            case 3: 
                                 Console.WriteLine(Consignar());
                                break;
                            case 4: 
                                 Console.WriteLine(Retirar());
                                break;
                            case 5: 
                                 Console.WriteLine(CerrarCuenta());
                                break;
                            case 0: 
                                 Console.WriteLine("Ha salido exitosamente");
                                break;
                            default:
                                 Console.WriteLine("Error en el Menu");
                                break;
                        }    
                    }
                    catch(Exception) 
                    {
                        Opcion1 = -4;
                    }
                }
                while(Opcion1 !=0); 
                Console.WriteLine("Ha finalizado el programa"); 

             }
            catch (Exception e)
             {
                throw new Exception("Error en el main " + e);
             } 
          
            
        }
          private static short Menu()
          {
            short Opcion2 = -1;
            do 
            { 
                Console.WriteLine("1 - Abrir Cuenta nueva");
                Console.WriteLine("2 - Ver Cuentas");
                Console.WriteLine("3 - Consignar a una cuenta");
                Console.WriteLine("4 - Retirar de una cuenta");
                Console.WriteLine("5 - Cerrar Cuenta");
                Console.WriteLine("0 - Salir");
                try
                {
                    Opcion2 = short.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Opcion2 = -1;
                }
            }
            while (Opcion2 < 0 || Opcion2 > 5); 
            return Opcion2;
          }
          private static string CrearCuenta()
          {
             string CuentaCreada = "", L ="";
             short x;
             try
             {
                  if (esCliente == false){
                    do
                    {
                        x = -1;
                        Console.WriteLine("Ingrese su nombre");
                        nom = Console.ReadLine().ToUpper();
                        if (string.IsNullOrEmpty(nom) || string.IsNullOrWhiteSpace(nom))
                        {
                        Console.WriteLine("Nombre ingresado invalido");
                        }
                        else {x= 1;} 
                    }while(x == -1); 
                        do
                        {
                            Console.WriteLine("Ingrese tipo de ID\nCC - TI - PA - CE");
                            L = Console.ReadLine().ToUpper();
                            switch (L)
                            {
                            case "CC":
                                tipoID = Cliente.listaTipoId.CC;
                                x = 1;
                                break;
                            case "TI":
                                x = 1;
                                tipoID = Cliente.listaTipoId.TI;
                                break;
                            case "PA":
                                tipoID = Cliente.listaTipoId.PA;
                                x = 1;
                                break;
                            case "CE":
                                tipoID = Cliente.listaTipoId.CE;
                                x = 1;
                                break;
                            default:
                                x = -1;
                                break;
                            }
                         
                        } while (x==-1);
                  }
                  do 
                  {
                    x = -1; 
                    Console.WriteLine("Ingrese tipo de Cuenta: Ahorros o Corriente");
                    L = Console.ReadLine().ToUpper();
                    switch (L)
                    {
                        case "AHORROS":
                            tipoCuenta = Cuenta.listaTipoCuenta.Ahorros;
                            x = 1;
                            break;
                        case "CORRIENTE":
                            tipoCuenta = Cuenta.listaTipoCuenta.Corriente;
                            x = 1;
                            break;
                        default:
                            x = -1;
                            break;
                    }
                  }while (x == -1);
                Console.WriteLine("\n");
                if (esCliente==false)
                {
                    cliente = new Cliente(tipoID, numID, nom, tel);
                    CuentaCreada = "Cliente creado Satisfactoriamente:" + " Nombre " + cliente.Nombre + ", " + "Nro Id" + cliente.Id + "\n";
                    CuentaCreada += cliente.Abrir_Cuenta(tipoCuenta);
                    esCliente = true;
                }
                else
                {
                    Console.WriteLine(cliente.Abrir_Cuenta(tipoCuenta));
                }
             }
             catch (Exception)
             {
                 throw new Exception( "Hubo un error creando la cuenta, Intentalo nuevamente mas tarde");
             }
            return CuentaCreada; 
          }
        private static string VerCuenta()
        {
            string CuentaCreada = "";
            try 
            {
                foreach (Cuenta i in cliente.CuentaBanco)
                {
                    if (i.Estado == Cuenta.listaTipoEstado.A)
                    {
                        CuentaCreada += "\n" + i.NroCuenta +"  "+i.TipoCuenta;
                    }
                }
            
            }
            catch (Exception)
            {
                throw new Exception("Error mostrando las cuentas");
            } 
            return CuentaCreada; 
        }
          private static string Consignar()
          {
            string CuentaCreada = "";
            try 
            {
                
            
            }
            catch (Exception)
            {
                throw new Exception("Error en la consignación");
            } 
            return CuentaCreada; 
          }
          private static string Retirar()
          {
            string CuentaCreada = "";
            try 
            {
               
            }
            catch (Exception)
            {
                throw new Exception("Error en el retiro");
            } 
            return CuentaCreada; 
          }
          private static string CerrarCuenta()
          {
            string CuentaCreada = "";
            try 
            {
               
            
            }
            catch (Exception)
            {
                throw new Exception("Error Cerrando la cuenta");
            } 
            return CuentaCreada; 
          }
    }
}
