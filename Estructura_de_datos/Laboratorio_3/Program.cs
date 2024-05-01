
//OPERACIONES BÁSICAS:

//1) REALIZA LA SUMA, RESTA, MULTIPLICACIÓN Y DIVISIÓN DE DOS NÚMEROS INGRESADOS POR EL USUARIO.      

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese el primer número
        Console.WriteLine("Por favor ingresa el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicitar al usuario que ingrese el segundo número
        Console.WriteLine("Por favor ingresa el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones matemáticas
        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;

        // Verificar si el segundo número es distinto de cero
        double division = 0;
        if (numero2 != 0)
        {
            division = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        // Mostrar los resultados
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
        // Solicitar la base del triángulo al usuario
        Console.WriteLine("Por favor ingresa la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        // Solicitar la altura del triángulo al usuario
        Console.WriteLine("Por favor ingresa la altura del triángulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        // Calcular el área del triángulo
        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        // Mostrar el área del triángulo
        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
    }
}


//CALCULADORA DE FACTORIAL:  

//4) CREA UNA FUNCIÓN QUE CALCULE LA FACTORIAL DE UN NÚMERO.  

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número para calcular su factorial
        Console.WriteLine("Por favor ingresa un número para calcular su factorial:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcular el factorial del número ingresado
        long factorial = CalcularFactorial(numero);

        // Mostrar el resultado
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    // Método para calcular el factorial de un número
    static long CalcularFactorial(int n)
    {
        // Verificar si el número es negativo (no se puede calcular el factorial de números negativos)
        if (n < 0)
        {
            throw new ArgumentException("No se puede calcular el factorial de un número negativo.");
        }

        // Inicializar el factorial como 1
        long factorial = 1;

        // Calcular el factorial del número
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
        // Solicitar al usuario que ingrese un número para verificar si es primo
        Console.WriteLine("Por favor ingresa un número para verificar si es primo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verificar si el número es primo
        bool esPrimo = VerificarPrimo(numero);

        // Mostrar el resultado
        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }

    // Método para verificar si un número es primo
    static bool VerificarPrimo(int num)
    {
        // Si el número es menor o igual a 1, no es primo
        if (num <= 1)
        {
            return false;
        }

        // Verificar si el número es divisible por algún número menor que él
        // Si encuentra algún divisor distinto de 1 y de sí mismo, no es primo
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        // Si no se encontró ningún divisor distinto de 1 y de sí mismo, entonces es primo
        return true;
    }
}

//INVERSIÓN DE CADENA:  

//6) TOMA UNA CADENA DE TEXTO Y MUESTRA SU INVERSIÓN.  

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una cadena de texto
        Console.WriteLine("Por favor ingresa una cadena de texto:");
        string texto = Console.ReadLine();

        // Invertir la cadena de texto
        string textoInvertido = InvertirCadena(texto);

        // Mostrar la cadena invertida
        Console.WriteLine($"La cadena invertida es: {textoInvertido}");
    }

    // Método para invertir una cadena de texto
    static string InvertirCadena(string cadena)
    {
        // Convertir la cadena a un arreglo de caracteres
        char[] caracteres = cadena.ToCharArray();

        // Invertir el arreglo de caracteres
        Array.Reverse(caracteres);

        // Crear una nueva cadena a partir del arreglo invertido
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
        // Solicitar al usuario los límites del rango
        Console.WriteLine("Por favor ingresa el límite inferior del rango:");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor ingresa el límite superior del rango:");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma de los números pares en el rango especificado
        int sumaPares = CalcularSumaPares(limiteInferior, limiteSuperior);

        // Mostrar la suma de los números pares
        Console.WriteLine($"La suma de los números pares en el rango [{limiteInferior}, {limiteSuperior}] es: {sumaPares}");
    }

    // Método para calcular la suma de los números pares en un rango
    static int CalcularSumaPares(int limiteInferior, int limiteSuperior)
    {
        int suma = 0;

        // Iterar a través de los números en el rango y sumar los pares
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
        // Crear un array para almacenar los cuadrados de los primeros 10 números naturales
        int[] cuadrados = new int[10];

        // Calcular los cuadrados de los primeros 10 números naturales
        for (int i = 1; i <= 10; i++)
        {
            cuadrados[i - 1] = i * i; // Guardar el cuadrado de cada número en el array
        }

        // Mostrar los cuadrados en el array
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
        // Solicitar al usuario que ingrese una cadena de texto
        Console.WriteLine("Por favor ingresa una cadena de texto:");
        string texto = Console.ReadLine();

        // Contar el número de vocales en la cadena de texto
        int numVocales = ContarVocales(texto);

        // Mostrar el resultado
        Console.WriteLine($"El número de vocales en la cadena es: {numVocales}");
    }

    // Método para contar el número de vocales en una cadena de texto
    static int ContarVocales(string cadena)
    {
        int conteo = 0;

        // Convertir la cadena a minúsculas para hacer la comparación de las vocales
        cadena = cadena.ToLower();

        // Iterar a través de cada carácter de la cadena y verificar si es una vocal
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
        // Imprimir los primeros 10 números de la serie Fibonacci
        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(CalcularFibonacci(i));
        }
    }

    // Método para calcular el número de Fibonacci en una posición dada
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

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese la cantidad de números
        Console.WriteLine("Por favor ingresa la cantidad de números:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        // Crear un array para almacenar los números ingresados
        int[] numeros = new int[cantidad];

        // Solicitar al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Ingresa el número {i + 1}:");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenar los números de menor a mayor
        Array.Sort(numeros);

        // Mostrar los números ordenados
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
        Solicitar al usuario que ingrese una palabra
        Console.WriteLine("Por favor ingresa una palabra:");
        string palabra = Console.ReadLine();

        Verificar si la palabra es un palíndromo
        bool esPalindromo = VerificarPalindromo(palabra);

        Mostrar el resultado
        if (esPalindromo)
        {
            Console.WriteLine($"{palabra} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"{palabra} no es un palíndromo.");
        }
    }

    Método para verificar si una palabra es un palíndromo
    static bool VerificarPalindromo(string palabra)
    {
        Convertir la palabra a minúsculas para hacer la comparación de manera no sensible a mayúsculas / minúsculas
        palabra = palabra.ToLower();

        Iterar a través de la mitad de la palabra y comparar los caracteres simétricos
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

        // Leer el número ingresado por el usuario
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("¡Entrada inválida! Debes ingresar un número entero.");
            return;
        }

        // Mostrar la tabla de multiplicar
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
        // Solicitar al usuario que ingrese el radio del círculo
        Console.WriteLine("Por favor ingresa el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el área del círculo
        double area = CalcularAreaCirculo(radio);

        // Mostrar el área del círculo
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }

    // Método para calcular el área de un círculo
    static double CalcularAreaCirculo(double radio)
    {
        // Fórmula para calcular el área de un círculo: A = π * r^2
        return Math.PI * radio * radio;
    }
}

//SUMA DE DÍGITOS:  

//15) TOMA UN NÚMERO ENTERO Y CALCULA LA SUMA DE SUS DÍGITOS.

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero
        Console.WriteLine("Por favor ingresa un número entero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma de los dígitos del número
        int sumaDigitos = CalcularSumaDigitos(numero);

        // Mostrar la suma de los dígitos del número
        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");
    }

    // Método para calcular la suma de los dígitos de un número entero
    static int CalcularSumaDigitos(int numero)
    {
        // Inicializar la variable para almacenar la suma de los dígitos
        int suma = 0;

        // Iterar a través de los dígitos del número y sumarlos
        while (numero != 0)
        {
            // Obtener el último dígito del número
            int digito = numero % 10;

            // Agregar el dígito a la suma
            suma += digito;

            // Eliminar el último dígito del número
            numero /= 10;
        }

        return suma;
    }
}