using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._Busqueda_Secuencial
{
    class Operacion
    {
        public bool BusquedaInt(List<int> lista, int item)// metodo para realizar busqueda de tipo de dato entero
        {
            int posicion = 0;
            bool encontrado = false;
            while (posicion < lista.Count)//ciclo para recorrer la lista
            {
                if (lista[posicion] == item)// si el elemento de la lista en la posicion actual es igual al elemento item
                {
                    encontrado = true;
                    return encontrado;// retorna true
                }
                else// si no existe un elemento igual
                {
                    posicion = posicion + 1;// aumenta la posicion en la lista
                }
            }
            return encontrado;// retorna la variable de tipo bool 
        }
        public bool BusquedaString(List<string> lista, string item)// el mismo metodo pero para tipo de datos de texto
        {
            int posicion = 0;
            bool encontrado = false;
            while (posicion < lista.Count)
            {
                if (lista[posicion] == item)
                {
                    encontrado = true;
                    return encontrado;
                }
                else
                {
                    posicion = posicion + 1;
                }
            }
            return encontrado;
        }
    }
}
