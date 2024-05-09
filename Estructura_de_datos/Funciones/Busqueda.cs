using System;

class Busqueda
{
    // Búsqueda secuencial
    public static int SequentialSearch(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    // Búsqueda binaria (requiere que el array esté ordenado previamente)
    public static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Comprueba si x está presente en el medio
            if (arr[mid] == x)
            {
                return mid;
            }

            // Si x es mayor, ignora la mitad izquierda
            if (arr[mid] < x)
            {
                left = mid + 1;
            }
            // Si x es menor, ignora la mitad derecha
            else
            {
                right = mid - 1;
            }
        }

        // Si x no está presente en el array
        return -1;
    }

    // Método principal
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };

        int x = 10;

        // Búsqueda secuencial
        int resultSequential = SequentialSearch(arr, x);
        if (resultSequential == -1)
        {
            Console.WriteLine("Elemento no encontrado (Búsqueda secuencial)");
        }
        else
        {
            Console.WriteLine("Elemento encontrado en el índice " + resultSequential + " (Búsqueda secuencial)");
        }

        // Búsqueda binaria
        int resultBinary = BinarySearch(arr, x);
        if (resultBinary == -1)
        {
            Console.WriteLine("Elemento no encontrado (Búsqueda binaria)");
        }
        else
        {
            Console.WriteLine("Elemento encontrado en el índice " + resultBinary + " (Búsqueda binaria)");
        }
    }
}

