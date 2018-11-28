using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2QuickSort
{
    class Imprimir
    {
        public void ImprimirEjer(double[] arreglo)
        {
            Operaciones imprimir = new Operaciones(); //Simplemente se crea la clase imprimir en la cual se escribiran los numeros sin orden y ya con orden aplicando el quicksort
            Console.WriteLine("Numeros sin orden: ");
            foreach (var item in arreglo)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\nNumeros ordenados de menor a mayor: ");
            imprimir.QuickSort(arreglo, 0, arreglo.Length - 1);

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
