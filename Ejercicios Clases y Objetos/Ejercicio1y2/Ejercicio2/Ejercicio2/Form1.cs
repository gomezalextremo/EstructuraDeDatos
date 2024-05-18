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

        // M�todo para calcular el sueldo base
        private double CalcularSueldoBase()
        {
            double sueldoBase = 0;

            if (Cargo == "Gerente")
            {
                if (Area == "Contabilidad")
                    sueldoBase = 6000;
                else if (Area == "Planificaci�n")
                    sueldoBase = 7000;
            }
            else if (Cargo == "Subgerente")
            {
                if (Area == "Contabilidad")
                    sueldoBase = 5000;
                else if (Area == "Planificaci�n")
                    sueldoBase = 6000;
            }

            return sueldoBase;
        }

        // M�todo para calcular la bonificaci�n
        private double CalcularBonificacion()
        {
            double bonificacion = 0;

            if (AniosAntiguedad <= 7)
                bonificacion = CalcularSueldoBase() * 0.05;
            else
                bonificacion = CalcularSueldoBase() * 0.04;

            return bonificacion;
        }

        // M�todo para calcular el monto de movilidad
        private double CalcularMovilidad()
        {
            double movilidad = 0;

            if (Cargo == "Gerente")
                movilidad = 700;
            else if (Cargo == "Subgerente")
                movilidad = 400;

            return movilidad;
        }

        // M�todo para calcular el sueldo final
        public double CalcularSueldoFinal()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = CalcularBonificacion();
            double movilidad = CalcularMovilidad();

            double sueldoFinal = sueldoBase + bonificacion + movilidad;

            return sueldoFinal;
        }

        // M�todo para mostrar informaci�n del jefe
        public void MostrarInformacion()
        {
            Console.WriteLine("Informaci�n del Jefe:");
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("�rea: " + Area);
            Console.WriteLine("A�os de antig�edad: " + AniosAntiguedad);
            Console.WriteLine("Sueldo Final: $" + CalcularSueldoFinal());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto jefe
            Jefe jefe = new Jefe("Juan Perez", "12345678", "Gerente", "Contabilidad", 5);

            // Mostrar informaci�n del jefe
            jefe.MostrarInformacion();
        }
    }
}
