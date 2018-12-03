using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3Radix
{
    class Radix
    {
        //metodo radix
        public void radix(int[] Abase)//De parametro recibe un arreglo
        {
            int var1, var2, conta;
            for (var1 = 31; var1 >= 0; var1--)
            {
                int[] aux = new int[Abase.Length];//Arreglo auxiliar para acomodar valores
                conta = 0;//Un contador igualado a 0
                for (var2 = 0; var2 < Abase.Length; var2++)
                {
                    bool move = Abase[var2] << var1 >= 0;//Si el valor es igual a 0, lo movera
                    if (var1 == 0 ? !move : move)//Si var1 es igual igual a cero entonces entra la condicion, el ? es un operador ternario
                    {
                        aux[conta] = Abase[var2];//Se intercambian los arreglos
                        conta++;
                    }
                    else//Si no es cierta la condicion, entra aqui
                    {
                        Abase[var2 - conta] = Abase[var2];
                    }
                }
                for (var2 = conta; var2 < aux.Length; var2++)//Este es para copiar del arreglo aux al real
                {
                    aux[var2] = Abase[var2 - conta];
                }
                Abase = aux;//Se copia lo del arreglo
            }
            Mostararreglo(Abase);//Muestra el arreglo sin orden
        }
        public void Mostararreglo(int[] Asegundo)//Metodo para mostrar el arreglo
        {
            int k;
            for (k = 0; k < Asegundo.Length; k++)
            {
                Console.Write(Asegundo[k] + ", ");
            }
            Console.ReadKey();
        }
        public void Ejercicio()
        {
            int[] Ejer1 = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };//Arreglo del ejercicio
            int[] Ejer2 = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] Ejer3 = { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] Ejer4 = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] Ejer5 = { 25, 108, 1024, 12, 351, 251, 39 };
            Console.WriteLine("Ejercicio 1 ordenado :");
            radix(Ejer1);//se muestra cada uno de los arreglos ya ordenados
            Console.Clear();
            Console.WriteLine("Ejercicio 2 ordenado :");
            radix(Ejer2);
            Console.Clear();
            Console.WriteLine("Ejercicio 3 ordenado :");
            radix(Ejer3);
            Console.Clear();
            Console.WriteLine("Ejercicio 4 ordenado :");
            radix(Ejer4);
            Console.Clear();
            Console.WriteLine("Ejercicio 5 ordenado :");
            radix(Ejer5);
            Console.ReadKey();
        }
    }
}
        
    


    

