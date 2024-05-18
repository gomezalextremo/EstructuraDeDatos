////namespace Aprendiendo
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            var Persona = new
////            { nombre = "Alexander", apellido = "Gomez", edad = 21 };


////            Console.WriteLine(Persona.nombre);
////            Console.WriteLine(Persona.apellido);
////            Console.WriteLine(Persona.edad);
////        }
////    }
////}
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Aprendiendo
//{
//    public class Cerveza
//    {
//        public decimal VolAlcohol { get; set; }
//        public int Amargor {  get; set; }
//        public int TiempoFermentacion { get; set; }
//        public string Tipo { get; set; }
//        public string Nombre {  get; set; }
//        public int Contenido { get; set; }
//        public int Consumo {  get; set; }

   

//        public Cerveza(decimal volAlcohol, int Amargor, 
//            int tiempoFermentatacion, string tipo, string nombre, int contenido, int consumo)
//        {
//            this.Amargor = Amargor;
//            this.VolAlcohol = VolAlcohol;
//            this.TiempoFermentacion = tiempoFermentatacion;
//            this.Tipo = tipo;
//            this.Nombre = nombre;             
//            this.Contenido = contenido;
//            this.Consumo = consumo;
//        }
//        public void Fermentacion()
         
//        {
//            for (int i = 0; i < TiempoFermentacion; i++);
                
//            Console.WriteLine("Se fermentó"); 
//        }
//        public void Tomar(int Consumo)
//        {
//            this.Contenido -= Consumo;
//        }
//    }
//}

