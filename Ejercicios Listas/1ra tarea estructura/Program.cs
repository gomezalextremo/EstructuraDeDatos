////Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.
//class Programa_1
//{
//    static void Main()
//    {
//        // Declarar variables para almacenar los números ingresados por el usuario
//        double num1, num2;

//        // Solicitar al usuario que ingrese el primer número
//        Console.Write("Ingrese el primer número: ");
//        num1 = Convert.ToDouble(Console.ReadLine());

//        // Solicitar al usuario que ingrese el segundo número
//        Console.Write("Ingrese el segundo número: ");
//        num2 = Convert.ToDouble(Console.ReadLine());

//        // Realizar las operaciones aritméticas
//        double suma = num1 + num2;
//        double resta = num1 - num2;
//        double multiplicacion = num1 * num2;

//        // Verificar si el segundo número es cero para evitar una división por cero
//        double division;
//        if (num2 != 0)
//        {
//            division = num1 / num2;
//        }
//        else
//        {
//            Console.WriteLine("Error: no se puede dividir entre cero.");
//            return;
//        }

//        // Mostrar los resultados
//        Console.WriteLine("La suma es: " + suma);
//        Console.WriteLine("La resta es: " + resta);
//        Console.WriteLine("La multiplicación es: " + multiplicacion);
//        Console.WriteLine("La división es: " + division);
//    }
//}


////Solicita un número al usuario y determina si es par o impar
//class Programa_2
//{
//    static void Main()
//    {
//        // Solicitar al usuario que ingrese un número
//        Console.Write("Ingrese un número: ");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        // Determinar si el número es par o impar
//        if (numero % 2 == 0)
//        {
//            Console.WriteLine("El número es par.");
//        }
//        else
//        {
//            Console.WriteLine("El número es impar.");
//        }
//    }
//}

////Pide la base y la altura de un triángulo al usuario y calcula su área.
//class Programa_3
//{
//    static void Main()
//    {
//        // Solicitar al usuario que ingrese la base y la altura del triángulo
//        Console.Write("Ingrese la base del triángulo: ");
//        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Ingrese la altura del triángulo: ");
//        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

//        // Calcular el área del triángulo
//        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

//        // Mostrar el resultado
//        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
//    }
//}


////Crea una función que calcule la factorial de un número.

//{
//    class Programa_4
//{
//    static void Main()
//    {
//        // Pide al usuario que ingrese un número
//        Console.Write("Ingrese un número para calcular su factorial: ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        // Calcula el factorial usando un ciclo `for`
//        int resultadoConFor = FactorialConFor(num);
//        Console.WriteLine("El factorial de " + num + "  es " + resultadoConFor);


//    }

//    // Calcula el factorial de un número usando un ciclo `for`
//    static int FactorialConFor(int n)
//    {
//        int resultado = 1;

//        // Ciclo desde 2 hasta n, multiplicando el resultado actual por i en cada iteración
//        for (int i = 2; i <= n; i++)
//        {
//            resultado *= i;
//        }

//        // Devuelve el resultado final
//        return resultado;
//    }
//}
//}

//Verifica si un número ingresado por el usuario es primo o no.
//class Program_5
//{
//    static void Main()
//    {
//        // Pide al usuario que ingrese un número
//        Console.Write("Ingrese un número: ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        // Verifica si el número es primo
//        if (EsPrimo(num))
//        {
//            Console.WriteLine(num + " es un número primo.");
//        }
//        else
//        {
//            Console.WriteLine(num + " no es un número primo.");
//        }
//    }

//    // Función para verificar si un número es primo
//    static bool EsPrimo(int num)
//    {
//        // Comprueba los casos base
//        if (num < 2) return false;
//        if (num == 2) return true;
//        if (num % 2 == 0) return false;

//        // Comprueba la divisibilidad hasta la raíz cuadrada del número
//        for (int i = 3; i * i <= num; i += 2)
//        {
//            if (num % i == 0) return false;
//        }

//        // Si no se encontraron factores, el número es primo
//        return true;
//    }
//}

// //Toma una cadena de texto y muestra su inversión.
//class Programa_6
//{
//    static void Main()
//    {
//        // Pide al usuario que ingrese una cadena de texto
//        Console.Write("Ingrese una cadena de texto: ");
//        string cadena = Console.ReadLine();

//        // Llama a la función para invertir la cadena
//        string inversa = InvertirCadena(cadena);

//        // Imprime el resultado
//        Console.WriteLine("La cadena invertida es: " + inversa);
//    }

//    // Función que inverte una cadena de texto
//    static string InvertirCadena(string cadena)
//    {
//        // Crea una cadena vacía para almacenar los caracteres invertidos
//        string inversa = "";

//        // Recorre la cadena original desde el final hasta el principio
//        for (int i = cadena.Length - 1; i >= 0; i--)
//        {
//            // Agrega cada carácter a la cadena invertida
//            inversa += cadena[i];
//        }

//        // Devuelve la cadena invertida
//        return inversa;
//    }
//}

////Calcula la suma de los números pares en un rango especificado por el usuario.
//class Programa_7
//{
//    static void Main()
//    {
//        // Solicita al usuario que ingrese el rango
//        Console.Write("Ingrese el inicio del rango: ");
//        int start = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ingrese el fin del rango: ");
//        int end = Convert.ToInt32(Console.ReadLine());

//        // Calcula la suma de los números pares en el rango
//        long sum = CalculateEvenSum(start, end);

//        // Imprime el resultado
//        Console.WriteLine("La suma de los números pares entre " + start + " y " + end + " es: " + sum);
//    }

//    // Función para calcular la suma de los números pares en un rango
//    static long CalculateEvenSum(int start, int end)
//    {
//        // Inicializa la suma
//        long sum = 0;

//        // Itera sobre el rango y agrega los números pares a la suma
//        for (int i = start; i <= end; i++)
//        {
//            if (i % 2 == 0)
//            {
//                sum += i;
//            }
//        }

//        // Devuelve la suma
//        return sum;
//    }
//}

////Crea una lista de los cuadrados de los primeros 10 números naturales.
//class Programa_8
//{
//    static void Main()
//    {
//        // Genera una lista de los cuadrados de los primeros 10 números naturales
//        var squares = Enumerable.Range(1, 10).Select(x => x * x);

//        // Imprime cada cuadrado en la lista
//        foreach (int num in squares)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}

////Cuenta el número de vocales en una cadena de texto.
//class Programa_9
//{
//    static void Main()
//    {
//        // Solicita al usuario que ingrese una cadena de texto
//        Console.Write("Ingrese una cadena de texto: ");
//        string input = Console.ReadLine();

//        // Cuenta el número de vocales en la cadena
//        int vowelCount = CountVowels(input);

//        // Imprime el resultado
//        Console.WriteLine("La cadena tiene " + vowelCount + " vocales.");
//    }

//    // Función para contar el número de vocales en una cadena
//    static int CountVowels(string input)
//    {
//        // Define el conjunto de vocales
//        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

//        // Inicializa el contador de vocales
//        int count = 0;

//        // Itera sobre cada carácter en la cadena
//        foreach (char c in input)
//        {
//            // Verifica si el carácter es una vocal
//            if (vowels.Contains(char.ToLower(c)))
//            {
//                count++;
//            }
//        }

//        // Devuelve el contador de vocales
//        return count;
//    }
//}

////Genera los primeros 10 números de la serie Fibonacci.
//    class Programa_10
//    {
//        static void Main(string[] args)
//        {
//            // Imprime los primeros 10 números de la serie Fibonacci
//            Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(Fibonacci(i));
//            }
//        }

//        // Función para calcular el enésimo número de la serie Fibonacci
//        static int Fibonacci(int n)
//        {
//            if (n == 0)
//            {
//                // Si n es 0, devuelve 0
//                return 0;
//            }
//            else if (n == 1)
//            {
//                // Si n es 1, devuelve 1
//                return 1;
//            }
//            else
//            {
//                // De lo contrario, calcula el enésimo número de la serie Fibonacci
//                // utilizando la recursividad para calcular los dos números anteriores
//                // y sumarlos
//                return Fibonacci(n - 1) + Fibonacci(n - 2);
//            }
//        }
//    }

////Ordena una lista de números ingresados por el usuario de menor a mayor.
//   class Programa_11
//   {
//       static void Main(string[] args)
//       {
//           // Solicitar al usuario el número de elementos que desea en la lista
//           Console.Write("Por favor ingrese el número de elementos que desea en la lista: ");
//           int numElementos = Convert.ToInt32(Console.ReadLine());

//           // Inicializar una lista para almacenar los elementos
//           int[] lista = new int[numElementos];

//           // Solicitar al usuario el valor de cada elemento
//           for (int i = 0; i < numElementos; i++)
//           {
//               Console.Write("Por favor ingrese el valor del elemento " + (i + 1) + ": ");
//               lista[i] = Convert.ToInt32(Console.ReadLine());
//           }

//           // Ordenar la lista utilizando el algoritmo de Burbuja
//           for (int i = 0; i < numElementos - 1; i++)
//           {
//               for (int j = 0; j < numElementos - i - 1; j++)
//               {
//                   if (lista[j] > lista[j + 1])
//                   {
//                       // Intercambiar los elementos si están en el orden incorrecto
//                       int temp = lista[j];
//                       lista[j] = lista[j + 1];
//                       lista[j + 1] = temp;
//                   }
//               }
//           }

//           // Imprimir la lista ordenada
//           Console.WriteLine("La lista ordenada es: ");
//           for (int i = 0; i < numElementos; i++)
//           {
//               Console.WriteLine(lista[i]);
//           }
//       }
//   }


////Verifica si una palabra ingresada por el usuario es un palíndromo.
//    class Programa_12
//    {
//        static void Main(string[] args)
//        {
//            // Solicitar al usuario que ingrese una palabra
//            Console.Write("Por favor ingrese una palabra: ");
//            string word = Console.ReadLine().ToLower();

//            // Verificar si la palabra es un palíndromo
//            bool isPalindrome = true;
//            for (int i = 0; i < word.Length / 2; i++)
//            {
//                if (word[i] != word[word.Length - 1 - i])
//                {
//                    isPalindrome = false;
//                    break;
//                }
//            }

//            // Mostrar el resultado
//            if (isPalindrome)
//            {
//                Console.WriteLine("La palabra es un palíndromo.");
//            }
//            else
//            {
//                Console.WriteLine("La palabra no es un palíndromo.");
//            }
//        }
//    }

////Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario.
//    class Programa_13
//    {
//        static void Main(string[] args)
//        {
//            // Solicitar al usuario que ingrese un número
//            Console.Write("Por favor ingrese un número: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            // Generar la tabla de multiplicar del número hasta 12
//            for (int i = 1; i <= 12; i++)
//            {
//                Console.WriteLine($"{number} x {i} = {number * i}");
//            }
//        }
//}

////Pide el radio de un círculo al usuario y calcula su área.
//   class Programa_14
//   {
//       static void Main(string[] args)
//       {
//           // Solicitar al usuario que ingrese el radio del círculo
//           Console.Write("Por favor ingrese el radio del círculo: ");
//           double radius = Convert.ToDouble(Console.ReadLine());

//           // Calcular el área del círculo
//           double area = Math.PI * Math.Pow(radius, 2);

//           // Imprimir el resultado
//           Console.WriteLine($"El área del círculo es: {area}");
//       }
//   }

////Toma un número entero y calcula la suma de sus dígitos.
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Solicitar al usuario que ingrese un número entero
//            Console.Write("Por favor ingrese un número entero: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            // Inicializar la variable que almacenará la suma de los dígitos
//            int sum = 0;

//            // Calcular la suma de los dígitos
//            while (number > 0)
//            {
//                sum += number % 10;
//                number /= 10;
//            }

//            // Imprimir el resultado
//            Console.WriteLine($"La suma de los dígitos es: {sum}");
//        }
//    }