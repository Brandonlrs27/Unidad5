using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {         
            Imprimir Ejer = new Imprimir(); //Se crea la clase Ejer para introducir valores en distintos arreglos
            double[] E1 = new double[] { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 };
            double[] E2 = new double[] { 1, 3, 5, 7, 8, 3, 9, (Math.Sqrt(2) / 2), 16.5664, 12, 0, 10 };
            double[] E3 = new double[] { 3, 7, 15, 4 / 3, 155, 100, 15, Math.Sqrt(3), 10, 3, 2 };
            double[] E4 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

            //Se imprimen los arreglos sin orden y con orden
            Console.WriteLine("1.- ");
            Ejer.ImprimirEjer(E1);
            Console.WriteLine("\n2.- ");
            Console.ReadKey();
            Ejer.ImprimirEjer(E2);
            Console.WriteLine("\n3.- ");
            Console.ReadKey();
            Ejer.ImprimirEjer(E3);
            Console.WriteLine("\n4.- ");
            Console.ReadKey();
            Ejer.ImprimirEjer(E4);
            Console.ReadKey();
        }
    }
}
