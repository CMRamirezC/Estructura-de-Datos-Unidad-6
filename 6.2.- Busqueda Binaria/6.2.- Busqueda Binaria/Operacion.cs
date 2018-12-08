using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2.__Busqueda_Binaria
{
    class Operacion
    {
        int[] arrayVector;// arreglo de datos tipo entero
        string[] arrayVectorS;// arreglo de datos tipo string
        int tamaño;// variable para guardar el tamaño del arreglo
        int indiceInicial = 0, indiceFinal;// variables para guardar el indice inicial del arreglo y el indice final del arreglo 
        public void LlenarArregloInt()// metodo para llenar el arreglo con datos de tipo int
        {
            Console.Write(" Ingrese cuantos numeros desea agregar al arreglo: ");
            tamaño = int.Parse(Console.ReadLine());
            arrayVector = new int[tamaño];

            for(int i = 0; i < arrayVector.Length; i++)// desde i = 0 hasta que sea menor al tamaño del arreglo
            {
                Console.SetCursorPosition(0,1); Console.Write(" Ingrese numero para la posicion [{0}] del arreglo: ", i + 1);// pregunta al usuario el numero que desea ingresar
                int item = int.Parse(Console.ReadLine());// se guarda el numero en una nueva variable de tipo int
                arrayVector[i] = item;// se agrega el numero en el arreglo en la posicion actual 
            }
            Console.WriteLine();
        }
        public void LlenarArregloString()// metodo para llenar el arreglo con datos de tipo string
        {
            Console.Write(" Ingrese cuantas letras desea agregar al arreglo: ");
            tamaño = int.Parse(Console.ReadLine());
            arrayVectorS = new string[tamaño];

            for (int i = 0; i < arrayVectorS.Length; i++)// desde i = 0 hasta que sea menor al tamaño del arreglo
            {
                Console.SetCursorPosition(0, 4); Console.Write(" Ingrese letra para la posicion [{0}] del arreglo: ", i + 1);// pregunta al usuario la letra que desea ingresar
                string item = Console.ReadLine();// se guarda la letra en una nueva variable de tipo string
                arrayVectorS[i] = item.ToUpper();// se agrega la letra en el arreglo en la posicion actual 
            }
            Console.WriteLine();
        }
        public void OrdenarArregloShellSortInt()//Metodo shell sort para ordenar el arreglo
        {
            tamaño = arrayVector.Length; // variable para guardar el tamaño del arreglo
            int gap = tamaño / 2; // variable para guardar la posicion media
            int temporal; // variable para guardado temporal de un dato 
            while (gap > 0)//mientras que la variable gap sea mayor a cero
            {
                for (int i = 0; i + gap < tamaño; i++)// ciclo for desde 0 hasta que i mas la variable gap sea mayor al tamaño del arreglo
                {
                    int j = i + gap; // variable para guardar la suma de i mas gap
                    temporal = arrayVector[j]; // se guarda el elemento en la posicion j como temporal
                    while (j - gap >= 0 && temporal < arrayVector[j - gap]) // mientras que j - gap sea mayor/igual a 0  y  el elemento temporal sea menor al elemento en la posicion j - gap
                    {
                        arrayVector[j] = arrayVector[j - gap];// se guardara el elemento de la posicion j - gap en la posicion j
                        j = j - gap;// j sera igual a j - gap
                    }
                    arrayVector[j] = temporal;// se guarda el elemento temporal en la posicion j del arreglo
                }
                gap = gap / 2;// se calcula gap como gap entre 2
            }
        }
        public void OrdenarArregloShellSortString()//Metodo shell sort para ordenar el arreglo de datos de tipo string
        {
            tamaño = arrayVectorS.Length; // variable para guardar el tamaño del arreglo
            int gap = tamaño / 2; // variable para guardar la posicion media
            string temporal; // variable para guardado temporal de un dato 
            while (gap > 0)//mientras que la variable gap sea mayor a cero
            {
                for (int i = 0; i + gap < tamaño; i++)// ciclo for desde 0 hasta que i mas la variable gap sea mayor al tamaño del arreglo
                {
                    int j = i + gap; // variable para guardar la suma de i mas gap
                    temporal = arrayVectorS[j]; // se guarda el elemento en la posicion j como temporal
                    while (j - gap >= 0 && Convert.ToInt32(temporal[0]) < Convert.ToInt32(arrayVectorS[j - gap][0])) // mientras que j - gap sea mayor/igual a 0  y  el elemento temporal sea menor al elemento en la posicion j - gap
                    {
                        arrayVectorS[j] = arrayVectorS[j - gap];// se guardara el elemento de la posicion j - gap en la posicion j
                        j = j - gap;// j sera igual a j - gap
                    }
                    arrayVectorS[j] = temporal;// se guarda el elemento temporal en la posicion j del arreglo
                }
                gap = gap / 2;// se calcula gap como gap entre 2
            }
        }
        public void BusquedaBinariaInt(int num)// metodo para hacer la busqueda bonaria mandando como parametro el numero que se desea buscar en el arreglo 
        {
            OrdenarArregloShellSortInt();// cada vez que se manda a llamar el metodo de busqueda este mismo mandara a llamar el metodo de ordenamiento del arreglo
            indiceFinal = arrayVector.Length - 1;// se declara el indice final como el tamaño del arreglo menos 1
            int indiceMedio = 0;// se crea una variable para el indice que se encuentra en medio del arreglo para partirlo en dos subarreglos
            bool encontrado = false;// variable bool que ayudara al hacer la busqueda
            while(indiceInicial <= indiceFinal && encontrado == false)// mientras que el indice inicial sea menor o igual al indice final y la variable encontrad sea false...
            {
                indiceMedio = (indiceInicial + indiceFinal) / 2;// se obtendra el indice medio con la division de la suma del indice inicial mas el indice final entre 2 
                if (arrayVector[indiceMedio] == num) // si el numero que esta en la posicion del indice medio es igual al numero que se mando 
                    encontrado = true;// entonces el numero si esta en el arreglo y la variable "encontrado" es igual a true
                else if (arrayVector[indiceMedio] > num)//si no se cumple la anterior condicion y si el numero en la posicion del indice medio es mayor al numero 
                    indiceFinal = indiceMedio - 1;// ahora el indice final sera el indice final sera el indice medio menos 1
                else// si no se cumplen ninguna de las dos entonces...
                    indiceInicial = indiceMedio + 1; // el indice inicial es igual al indice medio mas 1
            }
            if (encontrado == false)// si la variable "encontrado" es igual a false...
                Console.WriteLine("\n El numero: [{0}] no esta en el arreglo. ", num);// imprimira mensje de que el numero no esta en el arreglo
            else// en caso contrario (variable "encontrado" = true) entonces...
                Console.WriteLine("\n El numero: [{0}] si esta en el arreglo. ", num, indiceMedio + 1);// imprime mensaje de que el numero se encuentra en la posicion donde fue encontrado
        }
        public void BusquedaBinariaString(string letra)// metodo para hacer la busqueda bonaria mandando como parametro la letra que se desea buscar en el arreglo 
        {
            OrdenarArregloShellSortString();// cada vez que se manda a llamar el metodo de busqueda este mismo mandara a llamar el metodo de ordenamiento del arreglo
            indiceFinal = arrayVectorS.Length - 1;// se declara el indice final como el tamaño del arreglo menos 1
            int indiceMedio = 0;// se crea una variable para el indice que se encuentra en medio del arreglo para partirlo en dos subarreglos
            bool encontrado = false;// variable bool que ayudara al hacer la busqueda
            while (indiceInicial <= indiceFinal && encontrado == false)// mientras que el indice inicial sea menor o igual al indice final y la variable encontrad sea false...
            {
                indiceMedio = (indiceInicial + indiceFinal) / 2;// se obtendra el indice medio con la division de la suma del indice inicial mas el indice final entre 2 
                if (arrayVectorS[indiceMedio] == letra) // si la letra que esta en la posicion del indice medio es igual a la letra que se mando 
                    encontrado = true;// entonces la letra si esta en el arreglo y la variable "encontrado" es igual a true
                else if (Convert.ToInt32(arrayVectorS[indiceMedio][0]) > Convert.ToInt32(letra[0]))//si no se cumple la anterior condicion y si el numero ascci de la letra en la posicion del indice medio es mayor al numero ascci de la letra 
                    indiceFinal = indiceMedio - 1;// ahora el indice final sera el indice final sera el indice medio menos 1
                else// si no se cumplen ninguna de las dos entonces...
                    indiceInicial = indiceMedio + 1; // el indice inicial es igual al indice medio mas 1
            }
            if (encontrado == false)// si la variable "encontrado" es igual a false...
                Console.WriteLine("\n La letra: [{0}] no esta en el arreglo. ", letra);// imprimira mensje de que la letra no esta en el arreglo
            else// en caso contrario (variable "encontrado" = true) entonces...
                Console.WriteLine("\n La letra: [{0}] si esta en el arreglo. ", letra);// imprime mensaje de que la letra se encuentra en el arreglo
        }
        public void ImprimirArregloInt()// metodo para imprimir el arreglo 
        {
            for(int i = 0; i < arrayVector.Length; i++)
            {
                Console.Write(" [{0}] ",arrayVector[i]);
            }
        }
        public void ImprimirArregloString()// metodo para imprimir el arreglo 
        {
            for (int i = 0; i < arrayVectorS.Length; i++)
            {
                Console.Write(" [{0}] ", arrayVectorS[i]);
            }
        }
    }
}
