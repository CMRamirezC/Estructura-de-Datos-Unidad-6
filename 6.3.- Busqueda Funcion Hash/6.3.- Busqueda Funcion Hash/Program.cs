using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3.__Busqueda_Funcion_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Condicion = true;
            do
            {
                try
                {
                    Console.Clear();
                    Hashtable FuncionHash = new Hashtable();// se crea hastable para poder acceder a la funcion de busqueda de hash
                    FuncionHash.Add("A001", "Cesar Ramirez"); // se agregan 10 personas con su respectivo numero de folio el la tabla hash 
                    FuncionHash.Add("A002", "Samantha Ibarguen");
                    FuncionHash.Add("A003", "Dulce Villalobos");
                    FuncionHash.Add("A004", "Pedro Acevedo");
                    FuncionHash.Add("A005", "Jose Venegas");
                    FuncionHash.Add("A006", "Julio Chavez");
                    FuncionHash.Add("A007", "Maribel Cervantes");
                    FuncionHash.Add("A008", "Juan Ramirez");
                    FuncionHash.Add("A009", "Damian Molina");
                    FuncionHash.Add("A010", "Edy Cota");
                    Console.Title = " Busqueda en un registro de personas "; 
                    Console.WriteLine(" Bienvenido al registro por favor ingrese una opcion: "); // se indica al usuario que seleccione una opcion disponible
                    Console.Write(" 1.- Buscar registro   2.- Imprimir lista completa  3.- Salir: ");// menu de opciones disponibles
                    int opcion = int.Parse(Console.ReadLine());// se guarda la opcion que el usuario ingreso en una variable de tipo entero
                    switch (opcion)// switch 
                    {
                        case 1:// cuando el usuario ingrese el numero 1 (buscar registro)
                            Console.Write(" Ingrese su folio para realizar la busqueda: ");// se le preguntara al usuario el numero de folio con el que desea realizar la busqueda del registro 
                            string noFolio = Console.ReadLine();// se guarda el folio ingresado por le usuario en una variable de tipo string 
                            if (FuncionHash.ContainsKey(noFolio))// si la tabla hash "FuncionHash" contiene como llave el numero de folio ingresado por el usuario 
                                Console.WriteLine(" Registro encontrado con el Nombre: [{0}]", FuncionHash[noFolio]);// se imprime mensaje de que el registro fue encontrado con el nombre correspondiente
                            else// de no ser asi
                                Console.WriteLine(" Registro no encontrado! ");// imprime mensaje de que no encontro el registro
                            Console.ReadKey();
                            break;
                        case 2:// cuando el usuario ingrese el numero 2 (imprimir lista completa)
                            ImprimirLista(FuncionHash);// se manda a llamar el metodo para imprimir la tabla completa con todos los registros 
                            Console.ReadKey();
                            break;
                        case 3:// cuando el usuario ingrese el numero 3 (salir)
                            Condicion = false;// la variable de tipo bool sera igual a false para que el ciclo do-while se detenga y acabe el programa
                            Console.ReadKey();
                            break;
                        default:// siu el usuario ingresa un numero diferente 
                            Console.WriteLine(" Opcion ingresada no valida! ");// imprime mensaje de opcion incorrecta
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Condicion == true);
        }
        public static void ImprimirLista(Hashtable lista)// metodo para imprimir una tabla hash, recibiendo como parametro la tabla hash
        {
            foreach (DictionaryEntry item in lista)// por cada para clave-valor que se encuentre en la tabla 
            {
                Console.WriteLine(" Folio: [{0}], Nombre: [{1}] ", item.Key, item.Value);// se imprimira el numero de folio (key) y el nombre (value)
            }
            Console.ReadKey();
        }
    }
}
