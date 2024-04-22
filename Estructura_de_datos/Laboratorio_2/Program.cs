//programa que sume los n primeros numeros

//var n = 50;
//var suma = 0;

//for (var i = 0; i <= n; i++)
//{
//    suma = suma + i;
//}


//Console.WriteLine($" la suma de {n} primero numeros : {suma}");


/*1) realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.  
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        // solicitar al usuario que ingrese dos números
        Console.WriteLine("ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // realizar las operaciones matemáticas
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num1 / num2;

        // mostrar los resultados
        Console.WriteLine($"la suma de {num1} y {num2} es: {suma}");
        Console.WriteLine($"la resta de {num1} y {num2} es: {resta}");
        Console.WriteLine($"la multiplicación de {num1} y {num2} es: {multiplicacion}");
        Console.WriteLine($"la división de {num1} entre {num2} es: {division}");

        Console.ReadLine(); // esperar a que el usuario presione enter para salir
    }
}

