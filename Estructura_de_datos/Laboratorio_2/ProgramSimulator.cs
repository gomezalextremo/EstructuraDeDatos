//Programa que simula los ingresos y egresos en una cuenta

//using System;
//using System.Collections.Generic;

//// Clase para representar una transacción
//public class Transaccion
//{
//    public string Descripcion { get; set; }
//    public decimal Monto { get; set; }
//    public bool EsIngreso { get; set; }

//    public Transaccion(string descripcion, decimal monto, bool esIngreso)
//    {
//        Descripcion = descripcion;
//        Monto = monto;
//        EsIngreso = esIngreso;
//    }
//}

//// Clase principal del programa
//class ProgramSimulator
//{
//    static void Main(string[] args)
//    {
//        List<Transaccion> transacciones = new List<Transaccion>();
//        decimal saldo = 0;

//        while (true)
//        {
//            Console.WriteLine("1. Agregar transacción de ingreso");
//            Console.WriteLine("2. Agregar transacción de gasto");
//            Console.WriteLine("3. Ver saldo");
//            Console.WriteLine("4. Salir");
//            Console.Write("Seleccione una opción: ");

//            string opcion = Console.ReadLine();

//            switch (opcion)
//            {
//                case "1":
//                    Console.Write("Ingrese una descripción para el ingreso: ");
//                    string descripcionIngreso = Console.ReadLine();
//                    Console.Write("Ingrese el monto del ingreso: ");
//                    decimal montoIngreso = Convert.ToDecimal(Console.ReadLine());
//                    transacciones.Add(new Transaccion(descripcionIngreso, montoIngreso, true));
//                    saldo += montoIngreso;
//                    Console.WriteLine("Ingreso agregado exitosamente.");
//                    break;
//                case "2":
//                    Console.Write("Ingrese una descripción para el gasto: ");
//                    string descripcionGasto = Console.ReadLine();
//                    Console.Write("Ingrese el monto del gasto: ");
//                    decimal montoGasto = Convert.ToDecimal(Console.ReadLine());
//                    transacciones.Add(new Transaccion(descripcionGasto, montoGasto, false));
//                    saldo -= montoGasto;
//                    Console.WriteLine("Gasto agregado exitosamente.");
//                    break;
//                case "3":
//                    Console.WriteLine($"Saldo actual: {saldo}");
//                    Console.WriteLine("Transacciones:");
//                    foreach (var transaccion in transacciones)
//                    {
//                        string tipo = transaccion.EsIngreso ? "Ingreso" : "Gasto";
//                        Console.WriteLine($"{tipo}: {transaccion.Descripcion}, Monto: {transaccion.Monto}");
//                    }
//                    break;
//                case "4":
//                    Console.WriteLine("¡Hasta luego!");
//                    return;
//                default:
//                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
//                    break;
//            }

//            Console.WriteLine();
//        }
//    }
//}
