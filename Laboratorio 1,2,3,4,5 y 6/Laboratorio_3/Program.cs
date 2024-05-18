
//OPERACIONES BÁSICAS:

//1) REALIZA LA SUMA, RESTA, MULTIPLICACIÓN Y DIVISIÓN DE DOS NÚMEROS INGRESADOS POR EL USUARIO.      


using System;

class Program
{
    static void Main(string[] args)
    {
   
        Console.WriteLine("Por favor ingresa el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor ingresa el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;

        double division = 0;
        if (numero2 != 0)
        {
            division = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        if (numero2 != 0)
        {
            Console.WriteLine($"División: {division}");
        }
    }
}

//VERIFICACIÓN DE NÚMERO PAR O IMPAR:

//2) SOLICITA UN NÚMERO AL USUARIO Y DETERMINA SI ES PAR O IMPAR.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa un número entero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }
    }
}

//ÁREA DE UN TRIÁNGULO:  

//3) PIDE LA BASE Y LA ALTURA DE UN TRIÁNGULO AL USUARIO Y CALCULA SU ÁREA.  


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor ingresa la altura del triángulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
    }
}

//CALCULADORA DE FACTORIAL:  

//4) CREA UNA FUNCIÓN QUE CALCULE LA FACTORIAL DE UN NÚMERO.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa un número para calcular su factorial:");
        int numero = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(numero);

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static long CalcularFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("No se puede calcular el factorial de un número negativo.");
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

//NÚMERO PRIMO:

//5) VERIFICA SI UN NÚMERO INGRESADO POR EL USUARIO ES PRIMO O NO

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa un número para verificar si es primo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = VerificarPrimo(numero);

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }

    static bool VerificarPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

//INVERSIÓN DE CADENA:  

//6) TOMA UNA CADENA DE TEXTO Y MUESTRA SU INVERSIÓN.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa una cadena de texto:");
        string texto = Console.ReadLine();

        string textoInvertido = InvertirCadena(texto);

        Console.WriteLine($"La cadena invertida es: {textoInvertido}");
    }

    static string InvertirCadena(string cadena)
    {
        char[] caracteres = cadena.ToCharArray();

        Array.Reverse(caracteres);

        string cadenaInvertida = new string(caracteres);

        return cadenaInvertida;
    }
}

//SUMA DE NÚMEROS PARES:  

//7) CALCULA LA SUMA DE LOS NÚMEROS PARES EN UN RANGO ESPECIFICADO POR EL USUARIO.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Algoritmo para sumar numero en un rango espeficado");
        Console.WriteLine("Por favor ingresa el límite inferior del rango:");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor ingresa el límite superior del rango:");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        int sumaPares = CalcularSumaPares(limiteInferior, limiteSuperior);

        Console.WriteLine($"La suma de los números pares en el rango [{limiteInferior}, {limiteSuperior}] es: {sumaPares}");
    }
    static int CalcularSumaPares(int limiteInferior, int limiteSuperior)
    {
        int suma = 0;

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        return suma;
    }
}

////LISTA DE CUADRADOS:  

////8) CREA UNA LISTA DE LOS CUADRADOS DE LOS PRIMEROS 10 NÚMEROS NATURALES.  

class Program
{
    static void Main(string[] args)
    {
        int[] cuadrados = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            cuadrados[i - 1] = i * i; // Guardar el cuadrado de cada número en el array
        }

        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }
    }
}

//CONTADOR DE VOCALES:  

//9) CUENTA EL NÚMERO DE VOCALES EN UNA CADENA DE TEXTO.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa una cadena de texto:");
        string texto = Console.ReadLine();

        int numVocales = ContarVocales(texto);

        Console.WriteLine($"El número de vocales en la cadena es: {numVocales}");
    }

    static int ContarVocales(string cadena)
    {
        int conteo = 0;

        cadena = cadena.ToLower();

        foreach (char caracter in cadena)
        {
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                conteo++;
            }
        }

        return conteo;
    }
}

//NÚMEROS DE LA SERIE FIBONACCI:  

//10) GENERA LOS PRIMEROS 10 NÚMEROS DE LA SERIE FIBONACCI.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(CalcularFibonacci(i));
        }
    }

    static int CalcularFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int fibonacci = 0;
        int a = 0;
        int b = 1;

        for (int i = 2; i <= n; i++)
        {
            fibonacci = a + b;
            a = b;
            b = fibonacci;
        }

        return fibonacci;
    }
}

//ORDENAMIENTO DE LISTA:  

//11) ORDENA UNA LISTA DE NÚMEROS INGRESADOS POR EL USUARIO DE MENOR A MAYOR.  


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa la cantidad de números:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Ingresa el número {i + 1}:");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("Los números ordenados de menor a mayor son:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}

//PALÍNDROMO:  

//12) VERIFICA SI UNA PALABRA INGRESADA POR EL USUARIO ES UN PALÍNDROMO.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa una palabra:");
        string palabra = Console.ReadLine();

        bool esPalindromo = VerificarPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine($"{palabra} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{palabra} no es un palíndromo.");
        }
    }

    static bool VerificarPalindromo(string palabra)
    {
        palabra = palabra.ToLower();

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                return false; // Si los caracteres no coinciden, la palabra no es un palíndromo
            }
        }

        return true; // Si todos los caracteres coinciden, la palabra es un palíndromo
    }
}

//GENERADOR DE TABLAS DE MULTIPLICAR:  

//13) CREA UN PROGRAMA QUE GENERE LA TABLA DE MULTIPLICAR DE UN NÚMERO INGRESADO POR EL USUARIO.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generador de Tabla de Multiplicar");
        Console.Write("Ingresa un número para generar su tabla de multiplicar: ");

        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("¡Entrada inválida! Debes ingresar un número entero.");
            return;
        }

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

//CÁLCULO DEL ÁREA DE UN CÍRCULO:  

//14) PIDE EL RADIO DE UN CÍRCULO AL USUARIO Y CALCULA SU ÁREA.  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);

        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }

    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }
}

//SUMA DE DÍGITOS:  

//15) TOMA UN NÚMERO ENTERO Y CALCULA LA SUMA DE SUS DÍGITOS.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingresa un número entero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");
    }

    static int CalcularSumaDigitos(int numero)
    {
        int suma = 0;

        while (numero != 0)
        {
            int digito = numero % 10;

            suma += digito;

            numero /= 10;
        }

        return suma;
    }
}