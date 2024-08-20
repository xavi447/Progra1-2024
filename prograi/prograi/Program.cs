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

                //metro, kilometro, hectometro, decametro, decimetro, centimetro, milimetro, pies, pulgadas, yardas
                string[] unidad =
                {"Metro", "Kilometro", "Hectometro", "Decametro", "Decimetro", "Centimetro", "Milimetro", "Pies", "Pulgadas", "Yardas" }

                ;
                double[] longitud =
                {1, 1000, 100, 10, 0.1, 0.01, 0.001, 0.3048, 0.254, 0.9144  }

                ;

                while (true)
                {
                    Console.WriteLine("Seleccione la unidad de longitud que desea convertir");
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertir = int.Parse(Console.ReadLine() ?? "0") -1;
                    if (Uaconvertir < 0 || Uaconvertir >= unidad.Length )
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    Console.WriteLine("Elegistes la opcion {0} ahora selecciona a que unidad lo deseas convertir", Uaconvertir);
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;

                    if ( Uaconvertida < 0 || Uaconvertida >= unidad.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }

                    Console.Write("Introduce la longitud que desees convertir: ");
                    double Lconvertir = double.Parse(Console.ReadLine() ?? "0");



                    double resultado = Lconvertir * (longitud[Uaconvertir] / longitud[Uaconvertida]);
                    Console.WriteLine($"{Lconvertir} {unidad[Uaconvertir]} = {resultado} {unidad[Uaconvertida]}");

                    Console.ReadLine();




                };



            }





        }
    }
}
        
        
    
