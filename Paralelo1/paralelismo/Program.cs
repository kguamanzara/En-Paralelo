using System;
using System.Threading;
using System.Threading.Tasks;

namespace Paralelo
{
    class Program
    {
        public static void Main()
        {
            int[] Numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15, 16, 17, 18, 19, 20 };  //Crear un array
            Console.Write("Normal foreach: ");
            foreach (var numeros in Numeros)
            {
                Console.Write(longCalculation(numeros));   //Impresion del 1 al 1000
            }
           
            Console.Write("Paralelismo foreach : ");    //Salida en desorden
            Parallel.ForEach(Numeros, numeros => {  
                Console.WriteLine(longCalculation(numeros));
            });
        }

        private static int longCalculation(int numeros)
        {
            Thread.Sleep(1000); 
            return numeros * numeros;
        }
    }
}