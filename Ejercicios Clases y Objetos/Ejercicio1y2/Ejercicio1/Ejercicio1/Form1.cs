using System;

namespace SueldoArquitecto
{
    class Arquitecto
    {
        // Atributos
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; }
        public string Especialidad { get; set; }
        public string TipoActividad { get; set; }
        public string TipoAfiliacion { get; set; }

        // Constructor
        public Arquitecto(int codigo, string nombres, string condicionContrato, string especialidad, 
            string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
        }

        // Métodos
        public double CalcularSueldoBruto()
        {
            double sueldoBase = 0;

            // Calcular sueldo base según la condición de contrato y tipo de actividad
            if (CondicionContrato == "Estable")
            {
                if (TipoActividad == "Supervisión de Obras")
                    sueldoBase = 4000;
                else if (TipoActividad == "Supervisión de Vías")
                    sueldoBase = 6000;
            }
            else if (CondicionContrato == "Contrato")
            {
                if (TipoActividad == "Supervisión de Obras")
                    sueldoBase = 2000;
                else if (TipoActividad == "Supervisión de Vías")
                    sueldoBase = 4500;
            }

            // Calcular bonificación según la especialidad
            double bonificacion = 0;
            if (Especialidad == "Estructuras")
                bonificacion = sueldoBase * 0.16;
            else if (Especialidad == "Recursos Hídricos")
                bonificacion = sueldoBase * 0.18;

            // Calcular sueldo bruto sumando sueldo base y bonificación
            double sueldoBruto = sueldoBase + bonificacion;

            return sueldoBruto;
        }

        public double CalcularSueldoNeto()
        {
            // Calcular sueldo bruto
            double sueldoBruto = CalcularSueldoBruto();

            // Calcular descuentos
            double descuentoAFP = sueldoBruto * 0.15;
            double descuentoSNP = sueldoBruto * 0.08;

            // Calcular sueldo neto restando descuentos al sueldo bruto
            double sueldoNeto = sueldoBruto - descuentoAFP - descuentoSNP;

            return sueldoNeto;
        }

        // Método para mostrar información del arquitecto
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del arquitecto:");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Condición de contrato: " + CondicionContrato);
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Tipo de actividad: " + TipoActividad);
            Console.WriteLine("Tipo de afiliación: " + TipoAfiliacion);
            Console.WriteLine("Sueldo Bruto: $" + CalcularSueldoBruto());
            Console.WriteLine("Sueldo Neto: $" + CalcularSueldoNeto());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto arquitecto
            Arquitecto arquitecto = new Arquitecto(1234, "Juan Perez", "Estable", "Estructuras", 
                "Supervisión de Obras", "AFP");

            // Mostrar información del arquitecto
            arquitecto.MostrarInformacion();
        }
    }
}

