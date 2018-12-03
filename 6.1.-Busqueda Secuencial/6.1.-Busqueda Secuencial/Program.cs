using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._Busqueda_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " 6.1 Busqueda Secuencial ";
            Operacion op = new Operacion();
            Console.WriteLine(" Ejemplo 1: ");
            List<int> Calificaciones = new List<int> { 90, 100, 80, 78, 83 };// lista de calificacion de tipo entero
            Console.Write(" Que calificacion desea buscar? (70 - 100): ");// se le pregunta al usuario que calificacion desea buscar en la lista
            int item = int.Parse(Console.ReadLine());// se guarda el dato ingresado en una variable 
            bool respuesta = op.BusquedaInt(Calificaciones, item);// se guarda en una variable de tipo bool el retorno del metodo de busqueda, mandando como parametros la lista y el dato ingresado
            if (respuesta == true) // si la respuesta es true 
                Console.WriteLine(" Calificacion encontrada! ");// imprime mensaje de que encontro la calificacion 
            else // si es false
                Console.WriteLine(" Calificacion no encontrada! ");// imprime mensaje de que no encontro la calificacion
            Console.WriteLine();

            Console.WriteLine(" Ejemplo 2: ");
            List<string> Nombres = new List<string> { "Cesar", "Samantha", "Pedro", "Jose", "Dulce" };// lista de nombres de tipo string 
            Console.Write(" Que nombre desea buscar en la lista?: ");// se le pregunta al usuario que nombre desea buscar en la lista 
            string name = Console.ReadLine();// se guarda el dato ingresado en una variable string 
            bool respuesta2 = op.BusquedaString(Nombres, name);// se guarda en una variable de tipo bool el retorno del metodo de busqueda, mandando como parametros la lista y el dato ingresado
            if (respuesta2 == true)// si la respuesta es true 
                Console.WriteLine(" Nombre encontrado! ");// imprime mensaje de que encontro el nombre
            else // si es false
                Console.WriteLine(" Nombre no encontrado! ");// imprime mensaje de que no encontro el nombre
            Console.WriteLine();

        }
    }
}
