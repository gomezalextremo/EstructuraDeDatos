//Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos.
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();
        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> primos = EncontrarNumerosPrimos(numeros);

        Console.WriteLine("Números primos:");
        foreach (int primo in primos)
        {
            Console.WriteLine(primo);
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static HashSet<int> EncontrarNumerosPrimos(List<int> numeros)
    {
        HashSet<int> primos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
                primos.Add(numero);
        }

        return primos;
    }
}


//2.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        Console.WriteLine("Ingrese la letra por la que desea filtrar las palabras:");
        char letra = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Para un salto de línea después de la entrada de la letra

        HashSet<string> palabrasFiltradas = FiltrarPalabrasPorLetra(palabras, letra);

        Console.WriteLine($"Palabras que comienzan con '{letra}':");
        foreach (string palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLetra(string[] palabras, char letra)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
                palabrasFiltradas.Add(palabra);
        }

        return palabrasFiltradas;
    }
}


////3. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son divisibles por un número determinado.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        Console.WriteLine("Ingrese el divisor para filtrar los números:");
        int divisor = int.Parse(Console.ReadLine());

        HashSet<int> numerosDivisibles = FiltrarNumerosDivisibles(numeros, divisor);

        Console.WriteLine($"Números divisibles por {divisor}:");
        foreach (int numero in numerosDivisibles)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> FiltrarNumerosDivisibles(List<int> numeros, int divisor)
    {
        HashSet<int> numerosDivisibles = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numero % divisor == 0)
                numerosDivisibles.Add(numero);
        }

        return numerosDivisibles;
    }
}


//4. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en ambos conjuntos.


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números del primer conjunto separados por espacios:");
        string entradaConjunto1 = Console.ReadLine();
        Console.WriteLine("Ingrese los números del segundo conjunto separados por espacios:");
        string entradaConjunto2 = Console.ReadLine();

        // Convertir las entradas de usuario en arreglos de números
        HashSet<int> conjunto1 = ObtenerConjuntoDesdeEntrada(entradaConjunto1);
        HashSet<int> conjunto2 = ObtenerConjuntoDesdeEntrada(entradaConjunto2);

        HashSet<int> numerosComunes = ObtenerNumerosComunes(conjunto1, conjunto2);

        Console.WriteLine("Números presentes en ambos conjuntos:");
        foreach (int numero in numerosComunes)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerConjuntoDesdeEntrada(string entrada)
    {
        string[] numerosString = entrada.Split(' ');
        HashSet<int> conjunto = new HashSet<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                conjunto.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        return conjunto;
    }

    static HashSet<int> ObtenerNumerosComunes(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosComunes = new HashSet<int>(conjunto1);
        numerosComunes.IntersectWith(conjunto2);
        return numerosComunes;
    }
}

//5. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el primer conjunto pero no en el segundo.


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números del primer conjunto separados por espacios:");
        string entradaConjunto1 = Console.ReadLine();
        Console.WriteLine("Ingrese los números del segundo conjunto separados por espacios:");
        string entradaConjunto2 = Console.ReadLine();

        // Convertir las entradas de usuario en arreglos de números
        HashSet<int> conjunto1 = ObtenerConjuntoDesdeEntrada(entradaConjunto1);
        HashSet<int> conjunto2 = ObtenerConjuntoDesdeEntrada(entradaConjunto2);

        HashSet<int> numerosEnConjunto1NoEnConjunto2 = ObtenerNumerosEnConjunto1NoEnConjunto2(conjunto1, conjunto2);

        Console.WriteLine("Números en el primer conjunto pero no en el segundo:");
        foreach (int numero in numerosEnConjunto1NoEnConjunto2)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerConjuntoDesdeEntrada(string entrada)
    {
        string[] numerosString = entrada.Split(' ');
        HashSet<int> conjunto = new HashSet<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                conjunto.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        return conjunto;
    }

    static HashSet<int> ObtenerNumerosEnConjunto1NoEnConjunto2(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosEnConjunto1NoEnConjunto2 = new HashSet<int>(conjunto1);
        numerosEnConjunto1NoEnConjunto2.ExceptWith(conjunto2);
        return numerosEnConjunto1NoEnConjunto2;
    }
}


//6.Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el segundo conjunto pero no en el primero.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números del primer conjunto separados por espacios:");
        string entradaConjunto1 = Console.ReadLine();
        Console.WriteLine("Ingrese los números del segundo conjunto separados por espacios:");
        string entradaConjunto2 = Console.ReadLine();

        // Convertir las entradas de usuario en arreglos de números
        HashSet<int> conjunto1 = ObtenerConjuntoDesdeEntrada(entradaConjunto1);
        HashSet<int> conjunto2 = ObtenerConjuntoDesdeEntrada(entradaConjunto2);

        HashSet<int> numerosEnConjunto2NoEnConjunto1 = ObtenerNumerosEnConjunto2NoEnConjunto1(conjunto1, conjunto2);

        Console.WriteLine("Números en el segundo conjunto pero no en el primero:");
        foreach (int numero in numerosEnConjunto2NoEnConjunto1)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerConjuntoDesdeEntrada(string entrada)
    {
        string[] numerosString = entrada.Split(' ');
        HashSet<int> conjunto = new HashSet<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                conjunto.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        return conjunto;
    }

    static HashSet<int> ObtenerNumerosEnConjunto2NoEnConjunto1(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosEnConjunto2NoEnConjunto1 = new HashSet<int>(conjunto2);
        numerosEnConjunto2NoEnConjunto1.ExceptWith(conjunto1);
        return numerosEnConjunto2NoEnConjunto1;
    }
}


//7.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son anagramas.
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> anagramas = EncontrarAnagramas(palabras);

        Console.WriteLine("Anagramas encontrados:");
        foreach (string anagrama in anagramas)
        {
            Console.WriteLine(anagrama);
        }
    }

    static HashSet<string> EncontrarAnagramas(string[] palabras)
    {
        HashSet<string> anagramas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Sort(caracteres);
            string palabraOrdenada = new string(caracteres);

            if (!anagramas.Contains(palabraOrdenada))
            {
                HashSet<string> palabrasAnagramas = new HashSet<string>();
                palabrasAnagramas.Add(palabra);
                anagramas.Add(palabraOrdenada);

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (i != palabras.Length - 1 && palabras[i].Length == palabra.Length)
                    {
                        char[] tempCaracteres = palabras[i].ToCharArray();
                        Array.Sort(tempCaracteres);
                        string tempPalabraOrdenada = new string(tempCaracteres);

                        if (palabraOrdenada == tempPalabraOrdenada)
                            palabrasAnagramas.Add(palabras[i]);
                    }
                }

                if (palabrasAnagramas.Count > 1)
                    anagramas.UnionWith(palabrasAnagramas);
            }
        }

        return anagramas;
    }
}

//8.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos.

class Programa
{
    //static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

    // Convertir la entrada de usuario en un arreglo de palabras
    string[] palabras = entradaUsuario.Split(' ');

    HashSet<string> palindromos = EncontrarPalindromos(palabras);

    Console.WriteLine("Palíndromos encontrados:");
        foreach (string palindromo in palindromos)
        {
            Console.WriteLine(palindromo);
        }
    }

    static bool EsPalindromo(string palabra)
{
    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}

static HashSet<string> EncontrarPalindromos(string[] palabras)
{
    HashSet<string> palindromos = new HashSet<string>();

    foreach (string palabra in palabras)
    {
        if (EsPalindromo(palabra))
        {
            palindromos.Add(palabra);
        }
    }

    return palindromos;
}
}

//9. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada.
 

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese la longitud de las palabras que desea filtrar:");
        int longitud = int.Parse(Console.ReadLine());

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palabrasFiltradas = FiltrarPalabrasPorLongitud(palabras, longitud);

        Console.WriteLine($"Palabras de longitud {longitud} encontradas:");
        foreach (string palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLongitud(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return palabrasFiltradas;
    }
}


//10. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada.
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese la letra que desea buscar en las palabras:");
        char letra = Console.ReadLine()[0];

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palabrasConLetra = EncontrarPalabrasConLetra(palabras, letra);

        Console.WriteLine($"Palabras que contienen la letra '{letra}':");
        foreach (string palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> EncontrarPalabrasConLetra(string[] palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return palabrasConLetra;
    }
}


//11.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosOrdenados = ObtenerNumerosOrdenados(numeros);

        Console.WriteLine("Números ordenados de menor a mayor:");
        foreach (int numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosOrdenados(List<int> numeros)
    {
        HashSet<int> numerosOrdenados = new HashSet<int>(numeros);
        List<int> numerosOrdenadosLista = numerosOrdenados.ToList();
        numerosOrdenadosLista.Sort();
        return new HashSet<int>(numerosOrdenadosLista);
    }
}



//12. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de mayor a menor.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosOrdenados = ObtenerNumerosOrdenados(numeros);

        Console.WriteLine("Números ordenados de mayor a menor:");
        foreach (int numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosOrdenados(List<int> numeros)
    {
        HashSet<int> numerosOrdenados = new HashSet<int>(numeros);
        List<int> numerosOrdenadosLista = numerosOrdenados.ToList();
        numerosOrdenadosLista.Sort((a, b) => b.CompareTo(a));
        return new HashSet<int>(numerosOrdenadosLista);
    }
}


//13.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están duplicados.


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosDuplicados = EncontrarNumerosDuplicados(numeros);

        Console.WriteLine("Números duplicados:");
        foreach (int numero in numerosDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> EncontrarNumerosDuplicados(List<int> numeros)
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        HashSet<int> numerosDuplicados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (!numerosUnicos.Add(numero))
            {
                numerosDuplicados.Add(numero);
            }
        }

        return numerosDuplicados;
    }
}

//14.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que no están duplicados.


class Programa_14
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosNoDuplicados = EncontrarNumerosNoDuplicados(numeros);

        Console.WriteLine("Números no duplicados:");
        foreach (int numero in numerosNoDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> EncontrarNumerosNoDuplicados(List<int> numeros)
    {
        HashSet<int> numerosNoDuplicados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numeros.IndexOf(numero) == numeros.LastIndexOf(numero))
            {
                numerosNoDuplicados.Add(numero);
            }
        }

        return numerosNoDuplicados;
    }
}


//15. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son primos y están ordenados de menor a mayor.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosPrimosOrdenados = EncontrarNumerosPrimosOrdenados(numeros);

        Console.WriteLine("Números primos y ordenados de menor a mayor:");
        foreach (int numero in numerosPrimosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        for (int i = 5; i * i <= numero; i = i + 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static HashSet<int> EncontrarNumerosPrimosOrdenados(List<int> numeros)
    {
        HashSet<int> numerosPrimosOrdenados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
            {
                numerosPrimosOrdenados.Add(numero);
            }
        }

        List<int> listaOrdenada = new List<int>(numerosPrimosOrdenados);
        listaOrdenada.Sort();

        return new HashSet<int>(listaOrdenada);
    }
}


//16.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos y están ordenadas de menor a mayor.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palindromosOrdenados = EncontrarPalindromosOrdenados(palabras);

        Console.WriteLine("Palíndromos ordenados de menor a mayor:");
        foreach (string palindromo in palindromosOrdenados)
        {
            Console.WriteLine(palindromo);
        }
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static HashSet<string> EncontrarPalindromosOrdenados(string[] palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        List<string> listaOrdenada = palindromos.ToList();
        listaOrdenada.Sort();

        return new HashSet<string>(listaOrdenada);
    }
}


//17.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada y están ordenadas de menor a mayor.


class Programa_17
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese la longitud de las palabras que desea filtrar:");
        int longitud = int.Parse(Console.ReadLine());

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palabrasFiltradas = FiltrarPalabrasPorLongitudOrdenadas(palabras, longitud);

        Console.WriteLine($"Palabras de longitud {longitud} y ordenadas de menor a mayor:");
        foreach (string palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLongitudOrdenadas(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        List<string> listaOrdenada = palabrasFiltradas.ToList();
        listaOrdenada.Sort();

        return new HashSet<string>(listaOrdenada);
    }
}

//18. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada y están ordenadas de mayor a menor.


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese la letra que desea buscar en las palabras:");
        char letra = Console.ReadLine()[0];

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palabrasConLetraOrdenadas = EncontrarPalabrasConLetraOrdenadas(palabras, letra);

        Console.WriteLine($"Palabras que contienen la letra '{letra}' y están ordenadas de mayor a menor:");
        foreach (string palabra in palabrasConLetraOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> EncontrarPalabrasConLetraOrdenadas(string[] palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        List<string> listaOrdenada = palabrasConLetra.ToList();
        listaOrdenada.Sort((a, b) => b.CompareTo(a));

        return new HashSet<string>(listaOrdenada);
    }
}


//19.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor y que no están duplicados.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entradaUsuario = Console.ReadLine();

        // Convertir la entrada de usuario en un arreglo de números
        string[] numerosString = entradaUsuario.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numeroStr in numerosString)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{numeroStr}' no es un número válido y será omitido.");
            }
        }

        HashSet<int> numerosOrdenadosNoDuplicados = ObtenerNumerosOrdenadosNoDuplicados(numeros);

        Console.WriteLine("Números ordenados de menor a mayor y no duplicados:");
        foreach (int numero in numerosOrdenadosNoDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosOrdenadosNoDuplicados(List<int> numeros)
    {
        HashSet<int> numerosOrdenadosNoDuplicados = new HashSet<int>(numeros);
        List<int> listaOrdenada = numerosOrdenadosNoDuplicados.ToList();
        listaOrdenada.Sort(); // Ordenar de menor a mayor
        return new HashSet<int>(listaOrdenada);
    }
}


//20. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor.

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las palabras separadas por espacios:");
        string entradaUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese la longitud de las palabras que desea filtrar:");
        int longitud = int.Parse(Console.ReadLine());

        // Convertir la entrada de usuario en un arreglo de palabras
        string[] palabras = entradaUsuario.Split(' ');

        HashSet<string> palindromosOrdenados = EncontrarPalindromosDeLongitudOrdenados(palabras, longitud);

        Console.WriteLine($"Palíndromos de longitud {longitud} y ordenados de menor a mayor:");
        foreach (string palindromo in palindromosOrdenados)
        {
            Console.WriteLine(palindromo);
        }
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static HashSet<string> EncontrarPalindromosDeLongitudOrdenados(string[] palabras, int longitud)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud && EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        List<string> listaOrdenada = palindromos.ToList();
        listaOrdenada.Sort();

        return new HashSet<string>(listaOrdenada);
    }
}
