// ////1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.
//class Programa_1
//{
//    static void Main()
//    {
//        // Inicializamos la función recursiva con el primer número par, que es 2
//        ImprimirNumerosPares(2);
//    }
//    static void ImprimirNumerosPares(int numero)
//    {
//        // Condición de parada: si el número es mayor que 100, no hacemos nada más
//        if (numero <= 100)
//        {
//            // Imprimimos el número actual
//            Console.WriteLine(numero);

//            // Llamamos a la función recursiva con el siguiente número par
//            ImprimirNumerosPares(numero + 2);
//        }
//        // Si no se cumple la condición, la función termina y no se llama a sí misma
//    }
//}

//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.
//class Programa_2
//{
//    static void Main()
//    {
//        // Pedimos al usuario que ingrese un número
//        Console.WriteLine("Por favor, ingresa un número:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        // Llamamos a la función recursiva con el valor del número ingresado
//        Console.WriteLine("La suma de los números desde 1 hasta " + numero + " es: " + SumaRecursiva(numero));
//    }

//    static int SumaRecursiva(int n)
//    {
//        // Condición de parada: si n es igual a 1, devolvemos 1
//        if (n == 1)
//        {
//            return 1;
//        }

//        // Llamamos a la función recursiva con el valor de n - 1 y sumamos el valor de n
//        return n + SumaRecursiva(n - 1);
//    }
//}


//3)	Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.
//class Programa_3
//{
//    static void Main()
//    {
//        // Pedimos al usuario que ingrese un número
//        Console.WriteLine("Por favor, ingresa un número:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        // Llamamos a la función recursiva para imprimir la pirámide de números
//        ImprimirPiramide(numero);
//    }

//    static void ImprimirPiramide(int n, int fila = 1)
//    {
//        // Caso base: si la fila actual es mayor que n, salimos de la función recursiva
//        if (fila > n)
//        {
//            return;
//        }

//        // Imprimimos los números de la fila actual
//        for (int i = 1; i <= fila; i++)
//        {
//            Console.Write(i + " ");
//        }

//        // Pasamos a la siguiente línea después de imprimir la fila actual
//        Console.WriteLine();

//        // Llamamos recursivamente a la función para la siguiente fila
//        ImprimirPiramide(n, fila + 1);
//    }
//}

//4)	Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
// 4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
//class Programa_4
//{
//    static void Main()
//    {
//        // Pedimos al usuario que ingrese un número
//        Console.WriteLine("Por favor, ingresa un número:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        // Llamamos a la función recursiva para imprimir la pirámide de números invertidos
//        ImprimirPiramideInvertida(numero);
//    }

//    static void ImprimirPiramideInvertida(int n)
//    {
//        // Caso base: si n es menor que 1, no hay nada que imprimir
//        if (n < 1)
//        {
//            return;
//        }

//        // Imprimimos la pirámide de números invertidos
//        for (int fila = n; fila >= 1; fila--)
//        {
//            // Imprimimos espacios en blanco para centrar los números en cada fila
//            for (int espacio = 0; espacio < n - fila; espacio++)
//            {
//                Console.Write("  ");
//            }

//            // Imprimimos los números en orden descendente
//            for (int i = fila; i >= 1; i--)
//            {
//                Console.Write(i + " ");
//            }

//            // Pasamos a la siguiente línea después de imprimir la fila actual
//            Console.WriteLine();
//        }
//    }
//}

//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n.
//class Programa_5
//{
//    static void Main()
//    {
//        // Pedimos al usuario que ingrese un número
//        Console.WriteLine("Por favor, ingresa un número para imprimir su tabla de multiplicar:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        // Llamamos a la función recursiva para imprimir la tabla de multiplicar del número ingresado
//        ImprimirTablaMultiplicar(numero);
//    }

//    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
//    {
//        // Caso base: si el multiplicador es mayor que 10, terminamos la recursión
//        if (multiplicador > n)
//        {
//            return;
//        }

//        // Imprimimos el resultado de la multiplicación
//        Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));

//        // Llamamos recursivamente a la función con el siguiente multiplicador
//        ImprimirTablaMultiplicar(n, multiplicador + 1);
//    }
//}

////6) Crea una matriz de números reales.
//class Programa_6
//{
//    static void Main()
//    {
//        // Declaramos una matriz de enteros de 3 filas y 2 columnas
//        double[,] matriz = new double[3, 2];

//        // Asignamos valores a la matriz
//        matriz[0, 0] = 1.5;
//        matriz[0, 1] = 2.3;
//        matriz[1, 0] = 3.7;
//        matriz[1, 1] = 4.2;
//        matriz[2, 0] = 5.9;
//        matriz[2, 1] = 6.1;

//        // Imprimimos la matriz
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////7) Crea una matriz de números complejos.
//using System.Numerics;
//class Programa_7
//{
//    static void Main()
//    {
//        // Declaramos una matriz de números complejos de 3 filas y 3 columnas
//        Complex[,] matriz = new Complex[3, 3];

//        // Asignamos valores a la matriz
//        matriz[0, 0] = new Complex(1, 2);
//        matriz[0, 1] = new Complex(3, 4);
//        matriz[0, 2] = new Complex(5, 6);
//        matriz[1, 0] = new Complex(7, 8);
//        matriz[1, 1] = new Complex(9, 10);
//        matriz[1, 2] = new Complex(11, 12);
//        matriz[2, 0] = new Complex(13, 14);
//        matriz[2, 1] = new Complex(15, 16);
//        matriz[2, 2] = new Complex(17, 18);

//        // Imprimimos la matriz
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//8)	Crea una matriz de matrices.
//class Programa_8
//{
//    static void Main()
//    {
//        // Declaramos una matriz de matrices de enteros de 2x2 y 3x3
//        int[][,] matrizDeMatrices = new int[2][,];

//        // Creamos las matrices internas y las asignamos a la matriz principal
//        matrizDeMatrices[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
//        matrizDeMatrices[1] = new int[3, 3] { { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

//        // Imprimimos la matriz de matrices
//        for (int i = 0; i < matrizDeMatrices.Length; i++)
//        {
//            Console.WriteLine($"Matriz {i + 1}:");
//            for (int j = 0; j < matrizDeMatrices[i].GetLength(0); j++)
//            {
//                for (int k = 0; k < matrizDeMatrices[i].GetLength(1); k++)
//                {
//                    Console.Write(matrizDeMatrices[i][j, k] + "\t");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
//}

//9) Accede al elemento central de una matriz.
//class Programa_9
//{
//    static void Main()
//    {
//        // Declaramos una matriz de enteros de tamaño 5x5
//        int[,] matriz = new int[5, 5]
//        {
//            { 1, 2, 3, 4, 5 },
//            { 6, 7, 8, 9, 10 },
//            { 11, 12, 13, 14, 15 },
//            { 16, 17, 18, 19, 20 },
//            { 21, 22, 23, 24, 25 }
//        };

//        // Calculamos las coordenadas del elemento central
//        int filaCentral = matriz.GetLength(0) / 2;
//        int columnaCentral = matriz.GetLength(1) / 2;

//        // Accedemos al elemento central de la matriz
//        int elementoCentral = matriz[filaCentral, columnaCentral];

//        // Imprimimos el elemento central
//        Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
//    }
//}

//10) Suma dos matrices de diferentes tamaños.
//class Programa_10
//{
//    static void Main()
//    {
//        // Declaramos dos matrices de enteros de 2x2
//        int[,] matriz1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
//        int[,] matriz2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };

//        // Creamos una nueva matriz para almacenar la suma
//        int[,] suma = new int[2, 2];

//        // Sumamos las matrices elemento a elemento
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                suma[i, j] = matriz1[i, j] + matriz2[i, j];
//            }
//        }

//        // Imprimimos la matriz resultante
//        Console.WriteLine("Suma de matrices:");
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.Write(suma[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//11) Multiplica una matriz por un número.

//class Programa_11
//{
//    static void Main()
//    {
//        // Declaramos una matriz de enteros de 2x2
//        int[,] matriz = new int[2, 2] { { 1, 2 }, { 3, 4 } };

//        // Declaramos un número entero
//        int numero = 5;

//        // Creamos una nueva matriz para almacenar la matriz multiplicada
//        int[,] matrizMultiplicada = new int[2, 2];

//        // Multiplicamos cada elemento de la matriz por el número
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                matrizMultiplicada[i, j] = matriz[i, j] * numero;
//            }
//        }

//        // Imprimimos la matriz resultante
//        Console.WriteLine("Matriz multiplicada por un número:");
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.Write(matrizMultiplicada[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//12) Calcula la media de los elementos de una matriz.

//class Programa_12
//{
//    static void Main()
//    {
//        // Declaramos una matriz de enteros de 2x2
//        int[,] matriz = new int[2, 2] { { 1, 2 }, { 3, 4 } };

//        // Inicializamos la variable suma en 0
//        int suma = 0;

//        // Contamos el número de elementos en la matriz
//        int elementos = 0;

//        // Recorremos cada elemento de la matriz y sumamos su valor
//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                suma += matriz[i, j];
//                elementos++;
//            }
//        }

//        // Calculamos la media de los elementos
//        double media = (double)suma / elementos;

//        // Imprimimos la media de los elementos
//        Console.WriteLine("Media de los elementos de la matriz: " + media);
//    }
//}

//Ejercicio 1:Crea una matriz de números aleatorios de tamaño 100x100.
//class Programa_13
//{
//    static void Main()
//    {
//        // Creamos una instancia de la clase Random
//        Random random = new Random();

//        // Creamos una matriz de enteros de tamaño 100x100 con números aleatorios
//        int[,] matriz = new int[100, 100];
//        for (int i = 0; i < 100; i++)
//        {
//            for (int j = 0; j < 100; j++)
//            {
//                matriz[i, j] = random.Next(1, 101); // Generamos un número aleatorio entre 1 y 100
//            }
//        }

//        // Imprimimos la matriz en la consola
//        for (int i = 0; i < 100; i++)
//        {
//            for (int j = 0; j < 100; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////Ejercicio 2:Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.
//using System.Linq;

//class Programa_14
//{
//    static void Main()
//    {
//        // Declara una matriz de números enteros (puedes ajustar los valores según tu necesidad)
//        int[,] matriz = new int[,]
//        {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Calcula la media
//        double media = CalcularMedia(matriz);

//        // Calcula la mediana
//        double mediana = CalcularMediana(matriz);

//        // Calcula la desviación estándar
//        double desviacionEstandar = CalcularDesviacionEstandar(matriz);

//        // Imprime los resultados
//        Console.WriteLine($"Media: {media}");
//        Console.WriteLine($"Mediana: {mediana}");
//        Console.WriteLine($"Desviación Estándar: {desviacionEstandar}");
//    }

//    // Función para calcular la media
//    static double CalcularMedia(int[,] matriz)
//    {
//        int suma = 0;
//        int cantidadElementos = matriz.GetLength(0) * matriz.GetLength(1);

//        // Suma todos los elementos de la matriz
//        foreach (int numero in matriz)
//        {
//            suma += numero;
//        }

//        // Calcula la media
//        return (double)suma / cantidadElementos;
//    }

//    // Función para calcular la mediana
//    static double CalcularMediana(int[,] matriz)
//    {
//        // Convierte la matriz en una lista para facilitar el ordenamiento
//        var lista = matriz.Cast<int>().OrderBy(x => x).ToList();
//        int cantidadElementos = lista.Count;

//        // Si la cantidad de elementos es impar, la mediana es el valor central
//        if (cantidadElementos % 2 != 0)
//        {
//            return lista[cantidadElementos / 2];
//        }
//        // Si la cantidad de elementos es par, la mediana es el promedio de los dos valores centrales
//        else
//        {
//            int medio1 = lista[cantidadElementos / 2 - 1];
//            int medio2 = lista[cantidadElementos / 2];
//            return (medio1 + medio2) / 2.0;
//        }
//    }

//    // Función para calcular la desviación estándar
//    static double CalcularDesviacionEstandar(int[,] matriz)
//    {
//        // Calcula la media de los elementos de la matriz
//        double media = CalcularMedia(matriz);
//        int cantidadElementos = matriz.GetLength(0) * matriz.GetLength(1);
//        double sumaDiferenciasCuadrado = 0;

//        // Calcula la suma de las diferencias al cuadrado entre cada elemento y la media
//        foreach (int numero in matriz)
//        {
//            double diferencia = numero - media;
//            sumaDiferenciasCuadrado += diferencia * diferencia;
//        }

//        // Calcula la desviación estándar
//        return Math.Sqrt(sumaDiferenciasCuadrado / cantidadElementos);
//    }
//}

//Ejercicio 3:Escribe una función que encuentre el elemento máximo de una matriz.
//class Programa_15
//{
//    static int EncontrarMaximo(int[,] matriz)
//    {
//        int maximo = int.MinValue;
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                if (matriz[i, j] > maximo)
//                {
//                    maximo = matriz[i, j];
//                }
//            }
//        }
//        return maximo;
//    }

//    static void Main()
//    {
//        int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//        int maximo = EncontrarMaximo(matriz);
//        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
//    }
//}
//Ejercicio 4:Escribe una función que encuentre la submatriz de mayor suma de una matriz.

//Ejercicio 5:Escribe una función que encuentre la matriz de covarianza de dos matrices.
//using System;

//class Program
//{
//    static double[,] CalcularMatrizDeCovarianza(double[,] matriz1, double[,] matriz2)
//    {
//        int m = matriz1.GetLength(0);
//        int n = matriz1.GetLength(1);
//        if (m != matriz2.GetLength(0) || n != matriz2.GetLength(1))
//        {
//            throw new ArgumentException("Las matrices deben tener el mismo tamaño");
//        }

//        double[,] covarianza = new double[n, n];

//        // Calculamos la media de cada columna de las matrices
//        double[] media1 = new double[n];
//        double[] media2 = new double[n];
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                media1[j] += matriz1[i, j];
//                media2[j] += matriz2[i, j];
//            }
//        }
//        for (int j = 0; j < n; j++)
//        {
//            media1[j] /= m;
//            media2[j] /= m;
//        }

//        // Calculamos la matriz de covarianza
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                for (int k = 0; k < n; k++)
//                {
//                    covarianza[j, k] += (matriz1[i, j] - media1[j]) * (matriz2[i, k] - media2[k]);
//                }
//            }
//        }
//        for (int j = 0; j < n; j++)
//        {
//            for (int k = 0; k < n; k++)
//            {
//                covarianza[j, k] /= m;
//            }
//        }

//        return covarianza;
//    }

//    static void Main()
//    {
//        double[,] matriz1 = new double[3, 2] { { 1.0, 2.0 }, { 3.0, 4.0 }, { 5.0, 6.0 } };
//        double[,] matriz2 = new double[3, 2] { { 7.0, 8.0 }, { 9.0, 10.0 }, { 11.0, 12.0 } };
//        double[,] covarianza = CalcularMatrizDeCovarianza(matriz1, matriz2);
//        Console.WriteLine("La matriz de covarianza es:");
//        for (int i = 0; i < covarianza.GetLength(0); i++)
//        {
//            for (int j = 0; j < covarianza.GetLength(1); j++)
//            {
//                Console.Write(covarianza[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
