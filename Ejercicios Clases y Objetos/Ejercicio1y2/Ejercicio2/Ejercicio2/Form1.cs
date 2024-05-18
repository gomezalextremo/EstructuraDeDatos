using System;

namespace SueldoJefe
{
    class Jefe
    {
        // Atributos
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public int AniosAntiguedad { get; set; }

        // Constructor
        public Jefe(string nombres, string dni, string cargo, string area, int aniosAntiguedad)
        {
            Nombres = nombres;
            DNI = dni;
            Cargo = cargo;
            Area = area;
            AniosAntiguedad = aniosAntiguedad;
        }

        // Método para calcular el sueldo base
        private double CalcularSueldoBase()
        {
            double sueldoBase = 0;

            if (Cargo == "Gerente")
            {
                if (Area == "Contabilidad")
                    sueldoBase = 6000;
                else if (Area == "Planificación")
                    sueldoBase = 7000;
            }
            else if (Cargo == "Subgerente")
            {
                if (Area == "Contabilidad")
                    sueldoBase = 5000;
                else if (Area == "Planificación")
                    sueldoBase = 6000;
            }

            return sueldoBase;
        }

        // Método para calcular la bonificación
        private double CalcularBonificacion()
        {
            double bonificacion = 0;

            if (AniosAntiguedad <= 7)
                bonificacion = CalcularSueldoBase() * 0.05;
            else
                bonificacion = CalcularSueldoBase() * 0.04;

            return bonificacion;
        }

        // Método para calcular el monto de movilidad
        private double CalcularMovilidad()
        {
            double movilidad = 0;

            if (Cargo == "Gerente")
                movilidad = 700;
            else if (Cargo == "Subgerente")
                movilidad = 400;

            return movilidad;
        }

        // Método para calcular el sueldo final
        public double CalcularSueldoFinal()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = CalcularBonificacion();
            double movilidad = CalcularMovilidad();

            double sueldoFinal = sueldoBase + bonificacion + movilidad;

            return sueldoFinal;
        }

        // Método para mostrar información del jefe
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Jefe:");
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Área: " + Area);
            Console.WriteLine("Años de antigüedad: " + AniosAntiguedad);
            Console.WriteLine("Sueldo Final: $" + CalcularSueldoFinal());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto jefe
            Jefe jefe = new Jefe("Juan Perez", "12345678", "Gerente", "Contabilidad", 5);

            // Mostrar información del jefe
            jefe.MostrarInformacion();
        }
    }
}
