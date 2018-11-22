using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ordenamiento por metodo Burbuja");
                int tempo = 0;//inicializa una variable temporal
                Console.Write("Numeros a ingresar: ");
                int usuario = int.Parse(Console.ReadLine());
                int[] Nums = new int[usuario];//Arreglo definido por el usuario
                for (int i = 0; i < usuario; i++)
                {
                    Console.Write("Numero {0}: ", i + 1);
                    Nums[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < usuario; j++)//Comienza el metodo burbuja
                {
                    for (int k = 0; k < usuario - 1; k++)
                    {
                        if (Nums[j] < Nums[k])//Condicion que define si se ordena de menor a mayor o viceversa
                        {
                            tempo = Nums[j];//Se utiliza tempo de apoyo para conservar los valores antes de cambiarlos
                            Nums[j] = Nums[k];//cambios de valores de j
                            Nums[k] = tempo;//cambios de valores de k
                        }
                    }
                }
                Console.WriteLine("Numeros ya ordenados por metodo:");
                for (int i = 0; i < usuario; i++)
                {
                    Console.WriteLine("{0}.- {1}", (i + 1), Nums[i]);//Imprime ya ordenados
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
