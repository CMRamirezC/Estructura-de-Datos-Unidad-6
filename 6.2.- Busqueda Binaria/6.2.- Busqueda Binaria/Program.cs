using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2.__Busqueda_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Condicion = true;
            string Opcion;
            do
            {
                try
                {
                    Operacion bBinaria = new Operacion();// se crea un a clase para acceder a los metodos
                    Console.WriteLine(" 1.- Busqueda binaria de numeros     2.- Busqueda binaria de letras ");
                    Console.Write(" Que ejercicio desea revisar? (1/2): ");
                    int opcion = int.Parse(Console.ReadLine());
                    switch(opcion)
                    {
                        case 1:
                            bBinaria.LlenarArregloInt();// se manda a llamar el metodo para llenar el arreglo 
                            bBinaria.ImprimirArregloInt();// se manda a llamar el metodo para imprimir el arreglo 
                            Console.Write("\n\n Que elemento del arreglo desea buscar?: ");// se pregunta que numero del arreglo desea buscar
                            int num = int.Parse(Console.ReadLine());// se guarda el numero en una variable
                            bBinaria.BusquedaBinariaInt(num);// se manda a llamar el metodo de busqueda binaria mandando como parametro el numero que el usuario desea buscar
                            Console.WriteLine();
                            break;
                        case 2:
                            bBinaria.LlenarArregloString();// se manda a llamar el metodo para llenar el arreglo 
                            bBinaria.ImprimirArregloString();// se manda a llamar el metodo para imprimir el arreglo 
                            Console.Write("\n\n Que elemento del arreglo desea buscar?: ");// se pregunta que numero del arreglo desea buscar
                            string letra = Console.ReadLine();// se guarda el numero en una variable
                            bBinaria.BusquedaBinariaString(letra.ToUpper());// se manda a llamar el metodo de busqueda binaria mandando como parametro el numero que el usuario desea buscar
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine(" Opcion no vailda... ");
                            break;
                    }   
                    Console.Write(" Desea reiniciar el programa? (Si/No): ");
                    Opcion = Console.ReadLine();
                    switch (Opcion.ToUpper())
                    {
                        case "SI":
                            Condicion = true;
                            Console.WriteLine(" Reiniciando programa, presione cualquier recla para continuar... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "NO":
                            Condicion = false;
                            Console.WriteLine(" Cerrando programa... ");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine(" Opcion incorrecta!, se reiniciara el programa... ");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Condicion == true);
        }
    }
}
