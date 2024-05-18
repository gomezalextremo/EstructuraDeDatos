using System;

class Program
{
    static void Main()
    {
        int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matrizB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        int[,] suma = SumarMatrices(matrizA, matrizB);

        Console.WriteLine("La suma de las matrices es:");
        ImprimirMatriz(suma);
    }

    static int[,] SumarMatrices(int[,] A, int[,] B)
    {
        int filas = A.GetLength(0);
        int columnas = A.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = A[i, j] + B[i, j];
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
