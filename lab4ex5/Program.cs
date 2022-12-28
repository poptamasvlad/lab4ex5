using System;

namespace lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
            apelati-o si afisati-i rezultatul.*/

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Suma(n));

        }
        static int Suma(int n)
        {
            int suma = 0;

            if(n > 1)
            {
                suma = Suma(n - 1);
            }

            suma += n;
            return suma;
            
        }
    }
}
