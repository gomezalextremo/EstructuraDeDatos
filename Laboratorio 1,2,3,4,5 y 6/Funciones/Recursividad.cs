
using System;

namespace Funciones
{
    class Recursividad
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Factorial(5));
        }

        public static int Factorial(int x)
        {
            if (x == 0 || x ==1)

            {
                return 1;
            }

            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
