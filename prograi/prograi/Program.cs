using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograi
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] monedas = { "Dolar", "Euro", "Peso MX", "Peso col", "cordobas", "quetzal", "lempira", "Yenes", "libras esterlinas", "Pesos arg" };
                double[] tasasMoneda = { 1, 0.85, 17.20, 4174.89, 36.42, 7.72, 24.67, 148.65, 0.76, 365.20 };

                while (true)
                {
                    

                    Console.WriteLine("Selecciona la moneda que quieres convertir:");
                    for (int i = 0; i < monedas.Length; i++)
                        Console.WriteLine($"{i + 1}. {monedas[i]}");
                    int maconvertir = int.Parse(Console.ReadLine()  ) ;

                    Console.WriteLine(" elegistes la opcion {0} a que moneda lo quieres convertir:", maconvertir ) ;
                    for (int i = 0; i < monedas.Length; i++)
                        Console.WriteLine($"{i + 1}. {monedas[i]}");
                    int mconvertida = int.Parse(Console.ReadLine() ?? "0" ) -1 ;

                    if (maconvertir < 0 || maconvertir >= monedas.Length || mconvertida < 0 || mconvertida >= monedas.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }

                    Console.Write("Introduce la cantidad que deceas convertir: ");
                    double cantidad = double.Parse(Console.ReadLine() ?? "0");

                    
                    double resultado = cantidad * (tasasMoneda[mconvertida] / tasasMoneda[maconvertir]);
                    Console.WriteLine($"{cantidad} {monedas[maconvertir]} = {resultado} {monedas[mconvertida]}");

                    Console.ReadLine();

                }





            }
        }
        static void ConversorL() {

            //metro, kilometro, hectometro, decametro, decimetro, centimetro, milimetro, pies, pulgadas, yardas
            string[] unidad =  
            {"Metro", "Kilometro", "Hectometro", "Decametro", "Decimetro", "Centimetro", "Milimetro", "Pies", "Pulgadas", "Yardas" }
              
            ;
            double[] longitud =  
            {1, 1000, 100, 10, 0.1, 0.01, 0.001, 0.3048, 0.254, 0.9144  }     
           
            ;
        while (true) {
                Console.WriteLine("Seleccione la unidad de longitud que desea convertir");
                for (int i = 0; i < unidad.Length; i++)
                    Console.WriteLine($"{i + 1}. {unidad[i]}");
                int Uaconvertir = int.Parse(Console.ReadLine());

                Console.WriteLine("Elegistes la opcion {0} ahora selecciona a que unidad lo deseas convertir", Uaconvertir);
                for (int i = 0; i < unidad.Length; i++)
                    Console.WriteLine($"{i + 1}. {unidad[i]}");
                int Uaconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;

                if (Uaconvertir < 0 || Uaconvertir >= unidad.Length || Uaconvertida < 0 || Uaconvertida >= unidad.Length)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                Console.Write("Introduce la longitud que desees convertir: ");
                double Lconvertir = double.Parse(Console.ReadLine() ?? "0");



                double resultado = Lconvertir * (longitud[Uaconvertida] / longitud[Uaconvertir]);
                Console.WriteLine($"{Lconvertir} {unidad[Uaconvertir]} = {resultado} {unidad[Uaconvertida]}");

                Console.ReadLine();




            };
        
        
        
        }
    }
}
    
