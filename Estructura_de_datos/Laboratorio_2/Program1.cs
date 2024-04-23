//programa que sume los n primeros numeros

//var n = 50;
//var suma = 0;

//for (var i = 0; i <= n; i++)
//{
//    suma = suma + i;
//}


//Console.WriteLine($" la suma de {n} primero numeros : {suma}");


//                         1) Operaciones Básicas:    


//using System;
//class Program1
//{
//    static void Main(string[] args)
//    {
//        // solicitar al usuario que ingrese dos números
//        Console.WriteLine("ingrese el primer número:");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("ingrese el segundo número:");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        // realizar las operaciones matemáticas
//        double suma = num1 + num2;
//        double resta = num1 - num2;
//        double multiplicacion = num1 * num2;
//        double division = num1 / num2;

//        // mostrar los resultados
//        Console.WriteLine($"la suma de {num1} y {num2} es: {suma}");
//        Console.WriteLine($"la resta de {num1} y {num2} es: {resta}");
//        Console.WriteLine($"la multiplicación de {num1} y {num2} es: {multiplicacion}");
//        Console.WriteLine($"la división de {num1} entre {num2} es: {division}");

//        Console.ReadLine(); // esperar a que el usuario presione enter para salir
//    }
//}



//                    13)Generador de Tablas de Multiplicar:  

using System;

class Program1
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



