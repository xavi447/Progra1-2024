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
        //uso de funciones
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("***Menu de opciones***");
                Console.WriteLine("opcion 1: Conversion de monedas");
                Console.WriteLine("Opcion 2: Conversion de masas");
                Console.WriteLine("Opcion 3: conversion de Volumen");
                Console.WriteLine("Opcion 4: Conversion de Longitud");
                Console.WriteLine("Opcion 5: Conversion de almacenamiento");
                Console.WriteLine("Opcion 6: conversion de tiempo");
                Console.WriteLine("Opcion 7: salir");
                Console.Write("opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Cmonedas();
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:
                        Lconvertir();
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                }










                Console.ReadLine();





            }
        }
        static void Cmonedas()
        {
            string[] monedas = { "Dólar", "Euro", "Peso MX", "Peso col", "Córdobas", "Quetzal", "Lempira", "Yenes", "Libras Esterlinas", "Pesos Arg" };
            double[] tasasMoneda = { 1, 0.85, 17.20, 4174.89, 36.42, 7.72, 24.67, 148.65, 0.76, 365.20 };

            while (true)
            {
                
                Console.WriteLine("escoge la moneda que quieres convertir:");
                for (int i = 0; i < monedas.Length; i++)
                    Console.WriteLine($"{i + 1}. {monedas[i]}");
                int maconvertir = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (maconvertir < 0 || maconvertir >= monedas.Length)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                
                Console.WriteLine("Elegiste la opción {0}. a que moneda lo quieres convertir", maconvertir + 1);
                for (int i = 0; i < monedas.Length; i++)
                    Console.WriteLine($"{i + 1}. {monedas[i]}");
                int mconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (mconvertida < 0 || mconvertida >= monedas.Length)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                
                Console.Write("que cantidad deseas convertir: ");
                double cantidad = double.Parse(Console.ReadLine() ?? "0");

                
                double resultado = cantidad * (tasasMoneda[mconvertida] / tasasMoneda[maconvertir]);
                Console.WriteLine($"{cantidad} {monedas[maconvertir]} = {resultado} {monedas[mconvertida]}");



            }
        }
        static void Lconvertir()
        {

            
            string[] unidad =
            {"Metro", "Kilometro", "Hectometro", "Decametro", "Decimetro", "Centimetro", "Milimetro", "Pies", "Pulgadas", "Yardas" };
                 double[] longitud =
                {1, 1000, 100, 10, 0.1, 0.01, 0.001, 0.3048, 0.254, 0.9144  };

           
                while (true)
                {
                    
                    Console.WriteLine("Seleccione la unidad que desea convertir:");
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertir = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (Uaconvertir < 0 || Uaconvertir >= unidad.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }

                    
                    Console.WriteLine("Elegiste la opción {0}. ahora elige la unidad a la que lo quieres convertir:", Uaconvertir + 1);
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (Uaconvertida < 0 || Uaconvertida >= unidad.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }

              
                    Console.Write("escribe la unidad que deseas convertir: ");
                    double Lconvertir = double.Parse(Console.ReadLine() ?? "0");

                    
                    double resultado = Lconvertir * (longitud[Uaconvertir] / longitud[Uaconvertida]);
                    Console.WriteLine($"{Lconvertir} {unidad[Uaconvertir]} = {resultado} {unidad[Uaconvertida]}");

                  
                }
            

           
        }
    }
}
        
        
    
