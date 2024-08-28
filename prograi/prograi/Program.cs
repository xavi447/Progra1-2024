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
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("***Menu de Opciones***");
                Console.WriteLine("Opcion 1: Impuesto a las actividades economicas");
                Console.WriteLine("Opcion 2: conversor de superficie");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Impuesto();
                        break;
                    case 2:
                        Superficie();
                        break;


                }

                Console.ReadLine();
            }
        }
        static void Impuesto()
        {
            double[,] matriz = new double[,] {

            { 0.01, 500, 1.5, 0 },
            { 500.01, 1000, 1.5, 3 },
            {1000.01, 2000, 3, 3 },
            {2000.01, 3000, 6, 3 },
            {3000.01, 6000, 9, 3 },
            {8000.01, 18000,15,2 },
            {18000.01, 30000, 39, 2 },
            {30000.01, 60000, 63, 1 },
            {60000.01, 100000, 93, 0.8 },
            {100000.01, 200000, 125, 0.7 },
            {200000.01, 300000, 195, 0.6 },
            {300000.01, 400000, 255, 0.45 },
            {400000.01, 500000, 300, 0.4 },
            {500000.01, 1000000, 340, 0.30 },
            {1000000.01, 99999999, 490, 0.18 }

         };

            Console.WriteLine("Ingrese el monto: ");
            double monto = double.Parse(Console.ReadLine());
            for (double i = 0; i == monto; i++) ;
              
                
            


        }
        static void Superficie()
        {
            string[] areas = { "Pie cuadrado", "Vara cuadrada", "Yarda Cuadrada", "Metro cuadrado", "Tareas", "Manzana", "Hectarea" };
            double[] medida = { 1, 0.132, 0.11, 0.09, 0.000147, 0.000014, 0.0000092 };

            while (true)
            {
                Console.WriteLine("Elija la moneda que desea convertir");
                for (int i = 0; i < areas.Length; i++)
                    Console.WriteLine($"{i + 1}. {areas[i]}");
                int inicio = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (inicio < 0 || inicio >= areas.Length)
                {
                    Console.WriteLine("Opcion no validad");
                    continue;
                }

                Console.WriteLine("elegistes la opcion {0} ahora elige a que unidad de area la quieres convertir:", inicio + 1);
                for (int i = 0; i < areas.Length; i++)
                    Console.WriteLine($"{i + 1}. {areas[i]}");
                int salida = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (salida < 0 || salida >= areas.Length)
                {
                    Console.WriteLine("Opcion no valida");
                    continue;
                }

                Console.WriteLine("Ingresa la cantidad: ");
                double cantidad = double.Parse(Console.ReadLine());

                double resultado = cantidad * (medida[salida] / medida[inicio]);
                Console.WriteLine($"{cantidad} {areas[inicio]} = {resultado} {areas[salida]}");
                Console.ReadLine();
            }
        }


    }


}



    
