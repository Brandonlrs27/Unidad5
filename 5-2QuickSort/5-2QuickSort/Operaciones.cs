using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2QuickSort
{
    class Operaciones
    {
        public void QuickSort(double[] Ejer, int valIn, int valFi) //Se crea el metodo QuickSort donde se envia parametro y 2 variables
        {
            int vari1 = valIn; //Se le asigna el valor inicial a variable 1
            int vari2 = valFi; //Igual con la final a variable 2
            double pivote = Ejer[(valIn + valFi) / 2]; //Aqui ira el numero que esta al centro del arreglo

            do
            {
                while (Ejer[vari1] < pivote) { vari1++; } //Mientras que el numero que esta en el arreglo Ejer con indice vari1 sea menor al pivote, se aumenta vari1
                while (Ejer[vari2] > pivote) { vari2--; } //Mientras que el numero que esta en el arreglo Ejer con indice vari2 sea mayor al pivote, se disminuye vari2

                if (vari1 <= vari2)
                {
                    double varAuxiliar = Ejer[vari1]; //Se crea una variable auxiliar la cual se le asigna el valor en Ejer con indice vari1
                    Ejer[vari1] = varAuxiliar; //Lo que esta en esa instancia se le asigna a la variable auxiliar
                    Ejer[vari1] = Ejer[vari2]; //Se le asigna lo de Ejer con indice vari1 a Ejer con indice vari2
                    Ejer[vari2] = varAuxiliar; //Se le asigna a auxiliar lo que esta en Ejer con indice vari2
                    vari1++; //Se incrementa vari1
                    vari2--; //Se disminuye vari2
                }

            } while (vari1 <= vari2); //Esto se ejecutara siempre y cuando vari1 sea menor o igual a vari2

            if (vari2 > valIn) //Si lo que esta en vari2 es mayor al valor inicial se aplica el metodo Quicksort
            {
                QuickSort(Ejer, valIn, vari2);
            }

            if (vari1 < valFi) //Si lo que esta en vari1 es menor al valor final se aplica el metodo Quicksort
            { 
                QuickSort(Ejer, vari1, valFi);
            }
        }
    }
}
