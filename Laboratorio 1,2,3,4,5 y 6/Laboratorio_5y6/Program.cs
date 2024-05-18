//4. Desarrollo y Actividades Ejercicio:
//Recursividad:
//Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.
public static void ImprimirNumerosPares(int inicio, int fin)
{
    if (inicio <= fin)
    {
        if (inicio % 2 == 0)
        {
            Console.Write(inicio + " ");
        }
        ImprimirNumerosPares(inicio + 1, fin);
    }
}

// Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.


public static int Suma(int n)
{
    if (n == 1)
    {
        return 1;
    }
    return n + Suma(n - 1);
}
// Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.

public static void ImprimirPiramideNumeros(int n)
{
    if (n > 0)
    {
        ImprimirPiramideNumeros(n - 1);
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
//Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
public static void ImprimirPiramideInvertidaNumeros(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        ImprimirPiramideInvertidaNumeros(n - 1);
    }
}

// Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n.

public static void TablaDeMultiplicar(int n, int multiplicador)
{
    if (multiplicador <= 10)
    {
        Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));
        TablaDeMultiplicar(n, multiplicador + 1);
    }
}

//Matrices
//6) Crea una matriz de números reales:

double[,] matrizReales = new double[3, 3];

//7) Crea una matriz de números complejos.

System.Numerics.Complex[,] matrizComplejos = new System.Numerics.Complex[filas, columnas];

//8)Crear matriz de matrices:

int[,,] matrizDeMatrices = new int[3, 3, 3]; // Ejemplo de matriz de matrices 3x3x3

//9)Acceder al elemento central de una matriz:

int filaCentral = matriz.GetLength(0) / 2;
int columnaCentral = matriz.GetLength(1) / 2;
int elementoCentral = matriz[filaCentral, columnaCentral];

//10)Sumar dos matrices de diferentes tamaños:

double[,] matrizResultado = new double[Math.Max(matriz1.GetLength(0), matriz2.GetLength(0)), 
    Math.Max(matriz1.GetLength(1), matriz2.GetLength(1))];
for (int i = 0; i < matrizResultado.GetLength(0); i++)
{
    for (int j = 0; j < matrizResultado.GetLength(1); j++)
    {
        double valor1 = (i < matriz1.GetLength(0) && j < matriz1.GetLength(1)) ? matriz1[i, j] : 0;
        double valor2 = (i < matriz2.GetLength(0) && j < matriz2.GetLength(1)) ? matriz2[i, j] : 0;
        matrizResultado[i, j] = valor1 + valor2;
    }
}
//11) Multiplicar una matriz por un número:
public static double[,] MultiplicarMatrizPorEscalar(double[,] matriz, double escalar)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    double[,] resultado = new double[filas, columnas];
    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            resultado[i, j] = matriz[i, j] * escalar;
        }
    }
    return resultado;
}
//12) Calcular la media de los elementos de una matriz:
public static double Media(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    double suma = 0;
    foreach (double elemento in matriz)
    {
        suma += elemento;
    }
    return suma / (filas * columnas);
}

//Ejercicios de Matrices
//Ejercicio 1:Crear matriz de números aleatorios de tamaño 100x100:
Random aleatorio = new Random();
double[,] matrizAleatoria = new double[100, 100];
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        matrizAleatoria[i, j] = aleatorio.NextDouble();
    }
}
//Ejercicio 2:Calcular media, mediana y desviación estándar:

static void Main(string[] args)
{
    double[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    double media = CalcularMedia(matriz);
    Console.WriteLine("Media: " + media);

    double mediana = CalcularMediana(matriz);
    Console.WriteLine("Mediana: " + mediana);

    double desviacionEstandar = CalcularDesviacionEstandar(matriz);
    Console.WriteLine("Desviación estándar: " + desviacionEstandar);
}

static double CalcularMedia(double[,] matriz)
{
    int elementos = matriz.GetLength(0) * matriz.GetLength(1);
    double suma = 0;

    foreach (double elemento in matriz)
    {
        suma += elemento;
    }

    return suma / elementos;
}

static double CalcularMediana(double[,] matriz)
{
    double[] elementos = matriz.Cast<double>().ToArray();
    Array.Sort(elementos);

    int elementosTotales = elementos.Length;

    if (elementosTotales % 2 == 0)
    {
        return (elementos[elementosTotales / 2] + elementos[elementosTotales / 2 - 1]) / 2.0;
    }
    else
    {
        return elementos[elementosTotales / 2];
    }
}

static double CalcularDesviacionEstandar(double[,] matriz)
{
    double media = CalcularMedia(matriz);
    double sumaCuadradosDiferencia = 0;

    foreach (double elemento in matriz)
    {
        sumaCuadradosDiferencia += Math.Pow(elemento - media, 2);
    }

    int elementos = matriz.GetLength(0) * matriz.GetLength(1);
    double varianza = sumaCuadradosDiferencia / elementos;

    return Math.Sqrt(varianza);
}
//Ejercicio 3:Encontrar el elemento máximo de una matriz:
public static double EncontrarElementoMaximo(double[,] matriz)
{
    double maximo = matriz[0, 0];
    foreach (double elemento in matriz)
    {
        if (elemento > maximo)
        {
            maximo = elemento;
        }
    }
    return maximo;
}
//Ejercicio 4:Encontrar la submatriz de mayor suma:
public static double[,] EncontrarSubmatrizConMayorSuma(double[,] matriz, 
    int filasSubmatriz, int columnasSubmatriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    double maximaSuma = double.MinValue;
    double[,] submatrizMaximaSuma = new double[filasSubmatriz, columnasSubmatriz];
    for (int i = 0; i <= filas - filasSubmatriz; i++)
    {
        for (int j = 0; j <= columnas - columnasSubmatriz; j++)
        {
            double suma = 0;
            for (int k = i; k < i + filasSubmatriz; k++)
            {
                for (int l = j; l < j + columnasSubmatriz; l++)
                {
                    suma += matriz[k, l];
                }
            }
            if (suma > maximaSuma)
            {
                maximaSuma = suma;
                for (int m = 0; m < filasSubmatriz; m++)
                {
                    for (int n = 0; n < columnasSubmatriz; n++)
                    {
                        submatrizMaximaSuma[m, n] = matriz[i + m, j + n];
                    }
                }
            }
        }
    }
    return submatrizMaximaSuma;
}

//Ejercicio 5:Encontrar la matriz de covarianza de dos matrices:

public static double[,] MatrizCovarianza(double[,] matriz1, double[,] matriz2)
{
    int filas1 = matriz1.GetLength(0);
    int columnas1 = matriz1.GetLength(1);
    int filas2 = matriz2.GetLength(0);
    int columnas2 = matriz2.GetLength(1);
    if (filas1 != filas2 || columnas1 != columnas2)
    {
        throw new ArgumentException("Las matrices deben tener las mismas dimensiones");
    }
    double[,] covarianza = new double[columnas1, columnas2];
    for (int i = 0; i < columnas1; i++)
    {
        for (int j = 0; j < columnas2; j++)
        {
            double media1 = Media(ObtenerColumna(matriz1, i));
            double media2 = Media(ObtenerColumna(matriz2, j));
            double suma = 0;
            for (int k = 0; k < filas1; k++)
            {
                suma += (matriz1[k, i] - media1) * (matriz2[k, j] - media2);
            }
            covarianza[i, j] = suma / filas1;
        }
    }
    return covarianza;
}

public static double[] ObtenerColumna(double[,] matriz, int indiceColumna)
{
    int filas = matriz.GetLength(0);
    double[] columna = new double[filas];
    for (int i = 0; i < filas; i++)
    {
        columna[i] = matriz[i, indiceColumna];
    }
    return columna;
}
