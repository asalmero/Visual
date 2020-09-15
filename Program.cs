using System;
using System.Net;

namespace AplicacionPrueba
{
    class Program
    {

        static void Main(string[] args)

        { 
             int number, i, j, count = 1; // Variables Principales
            Console.Write("Enter a Row: "); //Row value
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            
            for (j = 1; j <= number; j++) // Ciclo Principal
            {
                for (i = 1; i <= count; i++) // For Anidado
                    Console.Write(" "); //Espacios
                count--;

                for (i = 1; i <= 2 * j - 1; i++) // Segundo Ciclo Anidado
                    Console.Write("*"); //Impresion de mi simbolo
                Console.WriteLine();
            }
        
            Console.WriteLine();
             
        }
    }
   
}
